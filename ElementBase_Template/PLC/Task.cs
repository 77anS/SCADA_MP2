using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

namespace ElementBase_Template
{
    /// <summary>
    /// "Task" type manage tags of devices
    /// </summary>
    public class myTask
    {

        #region FIELDS
            //public SCADA Parent { get; set; }
            public string TaskName { get; set; }
            public int Period { get; set; }

            public List<Tag> TagsList = new List<Tag>();

            Timer UpdateTimer = null; // Time for update value
            Timer MonitorTimer = null; // Time for monitor value
        #endregion

        #region CONTRUCTOR
            /// <summary>
            /// Constructor of Task
            /// </summary>
            /// <param name="taskName"> Name of task</param>
            /// <param name="period">Cycle time for updating tags</param>
            public myTask(string taskName, int period)
            {
                this.TaskName = taskName;
                this.Period = period;
            }
        #endregion

        #region METHODS
            /// <summary>
            /// Add tag to tags List
            /// </summary>
            /// <param name="tag">name of tag to add</param>
            public void AddTag(Tag tag)
                {
                    tag.parent = this;
                    TagsList.Add(tag);
                }

            /// <summary>
            /// Find tag and return tag in list of tag
            /// </summary>
            /// <param name="name"> name of tag to find</param>
            /// <returns>return tag in "Tag" type</returns>
            public Tag FindTag(string name)
            {
                Tag tag = null;
                for(int i = 0; i < TagsList.Count; i++)
                {
                    tag = TagsList[i];
                    if(tag.Name == name)
                    {
                        return tag;
                    }    
                }    
                 return null;   
            }

            /// <summary>
            /// Method implement updating value in cycle with two processing: get and update UI in time specified
            /// </summary>
            public void Engine()
            {
                this.UpdateTimer = new Timer(Period); //Create a timer with cycle period
                this.UpdateTimer.Elapsed += UpdatingTimer_Elapsed;
                this.UpdateTimer.AutoReset = true; //Allow repeate in cycle
                this.UpdateTimer.Start(); //Start raising Elapsed event <=> .Enable   = true

                this.MonitorTimer = new Timer(1000);
                this.MonitorTimer.Elapsed += MonitoringTimer_Elapsed;
                this.MonitorTimer.AutoReset = true;
                this.MonitorTimer.Enabled = true;
            }

            private void UpdatingTimer_Elapsed(object sender, ElapsedEventArgs e)
            {

            }

            private void MonitoringTimer_Elapsed(object sender, ElapsedEventArgs e)
            {

            }



        #endregion




    }
}
