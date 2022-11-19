using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using ElementBase_Template.PLC.Data_Mapping.Engine;
using ElementBase_Template.PLC.Data_Mapping;
using System.Threading;

using ElementBase_Template.Ultility;

using ElementBase_Template.PLC.PLC1; //Namespace for DB Mapping at PLC1
using ElementBase_Template.PLC.PLC2; //Namespace for DB Mapping at PLC2
using ElementBase_Template.PLC.PLC3; //Namespace for DB Mapping at PLC3

using ElementBase_Template;
using ElementBase_Template.ALARM;
using System.Runtime.CompilerServices;
using MongoDB.Driver;
using MongoDB.Bson;
namespace MP2_V01
{
    public static class Program
    {
        #region OLD VERSION
        ////EngineCycle: Read
        //public static EngineCycle.PLC_GD1 PLC_GD1 = new EngineCycle.PLC_GD1();
        //public static EngineCycle.PLC_GD1MR PLC_GD2 = new EngineCycle.PLC_GD1MR();
        //public static EngineCycle.PLC_GD2 PLC_GD3 = new EngineCycle.PLC_GD2();

        ///// <summary>
        ///// Data for SCADA
        ///// </summary>
        //public static InputStatus_DB43 InputStatus_PLC1 = new InputStatus_DB43();
        //public static QuanTracIndex_DB14 QuanTracIndex_PLC1 = new QuanTracIndex_DB14();
        //public static ResetRuntime_DB20 ResetRuntime_PLC1 = new ResetRuntime_DB20();
        //public static Runtime_DB19 Runtime_PLC1 = new Runtime_DB19();
        //public static RuntimeSetting_DB16 RuntimeSetting_PLC1 = new RuntimeSetting_DB16();
        //public static RuntimeSetting_UI RuntimeSetting_UI_PLC1 = new RuntimeSetting_UI();

        //public static InputStatus_DB63_PLC2 InputStatus_PLC2 = new InputStatus_DB63_PLC2();
        //public static ResetRuntime_DB38_PLC2 ResetRuntime_PLC2 = new ResetRuntime_DB38_PLC2();
        //public static Runtime_DB39_PLC2 Runtime_PLC2 = new Runtime_DB39_PLC2();
        //public static RuntimeSetting_DB1_PLC2 RuntimeSetting_PLC2 = new RuntimeSetting_DB1_PLC2();
        //public static RuntimeSetting_UI_PLC2 RuntimeSetting_UI_PLC2 = new RuntimeSetting_UI_PLC2();

        //public static InputStatus_DB55_PLC3 InputStatus_PLC3 = new InputStatus_DB55_PLC3();
        //public static ResetRuntime_DB25_PLC3 ResetRuntime_PLC3 = new ResetRuntime_DB25_PLC3();
        //public static Runtime_DB24_PLC3 Runtime_PLC3 = new Runtime_DB24_PLC3();
        //public static RuntimeSetting_DB19_PLC3 RuntimeSetting_PLC3 = new RuntimeSetting_DB19_PLC3();
        //public static RuntimeSetting_UI_PLC3 RuntimeSetting_UI_PLC3 = new RuntimeSetting_UI_PLC3();

        //public static QuanTracIndex_Tag QuanTracIndexLogger = new QuanTracIndex_Tag();


        ///// ALARM EVENT:
        ///// 
        //public static ALARM_EVENTS alarmEvents_system = new ALARM_EVENTS();
        #endregion

        #region FIELDS
            public static DateTime dateTimeMain;
            // Form:
            public static LOGIN loginPage;
            public static Frame framePage;
            public static HOME homePage;
            public static RESET resetPage;
            public static RUNTIME_COLLECTION runtimeCollectionPage;
            public static RUNTIME_GD1 runtimeGD1Page;
            public static RUNTIME_GD1MR runtimeGD1MRPage;
            public static RUNTIME_GD2 runtimeGD2Page;
            public static SETTING settingPage;
            public static TREND trendPage;
            public static ALARM alarmPage;
            public static DEVICE_LIST deviceListPage;
            public static BECAMEX_INFO becamexInfoPage;
            public static DATA_EXPORT dataExportPage;
            public static TESTING_ENVIRONMENT testingEnvironmentPage;
            public static ADMIN_PAGE adminPage;

            public static SIM_ON_OFF sim_on_off;

            // Form Load FINISH:
            public static bool loadF_homePage;

            //EngineCycle: Read
            public static EngineCycle.PLC_GD1 PLC_GD1;
            public static EngineCycle.PLC_GD1MR PLC_GD2;
            public static EngineCycle.PLC_GD2 PLC_GD3;
            internal static EngineCycle.AlarmEngine almCycle;

