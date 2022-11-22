using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC1_Runtime_DB19
    {
        /// Thời gian chạy RUNTIME thực tế (GD1)
        /// Note: Dint (PLC) <=> KDL: Int trong C#
        public int TuanHoanNuoc_runtime { get; set; }
        public int TuanHoanBun_runtime { get; set; }
        public int BunHoaLy1_runtime { get; set; }
        public int BunHoaLy2_runtime { get; set; }
        public int BeGom1_runtime { get; set; }
        public int BeGom2_runtime { get; set; }
        public int BeGom3_runtime { get; set; }
        public int DieuHoa1_runtime { get; set; }
        public int DieuHoa2_runtime { get; set; }
        public int Skbm1_runtime { get; set; }
        public int Skbm2_runtime { get; set; }
        public int Skbm3_runtime { get; set; }
        public int Mtk1_runtime { get; set; }
        public int Mtk2_runtime { get; set; }
        public int Mtk3_runtime { get; set; }
        public int DlAxit_runtime { get; set; }
        public int DlXut_runtime { get; set; }
        public int DlNp_runtime { get; set; }
        public int DlClo_runtime { get; set; }
        public int DlPac_runtime { get; set; }
        public int DlPolyme_runtime { get; set; }
        public int KhuayNp_runtime { get; set; }
        public int KhuayClo_runtime { get; set; }
        public int KhuayPac_runtime { get; set; }
        public int KhuayPolyme1_runtime { get; set; }
        public int KhuayPolyme2_runtime { get; set; }
    }
}
