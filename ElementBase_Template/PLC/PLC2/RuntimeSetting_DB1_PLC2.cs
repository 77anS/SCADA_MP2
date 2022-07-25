using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.PLC.PLC2
{
    public class RuntimeSetting_DB1_PLC2
    {
        public short anoxic1_setTime { get; set; }  // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 1
        public short anoxic2_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 2
        public short anoxic3_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 3
        public short anoxic4_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 4
        public short anoxic5_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 5
        public short anoxic6_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 6
        public short anoxic7_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 7
        public short anoxic8_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 8
        public short metanol_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Metanol "MT-ETN"
        public short metanol_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Metanol "MT-ETN"
        public short tuanHoan1_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm tuần hoàn 1 "TH1"
        public short tuanHoan2_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm tuần hoàn 2 "TH2"
        public short tuanHoan3_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm tuần hoàn 3 "TH3"
        public short gatBun_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" gạt bùn "GB1"
        public short gatBun_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" gạt bùn "GB1"
        public short bomBun_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 1 & 2 ON
        public short bomBun_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 1 & 2 OFF

        /*
        public short etanol1_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Etanol 1
        public short etanol2_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Etanol 2
        */

        public short khuayNaoh_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" khuấy NaoH "ON"
        public short khuayNaoh_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" khuấy NaoH "OFF"

        public short mkt01_setTime { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí MKT1
        public short mkt02_setTime { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí MTK2
        public short mkt03_setTime { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí MTK3

    }
}
