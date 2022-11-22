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
        public short bomNt_02A_setTime_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm nước thải 02A
        public short bomNt_02B_setTime_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm nước thải 02B
        public short mtk_AB06A_setTime_ui { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí AB06A
        public short mtk_AB06B_setTime_ui { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí AB06B
        public short mtk_AB06C_setTime_ui { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí AB06C
        public short gbbl05_setTime_on_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 05 "ON"
        public short gbbl05_setTime_off_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 05 "OFF"
        public short gbbl07_setTime_on_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 07 "ON"
        public short gbbl07_setTime_off_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 07 "OFF"
        public short gbbl09_setTime_on_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 09 'ON'
        public short gbbl09_setTime_off_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 09 'OFF'
        public short bomBun_05AB_setTime_on_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 05A và 05B "ON"
        public short bomBun_05AB_setTime_off_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 05A và 05B "OFF"
        public short bomBun_07AB_setTime_on_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 07A và 07B "ON"
        public short bomBun_07AB_setTime_off_ui { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 07A và 07B "OFF"
    }
}
