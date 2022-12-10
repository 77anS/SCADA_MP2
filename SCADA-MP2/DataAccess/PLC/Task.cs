using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BSCADA_Task = B_SCADA_Library_dotNetFramework.BaseClass.Task.Task;
using BSCADA_PLC = B_SCADA_Library_dotNetFramework.EntityType.PLC.S7.PLC;
using Driver_plc = B_SCADA_Library_dotNetFramework.BaseClass.Driver.PLC;
using B_SCADA_Library_dotNetFramework.BaseClass.File;
using System.Reflection;
using System.IO;
namespace SCADA_MP2.DataAccess.PLC
{
    /// <summary>
    /// LỚP TASK: !IMPORTANT => CẦN PHẢI KHỞI TẠO 
    /// </summary>
    class Task : BSCADA_Task
    {
        public BSCADA_PLC PLC1;
        public BSCADA_PLC PLC2;
        public BSCADA_PLC PLC3;
        public RequestPLC1 requestPLC1;
        public RequestPLC2 requestPLC2;
        public RequestPLC3 requestPLC3;

        /// <summary>
        /// Khởi tạo
        /// </summary>
        public Task() : base()
        {
            PLC1 = Program.BSCADA.FindPLC("PLC1");
            PLC2 = Program.BSCADA.FindPLC("PLC2");
            PLC3 = Program.BSCADA.FindPLC("PLC3");

            requestPLC1 = new RequestPLC1(PLC1);
            requestPLC2 = new RequestPLC2(PLC2);
            requestPLC3 = new RequestPLC3(PLC3);
        }
        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        /// <param name="period">Chu kỳ Task</param>
        /// <param name="_parent">Container</param>
        public Task(int period, object _parent) : base(period, _parent)
        {
            PLC1 = Program.BSCADA.FindPLC("PLC1");
            PLC2 = Program.BSCADA.FindPLC("PLC2");
            PLC3 = Program.BSCADA.FindPLC("PLC3");

            requestPLC1 = new RequestPLC1(PLC1);
            requestPLC2 = new RequestPLC2(PLC2);
            requestPLC3 = new RequestPLC3(PLC3);
        }
        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        /// <param name="period">Chu kỳ</param>
        /// <param name="autoReset">Lặp lại: True</param>
        /// <param name="_parent">Container</param>
        public Task(int period, bool autoReset, object _parent) : base(period,autoReset, _parent)
        {
            PLC1 = Program.BSCADA.FindPLC("PLC1");
            PLC2 = Program.BSCADA.FindPLC("PLC2");
            PLC3 = Program.BSCADA.FindPLC("PLC3");

            requestPLC1 = new RequestPLC1(PLC1);
            requestPLC2 = new RequestPLC2(PLC2);
            requestPLC3 = new RequestPLC3(PLC3);
        }

        public override void readTask()
        {
            //base.readTask();
            try
            {
                if (PLC1 != null)
                {
                    requestPLC1.readPLC(PLC1.plc); // Gọi phương thức Read() ở lớp "RequestPLC1"
                }
                if (PLC2 != null)
                {
                    requestPLC2.readPLC(PLC2.plc);
                }
                if (PLC3 != null)
                {
                    requestPLC3.readPLC(PLC3.plc);
                }
            }
            catch(Exception err)
            {
                // Logs sự kiện vào DataBase/ Log files:
                FileText SysHisData = new FileText();
                //SysHisData.OpenNCreate(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SystemHistoryData");
                //SysHisData.WriteLine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SystemHistoryData", err.Message);

                //Console.WriteLine("ERR: " + err.Message);
                SysHisData.OpenNCreate(SysHisData.DefaultPath, "SystemHistoryData");
                SysHisData.WriteLine(SysHisData.DefaultPath, "SystemHistoryData", err.Message + "[Stack:"+ err.StackTrace + "]");
            }

        }
    }
}
