using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.PLC.PLC1
{
    public class RuntimeSetting_DB16
    {
        /// Thời gian cài đặt runtime thực tế (GD1)
        /// Note: int (PLC) <=> KDL: short trong C#
        /// 
        public short beGom1_setTime { get; set; }
        public short beGom2_setTime { get; set; }
        public short beGom3_setTime { get; set; }
        public short dieuHoa1_setTime { get; set; }
        public short dieuHoa2_setTime { get; set; }
        public short mtk01_setTime { get; set; }
        public short mtk02_setTime { get; set; }
        public short mtk03_setTime { get; set; }

    }
}
