using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.PLC.PLC2
{
    public class ResetRuntime_DB38_PLC2
    {
        public bool anoxic1_resetCmd { get; set; }  // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 1
        public bool anoxic2_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 2
        public bool anoxic3_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 3
        public bool anoxic4_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 4
        public bool anoxic5_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 5
        public bool anoxic6_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 6
        public bool anoxic7_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 7
        public bool anoxic8_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Anoxic 8
        public bool etanol1_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Etanol 1
        public bool metanol_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Metanol "MT-ETN"
        public bool mkt01_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" máy thổi khí MKT1
        public bool mkt02_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" máy thổi khí MTK2
        public bool mkt03_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" máy thổi khí MTK3
        public bool tuanHoan1_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm tuần hoàn 1 "TH1"
        public bool tuanHoan2_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm tuần hoàn 2 "TH2"
        public bool tuanHoan3_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm tuần hoàn 3 "TH3"
        public bool gatBun_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" gạt bùn "GB1"
        public bool bomBun1_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm bùn 1
        public bool khuayNaoh_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" khuấy NaoH
        public bool dlNaoh_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" định lượng NaoH
        public bool al2so4_1_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất AL2SO4 1.
        public bool bomBun2_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm bùn 2
        public bool etanol2_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất Etanol 2
        public bool al2so4_2_resetCmd { get; set; } // Lệnh RESET thời gian "RUNTIME" bơm hóa chất AL2SO4 2.
    }
}
