using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using BSCADA = B_SCADA_Library_dotNetFramework.EntityType.SCADA.SCADA;
using BSCADA_Page = SCADA_MP2.Presentation;
using BSCADA_PLC = B_SCADA_Library_dotNetFramework.EntityType.PLC.S7.PLC;
using BSCADA_DataBlock = SCADA_MP2.Entity.DataBlock;
using BSCADA_Entity_dotNet = B_SCADA_Library_dotNetFramework.EntityType;
using BSCADA_Entity = SCADA_MP2.Entity;
namespace SCADA_MP2
{
    static class Program
    {
        #region FIELDS
        // ROOT:
        public static BSCADA BSCADA; // Class "SCADA"
        // UI:
        public static BSCADA_Page.Frame App; // Frame
        public static BSCADA_Page.Home homePage; // Home page
        public static BSCADA_Page.LineChart monitoringIndexPage;
        public static BSCADA_Page.Report reportPage;
        public static BSCADA_Page.InfoDeviceList infoPage;
        // DataBlock:
        public static BSCADA_DataBlock.PLC1_InputStatus_DB43 PLC1_DB43_InputStatus;
        public static BSCADA_DataBlock.PLC1_QuanTracIndex_DB44 PLC1_DB44_QuanTracIndex;
        public static BSCADA_DataBlock.PLC1_ResetRuntime_DB20 PLC1_DB20_ResetRuntime;
        public static BSCADA_DataBlock.PLC1_RuntimeSettingUI PLC1_RuntimeSettingUI;
        public static BSCADA_DataBlock.PLC1_RuntimeSetting_DB16 PLC1_DB16_RuntimeSetting;
        public static BSCADA_DataBlock.PLC1_Runtime_DB19 PLC1_DB19_Runtime;
        public static BSCADA_DataBlock.PLC2_InputStatus_DB63 PLC2_DB63_InputStatus;
        public static BSCADA_DataBlock.PLC2_ResetRuntime_DB38 PLC2_DB38_ResetRuntime;
        public static BSCADA_DataBlock.PLC2_RuntimeSettingUI PLC2_RuntimeSettingUI;
        public static BSCADA_DataBlock.PLC2_RuntimeSetting_DB1 PLC2_DB1_RuntimeSetting;
        public static BSCADA_DataBlock.PLC2_Runtime_DB39 PLC2_DB39_Runtime;
        public static BSCADA_DataBlock.PLC3_InputStatus_DB55 PLC3_DB55_InputStatus;
        public static BSCADA_DataBlock.PLC3_ResetRuntime_DB25 PLC3_DB25_ResetRuntime;
        public static BSCADA_DataBlock.PLC3_RuntimeSettingUI PLC3_RuntimeSettingUI;
        public static BSCADA_DataBlock.PLC3_RuntimeSetting_DB19 PLC3_DB19_RuntimeSetting;
        public static BSCADA_DataBlock.PLC3_Runtime_DB24 PLC3_DB24_Runtime;

        public static BSCADA_Entity.DataMapping.Page_Home HomePageData;
        // Log Data:
        #endregion

        #region METHOD - MAIN
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region CALL-FIRST
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #endregion

            Initializing();
            AddEntityToBSCADA();
            // Active Task READ DATABLOCK:
            BSCADA.FindTask("PLCDataTask").runTask_read();

            Application.Run(App);
        }

