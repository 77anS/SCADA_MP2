using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.PLC.PLC2
{
    public class InputStatus_DB63_PLC2
    {
        #region Tín hiệu "Auto/ Man" Máy thổi khí 1, 2 và 3
        /// <summary>
        /// Mỹ phước giai đoạn 1 "GD1MR"
        /// </summary>
        public bool mtk1_manMode { get; set; } // Tín hiệu "Manual" mode máy thổi khí 1
        public bool mtk1_autoMode { get; set; } // Tín hiệu "Auto" máy thổi khí 1
        public bool mtk2_manMode { get; set; } // Tín hiệu "Manual" máy thổi khí 2
        public bool mtk2_autoMode { get; set; } // Tín hiệu "Auto" máy thổi khí 2
        public bool mtk3_manMode { get; set; } // Tín hiệu "Manual" máy thổi khí 3
        public bool mtk3_autoMode { get; set; } // Tín hiệu "Auto" máy thổi khí 3
        #endregion
        #region Trạng thái "RUN" Feedback cơ cấu chấp hành


        /// <summary>
        /// Mỹ Phước giai đoạn 1 cải tạo : GD1MR
        /// </summary>
        /// 
        public bool anoxic1_runStatus { get; set; } = true;  // Trạng thái "RUN" bơm hóa chất Anoxic 1
        public bool anoxic1_tripStatus { get; set; } = true; // Trạng thái "TRIP" bơm hóa chất Anoxic 1.
        public bool anoxic2_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 2
        public bool anoxic2_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 2.
        public bool anoxic3_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 3
        public bool anoxic3_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 3.
        public bool anoxic4_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 4
        public bool anoxic4_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 4.
        public bool anoxic5_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 5
        public bool anoxic5_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 5.
        public bool anoxic6_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 6
        public bool anoxic6_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 6.
        public bool anoxic7_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 7
        public bool anoxic7_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 7.
        public bool anoxic8_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 8
        public bool anoxic8_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 8.
        public bool etanol1_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Etanol 1
        public bool etanol1_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Etanol 1.
        public bool etanol2_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Etanol 2
        public bool etanol2_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Etanol 2.
        public bool metanol_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Metanol "MT-ETN"
        public bool metanol_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Metanol "MT-ETN".
        public bool mkt01_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí MKT1
        public bool mkt01_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí 1.
        public bool mkt02_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí MTK2
        public bool mkt02_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí 2.
        public bool mkt03_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí MTK3
        public bool mkt03_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí 3.
        public bool tuanHoan1_runStatus { get; set; } // Trạng thái "RUN" bơm tuần hoàn 1 "TH1"
        public bool tuanHoan1_tripStatus { get; set; } // Trạng thái "TRIP" bơm tuần hoàn 1.
        public bool tuanHoan2_runStatus { get; set; } // Trạng thái "RUN" bơm tuần hoàn 2 "TH2"
        public bool tuanHoan2_tripStatus { get; set; } // Trạng thái "TRIP" bơm tuần hoàn 2.
        public bool tuanHoan3_runStatus { get; set; } // Trạng thái "RUN" bơm tuần hoàn 3 "TH3"
        public bool tuanHoan3_tripStatus { get; set; } // Trạng thái "TRIP" bơm tuần hoàn 3.
        public bool gatBun_runStatus { get; set; } // Trạng thái "RUN" gạt bùn "GB1"
        public bool gatBun_tripStatus { get; set; } // Trạng thái "TRIP" gạt bùn "GB1".
        public bool bomBun1_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 1
        public bool bomBun1_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 1.
        public bool bomBun2_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 2
        public bool bomBun2_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 2.
        public bool khuayNaoh_runStatus { get; set; } // Trạng thái "RUN" khuấy NaoH
        public bool khuayNaoh_tripStatus { get; set; } // Trạng thái "TRIP" khuấy NaoH.
        public bool dlNaoh_runStatus { get; set; } // Trạng thái "RUN" định lượng NaoH
        public bool dlNaoh_tripStatus { get; set; } // Trạng thái "TRIP" định lượng NaoH.
        public bool al2so4_1_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất AL2SO4 1.
        public bool al2so4_1_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất AL2SO4 1.
        public bool al2so4_2_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất AL2SO4 2.
        public bool al2so4_2_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất AL2SO4 2.
        #endregion
    }
}