            public static bool plc1_stopOtherConnecting;
            public static bool plc2_stopOtherConnecting;
            public static bool plc3_stopOtherConnecting;
            public static bool Enable_ReadData = false;

            /// <summary>
            /// DATA FROM PLC TO SCADA
            /// </summary>
            public static InputStatus_DB43 InputStatus_PLC1;
            public static QuanTracIndex_DB44 QuanTracIndex_PLC1;
            public static ResetRuntime_DB20 ResetRuntime_PLC1;
            public static Runtime_DB19 Runtime_PLC1;
            public static RuntimeSetting_DB16 RuntimeSetting_PLC1;
            public static RuntimeSetting_UI RuntimeSetting_UI_PLC1;

            public static InputStatus_DB63_PLC2 InputStatus_PLC2;
            public static ResetRuntime_DB38_PLC2 ResetRuntime_PLC2;
            public static Runtime_DB39_PLC2 Runtime_PLC2;
            public static RuntimeSetting_DB1_PLC2 RuntimeSetting_PLC2;
            public static RuntimeSetting_UI_PLC2 RuntimeSetting_UI_PLC2;

            public static InputStatus_DB55_PLC3 InputStatus_PLC3;
            public static ResetRuntime_DB25_PLC3 ResetRuntime_PLC3;
            public static Runtime_DB24_PLC3 Runtime_PLC3;
            public static RuntimeSetting_DB19_PLC3 RuntimeSetting_PLC3;
            public static RuntimeSetting_UI_PLC3 RuntimeSetting_UI_PLC3;

            public static QuanTracIndex_Tag QuanTracIndexLogger;


            /// ALARM LIST:
            /// 
            
            internal static AlarmItemsList.AlarmList_LevelDown danhSachAlarm;

            // LIST FOR SAVE LISTVIEW ROW ON TABLE
            public static List<ListViewItem> alarmItemsList; // Active Status Only
            public static List<ListViewItem> alarmItemsList_trip; //Active Status Only
            public static List<ListViewItem> alarmItemsList_float; // Active Status Only
            public static List<ListViewItem> alarmItemsList_connectInfo; // Active Status Only

            // LIST FOR SAVE ALARM HISTORY
            public static List<AlarmItems.GeneralAlarmItem> alarmList; // // History
            internal static List<AlarmItems.tripAlarmRow> alarmList_trip; // History
            internal static List<AlarmItems.floatAlarmRow> alarmList_float; // History
            internal static List<AlarmItems.connectInfoEventsRow> alarmList_connectInfo;// History

             internal static EngineCycle.EnviIndxAquisition EnviIndxStoring;

            #region DATABASE 
            public static ElementBase_Template.MongoDB.utility_MongoDB mongoDB_MP2 { get; set; }
            public static string mongoDB_hostname { get; set; }
            public static string mongoDB_port { get; set; }
            #endregion
        #endregion

        #region METHOD
        public static void ReadDatapPLC()
        {
            // PLC: READ
            PLC_GD1.updatedEngine(!(plc1_stopOtherConnecting));
            PLC_GD2.updatedEngine(!(plc2_stopOtherConnecting));
            PLC_GD3.updatedEngine(!(plc3_stopOtherConnecting));

            //listMongoDB();
        }

        // FORR TESTING---------------------------------
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                #region INITIATE FIELDS
                plc1_stopOtherConnecting = false;
                plc2_stopOtherConnecting = false;
                plc3_stopOtherConnecting = false;

                // Initilize: FORM Page:
                loginPage = new LOGIN();
                framePage = new Frame();
                homePage = new HOME();
                resetPage = new RESET();
                runtimeCollectionPage = new RUNTIME_COLLECTION();
                runtimeGD1Page = new RUNTIME_GD1();
                runtimeGD1MRPage = new RUNTIME_GD1MR();
                runtimeGD2Page = new RUNTIME_GD2();
                settingPage = new SETTING();
                trendPage = new TREND();
                alarmPage = new ALARM();
                deviceListPage = new DEVICE_LIST();
                becamexInfoPage = new BECAMEX_INFO();
                dataExportPage = new DATA_EXPORT();
                testingEnvironmentPage = new TESTING_ENVIRONMENT();
                adminPage = new ADMIN_PAGE();
                sim_on_off = new SIM_ON_OFF();

                // Event LoadForm
                loadF_homePage = false;

                /// <summary>
                /// Data for SCADA
                /// </summary>
                InputStatus_PLC1 = new InputStatus_DB43();
                QuanTracIndex_PLC1 = new QuanTracIndex_DB44();
                ResetRuntime_PLC1 = new ResetRuntime_DB20();
                Runtime_PLC1 = new Runtime_DB19();
                RuntimeSetting_PLC1 = new RuntimeSetting_DB16();
                RuntimeSetting_UI_PLC1 = new RuntimeSetting_UI();

