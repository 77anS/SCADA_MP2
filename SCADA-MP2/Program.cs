using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using SCADA_page = SCADA_MP2.Presentation;
using SCADA_frame = SCADA_MP2.Presentation.Frame;
using B_SCADA = B_SCADA_Library_dotNetFramework.EntityType.SCADA.SCADA;
using B_SCADA_PLC = B_SCADA_Library_dotNetFramework.EntityType.PLC.S7.PLC;
using DataBlock = SCADA_MP2.Entity.DataBlock;
namespace SCADA_MP2
{
    static class Program
    {
        public static SCADA_frame App; // Frame
        public static SCADA_page.Home homePage; // Home page
        public static B_SCADA B_SCADA; // Class "SCADA"
        // DataBlock
        public static DataBlock.PLC1_InputStatus_DB43 PLC1_DB43;
        public static DataBlock.PLC1_QuanTracIndex_DB44 PLC1_DB44;
        public static DataBlock.PLC1_ResetRuntime_DB20 PLC1_DB20;
        public static DataBlock.PLC1_RuntimeSettingUI PLC1_RuntimeSettingUI;
        public static DataBlock.PLC1_RuntimeSetting_DB16 PLC1_DB16;
        public static DataBlock.PLC1_Runtime_DB19 PLC1_DB19;
        public static DataBlock.PLC2_InputStatus_DB63 PLC2_DB63;
        public static DataBlock.PLC2_ResetRuntime_DB38 PLC2_DB38;
        public static DataBlock.PLC2_RuntimeSettingUI PLC2_RuntimeSettingUI;
        public static DataBlock.PLC2_RuntimeSetting_DB1 PLC2_DB1;
        public static DataBlock.PLC2_Runtime_DB39 PLC2_DB39;
        public static DataBlock.PLC3_InputStatus_DB55 PLC3_DB55;
        public static DataBlock.PLC3_ResetRuntime_DB25 PLC3_DB25;
        public static DataBlock.PLC3_RuntimeSettingUI PLC3_RuntimeSettingUI;
        public static DataBlock.PLC3_RuntimeSetting_DB19 PLC3_DB19;
        public static DataBlock.PLC3_Runtime_DB24 PLC3_DB24;

        #region METHOD (MAIN)
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

            App = new SCADA_frame();
            homePage = new SCADA_page.Home();
            B_SCADA = new B_SCADA();

            // Data Block
            PLC1_DB43 = new DataBlock.PLC1_InputStatus_DB43();
            PLC1_DB44 = new DataBlock.PLC1_QuanTracIndex_DB44();
            PLC1_DB20 = new DataBlock.PLC1_ResetRuntime_DB20();
            PLC1_RuntimeSettingUI = new DataBlock.PLC1_RuntimeSettingUI();
            PLC1_DB16 = new DataBlock.PLC1_RuntimeSetting_DB16();
            PLC1_DB19 = new DataBlock.PLC1_Runtime_DB19();
            PLC2_DB63 = new DataBlock.PLC2_InputStatus_DB63();
            PLC2_DB38 = new DataBlock.PLC2_ResetRuntime_DB38();
            PLC2_RuntimeSettingUI = new DataBlock.PLC2_RuntimeSettingUI();
            PLC2_DB1 = new DataBlock.PLC2_RuntimeSetting_DB1();
            PLC2_DB39 = new DataBlock.PLC2_Runtime_DB39();
            PLC3_DB55 = new DataBlock.PLC3_InputStatus_DB55();
            PLC3_DB25 = new DataBlock.PLC3_ResetRuntime_DB25();
            PLC3_RuntimeSettingUI = new DataBlock.PLC3_RuntimeSettingUI();
            PLC3_DB19 = new DataBlock.PLC3_RuntimeSetting_DB19();
            PLC3_DB24 = new DataBlock.PLC3_Runtime_DB24();


            /// Add Task
            B_SCADA.AddTask("PLCDataTask", new SCADA_MP2.DataAccess.PLC.Task());
            B_SCADA.AddTask("homePageTask",new BusinessLogic.HomePage.Task());
            //B_SCADA.AddTask("chartPageTask", new B_SCADA_task());
            //B_SCADA.AddTask("reportPageTask", new B_SCADA_task());
            //B_SCADA.AddTask("maintaiPageTask", new B_SCADA_task());
            //B_SCADA.AddTask("settingPageTask", new B_SCADA_task());
            //B_SCADA.AddTask("alarmPageTask", new B_SCADA_task());
            //B_SCADA.AddTask("infoPageTask", new B_SCADA_task());
            //Add UI
            B_SCADA.AddUI("homePage",homePage);
            // Add FacePlate
            // Add PLC
            B_SCADA.AddPLC("PLC1", new B_SCADA_PLC("PLC1", S7.Net.CpuType.S71200, "192.168.1.100", 0, 1, 250));
            B_SCADA.AddPLC("PLC2", new B_SCADA_PLC("PLC2", S7.Net.CpuType.S71200, "192.168.1.101", 0, 1, 250));
            B_SCADA.AddPLC("PLC3", new B_SCADA_PLC("PLC3", S7.Net.CpuType.S71200, "192.168.1.102", 0, 1, 250));
            // Add Motor
            // Add Pump
            // Add Sensor

            // Active Task READ DATABLOCK
            B_SCADA.FindTask("PLCDataTask").runTask_read();

            Application.Run(App);
        }
        #endregion
    }
}
