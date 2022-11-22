using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC3_InputStatus_DB55
    {
        /// <summary>
        /// Mỹ Phước giai đoạn 2 : GD2
        /// </summary>
        /// 
        #region
        public bool mayTachRac_runStatus { get; set; } // Trạng thái "RUN" máy tách rác
        public bool mayTachRac_tripStatus { get; set; } // Trạng thái "TRIP" máy tách rác.
        public bool bomNt_02A_runStatus { get; set; } // Trạng thái "RUN" bơm nước thải 02A
        public bool bomNt_02A_tripStatus { get; set; } // Trạng thái "TRIP" bơm nước thải 02A.
        public bool bomNt_02B_runStatus { get; set; } // Trạng thái "RUN" bơm nước thải 02B
        public bool bomNt_02B_tripStatus { get; set; } // Trạng thái "TRIP" bơm nước thải 02B.
        public bool mtk_AB06A_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí AB06A
        public bool mtk_AB06A_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí AB06A.
        public bool mtk_AB06B_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí AB06B
        public bool mtk_AB06B_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí AB06B.

        public bool mtk_AB06C_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí AB06C
        public bool mtk_AB06C_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí AB06C.

        public bool khuayKeoTu_GD2_runStatus { get; set; } // Trạng thái "RUN" khuấy keo tụ GD2
        public bool khuayKeoTu_GD2_tripStatus { get; set; } // Trạng thái "TRIP" khuấy keo tụ GD2.

        public bool khuayTaoBong_A_runStatus { get; set; } // Trạng thái "RUN" khuấy tạo bông A
        public bool khuayTaoBong_A_tripStatus { get; set; } // Trạng thái "TRIP" khuấy tạo bông A.

        public bool khuayTaoBong_B_runStatus { get; set; }  // Trạng thái "RUN" khuấy tạo bông B
        public bool khuayTaoBong_B_tripStatus { get; set; }  // Trạng thái "TRIP" khuấy tạo bông B.

        public bool gbbl05_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất GBBL 05
        public bool gbbl05_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất GBBL 05.

        public bool gbbl07_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất GBBL 07
        public bool gbbl07_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất GBBL 07.

        public bool gbbl09_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất GBBL 09
        public bool gbbl09_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất GBBL 09.

        public bool khuayPac_GD2_runStatus { get; set; } // Trạng thái "RUN" khuấy PAC GD2
        public bool khuayPac_GD2_tripStatus { get; set; } // Trạng thái "TRIP" khuấy PAC GD2.

        public bool khuayPoly_GD2_runStatus { get; set; } // Trạng thái "RUN" khuấy Polyme GD2
        public bool khuayPoly_GD2_tripStatus { get; set; } // Trạng thái "TRIP" khuấy Polyme GD2.

        public bool bomBun_05A_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 05A
        public bool bomBun_05A_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 05A.

        public bool bomBun_05B_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 05B
        public bool bomBun_05B_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 05B.

        public bool bomBun_07A_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 07A
        public bool bomBun_07A_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 07A.

        public bool bomBun_07B_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 07B
        public bool bomBun_07B_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 07B.

        public bool bomBun_SP10_runStatus { get; set; } // Trạng thái "RUN" bơm bùn SP10
        public bool bomBun_SP10_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn SP10.


        public bool dlPhen_03A_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng phèn 03A
        public bool dlPhen_03A_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng phèn 03A.

        public bool dlPhen_03B_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng phèn 03B
        public bool dlPhen_03B_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng phèn 03B.

        public bool dlPolyme_04A_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng Polyme 04A
        public bool dlPolyme_04A_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng Polyme 04A.

        public bool dlPolyme_04B_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng Polyme 04B
        public bool dlPolyme_04B_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng Polyme 04B.

        public bool dlXut_05A_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Xút 05A
        public bool dlXut_05A_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Xút 05A.

        public bool dlXut_05B_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Xút 05B
        public bool dlXut_05B_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Xút 05B.

        public bool dlDd_06A_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Dd 06A
        public bool dlDd_06A_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Dd 06A.

        public bool dlDd_06B_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Dd 06B
        public bool dlDd_06B_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Dd 06B.

        public bool dlKhuTrung_07A_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất khử trùng 07A
        public bool dlKhuTrung_07A_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất khử trùng 07A.

        public bool dlKhuTrung_07B_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất khử trùng 07B
        public bool dlKhuTrung_07B_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất khử trùng 07B.
        #endregion


        /// <summary>
        /// Mỹ phước giai đoạn 2 "GD2"
        /// </summary>
        /// 
        // Tín hiệu phao bể điều hòa
        public bool low_dieuHoa_float { get; set; } // Tín hiệu phao mức thấp 
        public bool high_dieuHoa_float { get; set; } // Tín hiệu phao mức cao
        public bool float_beBun05_float { get; set; } // Tín hiệu phao bể bùn 05
        public bool float_beBun07_float { get; set; } // Tín hiệu phao bể bùn 07
        public bool float_beBunSP10_float { get; set; } // Tín hiệu phao bể bùn SP10

        #region Tín hiệu quan trắc môi trường
        /// <summary>
        /// Mỹ phước giai đoạn 2 "GD2"
        /// </summary>
        /// 

        // Not used
        public short ph_sensor_in { get; set; } // Chỉ số PH "IW160" nước đàu vào.
        public short do_sensor_in { get; set; } // Chỉ số DO "IW162"
        public double ph_value_in { get; set; } // Gía trị PH sau xử lý => PLC Real 32 bit "MD50"
        #endregion
    }
}
