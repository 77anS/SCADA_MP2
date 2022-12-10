using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC1_RuntimeSetting_DB16
    {
        /// Thời gian cài đặt runtime thực tế (GD1)
        /// Note: int (PLC) <=> KDL: short trong C#
        /// 
        public short P101_bomBeGom1_setTime { get; set; }
        public short P102_bomBeGom2_setTime { get; set; }
        public short P103_BeGom3_setTime { get; set; }
        public short P0201_bomDieuHoa1_setTime { get; set; }
        public short P0202_bomDieuHoa2_setTime { get; set; }
        public short MTK01_mayTKbeDieuHoa_setTime { get; set; }
        public short Mtk02_mayTKbeDieuHoa_setTime { get; set; }
        public short Mtk03_mayTKbeDieuHoa_setTime { get; set; }
    }
}