                InputStatus_PLC2 = new InputStatus_DB63_PLC2();
                ResetRuntime_PLC2 = new ResetRuntime_DB38_PLC2();
                Runtime_PLC2 = new Runtime_DB39_PLC2();
                RuntimeSetting_PLC2 = new RuntimeSetting_DB1_PLC2();
                RuntimeSetting_UI_PLC2 = new RuntimeSetting_UI_PLC2();

                InputStatus_PLC3 = new InputStatus_DB55_PLC3();
                ResetRuntime_PLC3 = new ResetRuntime_DB25_PLC3();
                Runtime_PLC3 = new Runtime_DB24_PLC3();
                RuntimeSetting_PLC3 = new RuntimeSetting_DB19_PLC3();
                RuntimeSetting_UI_PLC3 = new RuntimeSetting_UI_PLC3();

                QuanTracIndexLogger = new QuanTracIndex_Tag();

                // Danh sách Items Alarm
                danhSachAlarm = new AlarmItemsList.AlarmList_LevelDown();


                // LIST FOR SAVE LISTVIEW ROW ON TABLE
                alarmItemsList = new List<ListViewItem>(); // Total alarm list 
                alarmItemsList_trip = new List<ListViewItem>(); // TRIP ALARM LIST
                alarmItemsList_float = new List<ListViewItem>();// FLOAT ALARM LIST
                alarmItemsList_connectInfo = new List<ListViewItem>(); // CONNECTING ALARM LIST

                // LIST FOR SAVE ALARM HISTORY
                alarmList = new List<AlarmItems.GeneralAlarmItem>(); // TOTAL ALARM LIST
                alarmList_trip = new List<AlarmItems.tripAlarmRow>(); // TRIP ALARM LIST
                alarmList_float = new List<AlarmItems.floatAlarmRow>(); // FLOAT ALARM LIST
                alarmList_connectInfo = new List<AlarmItems.connectInfoEventsRow>(); // CONNECTING ALARM LIST

                mongoDB_hostname = "localhost";
                mongoDB_port = "27017";
                mongoDB_MP2 = new ElementBase_Template.MongoDB.utility_MongoDB(mongoDB_hostname, mongoDB_port);
                mongoDB_MP2.connectToDB(mongoDB_hostname, mongoDB_port);

                //EngineCycle: Read
                PLC_GD1 = new EngineCycle.PLC_GD1();
                PLC_GD2 = new EngineCycle.PLC_GD1MR();
                PLC_GD3 = new EngineCycle.PLC_GD2();

                almCycle = new EngineCycle.AlarmEngine();
                almCycle.Load();




                #endregion

                ReadDatapPLC();
                almCycle.AlarmScan_Load(true);

                EnviIndxStoring = new EngineCycle.EnviIndxAquisition(300000); // cycle Time =  5 minute
                EnviIndxStoring.Load(true);

                #region ZONE FOR DEBUGGING

