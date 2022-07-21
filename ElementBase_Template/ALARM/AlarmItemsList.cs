using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.ALARM
{
    internal class AlarmItemsList
    {
        public class AlarmList_LevelDown
        {
            #region FLOAT - ALARM
            // Float
            public AlarmItems.floatAlarmRow almItem_floatBeGom = new AlarmItems.floatAlarmRow { activeStatus = false };
            public AlarmItems.floatAlarmRow almItem_floatBeDieuHoa = new AlarmItems.floatAlarmRow { activeStatus = false };
            public AlarmItems.floatAlarmRow almItem_floatBeBunSP10 = new AlarmItems.floatAlarmRow { activeStatus = false };
            public AlarmItems.floatAlarmRow almItem_floatBeBunSP05 = new AlarmItems.floatAlarmRow { activeStatus = false };
            public AlarmItems.floatAlarmRow almItem_floatBeBunSP07 = new AlarmItems.floatAlarmRow { activeStatus = false };
            #endregion

            #region TRIP - ALARM
            // Trip Motor
            // GD1
            #region Trip - GD1

            public AlarmItems.tripAlarmRow almItem_mtk01_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_mtk02_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_mtk03_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };

            public AlarmItems.tripAlarmRow almItem_dieuHoa1_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_dieuHoa2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };

            public AlarmItems.tripAlarmRow almItem_tuanHoanNuoc_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_tuanHoanBun_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };

            public AlarmItems.tripAlarmRow almItem_bunHoaLy1_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_bunHoaLy2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };

            public AlarmItems.tripAlarmRow almItem_beGom1_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_beGom2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_beGom3_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };

            public AlarmItems.tripAlarmRow almItem_skbm1_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_skbm2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_skbm3_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };

            public AlarmItems.tripAlarmRow almItem_dlAxit_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_dlXut_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_dlNp_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_dlClo_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_dlPac_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };

            public AlarmItems.tripAlarmRow almItem_dlPolyme1_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_dlPolyme2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };

            public AlarmItems.tripAlarmRow almItem_khuayNp_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_khuayClo_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_khuayPac_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_khuayPolyme1_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_khuayPolyme2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_khuayKeoTu_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_khuayTaoBong1_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_khuayTaoBong2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            public AlarmItems.tripAlarmRow almItem_motorGatBun_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };
            #endregion

            #region TRIP - GD1MR

            //GD1MR
            public AlarmItems.tripAlarmRow almItem_anoxic1_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Anoxic 1.
            public AlarmItems.tripAlarmRow almItem_anoxic2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Anoxic 2.
            public AlarmItems.tripAlarmRow almItem_anoxic3_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Anoxic 3.
            public AlarmItems.tripAlarmRow almItem_anoxic4_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Anoxic 4.
            public AlarmItems.tripAlarmRow almItem_anoxic5_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Anoxic 5.
            public AlarmItems.tripAlarmRow almItem_anoxic6_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Anoxic 6.
            public AlarmItems.tripAlarmRow almItem_anoxic7_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Anoxic 7.
            public AlarmItems.tripAlarmRow almItem_anoxic8_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Anoxic 8.
            public AlarmItems.tripAlarmRow almItem_etanol1_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Etanol 1.
            public AlarmItems.tripAlarmRow almItem_etanol2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Etanol 2. => Không xác định được control sử dụng SCADA
            public AlarmItems.tripAlarmRow almItem_metanol_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Metanol "MT-ETN".
            public AlarmItems.tripAlarmRow almItem_mkt01_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" máy thổi khí 1.
            public AlarmItems.tripAlarmRow almItem_mkt02_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" máy thổi khí 2.
            public AlarmItems.tripAlarmRow almItem_mkt03_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" máy thổi khí 3.
            public AlarmItems.tripAlarmRow almItem_tuanHoan1_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm tuần hoàn 1.
            public AlarmItems.tripAlarmRow almItem_tuanHoan2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm tuần hoàn 2.
            public AlarmItems.tripAlarmRow almItem_tuanHoan3_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm tuần hoàn 3.
            public AlarmItems.tripAlarmRow almItem_gatBun_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" gạt bùn "GB1".
            public AlarmItems.tripAlarmRow almItem_bomBun1_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm bùn 1.
            public AlarmItems.tripAlarmRow almItem_bomBun2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm bùn 2.
            public AlarmItems.tripAlarmRow almItem_khuayNaoh_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" khuấy NaoH.
            public AlarmItems.tripAlarmRow almItem_dlNaoh_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" định lượng NaoH.
            public AlarmItems.tripAlarmRow almItem_al2so4_1_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất AL2SO4 1.
            public AlarmItems.tripAlarmRow almItem_al2so4_2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất AL2SO4 2.
            #endregion

            #region TRIP - GD2
            // GD2
            public AlarmItems.tripAlarmRow almItem_mayTachRac_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" máy tách rác.
            public AlarmItems.tripAlarmRow almItem_bomNt_02A_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm nước thải 02A.
            public AlarmItems.tripAlarmRow almItem_bomNt_02B_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm nước thải 02B.
            public AlarmItems.tripAlarmRow almItem_mtk_AB06A_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" máy thổi khí AB06A.
            public AlarmItems.tripAlarmRow almItem_mtk_AB06B_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" máy thổi khí AB06B.

            public AlarmItems.tripAlarmRow almItem_mtk_AB06C_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" máy thổi khí AB06C.
            public AlarmItems.tripAlarmRow almItem_khuayKeoTu_GD2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" khuấy keo tụ GD2.
            public AlarmItems.tripAlarmRow almItem_khuayTaoBong_A_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" khuấy tạo bông A.
            public AlarmItems.tripAlarmRow almItem_khuayTaoBong_B_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false };  // Trạng thái "TRIP" khuấy tạo bông B.
            public AlarmItems.tripAlarmRow almItem_gbbl05_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất GBBL 05.
            public AlarmItems.tripAlarmRow almItem_gbbl07_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất GBBL 07.
            public AlarmItems.tripAlarmRow almItem_gbbl09_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất GBBL 09.
            public AlarmItems.tripAlarmRow almItem_khuayPac_GD2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" khuấy PAC GD2.
            public AlarmItems.tripAlarmRow almItem_khuayPoly_GD2_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" khuấy Polyme GD2.
            public AlarmItems.tripAlarmRow almItem_bomBun_05A_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm bùn 05A.
            public AlarmItems.tripAlarmRow almItem_bomBun_05B_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm bùn 05B.
            public AlarmItems.tripAlarmRow almItem_bomBun_07A_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm bùn 07A.
            public AlarmItems.tripAlarmRow almItem_bomBun_07B_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm bùn 07B.
            public AlarmItems.tripAlarmRow almItem_bomBun_SP10_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm bùn SP10.

            public AlarmItems.tripAlarmRow almItem_dlPhen_03A_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm định lượng phèn 03A.
            public AlarmItems.tripAlarmRow almItem_dlPhen_03B_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm định lượng phèn 03B.
            public AlarmItems.tripAlarmRow almItem_dlPolyme_04A_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm định lượng Polyme 04A.
            public AlarmItems.tripAlarmRow almItem_dlPolyme_04B_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm định lượng Polyme 04B.
            public AlarmItems.tripAlarmRow almItem_dlXut_05A_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Xút 05A.
            public AlarmItems.tripAlarmRow almItem_dlXut_05B_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Xút 05B.
            public AlarmItems.tripAlarmRow almItem_dlDd_06A_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Dd 06A.
            public AlarmItems.tripAlarmRow almItem_dlDd_06B_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất Dd 06B.
            public AlarmItems.tripAlarmRow almItem_dlKhuTrung_07A_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất khử trùng 07A.
            public AlarmItems.tripAlarmRow almItem_dlKhuTrung_07B_tripStatus = new AlarmItems.tripAlarmRow { activeStatus = false }; // Trạng thái "TRIP" bơm hóa chất khử trùng 07B.
            #endregion

            #endregion

            // Chỉ số quan trắc
            public AlarmItems.environmentIndexExceedAlarmRow almItem_flowInCap = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false }; // Read FLOW IN CAPACITY
            public AlarmItems.environmentIndexExceedAlarmRow almItem_flowOutCap = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false };
            public AlarmItems.environmentIndexExceedAlarmRow almItem_flowInTotal = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false };
            public AlarmItems.environmentIndexExceedAlarmRow almItem_flowOutTotal = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false };

            public AlarmItems.environmentIndexExceedAlarmRow almItem_cod_Index = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false };
            public AlarmItems.environmentIndexExceedAlarmRow almItem_tss_Index = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false }; // Read FLOW IN CAPACITY
            public AlarmItems.environmentIndexExceedAlarmRow almItem_ph_Index = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false };
            public AlarmItems.environmentIndexExceedAlarmRow almItem_color_Index = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false };
            public AlarmItems.environmentIndexExceedAlarmRow almItem_temper_Index = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false };
            public AlarmItems.environmentIndexExceedAlarmRow almItem_nh3_Index = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false };


            // Nước đầu vào
            public AlarmItems.environmentIndexExceedAlarmRow almItem_ph_sensor_in = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false }; // Chỉ số PH "IW160" nước đàu vào.
            public AlarmItems.environmentIndexExceedAlarmRow almItem_do_sensor_in = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false }; // Chỉ số DO "IW162"
            public AlarmItems.environmentIndexExceedAlarmRow almItem_ph_value_in = new AlarmItems.environmentIndexExceedAlarmRow { activeStatus = false }; // Gía trị PH sau xử lý => PLC Real 32 bit "MD50"

            // PLC connect
            public AlarmItems.connectInfoEventsRow almItem_PLC1 = new AlarmItems.connectInfoEventsRow { activeStatus = false }; // GD1
            public AlarmItems.connectInfoEventsRow almItem_PLC2 = new AlarmItems.connectInfoEventsRow { activeStatus = false }; // GD1MR
            public AlarmItems.connectInfoEventsRow almItem_PLC3 = new AlarmItems.connectInfoEventsRow { activeStatus = false }; // GD2
        }  
        
    }
}
