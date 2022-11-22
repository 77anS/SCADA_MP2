using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using B_SCADA_PLC = B_SCADA_Library_dotNetFramework.EntityType.PLC.S7.PLC;
using BaseClass_request = B_SCADA_Library_dotNetFramework.BaseClass.Driver.PLC.SIMATIC_S7.Request;
using S7.Net;
namespace SCADA_MP2.DataAccess.PLC
{
    public class RequestPLC3 : BaseClass_request
    {
        public RequestPLC3(B_SCADA_PLC plc) : base(plc)
        {

        }

        public override void detectPLC(Plc plc)
        {
            base.detectPLC(plc);
        }

        public override void Read(Plc plc)
        {
            //base.Read();
            // Read data to class: Mapping
            plc.ReadClass(Program.PLC3_DB55, 55, 0);
            plc.ReadClass(Program.PLC3_DB25, 25, 0);
            plc.ReadClass(Program.PLC3_DB24, 24, 0);
            plc.ReadClass(Program.PLC3_DB19, 19, 0);

        }
    }
}
