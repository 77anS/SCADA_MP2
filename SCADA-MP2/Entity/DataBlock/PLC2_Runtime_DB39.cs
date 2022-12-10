using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC2_Runtime_DB39
    {
        public int SM01_anoxic1_runtime { get; set; }  // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 1
        public int SM02_anoxic2_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 2
        public int SM03_anoxic3_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 3
        public int SM04_anoxic4_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 4
        public int SM05_anoxic5_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 5
        public int SM06_anoxic6_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 6
        public int SM07_anoxic7_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 7
        public int SM08_anoxic8_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 8
        public int DPETN_etanol1_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm hóa chất Etanol 1
        public int DPETN_etanol2_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm hóa chất Etanol 2
        public int MTETN_metanol_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm hóa chất Metanol "MT-ETN"
        public int MKT1_mkt01Aerotank_runtime { get; set; } // Thời gian chạy "RUNTIME" máy thổi khí MKT1
        public int MKT2_mkt02Aerotank_runtime { get; set; } // Thời gian chạy "RUNTIME" máy thổi khí MTK2
        public int MKT3_mkt03Aerotank_runtime { get; set; } // Thời gian chạy "RUNTIME" máy thổi khí MTK3
        public int TH1_tuanHoan1_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm tuần hoàn 1 "TH1"
        public int TH2_tuanHoan2_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm tuần hoàn 2 "TH2"
        public int TH3_tuanHoan3_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm tuần hoàn 3 "TH3"
        public int GB1_gatBun_runtime { get; set; } // Thời gian chạy "RUNTIME" gạt bùn "GB1"
        public int BB1_bomBun1_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm bùn 1
        public int BB2_bomBun2_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm bùn 2
        public int MTB_khuayNaoh_runtime { get; set; } // Thời gian chạy "RUNTIME" khuấy NaoH
        public int MTB_dlNaoh_runtime { get; set; } // Thời gian chạy "RUNTIME" định lượng NaoH
        public int MTB_al2so4_1_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm hóa chất AL2SO4 1.
        public int MTB_al2so4_2_runtime { get; set; } // Thời gian chạy "RUNTIME" bơm hóa chất AL2SO4 2.
    }
}
