using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ElementBase_Template;
using ElementBase_Template.User;

namespace ElementBase_Template.ALARM
{
    public class AlarmItems
    {


        /// <summary>
        /// Class for alarm table
        /// </summary> 
        internal class floatAlarmRow:ALARM_EVENTS.floatEvents
        {
            #region Fields
            // EXTRA PROPERTIES => FOR ALARM TABLE
            public string date { get; set; } // For "dd/mm/yyyy"
            public string time { get; set; } // For "HH:mm:ss"
            public string duration { get; set; }
            public string id { get; set; } // Id of this alarm
            public ALARM_EVENTS.alarmCode  error_id { get; set; } // Error Code

            public string status { get; set; } // Status of alarm
            public string comment { get; set; } // Description of alarm
            public Users user { get; set; }
            #endregion

            #region CONSTRUCTOR
            public floatAlarmRow(string entityName) : base(entityName)
            { 

            }
            public floatAlarmRow()
            {
           
            }

            public floatAlarmRow clone()
            {
                return this.MemberwiseClone() as floatAlarmRow;
            }
            #endregion

        }

        /// <summary>
        /// Class for alarm table
        /// </summary>
        internal class tripAlarmRow : ALARM_EVENTS.tripEvents
        {
            #region FIELDS
            // PROPERTY FOR ALARM TABLE
            public string date { get; set; }
            public string time { get; set; }
            public string duration { get; set; } 
            public string id { get; set; }
            public ALARM_EVENTS.alarmCode error_id { get; set; }

            public string status { get; set; }
            public string comment { get; set; }

            public Users user { get; set; }
            #endregion

            #region CONSTRUCTOR

            public tripAlarmRow(string entityName) : base(entityName)
            {

            }
            public tripAlarmRow()
            {

            }

            public tripAlarmRow clone()
            {
                return this.MemberwiseClone() as tripAlarmRow;
            }
            #endregion

        }

        internal class environmentIndexExceedAlarmRow : ALARM_EVENTS.enviromentIndexExceedEvents
        {
            #region FIELDS
            // PROPERTY FOR ALARM TABLE
            public string date { get; set; }
            public string time { get; set; }
            public string duration { get; set; }
            public string id { get; set; }
            public ALARM_EVENTS.alarmCode error_id { get; set; }

            public string status { get; set; }
            public string comment { get; set; }

            public Users user { get; set; }
            #endregion

            #region CONSTRUCTOR
            public environmentIndexExceedAlarmRow(string entityName, ALARM_EVENTS.environmentIndexType entityType) : base(entityName, entityType)
            {

            }

            public environmentIndexExceedAlarmRow(string entityName) : base(entityName)
            {

            }

            public environmentIndexExceedAlarmRow()
            {

            }
            #endregion

            public environmentIndexExceedAlarmRow clone()
            {
                return this.MemberwiseClone() as environmentIndexExceedAlarmRow;
            }

        }

        internal class connectInfoEventsRow : ALARM_EVENTS.connectInfoEvents
        {
            #region FIELDS
            public string date { get; set; }
            public string time { get; set; }
            public string duration { get; set; }
            public string id { get; set; }
            public ALARM_EVENTS.alarmCode error_id { get; set; }

            public string status { get; set; }
            public string comment { get; set; }

            public Users user { get; set; }
            #endregion

            #region CONSTRUCTOR
            public connectInfoEventsRow(string entityName, ALARM_EVENTS.connectType connectType, string errorContent) : base(entityName, connectType, errorContent)
            {
            }

            public connectInfoEventsRow(string entityName, ALARM_EVENTS.connectType connectType) : base(entityName, connectType)
            {
            }

            public connectInfoEventsRow()
            {

            }
            #endregion

            public connectInfoEventsRow clone()
            {
                return this.MemberwiseClone() as connectInfoEventsRow;
            }

        }    
    
        public class GeneralAlarmItem
        {
            public string id { get; set; }
            public string entityName { get; set; } = "";
            public bool activeStatus { get; set; }
            public DateTime timestamp { get; set; }
            public ElementBase_Template.ALARM_EVENTS.alarmSeverityLevels alarmSeverity { get; set; }
            public bool acknowledgment { get; set; }

            public ALARM_EVENTS.alarmCode error_id { get; set; }
            public string status { get; set; }
            public string description { get; set; }

            public string duration { get; set; }

            public GeneralAlarmItem(string entityName)
            {
                this.entityName = entityName;
                
            }

            public GeneralAlarmItem()
            {

            }

            public GeneralAlarmItem clone()
            {
                return this.MemberwiseClone() as GeneralAlarmItem;
            }
        }
    }
}
