using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC1_InputStatus_DB43
    {
        public bool MTK01_mayTKBeDieuHoa_runStatus { get; set; }
        public bool MTK01_mayTKBeDieuHoa_tripStatus { get; set; }

        public bool MTK02_mayTKBeDieuHoa_runStatus { get; set; }
        public bool MTK02_mayTKBeDieuHoa_tripStatus { get; set; }

        public bool MTK03_mayTKBeDieuHoa_runStatus { get; set; }
        public bool MTK03_mayTKBeDieuHoa_tripStatus { get; set; }

        public bool P0201_bomBeDieuHoa_runStatus { get; set; }
        public bool P0201_bomBeDieuHoa_tripStatus { get; set; }

        public bool P0202_bomBeDieuHoa_runStatus { get; set; }
        public bool P0202_bomBeDieuHoa_tripStatus { get; set; }

        public bool MTB_TuanHoanNuoc_runStatus { get; set; }
        public bool MTB_TuanHoanNuoc_tripStatus { get; set; }
        public bool MTB_TuanHoanBun_runStatus { get; set; }
        public bool MTB_TuanHoanBun_tripStatus { get; set; }
        public bool SP09A_BunHoaLy1_runStatus { get; set; }
        public bool SP09A_BunHoaLy1_tripStatus { get; set; }
        public bool SP09B_BunHoaLy2_runStatus { get; set; }
        public bool SP09B_BunHoaLy2_tripStatus { get; set; }
        public bool P101_BeGom1_runStatus { get; set; }
        public bool P101_BeGom1_tripStatus { get; set; }

        public bool P102_BeGom2_runStatus { get; set; }
        public bool P102_BeGom2_tripStatus { get; set; }

        public bool P103_BeGom3_runStatus { get; set; }
        public bool P103_BeGom3_tripStatus { get; set; }
        public bool SKBM1_runStatus { get; set; }
        public bool SKBM1_tripStatus { get; set; }

        public bool SKBM2_runStatus { get; set; }
        public bool SKBM2_tripStatus { get; set; }

        public bool SKBM3_runStatus { get; set; }
        public bool SKBM3_tripStatus { get; set; }

        public bool MTB_DlAxit_runStatus { get; set; }
        public bool MTB_DlAxit_tripStatus { get; set; }

        public bool DP02_DlXut_runStatus { get; set; }
        public bool DP02_DlXut_tripStatus { get; set; }

        public bool DP03_DlNp_runStatus { get; set; }
        public bool DP03_DlNp_tripStatus { get; set; }

        public bool DP04_DlClo_runStatus { get; set; }
        public bool DP04_DlClo_tripStatus { get; set; }

        public bool DP05_DlPac_runStatus { get; set; }
        public bool DP05_DlPac_tripStatus { get; set; }

        public bool DP06_1P1_DlPolyme1_runStatus { get; set; }
        public bool DP06_1P1_DlPolyme1_tripStatus { get; set; }

        public bool DP06_2P2_DlPolyme2_runStatus { get; set; }
        public bool DP06_2P2_DlPolyme2_tripStatus { get; set; }

        public bool MT03_KhuayNp_runStatus { get; set; }
        public bool MT03_KhuayNp_tripStatus { get; set; }

        public bool MT04_KhuayClo_runStatus { get; set; }
        public bool MT04_KhuayClo_tripStatus { get; set; }

        public bool MT05_KhuayPac_runStatus { get; set; }
        public bool MT05_KhuayPac_tripStatus { get; set; }

        public bool MT06_1P1_KhuayPolyme1_runStatus { get; set; }
        public bool MT06_1P1_KhuayPolyme1_tripStatus { get; set; }

        public bool MT06_2P2_KhuayPolyme2_runStatus { get; set; }
        public bool MT06_2P2_KhuayPolyme2_tripStatus { get; set; }

        public bool MT01_KhuayKeoTu_runStatus { get; set; }
        public bool MT01_KhuayKeoTu_tripStatus { get; set; }

        public bool MT02A_KhuayTaoBong1_runStatus { get; set; }
        public bool MT02A_KhuayTaoBong1_tripStatus { get; set; }

        public bool MT02B_KhuayTaoBong2_runStatus { get; set; }
        public bool MT02B_KhuayTaoBong2_tripStatus { get; set; }

        public bool GGB_MotorGatBun_runStatus { get; set; }
        public bool GGB_MotorGatBun_tripStatus { get; set; }

        /// <summary>
        /// Mỹ phước giai đoạn 1 "GD1"
        /// </summary>
        // Tín hiệu phao bể gom
        public bool LL101_PhaoBeGom_lowLevelStatus { get; set; } // Tín hiệu thấp "I2.6"
        public bool ML102_PhaoBeGom_mediumLevelStatus { get; set; } //Tín hiệu mức trung bình "I2.7"
        public bool HL103_PhaoBeGom_highLevelStatus { get; set; } //Tín hiệu mức cao "I3.0"
    }
}
