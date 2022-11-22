using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC1_QuanTracIndex_DB44
    {
        public float Cod_Index { get; set; }
        public float Tss_Index { get; set; } // Read FLOW IN CAPACITY
        public float FlowOutCap { get; set; }
        public float Ph_Index { get; set; }
        public float Color_Index { get; set; }
        public float Temper_Index { get; set; }
        public float Nh3_Index { get; set; }
        public float FlowInCap { get; set; } // Read FLOW IN CAPACITY
        public float FlowOutTotal { get; set; }
        public bool Reset_flowOut_total { get; set; }
        public float FlowInTotal { get; set; }
        public bool Reset_flowIn_total { get; set; }
    }
}
