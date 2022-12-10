using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC3_RuntimeSettingUI
    {
        // SETTIME UI
        public short WP02A_bomNt02A_setTime_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm nước thải 02A
        public short WP02B_bomNt02B_setTime_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm nước thải 02B
        public short AB06A_mtkAB06A_setTime_ui { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí AB06A
        public short AB06B_mtkAB06B_setTime_ui { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí AB06B
        public short AB06A_mtkAB06C_setTime_ui { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí AB06C
        public short MS05_gbbl05_setTime_on_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 05 "ON"
        public short MS05_gbbl05_setTime_off_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 05 "OFF"
        public short MS07_gbbl07_setTime_on_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 07 "ON"
        public short MS07_gbbl07_setTime_off_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 07 "OFF"
        public short MS09_gbbl09_setTime_on_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 09 'ON'
        public short MS09_gbbl09_setTime_off_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 09 'OFF'
        public short SP05AB_bomBun05AB_setTime_on_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 05A và 05B "ON"
        public short SP05AB_bomBun05AB_setTime_off_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 05A và 05B "OFF"
        public short SP07AB_bomBun07AB_setTime_on_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 07A và 07B "ON"
        public short SP07AB_bomBun07AB_setTime_off_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 07A và 07B "OFF"
    }
}
