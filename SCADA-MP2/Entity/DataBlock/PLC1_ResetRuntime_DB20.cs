using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC1_ResetRuntime_DB20
    {
        public bool MTB_TuanHoanNuoc_resetCmd { get; set; } // Bơm tuần hoàn nước.
        public bool MTB_TuanHoanBun_resetCmd { get; set; } // Bơm tuần hoàn bùn.
        public bool SP09A_BunHoaLy1_resetCmd { get; set; } // Bùn hóa lý 1.
        public bool SP09B_BunHoaLy2_resetCmd { get; set; } // Bùn hóa lý 2.
        public bool P101_BeGom1_resetCmd { get; set; } // Bể gom 1.
        public bool P102_BeGom2_resetCmd { get; set; } // Bể gom 2.
        public bool P103_BeGom3_resetCmd { get; set; } // Bể gom 3.
        public bool P0201_bomDieuHoa1_resetCmd { get; set; } // Bơm điều hòa 1.
        public bool P0202_bomDieuHoa2_resetCmd { get; set; } // Bơm điều hòa 2.
        public bool SKBM1_noMean_resetCmd { get; set; } //???.
        public bool SKBM2_noMean_resetCmd { get; set; } //???.
        public bool SKBM3_noMean_resetCmd { get; set; } //???.
        public bool MTK01_mayTKBeDieuHoa_resetCmd { get; set; } // Máy thổi khí 01.
        public bool MTK02_mayTKBeDieuHoa_resetCmd { get; set; } // Máy thổi khí 02.
        public bool MTK03_mayTKBeDieuHoa_resetCmd { get; set; } // Máy thổi khí 03.
        public bool MTB_DlAxit_resetCmd { get; set; } // Định lượng hóa chất axit.
        public bool DP02_DlXut_resetCmd { get; set; } // Định lượng Xút.
        public bool DP03_DlNp_resetCmd { get; set; } // Định lượng NP.
        public bool DP04_DlClo_resetCmd { get; set; } // Định lượng Clo.
        public bool DP05_DlPac_resetCmd { get; set; } // Định lượng PAC.
        public bool DP06_1P1_DlPolyme_resetCmd { get; set; } // Định lượng Polyme.

        //public bool dlPolyme2_resetCmd { get; set; } // Định lượng Polyme 2

        public bool MT03_KhuayNp_resetCmd { get; set; } // Máy khuấy NP.
        public bool MT04_KhuayClo_resetCmd { get; set; } // Khuấy Clo.
        public bool MT05_KhuayPac_resetCmd { get; set; } // Khuấy PAC.
        public bool MT06_1P1_KhuayPoly1_resetCmd { get; set; } // Khuấy Polyme 1.
        public bool MT02_2P2_KhuayPoly2_resetCmd { get; set; } // Khuây Polyme 2.
    }
}
