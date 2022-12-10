using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using S7.Net;
using BSCADA_PLC =  B_SCADA_Library_dotNetFramework.EntityType.PLC.S7.PLC;
using Driver_Request = B_SCADA_Library_dotNetFramework.BaseClass.Driver.PLC.SIMATIC_S7.Request;
namespace SCADA_MP2.DataAccess.PLC
{
    public class RequestPLC1 : Driver_Request
    {
        public RequestPLC1(BSCADA_PLC plc): base(plc)
        {

        }
        public override void readPLC(Plc plc)
        {
            base.readPLC(plc); // Gọi phương thức "Read" bên dưới
        }
        public override void Read(Plc plc)
        {
            //base.Read();

            // READ DATA: to CLASS AT PLC:
            plc.ReadClass(Program.PLC1_DB43_InputStatus, 43, 0);
            plc.ReadClass(Program.PLC1_DB20_ResetRuntime, 20, 0);
            plc.ReadClass(Program.PLC1_DB19_Runtime, 19, 0);
            plc.ReadClass(Program.PLC1_DB16_RuntimeSetting, 16, 0);
            //plc.ReadClass(QuanTracIndex_PLC1, 44, 0);

        }
    }
}
