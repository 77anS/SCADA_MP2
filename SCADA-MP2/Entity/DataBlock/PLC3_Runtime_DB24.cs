using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC3_Runtime_DB24
    {
        public int BS02A_mayTachRac_runtime { get; set; } // Thời gian "RUNTIME" máy tách rác
        public int WP02A_bomNt02A_runtime { get; set; } // Thời gian "RUNTIME" bơm nước thải 02A
        public int WP02B_bomN_02B_runtime { get; set; } // Thời gian "RUNTIME" bơm nước thải 02B
        public int AB06A_mayTKBiofor1_runtime { get; set; } // Thời gian "RUNTIME" máy thổi khí AB06A
        public int AB06B_mayTKBiofor2_runtime { get; set; } // Thời gian "RUNTIME" máy thổi khí AB06B
        public int AB06C_mayTKBiofor3_runtime { get; set; } // Thời gian "RUNTIME" máy thổi khí AB06C
        public int MI03_khuayKeoTuGD2_runtime { get; set; } // Thời gian "RUNTIME" khuấy keo tụ GD2
        public int MI04A_khuayTaoBongA_runtime { get; set; } // Thời gian "RUNTIME" khuấy tạo bông A
        public int MI04B_khuayTaoBongB_runtime { get; set; }  // Thời gian "RUNTIME" khuấy tạo bông B
        public int GBBL05_gatBunBeLang05_runtime { get; set; } // Thời gian "RUNTIME" bơm hóa chất GBBL 05
        public int GBBL07_gatBunBeLang07_runtime { get; set; } // Thời gian "RUNTIME" bơm hóa chất GBBL 07
        public int GBBL09_gatBunBeLang09_runtime { get; set; } // Thời gian "RUNTIME" bơm hóa chất GBBL 09
        public int MC03_khuayPacGD2_runtime { get; set; } // Thời gian "RUNTIME" khuấy PAC GD2
        public int MC04_khuayPolyGD2_runtime { get; set; } // Thời gian "RUNTIME" khuấy Polyme GD2
        public int SP05A_bomBun05A_runtime { get; set; } // Thời gian "RUNTIME" bơm bùn 05A
        public int SP05B_bomBun05B_runtime { get; set; } // Thời gian "RUNTIME" bơm bùn 05B
        public int SP07A_bomBun07A_runtime { get; set; } // Thời gian "RUNTIME" bơm bùn 07A
        public int SP07B_bomBun07B_runtime { get; set; } // Thời gian "RUNTIME" bơm bùn 07B
        public int SP10_bomBunSP10_runtime { get; set; } // Thời gian "RUNTIME" bơm bùn SP10
        public int MI03A_dlPhen03A_runtime { get; set; } // Thời gian "RUNTIME" bơm định lượng phèn 03A
        public int DP03B_dlPhen03B_runtime { get; set; } // Thời gian "RUNTIME" bơm định lượng phèn 03B
        public int DP04A_dlPoly04A_runtime { get; set; } // Thời gian "RUNTIME" bơm định lượng Polyme 04A
        public int DP04B_dlPoly04B_runtime { get; set; } // Thời gian "RUNTIME" bơm định lượng Polyme 04B
        public int DP05A_dlXut05A_runtime { get; set; } // Thời gian "RUNTIME" bơm hóa chất Xút 05A
        public int DP05B_dlXut05B_runtime { get; set; } // Thời gian "RUNTIME" bơm hóa chất Xút 05B
        public int DP06A_dlDD06A_runtime { get; set; } // Thời gian "RUNTIME" bơm hóa chất Dd 06A
        public int DP06B_dlDD06B_runtime { get; set; } // Thời gian "RUNTIME" bơm hóa chất Dd 06B
        public int DP07A_dlKhuTrung07A_runtime { get; set; } // Thời gian "RUNTIME" bơm hóa chất khử trùng 07A
        public int DP07B_dlKhuTrung07B_runtime { get; set; } // Thời gian "RUNTIME" bơm hóa chất khử trùng 07B
    }
}
