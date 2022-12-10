using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BSCADA_PLC = B_SCADA_Library_dotNetFramework.EntityType.PLC.S7.PLC;
using Driver_Request = B_SCADA_Library_dotNetFramework.BaseClass.Driver.PLC.SIMATIC_S7.Request;
using S7.Net;
namespace SCADA_MP2.DataAccess.PLC
{
    public class RequestPLC2 : Driver_Request
    {
        public RequestPLC2(BSCADA_PLC plc) : base(plc)
        {

        }
        public override void readPLC(Plc plc)
        {
            base.readPLC(plc);
        }
        public override void Read(Plc plc)
        {
            //base.Read();

            // Read data to class: Mapping
            plc.ReadClass(Program.PLC2_DB63_InputStatus, 63, 0);
            plc.ReadClass(Program.PLC2_DB38_ResetRuntime, 38, 0);
            plc.ReadClass(Program.PLC2_DB39_Runtime, 39, 0);
            plc.ReadClass(Program.PLC2_DB1_RuntimeSetting, 1, 0);

        }
    }
}
