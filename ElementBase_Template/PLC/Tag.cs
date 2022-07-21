using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template
{
    public class Tag
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public float Value { get; set; }
        public DateTime Timestamp { get; set; }


        public myTask parent { get; set; }
        public Tag(string name)
        {

        }    

        public Tag(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}
