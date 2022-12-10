using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC2_RuntimeSetting_DB1
    {
        public short SM01_anoxic1_setTime { get; set; }  // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 1
        public short SM02_anoxic2_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 2
        public short SM03_anoxic3_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 3
        public short SM04_anoxic4_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 4
        public short SM05_anoxic5_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 5
        public short SM06_anoxic6_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 6
        public short SM07_anoxic7_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 7
        public short SM08_anoxic8_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Anoxic 8
        public short MTETN_metanol_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Metanol "MT-ETN"
        public short MTETN_metanol_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Metanol "MT-ETN"
        public short TH1_tuanHoan1_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm tuần hoàn 1 "TH1"
        public short TH2_tuanHoan2_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm tuần hoàn 2 "TH2"
        public short TH3_tuanHoan3_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm tuần hoàn 3 "TH3"
        public short GB1_gatBun_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" gạt bùn "GB1"
        public short GB1_gatBun_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" gạt bùn "GB1"
        public short BB1_bomBun_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 1 & 2 ON
        public short BB1_bomBun_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 1 & 2 OFF

        /*
        public short etanol1_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Etanol 1
        public short etanol2_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Etanol 2
        */

        public short MTB_khuayNaoh_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" khuấy NaoH "ON"
        public short MTB_khuayNaoh_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" khuấy NaoH "OFF"

        public short MKT01_mayTKiAerotank_setTime { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí MKT1
        public short MKT02_mayTKAerotank_setTime { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí MTK2
        public short MKT03_mayTKAerotank_setTime { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí MTK3
    }
}