                // FORR TESSTING: --------------------
                /*
                #region GD1
                Program.InputStatus_PLC1.beGom1_runStatus = false;
                Program.InputStatus_PLC1.beGom2_runStatus = false;
                Program.InputStatus_PLC1.beGom3_runStatus = false;
                Program.InputStatus_PLC1.mtk01_runStatus = false;
                Program.InputStatus_PLC1.mtk02_runStatus = false;
                Program.InputStatus_PLC1.mtk03_runStatus = false;
                Program.InputStatus_PLC1.dieuHoa1_runStatus = false;
                Program.InputStatus_PLC1.dieuHoa2_runStatus = false;
                Program.InputStatus_PLC1.dlAxit_runStatus = false;
                Program.InputStatus_PLC1.dlXut_runStatus = false;
                Program.InputStatus_PLC1.dlNp_runStatus = false;
                Program.InputStatus_PLC1.dlClo_runStatus = false;
                Program.InputStatus_PLC1.dlPac_runStatus = false;
                Program.InputStatus_PLC1.dlPolyme1_runStatus= false;
                Program.InputStatus_PLC1.khuayNp_runStatus = false;
                Program.InputStatus_PLC1.khuayClo_runStatus = false;
                Program.InputStatus_PLC1.khuayPac_runStatus = false;
                Program.InputStatus_PLC1.khuayPolyme1_runStatus = false;
                Program.InputStatus_PLC1.khuayPolyme2_runStatus = false;
                Program.InputStatus_PLC1.khuayKeoTu_runStatus = false;
                Program.InputStatus_PLC1.khuayTaoBong1_runStatus = false;
                Program.InputStatus_PLC1.khuayTaoBong2_runStatus = false;
                Program.InputStatus_PLC1.motorGatBun_runStatus = false;


                Program.InputStatus_PLC1.beGom1_tripStatus = true;
                Program.InputStatus_PLC1.beGom2_tripStatus = true;
                Program.InputStatus_PLC1.beGom3_tripStatus = true;
                Program.InputStatus_PLC1.mtk01_tripStatus = true;
                Program.InputStatus_PLC1.mtk02_tripStatus = true;
                Program.InputStatus_PLC1.mtk03_tripStatus = true;
                Program.InputStatus_PLC1.dieuHoa1_tripStatus = true;
                Program.InputStatus_PLC1.dieuHoa2_tripStatus = true;
                Program.InputStatus_PLC1.dlAxit_tripStatus = true;
                Program.InputStatus_PLC1.dlXut_tripStatus = true;
                Program.InputStatus_PLC1.dlNp_tripStatus = true;
                Program.InputStatus_PLC1.dlClo_tripStatus = true;
                Program.InputStatus_PLC1.dlPac_tripStatus = true;
                Program.InputStatus_PLC1.dlPolyme1_tripStatus = true;
                Program.InputStatus_PLC1.khuayNp_tripStatus = true;
                Program.InputStatus_PLC1.khuayClo_tripStatus = true;
                Program.InputStatus_PLC1.khuayPac_tripStatus = true;
                Program.InputStatus_PLC1.khuayPolyme1_tripStatus = true;
                Program.InputStatus_PLC1.khuayPolyme2_tripStatus = true;
                Program.InputStatus_PLC1.khuayKeoTu_tripStatus = true;
                Program.InputStatus_PLC1.khuayTaoBong1_tripStatus = true;
                Program.InputStatus_PLC1.khuayTaoBong2_tripStatus = true;
                Program.InputStatus_PLC1.motorGatBun_tripStatus = true;

                #endregion

                #region GD1MR
                Program.InputStatus_PLC2.anoxic1_runStatus = false; // RUN: OK; TRIP: OK ; NORMAL: ; FALSE: OK ;
                Program.InputStatus_PLC2.anoxic2_runStatus = false; // RUN: OK; TRIP: OK ; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.anoxic3_runStatus = false;// RUN: OK; TRIP: OK ; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.anoxic4_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.anoxic5_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.anoxic6_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.anoxic7_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.anoxic8_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.metanol_runStatus = false;
                Program.InputStatus_PLC2.etanol1_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.etanol2_runStatus = false; // NO EXIST
                Program.InputStatus_PLC2.mkt01_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.mkt02_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.mkt03_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.tuanHoan1_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.tuanHoan2_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.tuanHoan3_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.gatBun_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.bomBun1_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC2.bomBun2_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;

                Program.InputStatus_PLC2.anoxic1_tripStatus = true;
                Program.InputStatus_PLC2.anoxic2_tripStatus = true;
                Program.InputStatus_PLC2.anoxic3_tripStatus = true;
                Program.InputStatus_PLC2.anoxic4_tripStatus = true;
                Program.InputStatus_PLC2.anoxic5_tripStatus = true;
                Program.InputStatus_PLC2.anoxic6_tripStatus = true;
                Program.InputStatus_PLC2.anoxic7_tripStatus = true;
                Program.InputStatus_PLC2.anoxic8_tripStatus = true;
                Program.InputStatus_PLC2.metanol_tripStatus = true;
                Program.InputStatus_PLC2.etanol1_tripStatus = true;
                Program.InputStatus_PLC2.etanol2_tripStatus = true;
                Program.InputStatus_PLC2.mkt01_tripStatus = true;
                Program.InputStatus_PLC2.mkt02_tripStatus = true;
                Program.InputStatus_PLC2.mkt03_tripStatus = true;
                Program.InputStatus_PLC2.tuanHoan1_tripStatus = true;
                Program.InputStatus_PLC2.tuanHoan2_tripStatus = true;
                Program.InputStatus_PLC2.tuanHoan3_tripStatus = true;
                Program.InputStatus_PLC2.gatBun_tripStatus = true;
                Program.InputStatus_PLC2.bomBun1_tripStatus = true;
                Program.InputStatus_PLC2.bomBun2_tripStatus = true;

                #endregion

                #region GD2
                Program.InputStatus_PLC3.mayTachRac_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.bomNt_02A_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.bomNt_02B_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.mtk_AB06A_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.mtk_AB06B_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.mtk_AB06C_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.khuayKeoTu_GD2_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.khuayTaoBong_A_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.khuayTaoBong_B_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.gbbl05_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.gbbl07_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.gbbl09_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.khuayPac_GD2_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.khuayPoly_GD2_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.bomBun_05A_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.bomBun_05B_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.bomBun_07A_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.bomBun_07B_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.bomBun_SP10_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.dlPhen_03A_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.dlPhen_03B_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.dlPolyme_04A_runStatus = false; // RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.dlPolyme_04B_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.dlXut_05A_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.dlXut_05B_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.dlDd_06A_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.dlDd_06B_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OKOK;
                Program.InputStatus_PLC3.dlKhuTrung_07A_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;
                Program.InputStatus_PLC3.dlKhuTrung_07B_runStatus = false;// RUN: OK; TRIP: OK; NORMAL: ; FALSE: OK;

                Program.InputStatus_PLC3.mayTachRac_tripStatus = true;
                Program.InputStatus_PLC3.bomNt_02A_tripStatus = true;
                Program.InputStatus_PLC3.bomNt_02B_tripStatus = true;
                Program.InputStatus_PLC3.mtk_AB06A_tripStatus = true;
                Program.InputStatus_PLC3.mtk_AB06B_tripStatus = true;
                Program.InputStatus_PLC3.mtk_AB06C_tripStatus = true;
                Program.InputStatus_PLC3.khuayKeoTu_GD2_tripStatus = true;
                Program.InputStatus_PLC3.khuayTaoBong_A_tripStatus = true;
                Program.InputStatus_PLC3.khuayTaoBong_B_tripStatus = true;
                Program.InputStatus_PLC3.gbbl05_tripStatus = true;
                Program.InputStatus_PLC3.gbbl07_tripStatus = true;
                Program.InputStatus_PLC3.gbbl09_tripStatus = true;
                Program.InputStatus_PLC3.khuayPac_GD2_tripStatus = true;
                Program.InputStatus_PLC3.khuayPoly_GD2_tripStatus = true;
                Program.InputStatus_PLC3.bomBun_05A_tripStatus = true;
                Program.InputStatus_PLC3.bomBun_05B_tripStatus = true;
                Program.InputStatus_PLC3.bomBun_07A_tripStatus = true;
                Program.InputStatus_PLC3.bomBun_07B_tripStatus = true;
                Program.InputStatus_PLC3.bomBun_SP10_tripStatus = true;
                Program.InputStatus_PLC3.dlPhen_03A_tripStatus = true;
                Program.InputStatus_PLC3.dlPhen_03B_tripStatus = true;
                Program.InputStatus_PLC3.dlPolyme_04A_tripStatus = true;
                Program.InputStatus_PLC3.dlPolyme_04B_tripStatus = true;
                Program.InputStatus_PLC3.dlXut_05A_tripStatus = true;
                Program.InputStatus_PLC3.dlXut_05B_tripStatus = true;
                Program.InputStatus_PLC3.dlDd_06A_tripStatus = true;
                Program.InputStatus_PLC3.dlDd_06B_tripStatus = true;
                Program.InputStatus_PLC3.dlKhuTrung_07A_tripStatus = true;
                Program.InputStatus_PLC3.dlKhuTrung_07B_tripStatus = true;
                #endregion

                #region PHAO
                Program.InputStatus_PLC1.low_beGom_float = true; 
                Program.InputStatus_PLC1.medium_beGom_float = false;
                Program.InputStatus_PLC1.high_beGom_float = true;
                Program.InputStatus_PLC3.low_dieuHoa_float = true;
                Program.InputStatus_PLC3.high_dieuHoa_float = true;

                Program.InputStatus_PLC3.float_beBun05_float = true;
                Program.InputStatus_PLC3.float_beBun07_float = true;
                Program.InputStatus_PLC3.float_beBunSP10_float = true;
                #endregion
                */



