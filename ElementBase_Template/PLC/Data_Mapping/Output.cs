using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.PLC.Data_Mapping.Temperorary
{
    public static class Output
    {
        #region Trạng thái "ON" trên cơ cấu chấp hành (Output: Q)
            /// <summary>
            /// Mỹ phước giai đoạn 1 "GD1"
            /// </summary>
            public static bool dieuHoa1_on { get; set; } // Bơm điều hòa 1.
            public static bool dieuHoa2_on { get; set; } // Bơm điều hòa 2.
            public static bool tuanHoanNuoc_on { get; set; } // Bơm tuần hoàn nước.
            public static bool tuanHoanBun_on { get; set; } // Bơm tuần hoàn bùn.
            public static bool bunHoaLy1_on { get; set; } // Bùn hóa lý 1.
            public static bool bunHoaLy2_on { get; set; } // Bùn hóa lý 2.
            public static bool beGom1_on { get; set; } // Bể gom 1.
            public static bool beGom2_on { get; set; } // Bể gom 2.
            public static bool beGom3_on { get; set; } // Bể gom 3.
            public static bool skbm1_on { get; set; } //???.
            public static bool skbm2_on { get; set; } //???.
            public static bool skbm3_on { get; set; } //???.
            public static bool mtk1_on { get; set; } // Máy thổi khí 01.
            public static bool mtk2_on { get; set; } // Máy thổi khí 02.
            public static bool mtk3_on { get; set; } // Máy thổi khí 03.
            public static bool dlAxit_on { get; set; } // Định lượng hóa chất axit.
            public static bool dlXut_on { get; set; } // Định lượng Xút.
            public static bool dlNp_on { get; set; } // Định lượng NP.
            public static bool dlClo_on { get; set; } // Định lượng Clo.
            public static bool dlPac_on { get; set; } // Định lượng PAC.
            public static bool dlPolyme_on { get; set; } // Định lượng Polyme.
            public static bool dlPolyme2_on { get; set; } // Định lượng Polyme 2 =>??? Không có
            public static bool khuayNp_on { get; set; } // Máy khuấy NP.
            public static bool khuayClo_on { get; set; } // Khuấy Clo.
            public static bool khuayPac_on { get; set; } // Khuấy PAC.
            public static bool khuayPoly1_on { get; set; } // Khuấy Polyme 1.
            public static bool khuayPoly2_on { get; set; } // Khuây Polyme 2.

            /// <summary>
            /// Mỹ Phước giai đoạn 1 cải tạo : GD1MR
            /// </summary>
            /// 
            public static bool anoxic1_on { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 1.
            public static bool anoxic2_on { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 2.
            public static bool anoxic3_on { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 3.
            public static bool anoxic4_on { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 4.
            public static bool anoxic5_on { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 5.
            public static bool anoxic6_on { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 6.
            public static bool anoxic7_on { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 7.
            public static bool anoxic8_on { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 8.
            public static bool etanol_on { get; set; } // Trạng thái "ON" bơm hóa chất Etanol
            public static bool metanol_on { get; set; } // Trạng thái "ON" bơm hóa chất Metanol
            public static bool mtk1_1_on { get; set; } // Trạng thái "ON" máy thổi khí 1.1.
            public static bool mtk1_2_on { get; set; } // Trạng thái "ON" máy thổi khí 1.2.
            public static bool mtk2_1_on { get; set; } // Trạng thái "ON" máy thổi khí 2.1.
            public static bool mtk2_2_on { get; set; } // Trạng thái "ON" máy thổi khí 2.2.
            public static bool mtk3_1_on { get; set; } // Trạng thái "ON" máy thổi khí 3.1.
            public static bool mtk3_2_on { get; set; } // Trạng thái "ON" máy thổi khí 3.2.
            public static bool tuanHoan1_on { get; set; } // Trạng thái "ON" bơm tuần hoàn 1.
            public static bool tuanHoan2_on { get; set; } // Trạng thái "ON" bơm tuần hoàn 2.
            public static bool tuanHoan3_on { get; set; } // Trạng thái "ON" bơm tuần hoàn 3.
            public static bool gatBun_on { get; set; } // Trạng thái "ON" gạt bùn.
            public static bool bomBun1_on { get; set; } // Trạng thái "ON" bơm bùn 1.
            public static bool bomBun2_on { get; set; } // Trạng thái "ON" bơm bùn 2.
            public static bool khuayNaoh_on { get; set; } // Trạng thái "ON" khuấy NaoH.
            public static bool dlNaoh_on { get; set; } // Trạng thái "ON" định lượng NaoH.
            public static bool al2so4_on { get; set; } // Trạng thái "ON" bơm hóa chất AL2SO4.

            /// <summary>
            /// Mỹ Phước giai đoạn 2 : GD2
            /// </summary>
            /// 
            public static bool mayTachRac_on { get; set; } // Trạng thái "ON" máy tách rác.
            public static bool bomNt_02A_on { get; set; } // Trạng thái "ON" bơm nước thải 02A.
            public static bool bomNt_02B_on { get; set; } // Trạng thái "ON" bơm nước thải 02B.
            public static bool mtk_AB06A_on { get; set; } // Trạng thái "ON" máy thổi khí AB06A.
            public static bool mtk_AB06B_on { get; set; } // Trạng thái "ON" máy thổi khí AB06B.
            public static bool mtk_AB06C_on { get; set; } // Trạng thái "ON" máy thổi khí AB06C.
            public static bool khuayKeoTu_GD2_on { get; set; } // Trạng thái "ON" khuấy keo tụ GD2.
            public static bool khuayTaoBong_A_on { get; set; } // Trạng thái "ON" khuấy tạo bông A.
            public static bool khuayTaoBong_B_on { get; set; }  // Trạng thái "ON" khuấy tạo bông B.
            public static bool gbbl05_on { get; set; } // Trạng thái "ON" bơm hóa chất GBBL 05.
            public static bool gbbl07_on { get; set; } // Trạng thái "ON" bơm hóa chất GBBL 07.
            public static bool gbbl09_on { get; set; } // Trạng thái "ON" bơm hóa chất GBBL 09.
            public static bool khuayPac_GD2_on { get; set; } // Trạng thái "ON" khuấy PAC GD2.
            public static bool khuayPoly_GD2_on { get; set; } // Trạng thái "ON" khuấy Polyme GD2.
            public static bool bomBun_05A_on { get; set; } // Trạng thái "ON" bơm bùn 05A.
            public static bool bomBun_05B_on { get; set; } // Trạng thái "ON" bơm bùn 05B.
            public static bool bomBun_07A_on { get; set; } // Trạng thái "ON" bơm bùn 07A.
            public static bool bomBun_07B_on { get; set; } // Trạng thái "ON" bơm bùn 07B.
            public static bool bomBun_SP10_on { get; set; } // Trạng thái "ON" bơm bùn SP10.
            public static bool dlPhen_03A_on { get; set; } // Trạng thái "ON" bơm định lượng phèn 03A.
            public static bool dlPhen_03B_on { get; set; } // Trạng thái "ON" bơm định lượng phèn 03B.
            public static bool dlPoly_04A_on { get; set; } // Trạng thái "ON" bơm định lượng Polyme 04A.
            public static bool dlPoly_04B_on { get; set; } // Trạng thái "ON" bơm định lượng Polyme 04B.
            public static bool dlXut_05A_on { get; set; } // Trạng thái "ON" bơm hóa chất Xút 05A.
            public static bool dlXut_05B_on { get; set; } // Trạng thái "ON" bơm hóa chất Xút 05B.
            public static bool dlDd_06A_on { get; set; } // Trạng thái "ON" bơm hóa chất Dd 06A.
            public static bool dlDd_06B_on { get; set; } // Trạng thái "ON" bơm hóa chất Dd 06B.
            public static bool dlKhuTrung_07A_on { get; set; } // Trạng thái "ON" bơm hóa chất khử trùng 07A.
            public static bool dlKhuTrung_07B_on { get; set; } // Trạng thái "ON" bơm hóa chất khử trùng 07B.
        #endregion

        #region Trạng thái "ON" biến nhớ M - Active
            /// <summary>
            /// Mỹ phước giai đoạn 1 "GD1"
            /// </summary>
            public static bool dieuHoa1_on_m { get; set; } // Bơm điều hòa 1..
            public static bool dieuHoa2_on_m { get; set; } // Bơm điều hòa 2..
            public static bool tuanHoanNuoc_on_m { get; set; } // Bơm tuần hoàn nước..
            public static bool tuanHoanBun_on_m { get; set; } // Bơm tuần hoàn bùn..
            public static bool bunHoaLy1_on_m { get; set; } // Bùn hóa lý 1..
            public static bool bunHoaLy2_on_m { get; set; } // Bùn hóa lý 2..
            public static bool beGom1_on_m { get; set; } // Bể gom 1..
            public static bool beGom2_on_m { get; set; } // Bể gom 2..
            public static bool beGom3_on_m { get; set; } // Bể gom 3..
            public static bool skbm1_on_m { get; set; } //???..
            public static bool skbm2_on_m { get; set; } //???..
            public static bool skbm3_on_m { get; set; } //???..
            public static bool mtk1_on_m { get; set; } // Máy thổi khí 01..
            public static bool mtk2_on_m { get; set; } // Máy thổi khí 02..
            public static bool mtk3_on_m { get; set; } // Máy thổi khí 03..
            public static bool dlAxit_on_m { get; set; } // Định lượng hóa chất axit..
            public static bool dlXut_on_m { get; set; } // Định lượng Xút..
            public static bool dlNp_on_m { get; set; } // Định lượng NP..
            public static bool dlClo_on_m { get; set; } // Định lượng Clo..
            public static bool dlPac_on_m { get; set; } // Định lượng PAC..
            public static bool dlPolyme_on_m { get; set; } // Định lượng Polyme..
            public static bool dlPolyme2_on_m { get; set; } // Định lượng Polyme 2 =>??? Không có
            public static bool khuayNp_on_m { get; set; } // Máy khuấy NP..
            public static bool khuayClo_on_m { get; set; } // Khuấy Clo..
            public static bool khuayPac_on_m { get; set; } // Khuấy PAC..
            public static bool khuayPoly1_on_m { get; set; } // Khuấy Polyme 1..
            public static bool khuayPoly2_on_m { get; set; } // Khuây Polyme 2..

            /// <summary>
            /// Mỹ phước giai đoạn 1 cải tạo "GD1MR" 
            /// </summary>
            /// 
            public static bool anoxic1_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 1..
            public static bool anoxic2_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 2..
            public static bool anoxic3_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 3..
            public static bool anoxic4_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 4..
            public static bool anoxic5_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 5..
            public static bool anoxic6_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 6..
            public static bool anoxic7_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 7..
            public static bool anoxic8_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Anoxic 8..
            public static bool etanol_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Etanol.
            public static bool metanol_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Metanol.
            public static bool mtk1_1_on_m { get; set; } // Trạng thái "ON" máy thổi khí 1.1..
            public static bool mtk1_2_on_m { get; set; } // Trạng thái "ON" máy thổi khí 1.2..
            public static bool mtk2_1_on_m { get; set; } // Trạng thái "ON" máy thổi khí 2.1..
            public static bool mtk2_2_on_m { get; set; } // Trạng thái "ON" máy thổi khí 2.2..
            public static bool mtk3_1_on_m { get; set; } // Trạng thái "ON" máy thổi khí 3.1..
            public static bool mtk3_2_on_m { get; set; } // Trạng thái "ON" máy thổi khí 3.2..
            public static bool tuanHoan1_on_m { get; set; } // Trạng thái "ON" bơm tuần hoàn 1..
            public static bool tuanHoan2_on_m { get; set; } // Trạng thái "ON" bơm tuần hoàn 2..
            public static bool tuanHoan3_on_m { get; set; } // Trạng thái "ON" bơm tuần hoàn 3..
            public static bool gatBun_on_m { get; set; } // Trạng thái "ON" gạt bùn..
            public static bool bomBun1_on_m { get; set; } // Trạng thái "ON" bơm bùn 1..
            public static bool bomBun2_on_m { get; set; } // Trạng thái "ON" bơm bùn 2..
            public static bool khuayNaoh_on_m { get; set; } // Trạng thái "ON" khuấy NaoH..
            public static bool dlNaoh_on_m { get; set; } // Trạng thái "ON" định lượng NaoH..
            public static bool al2so4_on_m { get; set; } // Trạng thái "ON" bơm hóa chất AL2SO4..


            /// <summary>
            /// Mỹ Phước giai đoạn 2 : GD2
            /// </summary>
            public static bool mayTachRac_on_m { get; set; } // Trạng thái "ON" máy tách rác
            public static bool bomNt_02A_on_m { get; set; } // Trạng thái "ON" bơm nước thải 02A
            public static bool bomNt_02B_on_m { get; set; } // Trạng thái "ON" bơm nước thải 02B
            public static bool mtk_AB06A_on_m { get; set; } // Trạng thái "ON" máy thổi khí AB06A
            public static bool mtk_AB06B_on_m { get; set; } // Trạng thái "ON" máy thổi khí AB06B
            public static bool mtk_AB06C_on_m { get; set; } // Trạng thái "ON" máy thổi khí AB06C
            public static bool khuayKeoTu_GD2_on_m { get; set; } // Trạng thái "ON" khuấy keo tụ GD2
            public static bool khuayTaoBong_A_on_m { get; set; } // Trạng thái "ON" khuấy tạo bông A
            public static bool khuayTaoBong_B_on_m { get; set; }  // Trạng thái "ON" khuấy tạo bông B
            public static bool gbbl05_on_m { get; set; } // Trạng thái "ON" bơm hóa chất GBBL 05
            public static bool gbbl07_on_m { get; set; } // Trạng thái "ON" bơm hóa chất GBBL 07
            public static bool gbbl09_on_m { get; set; } // Trạng thái "ON" bơm hóa chất GBBL 09
            public static bool khuayPac_GD2_on_m { get; set; } // Trạng thái "ON" khuấy PAC GD2
            public static bool khuayPoly_GD2_on_m { get; set; } // Trạng thái "ON" khuấy Polyme GD2
            public static bool bomBun_05A_on_m { get; set; } // Trạng thái "ON" bơm bùn 05A
            public static bool bomBun_05B_on_m { get; set; } // Trạng thái "ON" bơm bùn 05B
            public static bool bomBun_07A_on_m { get; set; } // Trạng thái "ON" bơm bùn 07A
            public static bool bomBun_07B_on_m { get; set; } // Trạng thái "ON" bơm bùn 07B
            public static bool bomBun_SP10_on_m { get; set; } // Trạng thái "ON" bơm bùn SP10
            public static bool dlPhen_03A_on_m { get; set; } // Trạng thái "ON" bơm định lượng phèn 03A
            public static bool dlPhen_03B_on_m { get; set; } // Trạng thái "ON" bơm định lượng phèn 03B
            public static bool dlPoly_04A_on_m { get; set; } // Trạng thái "ON" bơm định lượng Polyme 04A
            public static bool dlPoly_04B_on_m { get; set; } // Trạng thái "ON" bơm định lượng Polyme 04B
            public static bool dlXut_05A_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Xút 05A
            public static bool dlXut_05B_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Xút 05B
            public static bool dlDd_06A_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Dd 06A
            public static bool dlDd_06B_on_m { get; set; } // Trạng thái "ON" bơm hóa chất Dd 06B
            public static bool dlKhuTrung_07A_on_m { get; set; } // Trạng thái "ON" bơm hóa chất khử trùng 07A
            public static bool dlKhuTrung_07B_on_m { get; set; } // Trạng thái "ON" bơm hóa chất khử trùng 07B
        #endregion
    }
}
