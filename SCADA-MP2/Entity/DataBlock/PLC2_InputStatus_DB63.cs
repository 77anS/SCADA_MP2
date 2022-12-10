using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC2_InputStatus_DB63
    {
        /// <summary>
        /// Mỹ phước giai đoạn 1 "GD1MR"
        /// </summary>
        public bool mtk1_manMode { get; set; } // Tín hiệu "Manual" mode máy thổi khí 1
        public bool mtk1_autoMode { get; set; } // Tín hiệu "Auto" máy thổi khí 1
        public bool mtk2_manMode { get; set; } // Tín hiệu "Manual" máy thổi khí 2
        public bool mtk2_autoMode { get; set; } // Tín hiệu "Auto" máy thổi khí 2
        public bool mtk3_manMode { get; set; } // Tín hiệu "Manual" máy thổi khí 3
        public bool mtk3_autoMode { get; set; } // Tín hiệu "Auto" máy thổi khí 3

        /// <summary>
        /// Mỹ Phước giai đoạn 1 cải tạo : GD1MR
        /// </summary>
        /// 
        public bool SM01_anoxic1_runStatus { get; set; } = true;  // Trạng thái "RUN" bơm hóa chất Anoxic 1
        public bool SM01_anoxic1_tripStatus { get; set; } = true; // Trạng thái "TRIP" bơm hóa chất Anoxic 1.
        public bool SM02_anoxic2_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 2
        public bool SM02_anoxic2_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 2.
        public bool SM03_anoxic3_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 3
        public bool SM03_anoxic3_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 3.
        public bool SM04_anoxic4_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 4
        public bool SM04_anoxic4_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 4.
        public bool SM05_anoxic5_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 5
        public bool SM05_anoxic5_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 5.
        public bool SM06_anoxic6_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 6
        public bool SM06_anoxic6_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 6.
        public bool SM07_anoxic7_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 7
        public bool SM07_anoxic7_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 7.
        public bool SM08_anoxic8_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 8
        public bool SM08_anoxic8_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 8.
        public bool DPETN_etanol1_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Etanol 1
        public bool DPETN_etanol1_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Etanol 1.
        public bool MTB_etanol2_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Etanol 2
        public bool MTB_etanol2_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Etanol 2.
        public bool MTETN_metanol_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Metanol "MT-ETN"
        public bool MTETN_metanol_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Metanol "MT-ETN".
        public bool MKT1_mayTKAerotank1_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí MKT1
        public bool MKT1_mayTKAerotank1_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí 1.
        public bool MKT2_mayTKAerotank2_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí MTK2
        public bool MKT2_mayTKAerotank2_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí 2.
        public bool MKT3_mayTKAerotank3_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí MTK3
        public bool MKT3_mayTKAerotank3_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí 3.
        public bool TH1_tuanHoan1_runStatus { get; set; } // Trạng thái "RUN" bơm tuần hoàn 1 "TH1"
        public bool TH1_tuanHoan1_tripStatus { get; set; } // Trạng thái "TRIP" bơm tuần hoàn 1.
        public bool TH2_tuanHoan2_runStatus { get; set; } // Trạng thái "RUN" bơm tuần hoàn 2 "TH2"
        public bool TH2_tuanHoan2_tripStatus { get; set; } // Trạng thái "TRIP" bơm tuần hoàn 2.
        public bool TH3_tuanHoan3_runStatus { get; set; } // Trạng thái "RUN" bơm tuần hoàn 3 "TH3"
        public bool TH3_tuanHoan3_tripStatus { get; set; } // Trạng thái "TRIP" bơm tuần hoàn 3.
        public bool GB1_gatBun_runStatus { get; set; } // Trạng thái "RUN" gạt bùn "GB1"
        public bool GB1_gatBun_tripStatus { get; set; } // Trạng thái "TRIP" gạt bùn "GB1".
        public bool BB1_bomBun1_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 1
        public bool BB1_bomBun1_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 1.
        public bool BB2_bomBun2_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 2
        public bool BB2_bomBun2_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 2.
        public bool MTB_khuayNaoh_runStatus { get; set; } // Trạng thái "RUN" khuấy NaoH
        public bool MTB_khuayNaoh_tripStatus { get; set; } // Trạng thái "TRIP" khuấy NaoH.
        public bool MTB_dlNaoh_runStatus { get; set; } // Trạng thái "RUN" định lượng NaoH
        public bool MTB_dlNaoh_tripStatus { get; set; } // Trạng thái "TRIP" định lượng NaoH.
        public bool MTB_al2so4_1_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất AL2SO4 1.
        public bool MTB_al2so4_1_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất AL2SO4 1.
        public bool MTB_al2so4_2_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất AL2SO4 2.
        public bool MTB_al2so4_2_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất AL2SO4 2.
    }
}
