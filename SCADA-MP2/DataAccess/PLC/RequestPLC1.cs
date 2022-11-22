using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using S7.Net;
using B_SCADA_PLC =  B_SCADA_Library_dotNetFramework.EntityType.PLC.S7.PLC;
using BaseClass_request = B_SCADA_Library_dotNetFramework.BaseClass.Driver.PLC.SIMATIC_S7.Request;
namespace SCADA_MP2.DataAccess.PLC
{
    public class RequestPLC1 : BaseClass_request
    {
        public RequestPLC1(B_SCADA_PLC plc): base(plc)
        {

        }
        public override void detectPLC(Plc plc)
        {
            base.detectPLC(plc); // Gọi phương thức "Read" bên dưới
        }
        public override void Read(Plc plc)
        {
            //base.Read();
            // READ DATA: to CLASS AT PLC:
            plc.ReadClass(Program.PLC1_DB43, 43, 0);
            plc.ReadClass(Program.PLC1_DB20, 20, 0);
            plc.ReadClass(Program.PLC1_DB19, 19, 0);
            plc.ReadClass(Program.PLC1_DB16, 16, 0);
            //plc.ReadClass(QuanTracIndex_PLC1, 44, 0);

        }
    }
}
