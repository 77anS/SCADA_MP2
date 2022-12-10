using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC3_RuntimeSetting_DB19
    {
        public short WP02A_bomNt02A_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm nước thải 02A
        public short WP02B_bomNt02B_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm nước thải 02B
        public short AB06A_mtkAB06A_setTime { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí AB06A
        public short AB06B_mtkAB06B_setTime { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí AB06B
        public short AB06C_mtkAB06C_setTime { get; set; } // Thời gian cài đặt "RUNTIME" máy thổi khí AB06C
        public short MS05_gbbl05_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 05 "ON"
        public short MS05_gbbl05_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 05 "OFF"
        public short MS07_gbbl07_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 07 "ON"
        public short MS07_gbbl07_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 07 "OFF"
        public short MS09_gbbl09_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 09 'ON'
        public short MS09_gbbl09_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất GBBL 09 'OFF'
        public short SP05AB_bomBun05AB_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 05A và 05B "ON"
        public short SP05AB_bomBun05AB_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 05A và 05B "OFF"
        public short SP07AB_bomBun07AB_setTime_on { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 07A và 07B "ON"
        public short SP07ABbomBun07AB_setTime_off { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn 07A và 07B "OFF"
        //-----------------------------------------------------------------------------------------------------
        //public short mayTachRac_setTime { get; set; } // Thời gian cài đặt "RUNTIME" máy tách rác
        //public short khuayKeoTu_GD2_setTime { get; set; } // Thời gian cài đặt "RUNTIME" khuấy keo tụ GD2
        //public short khuayTaoBong_A_setTime { get; set; } // Thời gian cài đặt "RUNTIME" khuấy tạo bông A
        //public short khuayTaoBong_B_setTime { get; set; }  // Thời gian cài đặt "RUNTIME" khuấy tạo bông B
        //public short khuayPac_GD2_setTime { get; set; } // Thời gian cài đặt "RUNTIME" khuấy PAC GD2
        //public short khuayPoly_GD2_setTime { get; set; } // Thời gian cài đặt "RUNTIME" khuấy Polyme GD2
        //public short bomBun_SP10_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm bùn SP10
        //public short dlPhen_03A_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm định lượng phèn 03A
        //public short dlPhen_03B_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm định lượng phèn 03B
        //public short dlPoly_04A_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm định lượng Polyme 04A
        //public short dlPoly_04B_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm định lượng Polyme 04B
        //public short dlXut_05A_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Xút 05A
        //public short dlXut_05B_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Xút 05B
        //public short dlDd_06A_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Dd 06A
        //public short dlDd_06B_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất Dd 06B
        //public short dlKhuTrung_07A_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất khử trùng 07A
        //public short dlKhuTrung_07B_setTime { get; set; } // Thời gian cài đặt "RUNTIME" bơm hóa chất khử trùng 07B
    }
}
