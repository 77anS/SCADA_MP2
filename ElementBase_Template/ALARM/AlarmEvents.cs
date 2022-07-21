using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template
{
    public class ALARM_EVENTS
    {
        /// <summary>
        /// Class for Water Float Signal Event
        /// </summary>
        internal protected class floatEvents
        {
            #region FIELDS
                public string entityName { get; set; } = "";
                public bool activeStatus { get; set; }
                public DateTime timestamp { get; set; }
                public alarmSeverityLevels alarmSeverity { get; set; }
                public bool acknowledgment { get; set; }

                //---------------------------------------------------------
                public bool value { get; set; }
                public bool previousValue { get; set; }

                public string status { get; set; }
                public string description { get; set; }

                //public 
            #endregion

            #region CONSTRUCTOR
                public floatEvents(string entityName)
                {
                    this.entityName = entityName;
                }
                public floatEvents()
                {

                }
            #endregion

        }

        /// <summary>
        /// Class for TRIP events error
        /// </summary>
        internal protected class tripEvents
        {
            #region FIELDS
                public string entityName { get; set; } = "";
                public bool activeStatus { get; set; }
                public DateTime timestamp { get; set; }
                public alarmSeverityLevels alarmSeverity { get; set; }
                public bool acknowledgment { get; set; }
                 
                public bool value { get; set; }
                public bool previousValue { get; set; }

                public string status { get; set; }
                public string description { get; set; }
            #endregion

            #region CONSTRUCTOR
            public tripEvents(string entityName)
                {
                    this.entityName = entityName;
                }
                public tripEvents()
                {

                }
            #endregion

        }

        internal protected class enviromentIndexExceedEvents
        {
            #region FIELDS
            public string entityName { get; set; }
            public bool activeStatus { get; set; }
            public DateTime timestamp { get; set; }
            public alarmSeverityLevels alarmSeverity { get; set; }
            public bool acknowledgment { get; set; }

            public environmentIndexType entityType { get; set; }
            public float value { get; set; }
            public float previousValue { get; set; }
            public float threshold_Setting { get; set; }

            public string status { get; set; }
            public string description { get; set; }
            #endregion

            #region CONSTRUCTOR
            public enviromentIndexExceedEvents(string entityName, environmentIndexType entityType)
            {
                this.entityName = entityName;
                this.entityType = entityType;
            }

            public enviromentIndexExceedEvents(string entityName)
            {
                this.entityName = entityName;
            }

            public enviromentIndexExceedEvents()
            {

            }
            #endregion

        }

        internal protected class connectInfoEvents
        {
            #region FIELDS
                /// <summary>
                /// Entity Name for connecting
                /// </summary>
                public string entityName { get; set; }
                public bool activeStatus { get; set; }
                public DateTime timestamp { get; set; }
                public alarmSeverityLevels alarmSeverity { get; set; }
                public bool acknowledgment { get; set; }

                public connectType connectType { get; set; }
                public string errorContent { get; set; }
                public connectingStatus connectingStatus { get; set; } // = Connect, disconnect,...
                public string address { get; set; } // 192.168.0.X, station: 5,...

                public string status { get; set; }
                public string description { get; set; }
            #endregion

            #region CONSTRUCTOR
            public connectInfoEvents(string entityName, connectType connectType, string errorContent)
                {
                    this.entityName = entityName;
                    this.connectType = connectType;
                    this.errorContent = errorContent;
                }

                public connectInfoEvents(string entityName, connectType connectType)
                {
                    this.entityName = entityName;
                    this.connectType = connectType;
                }
                public connectInfoEvents(string entityName)
                {
                    this.entityName = entityName;
                }

                public connectInfoEvents()
                {

                }
            #endregion
        }

        internal protected class runtimeOverEvents
        {
            #region FIELDS
                public string entityName { get; set; }
                public bool activeStatus { get; set; }
                public DateTime timestamp { get; set; }
                public alarmSeverityLevels alarmSeverity { get; set; }
                public bool acknowledgment { get; set; }
               
                public int runtime { get; set; }
                public int runtimeSetting { get; set; }
                public int runtimeTotal { get; set; }

                public string status { get; set; }
                public string description { get; set; }


            #endregion

            #region CONSTRUCTOR
            /// <summary>
            /// CONSTRUCTOR
            /// </summary>
            /// <param name="entityName">Name of Entity</param>
            /// <param name="runtime"></param>
            /// <param name="runtimeSetting"></param>
            /// <param name="runtimeTotal"></param>
            /// <param name="comment"></param>

                public runtimeOverEvents(string entityName)
                {
                    this.entityName = entityName;
                }

                public runtimeOverEvents()
                {

                }
            #endregion
        }


        internal protected enum connectType { 
            Ethernet = 0,
            Modbus = 1,
        }

        #region ENUM
        public enum connectingStatus
        {
            isConnected = 0,
            isDisconnected = 1,
            isConnecting = 2,
            isDisconnecting = 3,
            isNotAvailable = 4,
            isAvailable = 5,

        }
        public enum environmentIndexType
        {
            cod = 0,
            tss = 1,
            ph = 2,
            color = 3,
            temperature = 4,
            amoni = 5,
            flowInTotal = 6,
            flowInCapacity = 7,
            flowOutTotal = 8,
            flowOutCapacity = 9,
        }

        public enum alarmSeverityLevels
        {
            Minor = 0,
            Warning = 1,
            Major = 2,
            Critical = 3,
            Serious = 4,
            Unknown = 5,

        }

        public enum alarmCode
        {
            /// <summary>
            /// "TRIP" ERROR CODE
            /// </summary>
            _0x0001 = 1, 
            /// <summary>
            /// "INCORRECT FLOAT" ERROR CODE
            /// </summary>
            _0x0002 = 2,
            /// <summary>
            /// "CONNECTING" ERROR CODE
            /// </summary>
            _0x0003 = 3,
            /// <summary>
            /// "EXCEED RUNTIME" ERROR CODE
            /// </summary>
            _0x0004 = 4,
            /// <summary>
            /// "OVERHEAD" ERROR CODE
            /// </summary>
            _0x0005 = 5,
        }
        #endregion
    }
}
