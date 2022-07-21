using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ElementBase_Template.PLC.Data_Mapping.Temperorary
{
    public class Input
    {
        public class PLC1
        {
            /// <summary>
            /// Mỹ phước giai đoạn 1 "GD1"
            /// </summary>
            // Tín hiệu phao bể gom
            public bool low_beGom_float { get; set; } // Tín hiệu thấp "I2.6"
            public bool medium_beGom_float { get; set; } //Tín hiệu mức trung bình "I2.7"
            public bool high_beGom_float { get; set; } //Tín hiệu mức cao "I3.0"

            #region Tín hiệu quan trắc môi trường
            /// <summary>
            /// Mỹ phước giai đoạn 1 "GD1"
            /// </summary>
            public double cod_Index { get; set; } = 5.5f; // Chỉ số COD
            public double tss_Index { get; set; } // Chỉ số TSS
            public double ph_Index { get; set; } = 7.5f; // PH
            public double color_Index { get; set; } // Chỉ số màu sắc
            public double temper_Index { get; set; } // Chỉ số nhiệt độ
            public double nh3_Index { get; set; } // Chỉ số NH3

            public double flowInCap { get; set; } // Lưu lượng NT vào
            public double flowInTotal { get; set; } // Lưu lượng tổng NT đầu vào

            public double flowOutCap { get; set; } // Công suất nước thải đầu ra
            public double flowOutTotal { get; set; } // Tổng lưu lượng nước thải đầu ra
            #endregion

            #region Trạng thái "RUN" Feedback cơ cấu chấp hành
            /// <summary>
            /// Mỹ phước giai đoạn 1 "GD1"
            /// </summary>
            /// 
            public bool dieuHoa1_runStatus { get; set; }// Bơm điều hòa 1 => ?? P0201
            public bool dieuHoa2_runStatus { get; set; } // Bơm điều hòa 2 => ?? P0202
            public bool tuanHoanNuoc_runStatus { get; set; } // Bơm tuần hoàn nước => ?? 
            public bool tuanHoanBun_runStatus { get; set; } // Bơm tuần hoàn bùn 
            public bool bunHoaLy1_runStatus { get; set; } // Bùn hóa lý 1
            public bool bunHoaLy2_runStatus { get; set; } // Bùn hóa lý 2
            public bool beGom1_runStatus { get; set; } // Bể gom 1 => P0101
            public bool beGom2_runStatus { get; set; } // Bể gom 2 => P0102
            public bool beGom3_runStatus { get; set; } // Bể gom 3 => P0103
            public bool skbm1_runStatus { get; set; } //???
            public bool skbm2_runStatus { get; set; } //???
            public bool skbm3_runStatus { get; set; } //???
            public bool mtk01_runStatus { get; set; } // Máy thổi khí 01 "MTK01"
            public bool mtk02_runStatus { get; set; } // Máy thổi khí 02 "MTK02"
            public bool mtk03_runStatus { get; set; } // Máy thổi khí 03 "MTK03"
            public bool dlAxit_runStatus { get; set; } // Định lượng hóa chất axit
            public bool dlXut_runStatus { get; set; } // Định lượng Xút
            public bool dlNp_runStatus { get; set; } // Định lượng NP
            public bool dlClo_runStatus { get; set; } // Định lượng Clo
            public bool dlPac_runStatus { get; set; } // Định lượng PAC
            public bool dlPolyme1_runStatus { get; set; } // Định lượng Polyme 1
            public bool dlPolyme2_runStatus { get; set; } // Định lượng Polyme 2
            public bool khuayNp_runStatus { get; set; } // Máy khuấy NP
            public bool khuayClo_runStatus { get; set; } // Khuấy Clo
            public bool khuayPac_runStatus { get; set; } // Khuấy PAC
            public bool khuayPoly1_runStatus { get; set; } // Khuấy Polyme 1
            public bool khuayPoly2_runStatus { get; set; } // Khuây Polyme 2
            public bool khuayKeoTu_runStatus { get; set; } // Khuấy keo tụ
            public bool khuayTaoBong1_runStatus { get; set; } // Khuấy tạo bông 1
            public bool khuayTaoBong2_runStatus { get; set; } // Khuấy tạo bông 2
            public bool motorGatBun_runStatus { get; set; } // Motot gạt bùn
            #endregion

            #region Trạng thái "TRIP" Feedback cơ cấu chấp hành
            /// <summary>
            /// Mỹ phước giai đoạn 1 "GD1"
            /// </summary>
            /// 
            public bool dieuHoa1_tripStatus { get; set; } // Bơm điều hòa 1.
            public bool dieuHoa2_tripStatus { get; set; } // Bơm điều hòa 2.
            public bool tuanHoanNuoc_tripStatus { get; set; } // Tuần hoàn nước .
            public bool tuanHoanBun_tripStatus { get; set; } // Bơm tuần hoàn bùn .
            public bool bunHoaLy1_tripStatus { get; set; } // Bùn hóa lý 1 .
            public bool bunHoaLy2_tripStatus { get; set; } // Bùn hóa lý 2.
            public bool beGom1_tripStatus { get; set; } // Bể gom 1.
            public bool beGom2_tripStatus { get; set; } // Bể gom 2.
            public bool beGom3_tripStatus { get; set; } // Bể gom 3.
            public bool skbm1_tripStatus { get; set; } //???.
            public bool skbm2_tripStatus { get; set; } //???.
            public bool skbm3_tripStatus { get; set; } //???.
            public bool mtk01_tripStatus { get; set; } // Máy thổi khí 01.
            public bool mtk02_tripStatus { get; set; } // Máy thổi khí 02.
            public bool mtk03_tripStatus { get; set; } // Máy thổi khí 03.
            public bool dlAxit_tripStatus { get; set; } // Định lượng hóa chất axit.
            public bool dlXut_tripStatus { get; set; } // Định lượng Xút.
            public bool dlNp_tripStatus { get; set; } // Định lượng NP.
            public bool dlClo_tripStatus { get; set; } // Định lượng Clo.
            public bool dlPac_tripStatus { get; set; } // Định lượng PAC.
            public bool dlPolyme1_tripStatus { get; set; } // Định lượng Polyme.
            public bool dlPolyme2_tripStatus { get; set; } // Định lượng Polyme 2 => ??? Ko có
            public bool khuayNp_tripStatus { get; set; } // Máy khuấy NP.
            public bool khuayClo_tripStatus { get; set; } // Khuấy Clo.
            public bool khuayPac_tripStatus { get; set; } // Khuấy PAC.
            public bool khuayPoly1_tripStatus { get; set; } // Khuấy Polyme 1.
            public bool khuayPoly2_tripStatus { get; set; } // Khuây Polyme 2.
            public bool khuayKeoTu_tripStatus { get; set; } // Khuấy keo tụ.
            public bool khuayTaoBong1_tripStatus { get; set; } // Khuấy tạo bông 1.
            public bool khuayTaoBong2_tripStatus { get; set; } // Khuấy tạo bông 2.
            public bool motorGatBun_tripStatus { get; set; } // Motor gạt bùn.
            #endregion

           


        }
        public class PLC2
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
            public bool anoxic1_runStatus { get; set; }  // Trạng thái "RUN" bơm hóa chất Anoxic 1
            public bool anoxic2_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 2
            public bool anoxic3_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 3
            public bool anoxic4_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 4
            public bool anoxic5_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 5
            public bool anoxic6_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 6
            public bool anoxic7_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 7
            public bool anoxic8_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 8
            public bool etanol1_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Etanol 1
            public bool etanol2_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Etanol 2
            public bool metanol_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Metanol "MT-ETN"
            public bool mkt01_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí MKT1
            public bool mkt02_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí MTK2
            public bool mkt03_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí MTK3
            public bool tuanHoan1_runStatus { get; set; } // Trạng thái "RUN" bơm tuần hoàn 1 "TH1"
            public bool tuanHoan2_runStatus { get; set; } // Trạng thái "RUN" bơm tuần hoàn 2 "TH2"
            public bool tuanHoan3_runStatus { get; set; } // Trạng thái "RUN" bơm tuần hoàn 3 "TH3"
            public bool gatBun_runStatus { get; set; } // Trạng thái "RUN" gạt bùn "GB1"
            public bool bomBun1_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 1
            public bool bomBun2_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 2
            public bool khuayNaoh_runStatus { get; set; } // Trạng thái "RUN" khuấy NaoH
            public bool dlNaoh_runStatus { get; set; } // Trạng thái "RUN" định lượng NaoH
            public bool al2so4_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất AL2SO4
            #endregion

            /// <summary>
            /// Mỹ Phước giai đoạn 1 cải tạo : GD1MR
            /// </summary>
            /// 
            #region
            public bool anoxic1_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 1.
            public bool anoxic2_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 2.
            public bool anoxic3_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 3.
            public bool anoxic4_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 4.
            public bool anoxic5_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 5.
            public bool anoxic6_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 6.
            public bool anoxic7_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 7.
            public bool anoxic8_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 8.
            public bool etanol1_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Etanol 1.
            public bool etanol2_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Etanol 2.
            public bool metanol_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Metanol "MT-ETN".
            public bool mkt01_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí 1.
            public bool mkt02_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí 2.
            public bool mkt03_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí 3.
            public bool tuanHoan1_tripStatus { get; set; } // Trạng thái "TRIP" bơm tuần hoàn 1.
            public bool tuanHoan2_tripStatus { get; set; } // Trạng thái "TRIP" bơm tuần hoàn 2.
            public bool tuanHoan3_tripStatus { get; set; } // Trạng thái "TRIP" bơm tuần hoàn 3.
            public bool gatBun_tripStatus { get; set; } // Trạng thái "TRIP" gạt bùn "GB1".
            public bool bomBun1_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 1.
            public bool bomBun2_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 2.
            public bool khuayNaoh_tripStatus { get; set; } // Trạng thái "TRIP" khuấy NaoH.
            public bool dlNaoh_tripStatus { get; set; } // Trạng thái "TRIP" định lượng NaoH.
            public bool al2so4_1_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất AL2SO4 1.
            public bool al2so4_2_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất AL2SO4 2.
            #endregion


        }
        public class PLC3
        {
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
            public short ph_sensor { get; set; } // Chỉ số PH "IW160"
            public short do_sensor { get; set; } // Chỉ số DO "IW162"
            public double ph_value { get; set; } // Gía trị PH sau xử lý => PLC Real 32 bit "MD50"

            #endregion

            /// <summary>
            /// Mỹ Phước giai đoạn 2 : GD2
            /// </summary>
            /// 
            #region
            public bool mayTachRac_runStatus { get; set; } // Trạng thái "RUN" máy tách rác
            public bool bomNt_02A_runStatus { get; set; } // Trạng thái "RUN" bơm nước thải 02A
            public bool bomNt_02B_runStatus { get; set; } // Trạng thái "RUN" bơm nước thải 02B
            public bool mtk_AB06A_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí AB06A
            public bool mtk_AB06B_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí AB06B
            public bool mtk_AB06C_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí AB06C
            public bool khuayKeoTu_GD2_runStatus { get; set; } // Trạng thái "RUN" khuấy keo tụ GD2
            public bool khuayTaoBong_A_runStatus { get; set; } // Trạng thái "RUN" khuấy tạo bông A
            public bool khuayTaoBong_B_runStatus { get; set; }  // Trạng thái "RUN" khuấy tạo bông B
            public bool gbbl05_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất GBBL 05
            public bool gbbl07_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất GBBL 07
            public bool gbbl09_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất GBBL 09
            public bool khuayPac_GD2_runStatus { get; set; } // Trạng thái "RUN" khuấy PAC GD2
            public bool khuayPoly_GD2_runStatus { get; set; } // Trạng thái "RUN" khuấy Polyme GD2
            public bool bomBun_05A_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 05A
            public bool bomBun_05B_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 05B
            public bool bomBun_07A_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 07A
            public bool bomBun_07B_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 07B
            public bool bomBun_SP10_runStatus { get; set; } // Trạng thái "RUN" bơm bùn SP10
            public bool dlPhen_03A_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng phèn 03A
            public bool dlPhen_03B_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng phèn 03B
            public bool dlPoly_04A_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng Polyme 04A
            public bool dlPoly_04B_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng Polyme 04B
            public bool dlXut_05A_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Xút 05A
            public bool dlXut_05B_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Xút 05B
            public bool dlDd_06A_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Dd 06A
            public bool dlDd_06B_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Dd 06B
            public bool dlKhuTrung_07A_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất khử trùng 07A
            public bool dlKhuTrung_07B_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất khử trùng 07B
            #endregion

            /// <summary>
            /// Mỹ Phước giai đoạn 2 : GD2
            /// </summary>
            /// 
            #region
            public bool mayTachRac_tripStatus { get; set; } // Trạng thái "TRIP" máy tách rác.
            public bool bomNt_02A_tripStatus { get; set; } // Trạng thái "TRIP" bơm nước thải 02A.
            public bool bomNt_02B_tripStatus { get; set; } // Trạng thái "TRIP" bơm nước thải 02B.
            public bool mtk_AB06A_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí AB06A.
            public bool mtk_AB06B_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí AB06B.
            public bool mtk_AB06C_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí AB06C.
            public bool khuayKeoTu_GD2_tripStatus { get; set; } // Trạng thái "TRIP" khuấy keo tụ GD2.
            public bool khuayTaoBong_A_tripStatus { get; set; } // Trạng thái "TRIP" khuấy tạo bông A.
            public bool khuayTaoBong_B_tripStatus { get; set; }  // Trạng thái "TRIP" khuấy tạo bông B.
            public bool gbbl05_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất GBBL 05.
            public bool gbbl07_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất GBBL 07.
            public bool gbbl09_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất GBBL 09.
            public bool khuayPac_GD2_tripStatus { get; set; } // Trạng thái "TRIP" khuấy PAC GD2.
            public bool khuayPoly_GD2_tripStatus { get; set; } // Trạng thái "TRIP" khuấy Polyme GD2.
            public bool bomBun_05A_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 05A.
            public bool bomBun_05B_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 05B.
            public bool bomBun_07A_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 07A.
            public bool bomBun_07B_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 07B.
            public bool bomBun_SP10_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn SP10.
            public bool dlPhen_03A_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng phèn 03A.
            public bool dlPhen_03B_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng phèn 03B.
            public bool dlPoly_04A_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng Polyme 04A.
            public bool dlPoly_04B_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng Polyme 04B.
            public bool dlXut_05A_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Xút 05A.
            public bool dlXut_05B_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Xút 05B.
            public bool dlDd_06A_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Dd 06A.
            public bool dlDd_06B_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Dd 06B.
            public bool dlKhuTrung_07A_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất khử trùng 07A.
            public bool dlKhuTrung_07B_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất khử trùng 07B.
            #endregion
        }

        //---------------------------------------------------------------------------------------
        //#region Tín hiệu phao

        ///// <summary>
        ///// Mỹ phước giai đoạn 1 "GD1"
        ///// </summary>
        //// Tín hiệu phao bể gom
        //public bool low_beGom_float { get; set; } // Tín hiệu thấp "I2.6"
        //    public bool medium_beGom_float { get; set; } //Tín hiệu mức trung bình "I2.7"
        //    public bool high_beGom_float { get; set; } //Tín hiệu mức cao "I3.0"


        //    /// <summary>
        //    /// Mỹ phước giai đoạn 2 "GD2"
        //    /// </summary>
        //    /// 
        //    // Tín hiệu phao bể điều hòa
        //    public bool low_dieuHoa_float { get; set; } // Tín hiệu phao mức thấp 
        //    public bool high_dieuHoa_float { get; set; } // Tín hiệu phao mức cao
        //    public bool float_beBun05_float { get; set; } // Tín hiệu phao bể bùn 05
        //    public bool float_beBun07_float { get; set; } // Tín hiệu phao bể bùn 07
        //    public bool float_beBunSP10_float { get; set; } // Tín hiệu phao bể bùn SP10

        //#endregion

        //#region Tín hiệu quan trắc môi trường
        ///// <summary>
        ///// Mỹ phước giai đoạn 1 "GD1"
        ///// </summary>
        //    public double cod_Index { get; set; } = 5.5f; // Chỉ số COD
        //    public double tss_Index { get; set; } // Chỉ số TSS
        //    public double ph_Index { get; set; } = 7.5f; // PH
        //    public double color_Index { get; set; } // Chỉ số màu sắc
        //    public double temper_Index { get; set; } // Chỉ số nhiệt độ
        //    public double nh3_Index { get; set; } // Chỉ số NH3

        //    public double flowInCap { get; set; } // Lưu lượng NT vào
        //    public double flowInTotal { get; set; } // Lưu lượng tổng NT đầu vào

        //    public double flowOutCap { get; set; } // Công suất nước thải đầu ra
        //    public double flowOutTotal { get; set; } // Tổng lưu lượng nước thải đầu ra

        //    /// <summary>
        //    /// Mỹ phước giai đoạn 2 "GD2"
        //    /// </summary>
        //    /// 

        //    // Not used
        //    public short ph_sensor { get; set; } // Chỉ số PH "IW160"
        //    public short do_sensor { get; set; } // Chỉ số DO "IW162"
        //    public double ph_value { get; set; } // Gía trị PH sau xử lý => PLC Real 32 bit "MD50"

        //#endregion

        //#region Trạng thái "RUN" Feedback cơ cấu chấp hành
        ///// <summary>
        ///// Mỹ phước giai đoạn 1 "GD1"
        ///// </summary>
        ///// 
        //#region
        //        public bool dieuHoa1_runStatus { get; set; } =  true; // Bơm điều hòa 1 => ?? P0201
        //        public bool dieuHoa2_runStatus { get; set; } // Bơm điều hòa 2 => ?? P0202
        //        public bool tuanHoanNuoc_runStatus { get; set; } // Bơm tuần hoàn nước => ?? 
        //        public bool tuanHoanBun_runStatus { get; set; } // Bơm tuần hoàn bùn 
        //        public bool bunHoaLy1_runStatus { get; set; } // Bùn hóa lý 1
        //        public bool bunHoaLy2_runStatus { get; set; } // Bùn hóa lý 2
        //        public bool beGom1_runStatus { get; set; } // Bể gom 1 => P0101
        //        public bool beGom2_runStatus { get; set; } // Bể gom 2 => P0102
        //        public bool beGom3_runStatus { get; set; } // Bể gom 3 => P0103
        //        public bool skbm1_runStatus { get; set; } //???
        //        public bool skbm2_runStatus { get; set; } //???
        //        public bool skbm3_runStatus { get; set; } //???
        //        public bool mtk01_runStatus { get; set; } // Máy thổi khí 01 "MTK01"
        //        public bool mtk02_runStatus { get; set; } // Máy thổi khí 02 "MTK02"
        //        public bool mtk03_runStatus { get; set; } // Máy thổi khí 03 "MTK03"
        //        public bool dlAxit_runStatus { get; set; } // Định lượng hóa chất axit
        //        public bool dlXut_runStatus { get; set; } // Định lượng Xút
        //        public bool dlNp_runStatus { get; set; } // Định lượng NP
        //        public bool dlClo_runStatus { get; set; } // Định lượng Clo
        //        public bool dlPac_runStatus { get; set; } // Định lượng PAC
        //        public bool dlPolyme1_runStatus { get; set; } // Định lượng Polyme 1
        //        public bool dlPolyme2_runStatus { get; set; } // Định lượng Polyme 2
        //        public bool khuayNp_runStatus { get; set; } // Máy khuấy NP
        //        public bool khuayClo_runStatus { get; set; } // Khuấy Clo
        //        public bool khuayPac_runStatus { get; set; } // Khuấy PAC
        //        public bool khuayPoly1_runStatus { get; set; } // Khuấy Polyme 1
        //        public bool khuayPoly2_runStatus { get; set; } // Khuây Polyme 2
        //        public bool khuayKeoTu_runStatus { get; set; } // Khuấy keo tụ
        //        public bool khuayTaoBong1_runStatus { get; set; } // Khuấy tạo bông 1
        //        public bool khuayTaoBong2_runStatus { get; set; } // Khuấy tạo bông 2
        //        public bool motorGatBun_runStatus { get; set; } // Motot gạt bùn
        //    #endregion

        //    /// <summary>
        //    /// Mỹ Phước giai đoạn 1 cải tạo : GD1MR
        //    /// </summary>
        //    /// 
        //    #region
        //        public bool anoxic1_runStatus { get; set; } = true;  // Trạng thái "RUN" bơm hóa chất Anoxic 1
        //        public bool anoxic2_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 2
        //        public bool anoxic3_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 3
        //        public bool anoxic4_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 4
        //        public bool anoxic5_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 5
        //        public bool anoxic6_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 6
        //        public bool anoxic7_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 7
        //        public bool anoxic8_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Anoxic 8
        //        public bool etanol1_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Etanol 1
        //        public bool etanol2_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Etanol 2
        //        public bool metanol_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Metanol "MT-ETN"
        //        public bool mkt01_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí MKT1
        //        public bool mkt02_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí MTK2
        //        public bool mkt03_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí MTK3
        //        public bool tuanHoan1_runStatus { get; set; } // Trạng thái "RUN" bơm tuần hoàn 1 "TH1"
        //        public bool tuanHoan2_runStatus { get; set; } // Trạng thái "RUN" bơm tuần hoàn 2 "TH2"
        //        public bool tuanHoan3_runStatus { get; set; } // Trạng thái "RUN" bơm tuần hoàn 3 "TH3"
        //        public bool gatBun_runStatus { get; set; } // Trạng thái "RUN" gạt bùn "GB1"
        //        public bool bomBun1_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 1
        //        public bool bomBun2_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 2
        //        public bool khuayNaoh_runStatus { get; set; } // Trạng thái "RUN" khuấy NaoH
        //        public bool dlNaoh_runStatus { get; set; } // Trạng thái "RUN" định lượng NaoH
        //        public bool al2so4_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất AL2SO4
        //    #endregion

        //    /// <summary>
        //    /// Mỹ Phước giai đoạn 2 : GD2
        //    /// </summary>
        //    /// 
        //    #region
        //        public bool mayTachRac_runStatus { get; set; } // Trạng thái "RUN" máy tách rác
        //        public bool bomNt_02A_runStatus { get; set; } // Trạng thái "RUN" bơm nước thải 02A
        //        public bool bomNt_02B_runStatus { get; set; } // Trạng thái "RUN" bơm nước thải 02B
        //        public bool mtk_AB06A_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí AB06A
        //        public bool mtk_AB06B_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí AB06B
        //        public bool mtk_AB06C_runStatus { get; set; } // Trạng thái "RUN" máy thổi khí AB06C
        //        public bool khuayKeoTu_GD2_runStatus { get; set; } // Trạng thái "RUN" khuấy keo tụ GD2
        //        public bool khuayTaoBong_A_runStatus { get; set; } // Trạng thái "RUN" khuấy tạo bông A
        //        public bool khuayTaoBong_B_runStatus { get; set; }  // Trạng thái "RUN" khuấy tạo bông B
        //        public bool gbbl05_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất GBBL 05
        //        public bool gbbl07_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất GBBL 07
        //        public bool gbbl09_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất GBBL 09
        //        public bool khuayPac_GD2_runStatus { get; set; } // Trạng thái "RUN" khuấy PAC GD2
        //        public bool khuayPoly_GD2_runStatus { get; set; } // Trạng thái "RUN" khuấy Polyme GD2
        //        public bool bomBun_05A_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 05A
        //        public bool bomBun_05B_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 05B
        //        public bool bomBun_07A_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 07A
        //        public bool bomBun_07B_runStatus { get; set; } // Trạng thái "RUN" bơm bùn 07B
        //        public bool bomBun_SP10_runStatus { get; set; } // Trạng thái "RUN" bơm bùn SP10
        //        public bool dlPhen_03A_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng phèn 03A
        //        public bool dlPhen_03B_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng phèn 03B
        //        public bool dlPoly_04A_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng Polyme 04A
        //        public bool dlPoly_04B_runStatus { get; set; } // Trạng thái "RUN" bơm định lượng Polyme 04B
        //        public bool dlXut_05A_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Xút 05A
        //        public bool dlXut_05B_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Xút 05B
        //        public bool dlDd_06A_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Dd 06A
        //        public bool dlDd_06B_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất Dd 06B
        //        public bool dlKhuTrung_07A_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất khử trùng 07A
        //        public bool dlKhuTrung_07B_runStatus { get; set; } // Trạng thái "RUN" bơm hóa chất khử trùng 07B
        //#endregion

        //#endregion

        //#region Trạng thái "TRIP" Feedback cơ cấu chấp hành
        ///// <summary>
        ///// Mỹ phước giai đoạn 1 "GD1"
        ///// </summary>
        ///// 
        //#region
        //    public bool dieuHoa1_tripStatus { get; set; } // Bơm điều hòa 1.
        //    public bool dieuHoa2_tripStatus { get; set; } = true; // Bơm điều hòa 2.
        //    public bool tuanHoanNuoc_tripStatus { get; set; } // Tuần hoàn nước .
        //    public bool tuanHoanBun_tripStatus { get; set; } // Bơm tuần hoàn bùn .
        //    public bool bunHoaLy1_tripStatus { get; set; } // Bùn hóa lý 1 .
        //    public bool bunHoaLy2_tripStatus { get; set; } // Bùn hóa lý 2.
        //    public bool beGom1_tripStatus { get; set; } // Bể gom 1.
        //    public bool beGom2_tripStatus { get; set; } // Bể gom 2.
        //    public bool beGom3_tripStatus { get; set; } // Bể gom 3.
        //    public bool skbm1_tripStatus { get; set; } //???.
        //    public bool skbm2_tripStatus { get; set; } //???.
        //    public bool skbm3_tripStatus { get; set; } //???.
        //    public bool mtk01_tripStatus { get; set; } // Máy thổi khí 01.
        //    public bool mtk02_tripStatus { get; set; } // Máy thổi khí 02.
        //    public bool mtk03_tripStatus { get; set; } // Máy thổi khí 03.
        //    public bool dlAxit_tripStatus { get; set; } // Định lượng hóa chất axit.
        //    public bool dlXut_tripStatus { get; set; } // Định lượng Xút.
        //    public bool dlNp_tripStatus { get; set; } // Định lượng NP.
        //    public bool dlClo_tripStatus { get; set; } // Định lượng Clo.
        //    public bool dlPac_tripStatus { get; set; } // Định lượng PAC.
        //    public bool dlPolyme1_tripStatus { get; set; } // Định lượng Polyme.
        //    public bool dlPolyme2_tripStatus { get; set; } // Định lượng Polyme 2 => ??? Ko có
        //    public bool khuayNp_tripStatus { get; set; } // Máy khuấy NP.
        //    public bool khuayClo_tripStatus { get; set; } // Khuấy Clo.
        //    public bool khuayPac_tripStatus { get; set; } // Khuấy PAC.
        //    public bool khuayPoly1_tripStatus { get; set; } // Khuấy Polyme 1.
        //    public bool khuayPoly2_tripStatus { get; set; } // Khuây Polyme 2.
        //    public bool khuayKeoTu_tripStatus { get; set; } // Khuấy keo tụ.
        //    public bool khuayTaoBong1_tripStatus { get; set; } // Khuấy tạo bông 1.
        //    public bool khuayTaoBong2_tripStatus { get; set; } // Khuấy tạo bông 2.
        //    public bool motorGatBun_tripStatus { get; set; } // Motor gạt bùn.
        //#endregion


        ///// <summary>
        ///// Mỹ Phước giai đoạn 1 cải tạo : GD1MR
        ///// </summary>
        ///// 
        //#region
        //    public bool anoxic1_tripStatus { get; set; } = true; // Trạng thái "TRIP" bơm hóa chất Anoxic 1.
        //    public bool anoxic2_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 2.
        //    public bool anoxic3_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 3.
        //    public bool anoxic4_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 4.
        //    public bool anoxic5_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 5.
        //    public bool anoxic6_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 6.
        //    public bool anoxic7_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 7.
        //    public bool anoxic8_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Anoxic 8.
        //    public bool etanol1_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Etanol 1.
        //    public bool etanol2_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Etanol 2.
        //    public bool metanol_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Metanol "MT-ETN".
        //    public bool mkt01_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí 1.
        //    public bool mkt02_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí 2.
        //    public bool mkt03_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí 3.
        //    public bool tuanHoan1_tripStatus { get; set; } // Trạng thái "TRIP" bơm tuần hoàn 1.
        //    public bool tuanHoan2_tripStatus { get; set; } // Trạng thái "TRIP" bơm tuần hoàn 2.
        //    public bool tuanHoan3_tripStatus { get; set; } // Trạng thái "TRIP" bơm tuần hoàn 3.
        //    public bool gatBun_tripStatus { get; set; } // Trạng thái "TRIP" gạt bùn "GB1".
        //    public bool bomBun1_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 1.
        //    public bool bomBun2_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 2.
        //    public bool khuayNaoh_tripStatus { get; set; } // Trạng thái "TRIP" khuấy NaoH.
        //    public bool dlNaoh_tripStatus { get; set; } // Trạng thái "TRIP" định lượng NaoH.
        //    public bool al2so4_1_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất AL2SO4 1.
        //    public bool al2so4_2_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất AL2SO4 2.
        //#endregion

        ///// <summary>
        ///// Mỹ Phước giai đoạn 2 : GD2
        ///// </summary>
        ///// 
        //#region
        //    public bool mayTachRac_tripStatus { get; set; } // Trạng thái "TRIP" máy tách rác.
        //    public bool bomNt_02A_tripStatus { get; set; } // Trạng thái "TRIP" bơm nước thải 02A.
        //    public bool bomNt_02B_tripStatus { get; set; } // Trạng thái "TRIP" bơm nước thải 02B.
        //    public bool mtk_AB06A_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí AB06A.
        //    public bool mtk_AB06B_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí AB06B.
        //    public bool mtk_AB06C_tripStatus { get; set; } // Trạng thái "TRIP" máy thổi khí AB06C.
        //    public bool khuayKeoTu_GD2_tripStatus { get; set; } // Trạng thái "TRIP" khuấy keo tụ GD2.
        //    public bool khuayTaoBong_A_tripStatus { get; set; } // Trạng thái "TRIP" khuấy tạo bông A.
        //    public bool khuayTaoBong_B_tripStatus { get; set; }  // Trạng thái "TRIP" khuấy tạo bông B.
        //    public bool gbbl05_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất GBBL 05.
        //    public bool gbbl07_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất GBBL 07.
        //    public bool gbbl09_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất GBBL 09.
        //    public bool khuayPac_GD2_tripStatus { get; set; } // Trạng thái "TRIP" khuấy PAC GD2.
        //    public bool khuayPoly_GD2_tripStatus { get; set; } // Trạng thái "TRIP" khuấy Polyme GD2.
        //    public bool bomBun_05A_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 05A.
        //    public bool bomBun_05B_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 05B.
        //    public bool bomBun_07A_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 07A.
        //    public bool bomBun_07B_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn 07B.
        //    public bool bomBun_SP10_tripStatus { get; set; } // Trạng thái "TRIP" bơm bùn SP10.
        //    public bool dlPhen_03A_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng phèn 03A.
        //    public bool dlPhen_03B_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng phèn 03B.
        //    public bool dlPoly_04A_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng Polyme 04A.
        //    public bool dlPoly_04B_tripStatus { get; set; } // Trạng thái "TRIP" bơm định lượng Polyme 04B.
        //    public bool dlXut_05A_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Xút 05A.
        //    public bool dlXut_05B_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Xút 05B.
        //    public bool dlDd_06A_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Dd 06A.
        //    public bool dlDd_06B_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất Dd 06B.
        //    public bool dlKhuTrung_07A_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất khử trùng 07A.
        //    public bool dlKhuTrung_07B_tripStatus { get; set; } // Trạng thái "TRIP" bơm hóa chất khử trùng 07B.
        //#endregion

        //#endregion

        //#region Tín hiệu "Auto/ Man" Máy thổi khí 1, 2 và 3
        //    /// <summary>
        //    /// Mỹ phước giai đoạn 1 "GD1"
        //    /// </summary>
        //    public bool mtk1_manMode { get; set; } // Tín hiệu "Manual" mode máy thổi khí 1
        //    public bool mtk1_autoMode { get; set; } // Tín hiệu "Auto" máy thổi khí 1
        //    public bool mtk2_manMode { get; set; } // Tín hiệu "Manual" máy thổi khí 2
        //    public bool mtk2_autoMode { get; set; } // Tín hiệu "Auto" máy thổi khí 2
        //    public bool mtk3_manMode { get; set; } // Tín hiệu "Manual" máy thổi khí 3
        //    public bool mtk3_autoMode { get; set; } // Tín hiệu "Auto" máy thổi khí 3
        //#endregion
    }
}
