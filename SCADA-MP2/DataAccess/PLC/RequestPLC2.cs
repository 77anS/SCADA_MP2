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
    public class RequestPLC2 : BaseClass_request
    {
        public RequestPLC2(B_SCADA_PLC plc) : base(plc)
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
            plc.ReadClass(Program.PLC2_DB63, 63, 0);
            plc.ReadClass(Program.PLC2_DB38, 38, 0);
            plc.ReadClass(Program.PLC2_DB39, 39, 0);
            plc.ReadClass(Program.PLC2_DB1, 1, 0);

        }
    }
}
