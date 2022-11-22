using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.DataBlock
{
    class PLC1_ResetRuntime_DB20
    {
        public bool TuanHoanNuoc_resetCmd { get; set; } // Bơm tuần hoàn nước.
        public bool TuanHoanBun_resetCmd { get; set; } // Bơm tuần hoàn bùn.
        public bool BunHoaLy1_resetCmd { get; set; } // Bùn hóa lý 1.
        public bool BunHoaLy2_resetCmd { get; set; } // Bùn hóa lý 2.
        public bool BeGom1_resetCmd { get; set; } // Bể gom 1.
        public bool BeGom2_resetCmd { get; set; } // Bể gom 2.
        public bool BeGom3_resetCmd { get; set; } // Bể gom 3.
        public bool DieuHoa1_resetCmd { get; set; } // Bơm điều hòa 1.
        public bool DieuHoa2_resetCmd { get; set; } // Bơm điều hòa 2.
        public bool Skbm1_resetCmd { get; set; } //???.
        public bool Skbm2_resetCmd { get; set; } //???.
        public bool Skbm3_resetCmd { get; set; } //???.
        public bool Mtk1_resetCmd { get; set; } // Máy thổi khí 01.
        public bool Mtk2_resetCmd { get; set; } // Máy thổi khí 02.
        public bool Mtk3_resetCmd { get; set; } // Máy thổi khí 03.
        public bool DlAxit_resetCmd { get; set; } // Định lượng hóa chất axit.
        public bool DlXut_resetCmd { get; set; } // Định lượng Xút.
        public bool DlNp_resetCmd { get; set; } // Định lượng NP.
        public bool DlClo_resetCmd { get; set; } // Định lượng Clo.
        public bool DlPac_resetCmd { get; set; } // Định lượng PAC.
        public bool DlPolyme_resetCmd { get; set; } // Định lượng Polyme.

        //public bool dlPolyme2_resetCmd { get; set; } // Định lượng Polyme 2

        public bool KhuayNp_resetCmd { get; set; } // Máy khuấy NP.
        public bool KhuayClo_resetCmd { get; set; } // Khuấy Clo.
        public bool KhuayPac_resetCmd { get; set; } // Khuấy PAC.
        public bool KhuayPoly1_resetCmd { get; set; } // Khuấy Polyme 1.
        public bool KhuayPoly2_resetCmd { get; set; } // Khuây Polyme 2.
    }
}