                // Quan Trắc Nước Thải
                //RandomValue random_cod = new RandomValue();
                //random_cod.random_float(5.5f, 10.0f);
                /*
                Program.QuanTracIndex_PLC1.flowInTotal = 155.55f;
                Program.QuanTracIndex_PLC1.flowInCap = 15.55f;
                Program.QuanTracIndex_PLC1.flowOutTotal = 185.55f;
                Program.QuanTracIndex_PLC1.flowOutCap = 17.5f;

                Program.QuanTracIndex_PLC1.nh3_Index = 7.5f;
                Program.QuanTracIndex_PLC1.ph_Index = 6.5f;
                Program.QuanTracIndex_PLC1.cod_Index = 7.7f;
                Program.QuanTracIndex_PLC1.tss_Index = 10;
                Program.QuanTracIndex_PLC1.color_Index = 7;
                Program.QuanTracIndex_PLC1.temper_Index = 20.5f;


                // Biểu đồ quan trắc
                Program.QuanTracIndexLogger.codIndex_Tag.Value = 10.5f;
                Program.QuanTracIndexLogger.codIndex_Tag.Timestamp = DateTime.Now;

                Program.QuanTracIndexLogger.tssIndex_Tag.Value = 9.5f;
                Program.QuanTracIndexLogger.tssIndex_Tag.Timestamp = DateTime.Now;

                Program.QuanTracIndexLogger.phIndex_Tag.Value = 10.5f;
                Program.QuanTracIndexLogger.phIndex_Tag.Timestamp = DateTime.Now;

                Program.QuanTracIndexLogger.colorIndex_Tag.Value = 10.5f;
                Program.QuanTracIndexLogger.colorIndex_Tag.Timestamp = DateTime.Now;

                Program.QuanTracIndexLogger.temperIndex_Tag.Value = 10.5f;
                Program.QuanTracIndexLogger.temperIndex_Tag.Timestamp = DateTime.Now;

                Program.QuanTracIndexLogger.amoniIndex_Tag.Value = 10.5f;
                Program.QuanTracIndexLogger.amoniIndex_Tag.Timestamp = DateTime.Now;

                Program.QuanTracIndexLogger.flowOutTotalIndex_Tag.Value = 10.5f;
                Program.QuanTracIndexLogger.flowOutTotalIndex_Tag.Timestamp = DateTime.Now;

                */





