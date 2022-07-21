using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

namespace ElementBase_Template.ALARM
{
     class Alarm_CycleScan
    {
        internal protected class levelDown
        {
            public Timer timer_AlarmScan = new Timer();
            public int period = 250;


            public void AlarmScan_Load(bool Enable_AlarmScan)
            {
                timer_AlarmScan.Interval = period;
                timer_AlarmScan.Elapsed += updateEventHandler;
                timer_AlarmScan.AutoReset = true;
                timer_AlarmScan.Enabled = Enable_AlarmScan;
            }

            public virtual void Load()
            {

            }

            public virtual void updateEventHandler(object sender, ElapsedEventArgs e)
            {
                DetectAlarm();
            }

            public virtual void DetectAlarm()
            {
                
            }
        }
        
    }
}
