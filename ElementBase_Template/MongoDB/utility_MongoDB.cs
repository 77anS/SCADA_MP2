using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;

using ElementBase_Template.Ultility;

namespace ElementBase_Template.MongoDB
{
    public class utility_MongoDB
    {
        public MongoClient dbClient { get; set; }
        public string url_db { get; set; }
        public IMongoDatabase database { get; set; }
        public IMongoCollection<BsonDocument> collection { get; set; }

        public BsonDocument bsonDocument { get; set; }

        public string hostName = "localhost";
        public string port = "27017";

        public Timestamp.ultility getTime = new Timestamp.ultility();
        public utility_MongoDB(string hostName, string port)
        {
            this.hostName = hostName;
            this.port = port;
            
        }
        public utility_MongoDB()
        {

        }
        public MongoClient connectToDB(string hostName = "localhost", string port = "27017")
        {
            //var dbClient = new MongoClient("mongodb://localhost:27017");
            //url_db = $"mongodb://{hostName}:{port}/db_name?connect=replicaSet";
            url_db = $"mongodb://{hostName}:{port}";
            dbClient = new MongoClient(url_db);

            return dbClient;
        }

        public IMongoDatabase findDB(MongoClient dbCLient,string database_name)
        {
            if(dbCLient != null)
            {
               this.database = dbClient.GetDatabase(database_name);
                return database;
            }

            return null;
        }    

        public IMongoCollection<BsonDocument> getCollection(MongoClient dbClient,IMongoDatabase database,string collection_name)
        {
            if (dbClient != null && database != null)
            {
                var a = database.GetCollection<BsonDocument>(collection_name);
                this.collection = a;
                return this.collection;
            }
            return null;
        }    

        /// <summary>
        /// Find documents in collection that having key equals to value
        /// </summary>
        /// <param name="key">key to find</param>
        /// <param name="value">value to find</param>
        /// <param name="collection">collection</param>
        public BsonDocument findKeyEqualValue_Collection(string key, string value, IMongoCollection<BsonDocument> collection)
        {
            //var filter = Builders<BsonDocument>.Filter.Eq("student_id", 10000);
            var filter = Builders<BsonDocument>.Filter.Eq(key, value);
            this.bsonDocument = collection.Find(filter).FirstOrDefault();

            return this.bsonDocument;
        }

        public List<BsonDocument> findKey_Gt_Lt(string key, DateTime value1, DateTime value2, IMongoCollection<BsonDocument> collection)
        {

            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Gt((x) => x["timestamp"], new BsonDateTime(value1)) & builder.Lt((x) => x["timestamp"], new BsonDateTime(value2));
            var docs =  collection.Find(filter).ToList();

            // TESTING -----------------------------------------------
            //var cursor = collection.Find(filter).ToCursor();
            //foreach (var document in cursor.ToEnumerable())
            //{
            //    Console.WriteLine(document);
            //}

            return docs;
        }
        public List<BsonDocument> findKey_Gt_Lt(string key, BsonDateTime value1, BsonDateTime value2, IMongoCollection<BsonDocument> collection)
        {

            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Gt((x) => x["timestamp"], value1) & builder.Lt((x) => x["timestamp"], value2);
            var docs = collection.Find(filter).ToList();

            // TESTING -----------------------------------------------
            //var cursor = collection.Find(filter).ToCursor();
            //foreach (var document in cursor.ToEnumerable())
            //{
            //    Console.WriteLine(document);
            //}

            return docs;
        }


        public List<BsonDocument> findKey_Gt_Lt(string key, Int32 value1, Int32 value2, IMongoCollection<BsonDocument> collection)
        {

            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Gt((x) => x["timestamp"], new BsonDateTime(value1)) & builder.Lt((x) => x["timestamp"], new BsonDateTime(value2));
            var docs = collection.Find(filter).ToList();

            // TESTING -----------------------------------------------
            //var cursor = collection.Find(filter).ToCursor();
            //foreach (var document in cursor.ToEnumerable())
            //{
            //    Console.WriteLine(document);
            //}

            return docs;
        }

        public List<BsonDocument> findKey_Gt (string key, int value, IMongoCollection<BsonDocument> collection)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Gt(key, value);
            var docs = collection.Find(filter).ToList();
            return docs;
        }

        public List<BsonDocument> findAll(IMongoCollection<BsonDocument> collection)
        {
            var docs = collection.Find(new BsonDocument()).ToList();
            return docs;
        }

        /// <summary>
        /// Insert a Bson Document to Collection
        /// </summary>
        /// <param name="collection">collection to insert</param>
        /// <param name="bsonDocument">document in Bson type to insert</param>
        public void crud_insert(IMongoCollection<BsonDocument> collection, BsonDocument bsonDocument)
        {
            collection.InsertOne(bsonDocument);
        }
        /// <Example: "Example">{{"name", "BMW"},{"price", 34621}}</Example>

        public void disconnect()
        {

        }
        
}
}
