using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC2_ResetRuntime_DB38
    {
        public bool SM01_anoxic1_resetCmd { get; set; }  // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 1
        public bool SM02_anoxic2_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 2
        public bool SM03_anoxic3_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 3
        public bool SM04_anoxic4_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 4
        public bool SM05_anoxic5_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 5
        public bool SM06_anoxic6_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 6
        public bool SM07_anoxic7_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 7
        public bool SM08_anoxic8_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 8
        public bool DPETN_etanol1_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Etanol 1
        public bool MTETN_metanol_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Metanol "MT-ETN"
        public bool MKT1_mayTKBeAerotank_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" máy thổi khí MKT1
        public bool MKT2_mayTKBeAerotank_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" máy thổi khí MTK2
        public bool MKT3_mayTKBeAerotank_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" máy thổi khí MTK3
        public bool TH1_tuanHoan1_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm tuần hoàn 1 "TH1"
        public bool TH2_tuanHoan2_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm tuần hoàn 2 "TH2"
        public bool TH3_tuanHoan3_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm tuần hoàn 3 "TH3"
        public bool GB1_gatBun_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" gạt bùn "GB1"
        public bool BB1_bomBun1_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm bùn 1
        public bool MTB_khuayNaoh_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" khuấy NaoH
        public bool MTB_dlNaoh_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" định lượng NaoH
        public bool MTB_al2so4_1_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất AL2SO4 1.
        public bool BB2_bomBun2_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm bùn 2
        public bool MTB_etanol2_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Etanol 2
        public bool MTB_al2so4_2_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất AL2SO4 2.
    }
}
