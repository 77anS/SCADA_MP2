using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

namespace ElementBase_Template.Ultility
{
    public class CycleTime
    {
        internal protected class levelDown
        {
            public Timer Timer_Scan = new Timer();
            public int Period = 250;

            public levelDown(int Period)
            {
                this.Period = Period;
            }
            public levelDown()
            {

            }
            public void Load(bool Enable_Cycle)
            {
                Timer_Scan.Interval = Period;
                Timer_Scan.Elapsed += updateEventHandler;
                Timer_Scan.AutoReset = true;
                Timer_Scan.Enabled = Enable_Cycle;
            }

            public virtual void updateEventHandler(object sender, ElapsedEventArgs e)
            {
                Detect();
            }

            public virtual void Detect()
            {

            }
        }
    }
}
