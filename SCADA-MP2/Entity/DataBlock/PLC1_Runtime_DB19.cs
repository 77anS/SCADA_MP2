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
        public int MTB_bomTuanHoanNuoc_runtime { get; set; }
        public int MTB_bomTuanHoanBun_runtime { get; set; }
        public int SP09A_BunHoaLy1_runtime { get; set; }
        public int SP09B_BunHoaLy2_runtime { get; set; }
        public int P101_bomBeGom1_runtime { get; set; }
        public int P102_bomBeGom2_runtime { get; set; }
        public int P103_bomBeGom3_runtime { get; set; }
        public int P0201_bomDieuHoa1_runtime { get; set; }
        public int P0202_bomDieuHoa2_runtime { get; set; }
        public int SKBM1_noMean_runtime { get; set; }
        public int SKBM2_noMean_runtime { get; set; }
        public int SKBM3_noMean_runtime { get; set; }
        public int MTK01_mayTKBeDieuHoa_runtime { get; set; }
        public int MTK02_mayTKBeDieuHoa_runtime { get; set; }
        public int MTK03_mayTKBeDieuHoa_runtime { get; set; }
        public int MTB_DlAxit_runtime { get; set; }
        public int DP02_DlXut_runtime { get; set; }
        public int DP03_DlNp_runtime { get; set; }
        public int DP04_DlClo_runtime { get; set; }
        public int DP06_1P2_DlPac_runtime { get; set; }
        public int DP06_2P2_DlPolyme_runtime { get; set; }
        public int MT03_KhuayNp_runtime { get; set; }
        public int MT04_KhuayClo_runtime { get; set; }
        public int MT05_KhuayPac_runtime { get; set; }
        public int MT06_KhuayPolyme1_runtime { get; set; }
        public int MT02_KhuayPolyme2_runtime { get; set; }
    }
}
