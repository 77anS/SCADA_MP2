using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.PLC.Data_Mapping.Temperorary
{
    public static class Parameter
    {
        #region RUNTIME SETTING

        #region VALUE GOT FROM DEVICES
            /// <summary>
            /// Mỹ phước giai đoạn 1 "GD1"
            /// </summary>
            // Bơm thu gom

            /// <summary>
            /// Symbol "P101"
            /// </summary>
            public static short beGom1_setTime { get; set; } // Setting time RUN of bơm thu gom 1 
            /// <summary>
            /// Symbol "P102"
            /// </summary>
            public static short beGom2_setTime { get; set; } // Thời gian RUN của bơm thu gom 2
            /// <summary>
            /// Symbol "P103"
            /// </summary>
            public static short beGom3_setTime { get; set; } // Thời gian RUN của bơm thu gom 3

            // Bơm điểu hòa
            public static short dieuHoa1_setTime { get; set; } // Thời gian RUN của bơm điều hòa 1
            public static short dieuHoa2_setTime { get; set; } // Thời gian RUN của bơm điều hòa 2
            public static short dieuHoa3_setTime { get; set; } // Thời gian RUN của bơm điều hòa 3

            //Máy thổi khí
            public static short mtk01_setTime { get; set; } // Thời gian RUN của máy thổi khí 1
            public static short mtk02_setTime { get; set; } // Thời gian RUN của máy thổi khí 2
            public static short mtk03_setTime { get; set; } // Thời gian RUN của máy thổi khí 3


            /// <summary>
            /// Mỹ phước giai đoạn 1 cải tạo "GD1MR"
            /// </summary>
            public static short anoxic1_setTime { get; set; }
            public static short anoxic2_setTime { get; set; }
            public static short anoxic3_setTime { get; set; }
            public static short anoxic4_setTime { get; set; }
            public static short anoxic5_setTime { get; set; }
            public static short anoxic6_setTime { get; set; }
            public static short anoxic7_setTime { get; set; }
            public static short anoxic8_setTime { get; set; }
            public static short metanol_setTime_on { get; set; }
            public static short metanol_setTime_off { get; set; }

            /// <summary>
            /// Symbol "TH1"
            /// </summary>
            public static short tuanHoan1_setTime { get; set; } // "TH1"
            public static short tuanHoan2_setTime { get; set; } // "TH2"
            public static short tuanHoan3_setTime { get; set; } // "TH3"
            
            /// <summary>
            /// Symbol "GB1"
            /// </summary>
            public static short gatBun_setTime_on { get; set; } // "GB1"
            /// <summary>
            /// Symbol "GB1"
            /// </summary>
            public static short gatBun_setTime_off { get; set; } // "GB1"
            /// <summary>
            /// Symbol "BB12": setting time for ON
            /// </summary>
            public static short bomBun_setTime_on { get; set; } //"BB12"
            /// <summary>
            /// Symbol "BB12": setting time for OFF
            /// </summary>
            public static short bomBun_setTime_off { get; set; } // "BB12"
            /// <summary>
            /// Symbol "NAOH": setting time for ON
            /// </summary>
            public static short khuayNaoh_setTime_on { get; set; }
            /// <summary>
            /// Symbol "NAOH": setting time for OFF
            /// </summary>
            public static short khuayNaoh_setTime_off { get; set; }
            /// <summary>
            /// Symbol "MKT01": setting time
            /// </summary>
            public static short mkt1_setTime { get; set; }
            /// <summary>
            /// Symbol "MKT02": setting time
            /// </summary>
            public static short mkt2_setTime { get; set; }
            /// <summary>
            /// Symbol "MKT03": setting time
            /// </summary>
            public static short mkt3_setTime { get; set; }

            // Mỹ phước giai đoạn 2 "GD2"
            /// <summary>
            /// Symbol "WP02A": setting time
            /// </summary>
            public static short nt02a_setTime { get; set; } // Thời gian cài đặt chạy bơm nước thải 02A
            /// <summary>
            /// Symbol "WP02B": setting time
            /// </summary>
            public static short nt02b_setTime { get; set; } // Thời gian cài đặt chạy bơm nước thải 02B
            public static short mtk_AB06A_setTime { get; set; } // Thời gian cài đặt chạy máy thối khí AB06A
            public static short mtk_AB06B_setTime { get; set; } // Thời gian cài đặt chạy máy thổi khí AB06B
            public static short mtk_AB06C_setTime { get; set; } // Thời gian cài đặt chạy máy thổi khí AB06C
            public static short gbbl05_setTime_on { get; set; } // Thời gian cài đặt ON chạy gạt bùn GBBL05
            public static short gbbl05_setTime_off { get; set; } // Thời gian cài đặt OFF chạy gạt bùn GBBL05
            public static short gbbl07_setTime_on { get; set; } // Thời gian cài đặt ON chạy gạt bùn GBBL07
            public static short gbbl07_setTime_off { get; set; } // Thời gian cài đặt OFF chạy gạt bùn GBBL07
            public static short gbbl09_setTime_on { get; set; } // Thời gian cài đặt ON chạy gạt bùn GBBL09
            public static short gbbl09_setTime_off { get; set; } // Thời gian cài đặt OFF chạy gạt bùn GBBL09

            /// <summary>
            /// Symbol "SP05A SP05B": setting time ON
            /// </summary>
            public static short bomBun05_setTime_on { get; set; } // Thời gian cài đặt ON bơm bùn 05: SP05A, SP05B
            /// <summary>
            /// Symbol "SP05A SP05B": setting time OFF
            /// </summary>   
            public static short bomBun05_setTime_off { get; set; } // Thời gian cài đặt OFF bơm bùn 05: SP05A, SP05B
            /// <summary>
            /// Symbol "SP07A SP07B": setting time ON
            /// </summary>
            public static short bomBun07_setTime_on { get; set; } // Thời gian cài đặt ON bơm bùn 07 : SP07A, SP07B
            /// <summary>
            /// Symbol "SP07A SP07B": setting time OFF
            /// </summary>
            public static short bomBun07_setTime_off { get; set; } // Thời gian cài đặt OFF bơm bùn 07: SP07A, SP07B

        #endregion

        #region UI VALUE SET
            /// <summary>
            /// Mỹ phước giai đoạn 1 "GD1"
            /// </summary>
            // Bơm thu gom

            /// <summary>
            /// Symbol "P101"
            /// </summary>
            public static short beGom1_setTime_ui { get; set; } // Setting time RUN of bơm thu gom 1 
            /// <summary>
            /// Symbol "P102"
            /// </summary>
            public static short beGom2_setTime_ui { get; set; } // Thời gian RUN của bơm thu gom 2
            /// <summary>
            /// Symbol "P103"
            /// </summary>
            public static short beGom3_setTime_ui { get; set; } // Thời gian RUN của bơm thu gom 3

            // Bơm điểu hòa
            /// <summary>
            /// Symbol "P201"
            /// </summary>
            public static short dieuHoa1_setTime_ui { get; set; } // Thời gian RUN của bơm điều hòa 1
            /// <summary>
            /// Symbol "P202"
            /// </summary>
            public static short dieuHoa2_setTime_ui { get; set; } // Thời gian RUN của bơm điều hòa 2
            public static short dieuHoa3_setTime_ui { get; set; } // Thời gian RUN của bơm điều hòa 3

            //Máy thổi khí
            public static short mtk01_setTime_ui { get; set; } // Thời gian RUN của máy thổi khí 1
            public static short mtk02_setTime_ui { get; set; } // Thời gian RUN của máy thổi khí 2
            public static short mtk03_setTime_ui { get; set; } // Thời gian RUN của máy thổi khí 3


            /// <summary>
            /// Mỹ phước giai đoạn 1 cải tạo "GD1MR"
            /// </summary>
            public static short anoxic1_setTime_ui { get; set; } // "SM01"
            public static short anoxic2_setTime_ui { get; set; }
            public static short anoxic3_setTime_ui { get; set; }
            public static short anoxic4_setTime_ui { get; set; }
            public static short anoxic5_setTime_ui { get; set; }
            public static short anoxic6_setTime_ui { get; set; }
            public static short anoxic7_setTime_ui { get; set; }
            public static short anoxic8_setTime_ui { get; set; } // "SM08"
            /// <summary>
            ///  Symbol "MT1" ON
            /// </summary>
            public static short metanol_setTime_on_ui { get; set; }
            /// <summary>
            ///  Symbol "MT1" OFF
            /// </summary>
            public static short metanol_setTime_off_ui { get; set; }

            /// <summary>
            /// Symbol "TH1"
            /// </summary>
            public static short tuanHoan1_setTime_ui { get; set; } // "TH1"
            public static short tuanHoan2_setTime_ui { get; set; } // "TH2"
            public static short tuanHoan3_setTime_ui { get; set; } // "TH3"

            /// <summary>
            /// Symbol "GB1"
            /// </summary>
            public static short gatBun_setTime_on_ui { get; set; } // "GB1"
            /// <summary>
            /// Symbol "GB1"
            /// </summary>
            public static short gatBun_setTime_off_ui { get; set; } // "GB1"
            /// <summary>
            /// Symbol "BB12": setting time for ON
            /// </summary>
            public static short bomBun_setTime_on_ui { get; set; } //"BB12"
            /// <summary>
            /// Symbol "BB12": setting time for OFF
            /// </summary>
            public static short bomBun_setTime_off_ui { get; set; } // "BB12"
            /// <summary>
            /// Symbol "NAOH": setting time for ON
            /// </summary>
            public static short khuayNaoh_setTime_on_ui { get; set; }
            /// <summary>
            /// Symbol "NAOH": setting time for OFF
            /// </summary>
            public static short khuayNaoh_setTime_off_ui { get; set; }
            /// <summary>
            /// Symbol "MKT01": setting time
            /// </summary>
            public static short mkt1_setTime_ui { get; set; }
            /// <summary>
            /// Symbol "MKT02": setting time
            /// </summary>
            public static short mkt2_setTime_ui { get; set; }
            /// <summary>
            /// Symbol "MKT03": setting time
            /// </summary>
            public static short mkt3_setTime_ui { get; set; }

            // Mỹ phước giai đoạn 2 "GD2"
            /// <summary>
            /// Symbol "WP02A": setting time
            /// </summary>
            public static short nt02a_setTime_ui { get; set; } // Thời gian cài đặt chạy bơm nước thải 02A
            /// <summary>
            /// Symbol "WP02B": setting time
            /// </summary>
            public static short nt02b_setTime_ui { get; set; } // Thời gian cài đặt chạy bơm nước thải 02B
            public static short mtk_AB06A_setTime_ui { get; set; } // Thời gian cài đặt chạy máy thối khí AB06A
            public static short mtk_AB06B_setTime_ui { get; set; } // Thời gian cài đặt chạy máy thổi khí AB06B
            public static short mtk_AB06C_setTime_ui { get; set; } // Thời gian cài đặt chạy máy thổi khí AB06C
            /// <summary>
            /// Symbol "MS05": setting time ON
            /// </summary>
            public static short gbbl05_setTime_on_ui { get; set; } // Thời gian cài đặt ON chạy gạt bùn GBBL05
            /// <summary>
            /// Symbol "MS05": setting time OFF
            /// </summary>    
            public static short gbbl05_setTime_off_ui { get; set; } // Thời gian cài đặt OFF chạy gạt bùn GBBL05
            /// <summary>
            /// Symbol "MS07": setting time ON
            /// </summary>
            public static short gbbl07_setTime_on_ui { get; set; } // Thời gian cài đặt ON chạy gạt bùn GBBL07
            /// <summary>
            /// Symbol "MS05": setting time OFF
            /// </summary>
            public static short gbbl07_setTime_off_ui { get; set; } // Thời gian cài đặt OFF chạy gạt bùn GBBL07
            /// <summary>
            /// Symbol "MS09": setting time ON
            /// </summary>
            public static short gbbl09_setTime_on_ui { get; set; } // Thời gian cài đặt ON chạy gạt bùn GBBL09
            /// <summary>
            /// Symbol "MS09": setting time OFF
            /// </summary>
            public static short gbbl09_setTime_off_ui { get; set; } // Thời gian cài đặt OFF chạy gạt bùn GBBL09

            /// <summary>
            /// Symbol "SP05A SP05B": setting time ON
            /// </summary>
            public static short bomBun05_setTime_on_ui { get; set; } // Thời gian cài đặt ON bơm bùn 05: SP05A, SP05B
            /// <summary>
            /// Symbol "SP05A SP05B": setting time OFF
            /// </summary>   
            public static short bomBun05_setTime_off_ui { get; set; } // Thời gian cài đặt OFF bơm bùn 05: SP05A, SP05B
            /// <summary>
            /// Symbol "SP07A SP07B": setting time ON
            /// </summary>
            public static short bomBun07_setTime_on_ui { get; set; } // Thời gian cài đặt ON bơm bùn 07 : SP07A, SP07B
            /// <summary>
            /// Symbol "SP07A SP07B": setting time OFF
            /// </summary>
            public static short bomBun07_setTime_off_ui { get; set; } // Thời gian cài đặt OFF bơm bùn 07: SP07A, SP07B

        #endregion
        #endregion

        #region Thời gian RUNTIME 
        /// <summary>
        /// Mỹ phước giai đoạn 1 "GD1"
        /// </summary>
        public static int dieuHoa1_runtime { get; set; } // Bơm điều hòa 1.
            public static int dieuHoa2_runtime { get; set; } // Bơm điều hòa 2.
            public static int tuanHoanNuoc_runtime { get; set; } // Bơm tuần hoàn nước.
            public static int tuanHoanBun_runtime { get; set; } // Bơm tuần hoàn bùn.
            public static int bunHoaLy1_runtime { get; set; } // Bùn hóa lý 1.
            public static int bunHoaLy2_runtime { get; set; } // Bùn hóa lý 2.
            public static int beGom1_runtime { get; set; } // Bể gom 1.
            public static int beGom2_runtime { get; set; } // Bể gom 2.
            public static int beGom3_runtime { get; set; } // Bể gom 3.
            public static int skbm1_runtime { get; set; } //???.
            public static int skbm2_runtime { get; set; } //???.
            public static int skbm3_runtime { get; set; } //???.
            public static int mtk1_runtime { get; set; } // Máy thổi khí 01.
            public static int mtk2_runtime { get; set; } // Máy thổi khí 02.
            public static int mtk3_runtime { get; set; } // Máy thổi khí 03.
            public static int dlAxit_runtime { get; set; } // Định lượng hóa chất axit.
            public static int dlXut_runtime { get; set; } // Định lượng Xút.
            public static int dlNp_runtime { get; set; } // Định lượng NP.
            public static int dlClo_runtime { get; set; } // Định lượng Clo.
            public static int dlPac_runtime { get; set; } // Định lượng PAC.
            public static int dlPolyme_runtime { get; set; } // Định lượng Polyme 1.
            //public static int dlPolyme2_runtime { get; set; } // Định lượng Polyme 2 =>???
            public static int khuayNp_runtime { get; set; } // Máy khuấy NP.
            public static int khuayClo_runtime { get; set; } // Khuấy Clo.
            public static int khuayPac_runtime { get; set; } // Khuấy PAC.
            public static int khuayPoly1_runtime { get; set; } // Khuấy Polyme 1.
            public static int khuayPoly2_runtime { get; set; } // Khuây Polyme 2

            //public static int khuayKeoTu_runtime { get; set; } // Khuấy keo tụ
            //public static int khuayTaoBong1_runtime { get; set; } // Khuấy tạo bông 1
            //public static int khuayTaoBong2_runtime { get; set; } // Khuấy tạo bông 2
            //public static int motorGatBun_runtime { get; set; } // Motot gạt bùn


            /// <summary>
            /// Mỹ phước giai đoạn 1 cải tạo "GD1MR"
            /// </summary>
            /// 
            public static int anoxic1_runtime { get; set; }
            public static int anoxic2_runtime { get; set; }
            public static int anoxic3_runtime { get; set; }
            public static int anoxic4_runtime { get; set; }
            public static int anoxic5_runtime { get; set; }
            public static int anoxic6_runtime { get; set; }
            public static int anoxic7_runtime { get; set; }
            public static int anoxic8_runtime { get; set; }
            public static int metanol_runtime { get; set; }
            public static int etanol1_runtime { get; set; }
            public static int etanol2_runtime { get; set; }
            public static int mtk_1_runtime { get; set; }
            public static int mtk_2_runtime { get; set; }
            public static int mtk_3_runtime { get; set; }
            public static int tuanHoan1_runtime { get; set; }
            public static int tuanHoan2_runtime { get; set; }
            public static int tuanHoan3_runtime { get; set; }
            public static int gatBun_runtime { get; set; }
            public static int bomBun1_runtime { get; set; }
            public static int bomBun2_runtime { get; set; }
            public static int khuayNaoh_runtime { get; set; }
            public static int dlNaoh_runtime { get; set; }
            public static int al2so4_1_runtime { get; set; }
            public static int al2so4_2_runtime { get; set; }

            /// <summary>
            /// Mỹ Phước giai đoạn 2 : GD2
            /// </summary>
            /// 
            public static int mayTachRac_runtime { get; set; } // Thời gian RUNTIME máy tách rác.
            public static int bomNt_02A_runtime { get; set; } // Thời gian RUNTIME bơm nước thải 02A.
            public static int bomNt_02B_runtime { get; set; } // Thời gian RUNTIME bơm nước thải 02B.
            public static int mtk_AB06A_runtime { get; set; } // Thời gian RUNTIME máy thổi khí AB06A.
            public static int mtk_AB06B_runtime { get; set; } // Thời gian RUNTIME máy thổi khí AB06B.
            public static int mtk_AB06C_runtime { get; set; } // Thời gian RUNTIME máy thổi khí AB06C.
            public static int khuayKeoTu_GD2_runtime { get; set; } // Thời gian RUNTIME khuấy keo tụ GD2.
            public static int khuayTaoBong_A_runtime { get; set; } // Thời gian RUNTIME khuấy tạo bông A.
            public static int khuayTaoBong_B_runtime { get; set; }  // Thời gian RUNTIME khuấy tạo bông B.
            public static int gbbl05_runtime { get; set; } // Thời gian RUNTIME bơm hóa chất GBBL 05.
            public static int gbbl07_runtime { get; set; } // Thời gian RUNTIME bơm hóa chất GBBL 07.
            public static int gbbl09_runtime { get; set; } // Thời gian RUNTIME bơm hóa chất GBBL 09.
            public static int khuayPac_GD2_runtime { get; set; } // Thời gian RUNTIME khuấy PAC GD2.
            public static int khuayPoly_GD2_runtime { get; set; } // Thời gian RUNTIME khuấy Polyme GD2.
            public static int bomBun_05A_runtime { get; set; } // Thời gian RUNTIME bơm bùn 05A.
            public static int bomBun_05B_runtime { get; set; } // Thời gian RUNTIME bơm bùn 05B.
            public static int bomBun_07A_runtime { get; set; } // Thời gian RUNTIME bơm bùn 07A.
            public static int bomBun_07B_runtime { get; set; } // Thời gian RUNTIME bơm bùn 07B.
            public static int bomBun_SP10_runtime { get; set; } // Thời gian RUNTIME bơm bùn SP10.
            public static int dlPhen_03A_runtime { get; set; } // Thời gian RUNTIME bơm định lượng phèn 03A.
            public static int dlPhen_03B_runtime { get; set; } // Thời gian RUNTIME bơm định lượng phèn 03B.
            public static int dlPoly_04A_runtime { get; set; } // Thời gian RUNTIME bơm định lượng Polyme 04A.
            public static int dlPoly_04B_runtime { get; set; } // Thời gian RUNTIME bơm định lượng Polyme 04B.
            public static int dlXut_05A_runtime { get; set; } // Thời gian RUNTIME bơm hóa chất Xút 05A.
            public static int dlXut_05B_runtime { get; set; } // Thời gian RUNTIME bơm hóa chất Xút 05B.
            public static int dlDd_06A_runtime { get; set; } // Thời gian RUNTIME bơm hóa chất Dd 06A.
            public static int dlDd_06B_runtime { get; set; } // Thời gian RUNTIME bơm hóa chất Dd 06B.
            public static int dlKhuTrung_07A_runtime { get; set; } // Thời gian RUNTIME bơm hóa chất khử trùng 07A.
            public static int dlKhuTrung_07B_runtime { get; set; } // Thời gian RUNTIME bơm hóa chất khử trùng 07B.

        #endregion

        #region RESET RUNTIME CMD
        /// <summary>
        /// Mỹ phước giai đoạn 1 "GD1"
        /// </summary>
         public static bool dieuHoa1_resetCmd { get; set; } // Bơm điều hòa 1.
            public static bool dieuHoa2_resetCmd { get; set; } // Bơm điều hòa 2.
            public static bool tuanHoanNuoc_resetCmd { get; set; } // Bơm tuần hoàn nước.
            public static bool tuanHoanBun_resetCmd { get; set; } // Bơm tuần hoàn bùn.
            public static bool bunHoaLy1_resetCmd { get; set; } // Bùn hóa lý 1.
            public static bool bunHoaLy2_resetCmd { get; set; } // Bùn hóa lý 2.
            public static bool beGom1_resetCmd { get; set; } // Bể gom 1.
            public static bool beGom2_resetCmd { get; set; } // Bể gom 2.
            public static bool beGom3_resetCmd { get; set; } // Bể gom 3.
            public static bool skbm1_resetCmd { get; set; } //???.
            public static bool skbm2_resetCmd { get; set; } //???.
            public static bool skbm3_resetCmd { get; set; } //???.
            public static bool mtk1_resetCmd { get; set; } // Máy thổi khí 01.
            public static bool mtk2_resetCmd { get; set; } // Máy thổi khí 02.
            public static bool mtk3_resetCmd { get; set; } // Máy thổi khí 03.
            public static bool dlAxit_resetCmd { get; set; } // Định lượng hóa chất axit.
            public static bool dlXut_resetCmd { get; set; } // Định lượng Xút.
            public static bool dlNp_resetCmd { get; set; } // Định lượng NP.
            public static bool dlClo_resetCmd { get; set; } // Định lượng Clo.
            public static bool dlPac_resetCmd { get; set; } // Định lượng PAC.
            public static bool dlPolyme_resetCmd { get; set; } // Định lượng Polyme.

            //public static bool dlPolyme2_resetCmd { get; set; } // Định lượng Polyme 2

            public static bool khuayNp_resetCmd { get; set; } // Máy khuấy NP.
            public static bool khuayClo_resetCmd { get; set; } // Khuấy Clo.
            public static bool khuayPac_resetCmd { get; set; } // Khuấy PAC.
            public static bool khuayPoly1_resetCmd { get; set; } // Khuấy Polyme 1.
            public static bool khuayPoly2_resetCmd { get; set; } // Khuây Polyme 2.

            //public static bool khuayKeoTu_resetCmd { get; set; } // Khuấy keo tụ
            //public static bool khuayTaoBong1_resetCmd { get; set; } // Khuấy tạo bông 1
            //public static bool khuayTaoBong2_resetCmd { get; set; } // Khuấy tạo bông 2
            //public static bool motorGatBun_resetCmd { get; set; } // Motot gạt bùn

            /// <summary>
            /// Mỹ phước giai đoạn 1 cải tạo "GD1MR"
            /// </summary>
            /// 
            public static bool anoxic1_resetCmd { get; set; }
            public static bool anoxic2_resetCmd { get; set; }
            public static bool anoxic3_resetCmd { get; set; }
            public static bool anoxic4_resetCmd { get; set; }
            public static bool anoxic5_resetCmd { get; set; }
            public static bool anoxic6_resetCmd { get; set; }
            public static bool anoxic7_resetCmd { get; set; }
            public static bool anoxic8_resetCmd { get; set; }
            public static bool metanol_resetCmd { get; set; }
            public static bool etanol1_resetCmd { get; set; }
            public static bool etanol2_resetCmd { get; set; }
            public static bool mtk_1_resetCmd { get; set; }
            public static bool mtk_2_resetCmd { get; set; }
            public static bool mtk_3_resetCmd { get; set; }
            public static bool tuanHoan1_resetCmd { get; set; }
            public static bool tuanHoan2_resetCmd { get; set; }
            public static bool tuanHoan3_resetCmd { get; set; }
            public static bool gatBun_resetCmd { get; set; }
            public static bool bomBun1_resetCmd { get; set; }
            public static bool bomBun2_resetCmd { get; set; }
            public static bool khuayNaoh_resetCmd { get; set; }
            public static bool dlNaoh_resetCmd { get; set; }
            public static bool al2so4_1_resetCmd { get; set; }
            public static bool al2so4_2_resetCmd { get; set; }

            /// <summary>
            /// Mỹ Phước giai đoạn 2 : GD2
            /// </summary>
            /// 
            public static bool mayTachRac_resetCmd { get; set; } // CMD Reset runtime máy tách rác.
            public static bool bomNt_02A_resetCmd { get; set; } // CMD Reset runtime bơm nước thải 02A.
            public static bool bomNt_02B_resetCmd { get; set; } // CMD Reset runtime bơm nước thải 02B.
            public static bool mtk_AB06A_resetCmd { get; set; } // CMD Reset runtime máy thổi khí AB06A.
            public static bool mtk_AB06B_resetCmd { get; set; } // CMD Reset runtime máy thổi khí AB06B.
            public static bool mtk_AB06C_resetCmd { get; set; } // CMD Reset runtime máy thổi khí AB06C.
            public static bool khuayKeoTu_GD2_resetCmd { get; set; } // CMD Reset runtime khuấy keo tụ GD2.
            public static bool khuayTaoBong_A_resetCmd { get; set; } // CMD Reset runtime khuấy tạo bông A.
            public static bool khuayTaoBong_B_resetCmd { get; set; }  // CMD Reset runtime khuấy tạo bông B.
            public static bool gbbl05_resetCmd { get; set; } // CMD Reset runtime bơm hóa chất GBBL 05.
            public static bool gbbl07_resetCmd { get; set; } // CMD Reset runtime bơm hóa chất GBBL 07.
            public static bool gbbl09_resetCmd { get; set; } // CMD Reset runtime bơm hóa chất GBBL 09.
            public static bool khuayPac_GD2_resetCmd { get; set; } // CMD Reset runtime khuấy PAC GD2.
            public static bool khuayPoly_GD2_resetCmd { get; set; } // CMD Reset runtime khuấy Polyme GD2.
            public static bool bomBun_05A_resetCmd { get; set; } // CMD Reset runtime bơm bùn 05A.
            public static bool bomBun_05B_resetCmd { get; set; } // CMD Reset runtime bơm bùn 05B.
            public static bool bomBun_07A_resetCmd { get; set; } // CMD Reset runtime bơm bùn 07A.
            public static bool bomBun_07B_resetCmd { get; set; } // CMD Reset runtime bơm bùn 07B.
            public static bool bomBun_SP10_resetCmd { get; set; } // CMD Reset runtime bơm bùn SP10.
            public static bool dlPhen_03A_resetCmd { get; set; } // CMD Reset runtime bơm định lượng phèn 03A.
            public static bool dlPhen_03B_resetCmd { get; set; } // CMD Reset runtime bơm định lượng phèn 03B.
            public static bool dlPoly_04A_resetCmd { get; set; } // CMD Reset runtime bơm định lượng Polyme 04A.
            public static bool dlPoly_04B_resetCmd { get; set; } // CMD Reset runtime bơm định lượng Polyme 04B.
            public static bool dlXut_05A_resetCmd { get; set; } // CMD Reset runtime bơm hóa chất Xút 05A.
            public static bool dlXut_05B_resetCmd { get; set; } // CMD Reset runtime bơm hóa chất Xút 05B.
            public static bool dlDd_06A_resetCmd { get; set; } // CMD Reset runtime bơm hóa chất Dd 06A.
            public static bool dlDd_06B_resetCmd { get; set; } // CMD Reset runtime bơm hóa chất Dd 06B.
            public static bool dlKhuTrung_07A_resetCmd { get; set; } // CMD Reset runtime bơm hóa chất khử trùng 07A.
            public static bool dlKhuTrung_07B_resetCmd { get; set; } // CMD Reset runtime bơm hóa chất khử trùng 07B.
        #endregion
    }
}
