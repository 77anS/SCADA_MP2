using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC1_RuntimeSettingUI
    {
        // SETTIME UI
        public short P101_bomBeGom1_setTime_ui { get; set; }
        public short P102_bomBeGom2_setTime_ui { get; set; }
        public short P103_bomBeGom3__setTime_ui { get; set; }
        public short P0201_bomDieuHoa1_setTime_ui { get; set; }
        public short P0202_bomDieuHoa2_setTime_ui { get; set; }
        public short MTK01_mayTKbeDieuHoa_setTime_ui { get; set; }
        public short MTK02_mayTKbeDieuHoa_setTime_ui { get; set; }
        public short MTK03_mayTKbeDieuHoa_setTime_ui { get; set; }
    }
}
