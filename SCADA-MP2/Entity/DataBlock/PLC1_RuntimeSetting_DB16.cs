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
        public short BeGom1_setTime { get; set; }
        public short BeGom2_setTime { get; set; }
        public short BeGom3_setTime { get; set; }
        public short DieuHoa1_setTime { get; set; }
        public short DieuHoa2_setTime { get; set; }
        public short Mtk01_setTime { get; set; }
        public short Mtk02_setTime { get; set; }
        public short Mtk03_setTime { get; set; }
    }
}