                /*
                #region RUNTIME SETTING
                Program.RuntimeSetting_PLC2.mkt01_setTime = 107;
                Program.RuntimeSetting_PLC2.mkt02_setTime = 10;
                Program.RuntimeSetting_PLC2.mkt03_setTime = 5;
                Program.RuntimeSetting_PLC2.anoxic1_setTime = 15;
                Program.RuntimeSetting_PLC2.anoxic2_setTime = 15;
                Program.RuntimeSetting_PLC2.anoxic3_setTime = 15;
                Program.RuntimeSetting_PLC2.anoxic4_setTime= 15;
                Program.RuntimeSetting_PLC2.anoxic5_setTime= 15;
                 Program.RuntimeSetting_PLC2.anoxic6_setTime= 15;
                Program.RuntimeSetting_PLC2.anoxic7_setTime= 15;
                Program.RuntimeSetting_PLC2.anoxic8_setTime= 15;

                Program.RuntimeSetting_PLC3.bomBun_05AB_setTime_on= 15;
                Program.RuntimeSetting_PLC3.bomBun_05AB_setTime_off = 15;

                Program.RuntimeSetting_PLC1.beGom1_setTime= 15;
                Program.RuntimeSetting_PLC1.beGom2_setTime= 15;
                Program.RuntimeSetting_PLC1.beGom3_setTime= 15;

                Program.RuntimeSetting_PLC2.tuanHoan1_setTime= 15;
                Program.RuntimeSetting_PLC2.tuanHoan2_setTime= 15;
                Program.RuntimeSetting_PLC2.tuanHoan3_setTime= 15;

                Program.RuntimeSetting_PLC2.metanol_setTime_on= 15;
                Program.RuntimeSetting_PLC2.metanol_setTime_off= 15;

                Program.RuntimeSetting_PLC2.gatBun_setTime_on= 15;
                Program.RuntimeSetting_PLC2.gatBun_setTime_off= 15;

                Program.RuntimeSetting_PLC2.khuayNaoh_setTime_on= 15;
                Program.RuntimeSetting_PLC2.khuayNaoh_setTime_off= 15;

                Program.RuntimeSetting_PLC1.mtk01_setTime= 15;
                Program.RuntimeSetting_PLC1.mtk02_setTime= 15;
                Program.RuntimeSetting_PLC1.mtk03_setTime= 15;

                Program.RuntimeSetting_PLC3.bomBun_07AB_setTime_on= 15;
                Program.RuntimeSetting_PLC3.bomBun_07AB_setTime_off= 15;

                Program.RuntimeSetting_PLC1.dieuHoa1_setTime= 15;
                Program.RuntimeSetting_PLC1.dieuHoa2_setTime= 15;

                Program.RuntimeSetting_PLC2.bomBun_setTime_on= 15;
                Program.RuntimeSetting_PLC2.bomBun_setTime_off= 15;

                Program.RuntimeSetting_PLC1.dieuHoa1_setTime= 15;
                Program.RuntimeSetting_PLC1.dieuHoa2_setTime= 15;

                Program.RuntimeSetting_PLC3.mtk_AB06A_setTime= 15;
                Program.RuntimeSetting_PLC3.mtk_AB06B_setTime= 15;
                Program.RuntimeSetting_PLC3.mtk_AB06C_setTime= 15;

                Program.RuntimeSetting_PLC3.gbbl05_setTime_on= 15;
                Program.RuntimeSetting_PLC3.gbbl05_setTime_off= 15;

                Program.RuntimeSetting_PLC3.gbbl07_setTime_on= 15;
                Program.RuntimeSetting_PLC3.gbbl07_setTime_off= 15;

                Program.RuntimeSetting_PLC3.gbbl09_setTime_on= 15;
                Program.RuntimeSetting_PLC3.gbbl09_setTime_off= 15;
                #endregion
                */

