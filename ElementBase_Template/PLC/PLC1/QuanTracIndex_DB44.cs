using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.PLC.PLC1
{
    public class QuanTracIndex_DB44
    {

        public float cod_Index { get; set; }
        public float tss_Index { get; set; } // Read FLOW IN CAPACITY
        public float flowOutCap { get; set; }
        public float ph_Index { get; set; }
        public float color_Index { get; set; }
        public float temper_Index { get; set; }
        public float nh3_Index { get; set; }
        public float flowInCap { get; set; } // Read FLOW IN CAPACITY
        public float flowOutTotal { get; set; }
        public bool reset_flowOut_total { get; set; }
        public float flowInTotal { get; set; }
        public bool reset_flowIn_total { get; set; }

        //public float this[int i]
        //{
        //    get { return quanTrac[i]; } 
        //    set { quanTrac[i] = value; } 
        //}


        /// Cập nhật giá trị quan trắc môi trường
        //Input.flowInCap = (double)plc.Read(DataType.DataBlock,14,68,VarType.Real,1); // Read FLOW IN CAPACITY
        //Input.flowOutCap = (double)plc.Read(DataType.DataBlock, 14, 48, VarType.Real, 1); // Read FLOW OUT CAPACITY
        //Input.flowInTotal= (double)plc.Read(DataType.DataBlock, 14, 78, VarType.Real, 1); // Read FLOW IN TOTAL
        //Input.flowOutTotal = (double)plc.Read(DataType.DataBlock, 14, 72, VarType.Real, 1); // Read FLOW OUT TOTAL

        //Input.cod_Index = (double)plc.Read(DataType.DataBlock, 14, 40, VarType.Real, 1); // COD 
        //Input.tss_Index = (double)plc.Read(DataType.DataBlock, 14, 44, VarType.Real, 1); // TSS
        //Input.ph_Index = (double)plc.Read(DataType.DataBlock, 14, 52, VarType.Real, 1); // PH "MD512"
        //Input.color_Index = (double)plc.Read(DataType.DataBlock, 14, 56, VarType.Real, 1); // COLOR
        //Input.temper_Index = (double)plc.Read(DataType.DataBlock, 14, 60, VarType.Real, 1); // TEMPERATURE
        //Input.nh3_Index = (double)plc.Read(DataType.DataBlock, 14, 64, VarType.Real, 1); // NH3
    }
}
