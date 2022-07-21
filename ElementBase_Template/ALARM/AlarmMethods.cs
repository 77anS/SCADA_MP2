using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;
using System.Collections.Generic;
using ElementBase_Template.PLC.PLC1;

namespace ElementBase_Template.ALARM
{
    class AlarmMethods
    {
        public class A: AlarmItems.tripAlarmRow
        {

        }
        public class TripDetect<T, A> where T: AlarmItems.tripAlarmRow where A:InputStatus_DB43
        {
            public T DynamicObject1 { get; set; }
            public A DynamicObject2 { get; set; }
            public TripDetect(T obj1, A obj2)
            {
                DynamicObject1 = obj1;
                DynamicObject2 = obj2;
                
            }
            public void action()
            {
                
            }

            //Program.danhSachAlarm.almItem_mtk01_tripStatus.value = Program.InputStatus_PLC1.mtk01_tripStatus;
                    
        }    

    }
}