                /*
                #region RUNTIME - GD1
                Program.Runtime_PLC1.dieuHoa1_runtime = 25;
                Program.Runtime_PLC1.dieuHoa2_runtime = 25;
                Program.Runtime_PLC1.tuanHoanNuoc_runtime = 25;
                Program.Runtime_PLC1.tuanHoanBun_runtime = 25;
                Program.Runtime_PLC1.bunHoaLy1_runtime = 25;
                Program.Runtime_PLC1.bunHoaLy2_runtime = 25;
                Program.Runtime_PLC1.beGom1_runtime = 25;
                Program.Runtime_PLC1.beGom2_runtime = 25;
                Program.Runtime_PLC1.beGom3_runtime = 25;
                Program.Runtime_PLC1.skbm1_runtime = 25;
                Program.Runtime_PLC1.skbm2_runtime = 25;
                Program.Runtime_PLC1.skbm3_runtime = 25;
                Program.Runtime_PLC1.mtk1_runtime = 25;
                Program.Runtime_PLC1.mtk2_runtime = 25;
                Program.Runtime_PLC1.mtk3_runtime = 25;
                Program.Runtime_PLC1.dlAxit_runtime = 25;
                Program.Runtime_PLC1.dlXut_runtime = 25;
                Program.Runtime_PLC1.dlNp_runtime = 25;
                Program.Runtime_PLC1.dlClo_runtime = 25;
                Program.Runtime_PLC1.dlPac_runtime = 25;
                Program.Runtime_PLC1.dlPolyme_runtime = 25;
                Program.Runtime_PLC1.khuayNp_runtime = 25;
                Program.Runtime_PLC1.khuayClo_runtime = 25;
                Program.Runtime_PLC1.khuayPac_runtime = 25;
                Program.Runtime_PLC1.khuayPolyme1_runtime = 25;
                Program.Runtime_PLC1.khuayPolyme2_runtime = 25;
                #endregion
                */
                /*
                #region RUNTIME - GD1MR
                Program.Runtime_PLC2.anoxic1_runtime = 15;  // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 1
                Program.Runtime_PLC2.anoxic2_runtime = 15; // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 2
                Program.Runtime_PLC2.anoxic3_runtime = 15; // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 3
                Program.Runtime_PLC2.anoxic4_runtime = 15; // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 4
                Program.Runtime_PLC2.anoxic5_runtime = 15; // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 5
                Program.Runtime_PLC2.anoxic6_runtime = 15; // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 6
                Program.Runtime_PLC2.anoxic7_runtime = 15; // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 7
                Program.Runtime_PLC2.anoxic8_runtime = 15; // Thời gian chạy "RUNTIME" bơm hóa chất Anoxic 8
                Program.Runtime_PLC2.etanol1_runtime = 15; // Thời gian chạy "RUNTIME" bơm hóa chất Etanol 1
                Program.Runtime_PLC2.etanol2_runtime = 15; // Thời gian chạy "RUNTIME" bơm hóa chất Etanol 2
                Program.Runtime_PLC2.metanol_runtime = 15; // Thời gian chạy "RUNTIME" bơm hóa chất Metanol "MT-ETN"
                Program.Runtime_PLC2.mkt01_runtime = 15; // Thời gian chạy "RUNTIME" máy thổi khí MKT1
                Program.Runtime_PLC2.mkt02_runtime = 15; // Thời gian chạy "RUNTIME" máy thổi khí MTK2
                Program.Runtime_PLC2.mkt03_runtime = 15; // Thời gian chạy "RUNTIME" máy thổi khí MTK3
                Program.Runtime_PLC2.tuanHoan1_runtime = 15; // Thời gian chạy "RUNTIME" bơm tuần hoàn 1 "TH1"
                Program.Runtime_PLC2.tuanHoan2_runtime = 15; // Thời gian chạy "RUNTIME" bơm tuần hoàn 2 "TH2"
                Program.Runtime_PLC2.tuanHoan3_runtime = 15; // Thời gian chạy "RUNTIME" bơm tuần hoàn 3 "TH3"
                Program.Runtime_PLC2.gatBun_runtime = 15; // Thời gian chạy "RUNTIME" gạt bùn "GB1"
                Program.Runtime_PLC2.bomBun1_runtime = 15; // Thời gian chạy "RUNTIME" bơm bùn 1
                Program.Runtime_PLC2.bomBun2_runtime = 15; // Thời gian chạy "RUNTIME" bơm bùn 2
                Program.Runtime_PLC2.khuayNaoh_runtime = 15; // Thời gian chạy "RUNTIME" khuấy NaoH
                Program.Runtime_PLC2.dlNaoh_runtime = 15; // Thời gian chạy "RUNTIME" định lượng NaoH
                Program.Runtime_PLC2.al2so4_1_runtime = 15; // Thời gian chạy "RUNTIME" bơm hóa chất AL2SO4 1.
                Program.Runtime_PLC2.al2so4_2_runtime = 15; // Thời gian chạy "RUNTIME" bơm hóa chất AL2SO4 2.
                #endregion

                #region RUNTIME - GD2
                Program.Runtime_PLC3.mayTachRac_runtime = 35; // Thời gian "RUNTIME" máy tách rác
                Program.Runtime_PLC3.bomNt_02A_runtime = 35; // Thời gian "RUNTIME" bơm nước thải 02A
                Program.Runtime_PLC3.bomNt_02B_runtime = 35; // Thời gian "RUNTIME" bơm nước thải 02B
                Program.Runtime_PLC3.mtk_AB06A_runtime = 35; // Thời gian "RUNTIME" máy thổi khí AB06A
                Program.Runtime_PLC3.mtk_AB06B_runtime = 35; // Thời gian "RUNTIME" máy thổi khí AB06B
                Program.Runtime_PLC3.mtk_AB06C_runtime = 35; // Thời gian "RUNTIME" máy thổi khí AB06C
                Program.Runtime_PLC3.khuayKeoTu_GD2_runtime = 35; // Thời gian "RUNTIME" khuấy keo tụ GD2
                Program.Runtime_PLC3.khuayTaoBong_A_runtime = 35; // Thời gian "RUNTIME" khuấy tạo bông A
                Program.Runtime_PLC3.khuayTaoBong_B_runtime = 35;  // Thời gian "RUNTIME" khuấy tạo bông B
                Program.Runtime_PLC3.gbbl05_runtime = 35; // Thời gian "RUNTIME" bơm hóa chất GBBL 05
                Program.Runtime_PLC3.gbbl07_runtime = 35; // Thời gian "RUNTIME" bơm hóa chất GBBL 07
                Program.Runtime_PLC3.gbbl09_runtime = 35; // Thời gian "RUNTIME" bơm hóa chất GBBL 09
                Program.Runtime_PLC3.khuayPac_GD2_runtime = 35; // Thời gian "RUNTIME" khuấy PAC GD2
                Program.Runtime_PLC3.khuayPoly_GD2_runtime = 35; // Thời gian "RUNTIME" khuấy Polyme GD2
                Program.Runtime_PLC3.bomBun_05A_runtime = 35; // Thời gian "RUNTIME" bơm bùn 05A
                Program.Runtime_PLC3.bomBun_05B_runtime = 35; // Thời gian "RUNTIME" bơm bùn 05B
                Program.Runtime_PLC3.bomBun_07A_runtime = 35; // Thời gian "RUNTIME" bơm bùn 07A
                Program.Runtime_PLC3.bomBun_07B_runtime = 35; // Thời gian "RUNTIME" bơm bùn 07B
                Program.Runtime_PLC3.bomBun_SP10_runtime = 35; // Thời gian "RUNTIME" bơm bùn SP10
                Program.Runtime_PLC3.dlPhen_03A_runtime = 35; // Thời gian "RUNTIME" bơm định lượng phèn 03A
                Program.Runtime_PLC3.dlPhen_03B_runtime = 35; // Thời gian "RUNTIME" bơm định lượng phèn 03B
                Program.Runtime_PLC3.dlPoly_04A_runtime = 35; // Thời gian "RUNTIME" bơm định lượng Polyme 04A
                Program.Runtime_PLC3.dlPoly_04B_runtime = 35; // Thời gian "RUNTIME" bơm định lượng Polyme 04B
                Program.Runtime_PLC3.dlXut_05A_runtime = 35; // Thời gian "RUNTIME" bơm hóa chất Xút 05A
                Program.Runtime_PLC3.dlXut_05B_runtime = 35; // Thời gian "RUNTIME" bơm hóa chất Xút 05B
                Program.Runtime_PLC3.dlDd_06A_runtime = 35; // Thời gian "RUNTIME" bơm hóa chất Dd 06A
                Program.Runtime_PLC3.dlDd_06B_runtime = 35; // Thời gian "RUNTIME" bơm hóa chất Dd 06B
                Program.Runtime_PLC3.dlKhuTrung_07A_runtime = 35; // Thời gian "RUNTIME" bơm hóa chất khử trùng 07A
                Program.Runtime_PLC3.dlKhuTrung_07B_runtime = 35; // Thời gian "RUNTIME" bơm hóa chất khử trùng 07B

                #endregion
                */


                #endregion
            }

            catch (Exception err)
            {
                //Console.WriteLine(err);
            }

            Application.Run(loginPage);

        }


    }
}
