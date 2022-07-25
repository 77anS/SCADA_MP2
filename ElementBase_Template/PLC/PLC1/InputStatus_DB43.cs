using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.PLC.PLC1
{
    public class InputStatus_DB43
    {
        public bool mtk01_runStatus { get; set; }
        public bool mtk01_tripStatus { get; set; }

        public bool mtk02_runStatus { get; set; }
        public bool mtk02_tripStatus { get; set; }

        public bool mtk03_runStatus { get; set; }
        public bool mtk03_tripStatus { get; set; }

        public bool dieuHoa1_runStatus { get; set; }
        public bool dieuHoa1_tripStatus { get; set; }

        public bool dieuHoa2_runStatus { get; set; }
        public bool dieuHoa2_tripStatus { get; set; }

        public bool tuanHoanNuoc_runStatus { get; set; }
        public bool tuanHoanNuoc_tripStatus { get; set; }
        public bool tuanHoanBun_runStatus { get; set; }
        public bool tuanHoanBun_tripStatus { get; set; }
        public bool bunHoaLy1_runStatus { get; set; }
        public bool bunHoaLy1_tripStatus { get; set; }
        public bool bunHoaLy2_runStatus { get; set; }
        public bool bunHoaLy2_tripStatus { get; set; }
        public bool beGom1_runStatus { get; set; }
        public bool beGom1_tripStatus { get; set; }

        public bool beGom2_runStatus { get; set; }
        public bool beGom2_tripStatus { get; set; }

        public bool beGom3_runStatus { get; set; }
        public bool beGom3_tripStatus { get; set; }
        public bool skbm1_runStatus { get; set; }
        public bool skbm1_tripStatus { get; set; }

        public bool skbm2_runStatus { get; set; }
        public bool skbm2_tripStatus { get; set; }

        public bool skbm3_runStatus { get; set; }
        public bool skbm3_tripStatus { get; set; }

        public bool dlAxit_runStatus { get; set; }
        public bool dlAxit_tripStatus { get; set; }

        public bool dlXut_runStatus { get; set; }
        public bool dlXut_tripStatus { get; set; }

        public bool dlNp_runStatus { get; set; }
        public bool dlNp_tripStatus { get; set; }

        public bool dlClo_runStatus { get; set; }
        public bool dlClo_tripStatus { get; set; }

        public bool dlPac_runStatus { get; set; }
        public bool dlPac_tripStatus { get; set; }

        public bool dlPolyme1_runStatus { get; set; }
        public bool dlPolyme1_tripStatus { get; set; }
        public bool dlPolyme2_runStatus { get; set; }
        public bool dlPolyme2_tripStatus { get; set; }

        public bool khuayNp_runStatus { get; set; }
        public bool khuayNp_tripStatus { get; set; }

        public bool khuayClo_runStatus { get; set; }
        public bool khuayClo_tripStatus { get; set; }

        public bool khuayPac_runStatus { get; set; }
        public bool khuayPac_tripStatus { get; set; }

        public bool khuayPolyme1_runStatus { get; set; }
        public bool khuayPolyme1_tripStatus { get; set; }

        public bool khuayPolyme2_runStatus { get; set; }
        public bool khuayPolyme2_tripStatus { get; set; }

        public bool khuayKeoTu_runStatus { get; set; }
        public bool khuayKeoTu_tripStatus { get; set; }

        public bool khuayTaoBong1_runStatus { get; set; }
        public bool khuayTaoBong1_tripStatus { get; set; }

        public bool khuayTaoBong2_runStatus { get; set; }
        public bool khuayTaoBong2_tripStatus { get; set; }

        public bool motorGatBun_runStatus { get; set; }
        public bool motorGatBun_tripStatus { get; set; }

        /// <summary>
        /// Mỹ phước giai đoạn 1 "GD1"
        /// </summary>
        // Tín hiệu phao bể gom
        public bool low_beGom_float { get; set; } // Tín hiệu thấp "I2.6"
        public bool medium_beGom_float { get; set; } //Tín hiệu mức trung bình "I2.7"
        public bool high_beGom_float { get; set; } //Tín hiệu mức cao "I3.0"
    }
}