        public static void Initializing()
        {
            // UI:
            App = new BSCADA_Page.Frame();
            homePage = new BSCADA_Page.Home();
            monitoringIndexPage = new BSCADA_Page.LineChart();
            reportPage = new BSCADA_Page.Report();
            infoPage = new BSCADA_Page.InfoDeviceList();
            // ROOT:
            BSCADA = new BSCADA();
            // Data Block:
            PLC1_DB43_InputStatus = new BSCADA_DataBlock.PLC1_InputStatus_DB43();
            PLC1_DB44_QuanTracIndex = new BSCADA_DataBlock.PLC1_QuanTracIndex_DB44();
            PLC1_DB20_ResetRuntime = new BSCADA_DataBlock.PLC1_ResetRuntime_DB20();
            PLC1_RuntimeSettingUI = new BSCADA_DataBlock.PLC1_RuntimeSettingUI();
            PLC1_DB16_RuntimeSetting = new BSCADA_DataBlock.PLC1_RuntimeSetting_DB16();
            PLC1_DB19_Runtime = new BSCADA_DataBlock.PLC1_Runtime_DB19();
            PLC2_DB63_InputStatus = new BSCADA_DataBlock.PLC2_InputStatus_DB63();
            PLC2_DB38_ResetRuntime = new BSCADA_DataBlock.PLC2_ResetRuntime_DB38();
            PLC2_RuntimeSettingUI = new BSCADA_DataBlock.PLC2_RuntimeSettingUI();
            PLC2_DB1_RuntimeSetting = new BSCADA_DataBlock.PLC2_RuntimeSetting_DB1();
            PLC2_DB39_Runtime = new BSCADA_DataBlock.PLC2_Runtime_DB39();
            PLC3_DB55_InputStatus = new BSCADA_DataBlock.PLC3_InputStatus_DB55();
            PLC3_DB25_ResetRuntime = new BSCADA_DataBlock.PLC3_ResetRuntime_DB25();
            PLC3_RuntimeSettingUI = new BSCADA_DataBlock.PLC3_RuntimeSettingUI();
            PLC3_DB19_RuntimeSetting = new BSCADA_DataBlock.PLC3_RuntimeSetting_DB19();
            PLC3_DB24_Runtime = new BSCADA_DataBlock.PLC3_Runtime_DB24();
            //DATA FOR MAPPING:
            HomePageData = new BSCADA_Entity.DataMapping.Page_Home();
        }
        public static void AddEntityToBSCADA()
        {
            // Add PLC:
            BSCADA.AddPLC("PLC1", new BSCADA_PLC("PLC1", S7.Net.CpuType.S71200, "192.168.0.3", 0, 1, 250, BSCADA));
            BSCADA.AddPLC("PLC2", new BSCADA_PLC("PLC2", S7.Net.CpuType.S71200, "192.168.1.101", 0, 1, 250, BSCADA));
            BSCADA.AddPLC("PLC3", new BSCADA_PLC("PLC3", S7.Net.CpuType.S71200, "192.168.1.102", 0, 1, 250, BSCADA));
            //Add UI
            BSCADA.AddUI("homePage", homePage);
            // Add FacePlate:
            // Add Motor:
            BSCADA.AddMotor("mtk01", Program.HomePageData.mtk01);
            BSCADA.AddMotor("mtk02", Program.HomePageData.mtk02);
            BSCADA.AddMotor("mtk03", Program.HomePageData.mtk03);
            BSCADA.AddMotor("mtetn", Program.HomePageData.mtetn);
            BSCADA.AddMotor("dpetn", Program.HomePageData.dpetn);
            BSCADA.AddMotor("dp03", Program.HomePageData.dp03);
            BSCADA.AddMotor("mt03", Program.HomePageData.mt03);
            BSCADA.AddMotor("mkt1", Program.HomePageData.mkt1);
            BSCADA.AddMotor("mkt2", Program.HomePageData.mkt2);
            BSCADA.AddMotor("mkt3", Program.HomePageData.mkt3);
            BSCADA.AddMotor("mt05", Program.HomePageData.mt05);
            BSCADA.AddMotor("dp05", Program.HomePageData.dp05);
            BSCADA.AddMotor("dp06_1", Program.HomePageData.dp06_1);
            BSCADA.AddMotor("mt06_1", Program.HomePageData.mt06_1);
            BSCADA.AddMotor("bb1", Program.HomePageData.bb1);
            BSCADA.AddMotor("bb2", Program.HomePageData.bb2);
            BSCADA.AddMotor("p0101", Program.HomePageData.p0101);
            BSCADA.AddMotor("p0102", Program.HomePageData.p0102);
            BSCADA.AddMotor("p0103", Program.HomePageData.p0103);
            BSCADA.AddMotor("bs02a", Program.HomePageData.bs02a);
            BSCADA.AddMotor("p0201", Program.HomePageData.p0201);
            BSCADA.AddMotor("p0202", Program.HomePageData.p0202);
            BSCADA.AddMotor("wp02a", Program.HomePageData.wp02a);
            BSCADA.AddMotor("wp02b", Program.HomePageData.wp02b);
            BSCADA.AddMotor("sm01", Program.HomePageData.sm01);
            BSCADA.AddMotor("sm02", Program.HomePageData.sm02);
            BSCADA.AddMotor("sm03", Program.HomePageData.sm03);
            BSCADA.AddMotor("sm04", Program.HomePageData.sm04);
            BSCADA.AddMotor("sm05", Program.HomePageData.sm05);
            BSCADA.AddMotor("sm06", Program.HomePageData.sm06);
            BSCADA.AddMotor("sm07", Program.HomePageData.sm07);
            BSCADA.AddMotor("sm08", Program.HomePageData.sm08);
            BSCADA.AddMotor("th1", Program.HomePageData.th1);
            BSCADA.AddMotor("th2", Program.HomePageData.th2);
            BSCADA.AddMotor("th3", Program.HomePageData.th3);
            BSCADA.AddMotor("gb1", Program.HomePageData.gb1);
            BSCADA.AddMotor("mc04", Program.HomePageData.mc04);
            BSCADA.AddMotor("mc03", Program.HomePageData.mc03);
            BSCADA.AddMotor("dp04a", Program.HomePageData.dp04a);
            BSCADA.AddMotor("dp04b", Program.HomePageData.dp04b);
            BSCADA.AddMotor("dp05a", Program.HomePageData.dp05a);
            BSCADA.AddMotor("dp05b", Program.HomePageData.dp05b);
            BSCADA.AddMotor("dp06a", Program.HomePageData.dp06a);
            BSCADA.AddMotor("dp06b", Program.HomePageData.dp06b);
            BSCADA.AddMotor("mi03", Program.HomePageData.mi03);
            BSCADA.AddMotor("mi04a", Program.HomePageData.mi04a);
            BSCADA.AddMotor("mi04b", Program.HomePageData.mi04b);
            BSCADA.AddMotor("ms05", Program.HomePageData.ms05);
            BSCADA.AddMotor("ab06a", Program.HomePageData.ab06a);
            BSCADA.AddMotor("ab06b", Program.HomePageData.ab06b);
            BSCADA.AddMotor("ab06c", Program.HomePageData.ab06c);
            BSCADA.AddMotor("ms07", Program.HomePageData.ms07);
            BSCADA.AddMotor("mt02", Program.HomePageData.mt02);
            BSCADA.AddMotor("dp02", Program.HomePageData.dp02);
            BSCADA.AddMotor("mt04", Program.HomePageData.mt04);
            BSCADA.AddMotor("dp04", Program.HomePageData.dp04);
            BSCADA.AddMotor("mt02b", Program.HomePageData.mt02b);
            BSCADA.AddMotor("mt02a", Program.HomePageData.mt02a);
            BSCADA.AddMotor("mt-01", Program.HomePageData.mt01);
            BSCADA.AddMotor("sp10", Program.HomePageData.sp10);
            BSCADA.AddMotor("dp04a_1", Program.HomePageData.dp04a_1);
            BSCADA.AddMotor("dp04a_2", Program.HomePageData.dp04a_2);
            BSCADA.AddMotor("ms09", Program.HomePageData.ms09);
            BSCADA.AddMotor("sp05a", Program.HomePageData.sp05a);
            BSCADA.AddMotor("sp05b", Program.HomePageData.sp05b);
            BSCADA.AddMotor("sp07a", Program.HomePageData.sp07a);
            BSCADA.AddMotor("sp07b", Program.HomePageData.sp07b);
            BSCADA.AddMotor("dp07a", Program.HomePageData.dp07a);
            BSCADA.AddMotor("dp07b", Program.HomePageData.dp07b);
            BSCADA.AddMotor("sp11", Program.HomePageData.sp11);
            BSCADA.AddMotor("ggb", Program.HomePageData.ggb);
            BSCADA.AddMotor("mc09", Program.HomePageData.mc09);
            BSCADA.AddMotor("dp09a", Program.HomePageData.dp09a);
            BSCADA.AddMotor("dp09b", Program.HomePageData.dp09b);
            BSCADA.AddMotor("dp01", Program.HomePageData.dp01);
            BSCADA.AddMotor("dp06_2", Program.HomePageData.dp06_2);
            BSCADA.AddMotor("mt06_2", Program.HomePageData.mt06_2);

            // Add Sensor:
            BSCADA.AddSensor("hl01", new BSCADA_Entity_dotNet.Sensor.Sensor(BSCADA));
            BSCADA.AddSensor("ml01", new BSCADA_Entity_dotNet.Sensor.Sensor(BSCADA));
            BSCADA.AddSensor("ll101", new BSCADA_Entity_dotNet.Sensor.Sensor(BSCADA));
            BSCADA.AddSensor("hl201", new BSCADA_Entity_dotNet.Sensor.Sensor(BSCADA));
            BSCADA.AddSensor("ll201", new BSCADA_Entity_dotNet.Sensor.Sensor(BSCADA));
            BSCADA.AddSensor("hl10", new BSCADA_Entity_dotNet.Sensor.Sensor(BSCADA));
            BSCADA.AddSensor("hl05", new BSCADA_Entity_dotNet.Sensor.Sensor(BSCADA));
            BSCADA.AddSensor("hl07", new BSCADA_Entity_dotNet.Sensor.Sensor(BSCADA));

            // Add Task:
            BSCADA.AddTask("PLCDataTask", (new SCADA_MP2.DataAccess.PLC.Task(1000, BSCADA)));
            //B_SCADA.AddTask("chartPageTask", new B_SCADA_task());
            //B_SCADA.AddTask("reportPageTask", new B_SCADA_task());
            //B_SCADA.AddTask("maintaiPageTask", new B_SCADA_task());
            //B_SCADA.AddTask("settingPageTask", new B_SCADA_task());
            //B_SCADA.AddTask("alarmPageTask", new B_SCADA_task());
            //B_SCADA.AddTask("infoPageTask", new B_SCADA_task());

            // Add BackWorker
            BSCADA.AddBackWorker("BackWorker_Home", homePage.backWorker);
        }
        #endregion
    }
}
