using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.PLC.PLC3
{
    public class ResetRuntime_DB25_PLC3
    {
        public bool mayTachRac_resetCmd { get; set; } // Lệnh RESET "RUNTIME" máy tách rác
        public bool bomNt_02A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm nước thải 02A
        public bool bomNt_02B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm nước thải 02B
        public bool mtk_AB06A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" máy thổi khí AB06A
        public bool mtk_AB06B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" máy thổi khí AB06B
        public bool mtk_AB06C_resetCmd { get; set; } // Lệnh RESET "RUNTIME" máy thổi khí AB06C
        public bool khuayKeoTu_GD2_resetCmd { get; set; } // Lệnh RESET "RUNTIME" khuấy keo tụ GD2
        public bool khuayTaoBong_A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" khuấy tạo bông A
        public bool khuayTaoBong_B_resetCmd { get; set; }  // Lệnh RESET "RUNTIME" khuấy tạo bông B
        public bool gbbl05_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất GBBL 05
        public bool gbbl07_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất GBBL 07
        public bool gbbl09_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất GBBL 09
        public bool khuayPac_GD2_resetCmd { get; set; } // Lệnh RESET "RUNTIME" khuấy PAC GD2
        public bool khuayPoly_GD2_resetCmd { get; set; } // Lệnh RESET "RUNTIME" khuấy Polyme GD2
        public bool bomBun_05A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm bùn 05A
        public bool bomBun_05B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm bùn 05B
        public bool bomBun_07A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm bùn 07A
        public bool bomBun_07B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm bùn 07B
        public bool bomBun_SP10_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm bùn SP10
        public bool dlPhen_03A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm định lượng phèn 03A
        public bool dlPhen_03B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm định lượng phèn 03B
        public bool dlPoly_04A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm định lượng Polyme 04A
        public bool dlPoly_04B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm định lượng Polyme 04B
        public bool dlXut_05A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất Xút 05A
        public bool dlXut_05B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất Xút 05B
        public bool dlDd_06A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất Dd 06A
        public bool dlDd_06B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất Dd 06B
        public bool dlKhuTrung_07A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất khử trùng 07A
        public bool dlKhuTrung_07B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất khử trùng 07B
    }
}
