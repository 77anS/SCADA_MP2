using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC3_ResetRuntime_DB25
    {
        public bool BS02A_mayTachRac_resetCmd { get; set; } // Lệnh RESET "RUNTIME" máy tách rác
        public bool WP02A_bomNt02A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm nước thải 02A
        public bool WP02b_bomNt02B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm nước thải 02B
        public bool AB06A_mtkAB06A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" máy thổi khí AB06A
        public bool AB06B_mtkAB06B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" máy thổi khí AB06B
        public bool AB06C_mtkAB06C_resetCmd { get; set; } // Lệnh RESET "RUNTIME" máy thổi khí AB06C
        public bool MI03_khuayKeoTuGD2_resetCmd { get; set; } // Lệnh RESET "RUNTIME" khuấy keo tụ GD2
        public bool MI04A_khuayTaoBongA_resetCmd { get; set; } // Lệnh RESET "RUNTIME" khuấy tạo bông A
        public bool MI04B_khuayTaoBongB_resetCmd { get; set; }  // Lệnh RESET "RUNTIME" khuấy tạo bông B
        public bool MS05_gbbl05_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất GBBL 05
        public bool MS07_gbbl07_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất GBBL 07
        public bool MS09_gbbl09_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất GBBL 09
        public bool MC03_khuayPacGD2_resetCmd { get; set; } // Lệnh RESET "RUNTIME" khuấy PAC GD2
        public bool MC04_khuayPolyGD2_resetCmd { get; set; } // Lệnh RESET "RUNTIME" khuấy Polyme GD2
        public bool SP05A_bomBun05A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm bùn 05A
        public bool SP05B_bomBun05B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm bùn 05B
        public bool SP07A_bomBun07A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm bùn 07A
        public bool SP07B_bomBun07B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm bùn 07B
        public bool SP10_bomBunSP10_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm bùn SP10
        public bool MI03_dlPhen03A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm định lượng phèn 03A
        public bool DP03B_dlPhen03B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm định lượng phèn 03B
        public bool DP04A_dlPoly04A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm định lượng Polyme 04A
        public bool DP04B_dlPoly04B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm định lượng Polyme 04B
        public bool DP05A_dlXut05A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất Xút 05A
        public bool DP05B_dlXut05B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất Xút 05B
        public bool DP06A_dlDd06A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất Dd 06A
        public bool DP06B_dlDd06B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất Dd 06B
        public bool DP07A_dlKhuTrung07A_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất khử trùng 07A
        public bool DP07B_dlKhuTrung07B_resetCmd { get; set; } // Lệnh RESET "RUNTIME" bơm hóa chất khử trùng 07B
    }
}
