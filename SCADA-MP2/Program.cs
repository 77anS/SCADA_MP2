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
            BSCADA.AddPLC("PLC1", new BSCADA_PLC("PLC1", S7.Net.CpuType.S71200, "192.168.1.100", 0, 1, 250, BSCADA));
            BSCADA.AddPLC("PLC2", new BSCADA_PLC("PLC2", S7.Net.CpuType.S71200, "192.168.1.101", 0, 1, 250, BSCADA));
            BSCADA.AddPLC("PLC3", new BSCADA_PLC("PLC3", S7.Net.CpuType.S71200, "192.168.1.102", 0, 1, 250, BSCADA));
            //Add UI
            BSCADA.AddUI("homePage", homePage);
            // Add FacePlate:
            // Add Motor:
            BSCADA.AddMotor("mtk01", Program.HomePageData.mtk01);
            BSCADA.AddMotor("mtk02", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mtk03", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mtetn", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dpetn", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp03", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mt03", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mkt1", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mkt2", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mkt3", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mt05", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp05", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp06_1", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mt06_1", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("bb1", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("bb2", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("p0101", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("p0102", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("p0103", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("bs02a", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("p0201", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("p0202", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("wp02a", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("wp02b", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sm01", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sm02", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sm03", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sm04", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sm05", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sm06", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sm07", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sm08", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("th1", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("th2", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("th3", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("gb1", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mc04", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mc03", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp04a", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp04b", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp05a", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp05b", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp06a", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp06b", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mi03", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mi04a", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mi04b", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("ms05", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("ab06a", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("ab06b", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("ab06c", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("ms07", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mt02", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp02", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mt04", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp04", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mt02b", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mt02a", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mt-01", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sp10", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp04a_1", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp04a_2", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("ms09", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sp05a", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sp05b", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sp07a", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sp07b", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp07a", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp07b", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("sp11", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("ggb", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mc09", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp09a", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp09b", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp01", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("dp06_2", new BSCADA_Entity.Motor.Motor(BSCADA));
            BSCADA.AddMotor("mt06_2", new BSCADA_Entity.Motor.Motor(BSCADA));

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
