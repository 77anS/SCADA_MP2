using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.PLC.PLC1
{
    public class ResetRuntime_DB20
    {
        public bool tuanHoanNuoc_resetCmd { get; set; } // Bơm tuần hoàn nước.
        public bool tuanHoanBun_resetCmd { get; set; } // Bơm tuần hoàn bùn.
        public bool bunHoaLy1_resetCmd { get; set; } // Bùn hóa lý 1.
        public bool bunHoaLy2_resetCmd { get; set; } // Bùn hóa lý 2.
        public bool beGom1_resetCmd { get; set; } // Bể gom 1.
        public bool beGom2_resetCmd { get; set; } // Bể gom 2.
        public bool beGom3_resetCmd { get; set; } // Bể gom 3.
        public bool dieuHoa1_resetCmd { get; set; } // Bơm điều hòa 1.
        public bool dieuHoa2_resetCmd { get; set; } // Bơm điều hòa 2.
        public bool skbm1_resetCmd { get; set; } //???.
        public bool skbm2_resetCmd { get; set; } //???.
        public bool skbm3_resetCmd { get; set; } //???.
        public bool mtk1_resetCmd { get; set; } // Máy thổi khí 01.
        public bool mtk2_resetCmd { get; set; } // Máy thổi khí 02.
        public bool mtk3_resetCmd { get; set; } // Máy thổi khí 03.
        public bool dlAxit_resetCmd { get; set; } // Định lượng hóa chất axit.
        public bool dlXut_resetCmd { get; set; } // Định lượng Xút.
        public bool dlNp_resetCmd { get; set; } // Định lượng NP.
        public bool dlClo_resetCmd { get; set; } // Định lượng Clo.
        public bool dlPac_resetCmd { get; set; } // Định lượng PAC.
        public bool dlPolyme_resetCmd { get; set; } // Định lượng Polyme.

        //public bool dlPolyme2_resetCmd { get; set; } // Định lượng Polyme 2

        public bool khuayNp_resetCmd { get; set; } // Máy khuấy NP.
        public bool khuayClo_resetCmd { get; set; } // Khuấy Clo.
        public bool khuayPac_resetCmd { get; set; } // Khuấy PAC.
        public bool khuayPoly1_resetCmd { get; set; } // Khuấy Polyme 1.
        public bool khuayPoly2_resetCmd { get; set; } // Khuây Polyme 2.

    }
}
