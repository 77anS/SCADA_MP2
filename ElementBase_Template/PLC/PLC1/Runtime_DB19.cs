using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.PLC.PLC1
{
    public class Runtime_DB19
    {

        /// Thời gian chạy RUNTIME thực tế (GD1)
        /// Note: Dint (PLC) <=> KDL: Int trong C#

        public int tuanHoanNuoc_runtime { get; set; }
        public int tuanHoanBun_runtime { get; set; }
        public int bunHoaLy1_runtime { get; set; }
        public int bunHoaLy2_runtime { get; set; }

        public int beGom1_runtime { get; set; }

        public int beGom2_runtime { get; set; }
        public int beGom3_runtime { get; set; }
        public int dieuHoa1_runtime { get; set; }
        public int dieuHoa2_runtime { get; set; }
        public int skbm1_runtime { get; set; }
        public int skbm2_runtime { get; set; }
        public int skbm3_runtime { get; set; }
        public int mtk1_runtime { get; set; }
        public int mtk2_runtime { get; set; }
        public int mtk3_runtime { get; set; }
        public int dlAxit_runtime { get; set; }
        public int dlXut_runtime { get; set; }
        public int dlNp_runtime { get; set; }
        public int dlClo_runtime { get; set; }
        public int dlPac_runtime { get; set; }
        public int dlPolyme_runtime { get; set; }
        public int khuayNp_runtime { get; set; }
        public int khuayClo_runtime { get; set; }
        public int khuayPac_runtime { get; set; }
        public int khuayPolyme1_runtime { get; set; }
        public int khuayPolyme2_runtime { get; set; }

    }
}
