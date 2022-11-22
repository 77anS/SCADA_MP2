using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using B_SCADA_Task = B_SCADA_Library_dotNetFramework.BaseClass.Task.Task;
using B_SCADA_PLC = B_SCADA_Library_dotNetFramework.EntityType.PLC.S7.PLC;
using Driver_plc = B_SCADA_Library_dotNetFramework.BaseClass.Driver.PLC;
namespace SCADA_MP2.DataAccess.PLC
{
    /// <summary>
    /// LỚP TASK: !IMPORTANT => CẦN PHẢI KHỞI TẠO 
    /// </summary>
    class Task : B_SCADA_Task
    {
        public B_SCADA_PLC PLC1;
        public B_SCADA_PLC PLC2;
        public B_SCADA_PLC PLC3;
        public RequestPLC1 requestPLC1;
        public RequestPLC2 requestPLC2;
        public RequestPLC3 requestPLC3;

        /// <summary>
        /// Khởi tạo
        /// </summary>
        public Task()
        {
            PLC1 = Program.B_SCADA.FindPLC("PLC1");
            PLC2 = Program.B_SCADA.FindPLC("PLC2");
            PLC3 = Program.B_SCADA.FindPLC("PLC3");

            requestPLC1 = new RequestPLC1(PLC1);
            requestPLC2 = new RequestPLC2(PLC2);
            requestPLC3 = new RequestPLC3(PLC3);
        }

        public override void readTask()
        {
            //base.readTask();
            if (PLC1 != null)
            {
                requestPLC1.detectPLC(PLC1.plc); // Gọi phương thức Read() ở lớp "RequestPLC1"
            }
            if (PLC2 != null)
            {
                requestPLC2.detectPLC(PLC2.plc);
            }
            if (PLC3 != null)
            {
                requestPLC3.detectPLC(PLC3.plc);
            }
        }
    }
}
