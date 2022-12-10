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
        public bool BS02A_mayTachRac_runStatus { get; set; } // Trạng thái "RUN" máy tách rác
        public bool BS02A_mayTachRac_tripStatus { get; set; } // Trạng thái "TRIP" máy tách rác.
        public bool WP02A_bomNt_02A_runStatus { get; set; } // Trạng thái "RUN" bơm nước thải 02A
        public bool WP02A_bomNt_02A_tripStatus { get; set; } // Trạng thái "TRIP" bơm nước thải 02A.
        public bool WP02B_bomNt_02B_runStatus { get; set; } // Trạng thái "RUN" bơm nước thải 02B
        public bool WP02B_bomNt_02B_tripStatus { get; set; } // Trạng thái "TRIP" bơm nước thải 02B.
        public bool AB06A_mayTKBiofor1_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí AB06A
        public bool AB06A_mayTKBiofor1_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí AB06A.
        public bool AB06B_mayTKBiofor2_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí AB06B
        public bool AB06B_mayTKBiofor2_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí AB06B.

        public bool AB06C_mayTKBiofor3_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí AB06C
        public bool AB06C_mayTKBiofor3_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí AB06C.

        public bool MI03_khuayKeoTu_runStatus { get; set; } // Trạng thái "RUN" khuấy keo tụ GD2
        public bool MI03_khuayKeoTu_tripStatus { get; set; } // Trạng thái "TRIP" khuấy keo tụ GD2.

        public bool MI04A_khuayTaoBongA_runStatus { get; set; } // Trạng thái "RUN" khuấy tạo bông A
        public bool MI04A_khuayTaoBongA_tripStatus { get; set; } // Trạng thái "TRIP" khuấy tạo bông A.

        public bool MI04B_khuayTaoBongB_runStatus { get; set; }  // Trạng thái "RUN" khuấy tạo bông B
        public bool MI04B_khuayTaoBongB_tripStatus { get; set; }  // Trạng thái "TRIP" khuấy tạo bông B.

        public bool MS05_gbbl05_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất GBBL 05
        public bool MS05_gbbl05_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất GBBL 05.

        public bool MS07_gbbl07_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất GBBL 07
        public bool MS07_gbbl07_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất GBBL 07.

        public bool MS09_gbbl09_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất GBBL 09
        public bool MS09_gbbl09_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất GBBL 09.

        public bool MC03_khuayPac_runStatus { get; set; } // Trạng thái "RUN" khuấy PAC GD2
        public bool MC03_khuayPac_tripStatus { get; set; } // Trạng thái "TRIP" khuấy PAC GD2.

        public bool MC04_khuayPoly_runStatus { get; set; } // Trạng thái "RUN" khuấy Polyme GD2
        public bool MC04_khuayPoly_tripStatus { get; set; } // Trạng thái "TRIP" khuấy Polyme GD2.

        public bool SP05A_bomBun05A_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 05A
        public bool SP05A_bomBun05A_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 05A.

        public bool SP05B_bomBun05B_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 05B
        public bool SP05B_bomBun05B_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 05B.

        public bool SP07A_bomBun07A_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 07A
        public bool SP07A_bomBun07A_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 07A.

        public bool SP07B_bomBun07B_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 07B
        public bool SP07B_bomBun07B_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 07B.

        public bool SP10_bomBunSP10_runStatus { get; set; } // Trạng thái "RUN" bơm bùn SP10
        public bool SP10_bomBunSP10_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn SP10.


        public bool MI03_dlPhen03A_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng phèn 03A
        public bool MI03_dlPhen03A_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng phèn 03A.

        public bool DP03B_dlPhen03B_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng phèn 03B
        public bool DP03B_dlPhen03B_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng phèn 03B.

        public bool DP04A_dlPolyme04A_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng Polyme 04A
        public bool DP04A_dlPolyme04A_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng Polyme 04A.

        public bool DP04B_dlPolyme04B_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng Polyme 04B
        public bool DP04B_dlPolyme04B_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng Polyme 04B.

        public bool DP05A_dlXut05A_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Xút 05A
        public bool DP05A_dlXut05A_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Xút 05A.

        public bool DP05B_dlXut05B_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Xút 05B
        public bool DP05B_dlXut05B_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Xút 05B.

        public bool DP06A_dlDd06A_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Dd 06A
        public bool DP06A_dlDd06A_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Dd 06A.

        public bool DP06B_dlDd06B_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Dd 06B
        public bool DP06B_dlDd06B_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Dd 06B.

        public bool DP07A_dlKhuTrung_07A_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất khử trùng 07A
        public bool DP07A_dlKhuTrung_07A_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất khử trùng 07A.

        public bool DP07B_dlKhuTrung_07B_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất khử trùng 07B
        public bool DP07B_dlKhuTrung_07B_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất khử trùng 07B.
        #endregion


        /// <summary>
        /// Mỹ phước giai đoạn 2 "GD2"
        /// </summary>
        /// 
        // Tín hiệu phao bể điều hòa
        public bool LL201_beDieuHoa_lowLevel { get; set; } // Tín hiệu phao mức thấp 
        public bool LL201_beDieuHoa_highLevel { get; set; } // Tín hiệu phao mức cao
        public bool HL05_beBun05_highLevel { get; set; } // Tín hiệu phao bể bùn 05
        public bool HL07_beBun07_highLevel { get; set; } // Tín hiệu phao bể bùn 07
        public bool HL10_beBunSP10_highLevel { get; set; } // Tín hiệu phao bể bùn SP10

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
