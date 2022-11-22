using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC1_InputStatus_DB43
    {
        public bool Mtk01_runStatus { get; set; }
        public bool Mtk01_tripStatus { get; set; }

        public bool Mtk02_runStatus { get; set; }
        public bool Mtk02_tripStatus { get; set; }

        public bool Mtk03_runStatus { get; set; }
        public bool Mtk03_tripStatus { get; set; }

        public bool DieuHoa1_runStatus { get; set; }
        public bool DieuHoa1_tripStatus { get; set; }

        public bool DieuHoa2_runStatus { get; set; }
        public bool DieuHoa2_tripStatus { get; set; }

        public bool TuanHoanNuoc_runStatus { get; set; }
        public bool TuanHoanNuoc_tripStatus { get; set; }
        public bool TuanHoanBun_runStatus { get; set; }
        public bool TuanHoanBun_tripStatus { get; set; }
        public bool BunHoaLy1_runStatus { get; set; }
        public bool BunHoaLy1_tripStatus { get; set; }
        public bool BunHoaLy2_runStatus { get; set; }
        public bool BunHoaLy2_tripStatus { get; set; }
        public bool BeGom1_runStatus { get; set; }
        public bool BeGom1_tripStatus { get; set; }

        public bool BeGom2_runStatus { get; set; }
        public bool BeGom2_tripStatus { get; set; }

        public bool BeGom3_runStatus { get; set; }
        public bool BeGom3_tripStatus { get; set; }
        public bool Skbm1_runStatus { get; set; }
        public bool Skbm1_tripStatus { get; set; }

        public bool Skbm2_runStatus { get; set; }
        public bool Skbm2_tripStatus { get; set; }

        public bool Skbm3_runStatus { get; set; }
        public bool Skbm3_tripStatus { get; set; }

        public bool DlAxit_runStatus { get; set; }
        public bool DlAxit_tripStatus { get; set; }

        public bool DlXut_runStatus { get; set; }
        public bool DlXut_tripStatus { get; set; }

        public bool DlNp_runStatus { get; set; }
        public bool DlNp_tripStatus { get; set; }

        public bool DlClo_runStatus { get; set; }
        public bool DlClo_tripStatus { get; set; }

        public bool DlPac_runStatus { get; set; }
        public bool DlPac_tripStatus { get; set; }

        public bool DlPolyme1_runStatus { get; set; }
        public bool DlPolyme1_tripStatus { get; set; }

        public bool DlPolyme2_runStatus { get; set; }
        public bool DlPolyme2_tripStatus { get; set; }

        public bool KhuayNp_runStatus { get; set; }
        public bool KhuayNp_tripStatus { get; set; }

        public bool KhuayClo_runStatus { get; set; }
        public bool KhuayClo_tripStatus { get; set; }

        public bool KhuayPac_runStatus { get; set; }
        public bool KhuayPac_tripStatus { get; set; }

        public bool KhuayPolyme1_runStatus { get; set; }
        public bool KhuayPolyme1_tripStatus { get; set; }

        public bool KhuayPolyme2_runStatus { get; set; }
        public bool KhuayPolyme2_tripStatus { get; set; }

        public bool KhuayKeoTu_runStatus { get; set; }
        public bool KhuayKeoTu_tripStatus { get; set; }

        public bool KhuayTaoBong1_runStatus { get; set; }
        public bool KhuayTaoBong1_tripStatus { get; set; }

        public bool KhuayTaoBong2_runStatus { get; set; }
        public bool KhuayTaoBong2_tripStatus { get; set; }

        public bool MotorGatBun_runStatus { get; set; }
        public bool MotorGatBun_tripStatus { get; set; }

        /// <summary>
        /// Mỹ phước giai đoạn 1 "GD1"
        /// </summary>
        // Tín hiệu phao bể gom
        public bool Low_beGom_float { get; set; } // Tín hiệu thấp "I2.6"
        public bool Medium_beGom_float { get; set; } //Tín hiệu mức trung bình "I2.7"
        public bool High_beGom_float { get; set; } //Tín hiệu mức cao "I3.0"
    }
}
