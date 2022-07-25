using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP2_V01
{
    public partial class TESTING_ENVIRONMENT : Form
    {
        Form _parent;
        public byte trip_mtk01 { get; set; } = 0;
        public byte trip_mtk02 { get; set; } = 0;
        public byte trip_mtk03 { get; set; } = 0;

        public byte trip_dieuHoa1{ get; set; } = 0;

        public byte trip_dieuHoa2 { get; set; } = 0;
        public byte trip_tuanHoanNuoc { get; set; } = 0;
        public byte trip_tuanHoanBun { get; set; } = 0;
        public byte trip_bunHoaLy2 { get; set; } = 0;
        public byte trip_bunHoaLy1 { get; set; } = 0;
        public byte trip_beGom1 { get; set; } = 0;
        public byte trip_beGom2 { get; set; } = 0;
        public byte trip_beGom3 { get; set; } = 0;
        public byte trip_skbm1 { get; set; } = 0;
        public byte trip_skbm2{ get; set; } = 0;
        public byte trip_skbm3 { get; set; } = 0;
        public byte trip_dlAxit { get; set; } = 0;
        public byte trip_dlXut { get; set; } = 0;
        public byte trip_dlNp { get; set; } = 0;
        public byte trip_dlClo { get; set; } = 0;
        public byte trip_dlPac { get; set; } = 0;
        public byte trip_dlPolyme1 { get; set; } = 0;
        public byte trip_dlPolyme2 { get; set; } = 0;
        public byte trip_khuayNp { get; set; } = 0;
        public byte trip_khuayClo { get; set; } = 0;
        public byte trip_khuayPac { get; set; } = 0;
        public byte trip_khuayPolyme1 { get; set; } = 0;
        public byte trip_khuayPolyme2 { get; set; } = 0;
        public byte trip_khuayKeoTu { get; set; } = 0;
        public byte trip_khuayTaoBong1 { get; set; } = 0;
        public byte trip_khuayTaoBong2 { get; set; } = 0;
        public byte trip_motorGatBun { get; set; } = 0;



        public byte trip_anoxic1 { get; set; } = 0;
        public byte trip_anoxic2 { get; set; } = 0;
        public byte trip_anoxic3 { get; set; } = 0;
        public byte trip_anoxic4 { get; set; } = 0;
        public byte trip_anoxic5 { get; set; } = 0;
        public byte trip_anoxic6 { get; set; } = 0;
        public byte trip_anoxic7 { get; set; } = 0;
        public byte trip_anoxic8 { get; set; } = 0;
        public byte trip_etanol1 { get; set; } = 0;
        public byte trip_etanol2 { get; set; } = 0;
        public byte trip_metanol { get; set; } = 0;
        public byte trip_mkt01 { get; set; } = 0;
        public byte trip_mkt02 { get; set; } = 0;
        public byte trip_mkt03 { get; set; } = 0;
        public byte trip_tuanHoan1 { get; set; } = 0;
        public byte trip_tuanHoan2 { get; set; } = 0;
        public byte trip_tuanHoan3 { get; set; } = 0;
        public byte trip_gatBun { get; set; } = 0;
        public byte trip_bomBun1 { get; set; } = 0;
        public byte trip_bomBun2 { get; set; } = 0;
        public byte trip_khuayNaoh { get; set; } = 0;
        public byte trip_dlNaoh { get; set; } = 0;
        public byte trip_al2so4_1 { get; set; } = 0;
        public byte trip_al2so4_2 { get; set; } = 0;



        public byte trip_mayTachRac { get; set; } = 0;
        public byte trip_bomNt_02A { get; set; } = 0;
        public byte trip_bomNt_02B { get; set; } = 0;
        public byte trip_mtk_AB06A { get; set; } = 0;
        public byte trip_mtk_AB06B { get; set; } = 0;
        public byte trip_mtk_AB06C { get; set; } = 0;
        public byte trip_khuayKeoTu_GD2 { get; set; } = 0;
        public byte trip_khuayTaoBong_A { get; set; } = 0;
        public byte trip_khuayTaoBong_B { get; set; } = 0;
        public byte trip_gbbl05 { get; set; } = 0;
        public byte trip_gbbl07 { get; set; } = 0;
        public byte trip_gbbl09 { get; set; } = 0;
        public byte trip_khuayPac_GD2 { get; set; } = 0;
        public byte trip_khuayPoly_GD2 { get; set; } = 0;
        public byte trip_bomBun_05A { get; set; } = 0;
        public byte trip_bomBun_05B { get; set; } = 0;
        public byte trip_bomBun_07A { get; set; } = 0;
        public byte trip_bomBun_07B { get; set; } = 0;
        public byte trip_bomBun_SP10 { get; set; } = 0;
        public byte trip_dlPhen_03A { get; set; } = 0;
        public byte trip_dlPhen_03B { get; set; } = 0;
        public byte trip_dlPolyme_04A { get; set; } = 0;
        public byte trip_dlPolyme_04B { get; set; } = 0;
        public byte trip_dlXut_05A { get; set; } = 0;
        public byte trip_dlXut_05B { get; set; } = 0;
        public byte trip_dlDd_06A { get; set; } = 0;
        public byte trip_dlDd_06B { get; set; } = 0;
        public byte trip_dlKhuTrung_07A { get; set; } = 0;
        public byte trip_dlKhuTrung_07B { get; set; } = 0;




        public TESTING_ENVIRONMENT(Form _parent)
        {
            InitializeComponent();
            this._parent = new Form();
            this._parent = _parent;
        }

        public TESTING_ENVIRONMENT()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        { 
            if(Program.InputStatus_PLC1.mtk01_tripStatus == false)
            {
                Program.InputStatus_PLC1.mtk01_tripStatus = true;
                ++trip_mtk01;
                Console.WriteLine(Program.InputStatus_PLC1.mtk01_tripStatus);
            }    
            else
            {
                Program.InputStatus_PLC1.mtk01_tripStatus = false;
                trip_mtk01 = 0;
                Console.WriteLine(Program.InputStatus_PLC1.mtk01_tripStatus);
            }    
            
        }

        private void TESTING_ENVIRONMENT_Load(object sender, EventArgs e)
        {

            Program.testingEnvironmentPage.TopMost = true;
            //Program.testingEnvironmentPage.TopLevel = false;
        }

        private void TESTING_ENVIRONMENT_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void TESTING_ENVIRONMENT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.testingEnvironmentPage.TopMost = false;

            Program.framePage.Enabled = true;
            Program.framePage.TopMost = true;

            //this._parent.Enabled = true;
            //this._parent.TopMost = true;
            //this._parent.TopLevel = false;
        }

        private void mtk02_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.mtk02_tripStatus == false)
            {
                Program.InputStatus_PLC1.mtk02_tripStatus = true;
                ++trip_mtk02;
                Console.WriteLine(Program.InputStatus_PLC1.mtk02_tripStatus);
            }
            else
            {
                Program.InputStatus_PLC1.mtk02_tripStatus = false;
                trip_mtk02 = 0;
                Console.WriteLine(Program.InputStatus_PLC1.mtk02_tripStatus);
            }
        }

        private void mtk03_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.mtk03_tripStatus == false)
            {
                Program.InputStatus_PLC1.mtk03_tripStatus = true;
                ++trip_mtk03;
            }
            else
            {
                Program.InputStatus_PLC1.mtk03_tripStatus = false;
                trip_mtk03 = 0;
            }
        }

        private void dlPol1_Click(object sender, EventArgs e)
        {

        }

        private void dlPol2_Click(object sender, EventArgs e)
        {
        }

        private void dh1_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.dieuHoa1_tripStatus == false)
            {
                Program.InputStatus_PLC1.dieuHoa1_tripStatus = true;
                ++trip_dieuHoa1;
            }
            else
            {
                Program.InputStatus_PLC1.dieuHoa1_tripStatus = false;
                trip_dieuHoa1 = 0;
            }
        }

        private void dh2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.dieuHoa2_tripStatus == false)
            {
                Program.InputStatus_PLC1.dieuHoa2_tripStatus = true;
                ++trip_dieuHoa2;
            }
            else
            {
                Program.InputStatus_PLC1.dieuHoa2_tripStatus = false;
                trip_dieuHoa2 = 0;
            }
        }

        private void thNuoc_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.tuanHoanNuoc_tripStatus == false)
            {
                Program.InputStatus_PLC1.tuanHoanNuoc_tripStatus = true;
                ++trip_tuanHoanNuoc;
            }
            else
            {
                Program.InputStatus_PLC1.tuanHoanNuoc_tripStatus = false;
                trip_tuanHoanNuoc = 0;
            }
        }

        private void thBun_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.tuanHoanBun_tripStatus == false)
            {
                Program.InputStatus_PLC1.tuanHoanBun_tripStatus = true;
                ++trip_tuanHoanBun;
            }
            else
            {
                Program.InputStatus_PLC1.tuanHoanBun_tripStatus = false;
                trip_tuanHoanBun = 0;
            }
        }

        private void hoaLy1_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.bunHoaLy1_tripStatus == false)
            {
                Program.InputStatus_PLC1.bunHoaLy1_tripStatus = true;
                ++trip_bunHoaLy1;
            }
            else
            {
                Program.InputStatus_PLC1.bunHoaLy1_tripStatus = false;
                trip_bunHoaLy1 = 0;
            }
        }

        private void hoaLy2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.bunHoaLy2_tripStatus == false)
            {
                Program.InputStatus_PLC1.bunHoaLy2_tripStatus = true;
                ++trip_bunHoaLy2;
            }
            else
            {
                Program.InputStatus_PLC1.bunHoaLy2_tripStatus = false;
                trip_bunHoaLy2 = 0;
            }
        }

        private void khuayPolyme1_Click(object sender, EventArgs e)
        {

        }

        private void beGom1_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.beGom1_tripStatus == false)
            {
                Program.InputStatus_PLC1.beGom1_tripStatus = true;
                ++trip_beGom1;
            }
            else
            {
                Program.InputStatus_PLC1.beGom1_tripStatus = false;
                trip_beGom1 = 0;
            }
        }
        private void beGom2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.beGom2_tripStatus == false)
            {
                Program.InputStatus_PLC1.beGom2_tripStatus = true;
                ++trip_beGom2;
            }
            else
            {
                Program.InputStatus_PLC1.beGom2_tripStatus = false;
                trip_beGom2 = 0;
            }
        }

        private void beGom3_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.beGom3_tripStatus == false)
            {
                Program.InputStatus_PLC1.beGom3_tripStatus = true;
                ++trip_beGom3;
            }
            else
            {
                Program.InputStatus_PLC1.beGom3_tripStatus = false;
                trip_beGom3 = 0;
            }
        }

        private void skbm1_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.skbm1_tripStatus == false)
            {
                Program.InputStatus_PLC1.skbm1_tripStatus = true;
                ++trip_skbm1;
            }
            else
            {
                Program.InputStatus_PLC1.skbm1_tripStatus = false;
                trip_skbm1 = 0;
            }
        }

        private void skbm2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.skbm2_tripStatus == false)
            {
                Program.InputStatus_PLC1.skbm2_tripStatus = true;
                ++trip_skbm2;
            }
            else
            {
                Program.InputStatus_PLC1.skbm2_tripStatus = false;
                trip_skbm2 = 0;
            }
        }

        private void skbm3_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.skbm3_tripStatus == false)
            {
                Program.InputStatus_PLC1.skbm3_tripStatus = true;
                ++trip_skbm3;
            }
            else
            {
                Program.InputStatus_PLC1.skbm3_tripStatus = false;
                trip_skbm3 = 0;
            }
        }

        private void dlAxit_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.dlAxit_tripStatus == false)
            {
                Program.InputStatus_PLC1.dlAxit_tripStatus = true;
                ++trip_dlAxit;
            }
            else
            {
                Program.InputStatus_PLC1.dlAxit_tripStatus = false;
                trip_dlAxit = 0;
            }
        }

        private void dlXut_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.dlXut_tripStatus == false)
            {
                Program.InputStatus_PLC1.dlXut_tripStatus = true;
                ++trip_dlXut;
            }
            else
            {
                Program.InputStatus_PLC1.dlXut_tripStatus = false;
                trip_dlXut = 0;
            }
        }

        private void dlNp_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.dlNp_tripStatus == false)
            {
                Program.InputStatus_PLC1.dlNp_tripStatus = true;
                ++trip_dlNp;
            }
            else
            {
                Program.InputStatus_PLC1.dlNp_tripStatus = false;
                trip_dlNp = 0;
            }
        }

        private void dlClo_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.dlClo_tripStatus == false)
            {
                Program.InputStatus_PLC1.dlClo_tripStatus = true;
                ++trip_dlClo;
            }
            else
            {
                Program.InputStatus_PLC1.dlClo_tripStatus = false;
                trip_dlClo = 0;
            }
        }

        private void dlPac_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.dlPac_tripStatus == false)
            {
                Program.InputStatus_PLC1.dlPac_tripStatus = true;
                ++trip_dlPac;
            }
            else
            {
                Program.InputStatus_PLC1.dlPac_tripStatus = false;
                trip_dlPac = 0;
            }
        }

        private void dlPoly1_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.dlPolyme1_tripStatus == false)
            {
                Program.InputStatus_PLC1.dlPolyme1_tripStatus = true;
                ++trip_dlPolyme1;
            }
            else
            {
                Program.InputStatus_PLC1.dlPolyme1_tripStatus = false;
                trip_dlPolyme1 = 0;
            }
        }

        private void dlPoly2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.dlPolyme2_tripStatus == false)
            {
                Program.InputStatus_PLC1.dlPolyme2_tripStatus = true;
                ++trip_dlPolyme2;
            }
            else
            {
                Program.InputStatus_PLC1.dlPolyme2_tripStatus = false;
                trip_dlPolyme2 = 0;
            }
        }

        private void khuayNp_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.khuayNp_tripStatus == false)
            {
                Program.InputStatus_PLC1.khuayNp_tripStatus = true;
                ++trip_khuayNp;
            }
            else
            {
                Program.InputStatus_PLC1.khuayNp_tripStatus = false;
                trip_khuayNp = 0;
            }
        }

        private void khuayClo_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.khuayClo_tripStatus == false)
            {
                Program.InputStatus_PLC1.khuayClo_tripStatus = true;
                ++trip_khuayClo;
            }
            else
            {
                Program.InputStatus_PLC1.khuayClo_tripStatus = false;
                trip_khuayClo = 0;
            }
        }

        private void khuayPac_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.khuayPac_tripStatus == false)
            {
                Program.InputStatus_PLC1.khuayPac_tripStatus = true;
                ++trip_khuayPac;
            }
            else
            {
                Program.InputStatus_PLC1.khuayPac_tripStatus = false;
                trip_khuayPac = 0;
            }
        }

        private void khuayPoly1_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.khuayPolyme1_tripStatus == false)
            {
                Program.InputStatus_PLC1.khuayPolyme1_tripStatus = true;
                ++trip_khuayPolyme1;
            }
            else
            {
                Program.InputStatus_PLC1.khuayPolyme1_tripStatus = false;
                trip_khuayPolyme1 = 0;
            }
        }

        private void khuayPoly2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.khuayPolyme2_tripStatus == false)
            {
                Program.InputStatus_PLC1.khuayPolyme2_tripStatus = true;
                ++trip_khuayPolyme2;
            }
            else
            {
                Program.InputStatus_PLC1.khuayPolyme2_tripStatus = false;
                trip_khuayPolyme2 = 0;
            }
        }

        private void khuayKeo_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.khuayKeoTu_tripStatus == false)
            {
                Program.InputStatus_PLC1.khuayKeoTu_tripStatus = true;
                ++trip_khuayKeoTu;
            }
            else
            {
                Program.InputStatus_PLC1.khuayKeoTu_tripStatus = false;
                trip_khuayKeoTu = 0;
            }
        }

        private void khuayTB1_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.khuayTaoBong1_tripStatus == false)
            {
                Program.InputStatus_PLC1.khuayTaoBong1_tripStatus = true;
                ++trip_khuayTaoBong1;
            }
            else
            {
                Program.InputStatus_PLC1.khuayTaoBong1_tripStatus = false;
                trip_khuayTaoBong1 = 0;
            }
        }

        private void khuayTB2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.khuayTaoBong2_tripStatus == false)
            {
                Program.InputStatus_PLC1.khuayTaoBong2_tripStatus = true;
                ++trip_khuayTaoBong2;
            }
            else
            {
                Program.InputStatus_PLC1.khuayTaoBong2_tripStatus = false;
                trip_khuayTaoBong2 = 0;
            }
        }

        private void mototGatBun_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC1.motorGatBun_tripStatus == false)
            {
                Program.InputStatus_PLC1.motorGatBun_tripStatus = true;
                ++trip_motorGatBun;
            }
            else
            {
                Program.InputStatus_PLC1.motorGatBun_tripStatus = false;
                trip_motorGatBun = 0;
            }
        }

        private void mayTachRac_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.mayTachRac_tripStatus == false)
            {
                Program.InputStatus_PLC3.mayTachRac_tripStatus = true;
                ++trip_mayTachRac;
            }
            else
            {
                Program.InputStatus_PLC3.mayTachRac_tripStatus = false;
                trip_mayTachRac = 0;
            }
        }

        private void nt02a_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.bomNt_02A_tripStatus == false)
            {
                Program.InputStatus_PLC3.bomNt_02A_tripStatus = true;
                ++trip_bomNt_02A;
            }
            else
            {
                Program.InputStatus_PLC3.bomNt_02A_tripStatus = false;
                trip_bomNt_02A = 0;
            }
        }

        private void nt02b_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.bomNt_02B_tripStatus == false)
            {
                Program.InputStatus_PLC3.bomNt_02B_tripStatus = true;
                ++trip_bomNt_02B;
            }
            else
            {
                Program.InputStatus_PLC3.bomNt_02B_tripStatus = false;
                trip_bomNt_02B = 0;
            }
        }

        private void ab06a_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.mtk_AB06A_tripStatus == false)
            {
                Program.InputStatus_PLC3.mtk_AB06A_tripStatus = true;
                ++trip_mtk_AB06A;
            }
            else
            {
                Program.InputStatus_PLC3.mtk_AB06A_tripStatus = false;
                trip_mtk_AB06A = 0;
            }
        }

        private void ab06b_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.mtk_AB06B_tripStatus == false)
            {
                Program.InputStatus_PLC3.mtk_AB06B_tripStatus = true;
                ++trip_mtk_AB06B;
            }
            else
            {
                Program.InputStatus_PLC3.mtk_AB06B_tripStatus = false;
                trip_mtk_AB06B = 0;
            }
        }

        private void ab06c_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.mtk_AB06C_tripStatus == false)
            {
                Program.InputStatus_PLC3.mtk_AB06C_tripStatus = true;
                ++trip_mtk_AB06C;
            }
            else
            {
                Program.InputStatus_PLC3.mtk_AB06C_tripStatus = false;
                trip_mtk_AB06C = 0;
            }
        }

        private void keoTu_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.khuayKeoTu_GD2_tripStatus == false)
            {
                Program.InputStatus_PLC3.khuayKeoTu_GD2_tripStatus = true;
                ++trip_khuayKeoTu_GD2;
            }
            else
            {
                Program.InputStatus_PLC3.khuayKeoTu_GD2_tripStatus = false;
                trip_khuayKeoTu_GD2 = 0;
            }
        }

        private void taoBongA_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.khuayTaoBong_A_tripStatus == false)
            {
                Program.InputStatus_PLC3.khuayTaoBong_A_tripStatus = true;
                ++trip_khuayTaoBong_A;
            }
            else
            {
                Program.InputStatus_PLC3.khuayTaoBong_A_tripStatus = false;
                trip_khuayTaoBong_A = 0;
            }
        }

        private void taoBongB_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.khuayTaoBong_B_tripStatus == false)
            {
                Program.InputStatus_PLC3.khuayTaoBong_B_tripStatus = true;
                ++trip_khuayTaoBong_B;
            }
            else
            {
                Program.InputStatus_PLC3.khuayTaoBong_B_tripStatus = false;
                trip_khuayTaoBong_B = 0;
            }
        }

        private void gbbl05_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.gbbl05_tripStatus == false)
            {
                Program.InputStatus_PLC3.gbbl05_tripStatus = true;
                ++trip_gbbl05;
            }
            else
            {
                Program.InputStatus_PLC3.gbbl05_tripStatus = false;
                trip_gbbl05 = 0;
            }
        }

        private void gbbl07_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.gbbl07_tripStatus == false)
            {
                Program.InputStatus_PLC3.gbbl07_tripStatus = true;
                ++trip_gbbl07;
            }
            else
            {
                Program.InputStatus_PLC3.gbbl07_tripStatus = false;
                trip_gbbl07 = 0;
            }
        }

        private void gbbl09_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.gbbl09_tripStatus == false)
            {
                Program.InputStatus_PLC3.gbbl09_tripStatus = true;
                ++trip_gbbl09;
            }
            else
            {
                Program.InputStatus_PLC3.gbbl09_tripStatus = false;
                trip_gbbl09 = 0;
            }
        }

        private void khuayPac_GD2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.khuayPac_GD2_tripStatus == false)
            {
                Program.InputStatus_PLC3.khuayPac_GD2_tripStatus = true;
                ++trip_khuayPac_GD2;
            }
            else
            {
                Program.InputStatus_PLC3.khuayPac_GD2_tripStatus = false;
                trip_khuayPac_GD2 = 0;
            }
        }

        private void khuayPoly_GD2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.khuayPoly_GD2_tripStatus == false)
            {
                Program.InputStatus_PLC3.khuayPoly_GD2_tripStatus = true;
                ++trip_khuayPoly_GD2;
            }
            else
            {
                Program.InputStatus_PLC3.khuayPoly_GD2_tripStatus = false;
                trip_khuayPoly_GD2 = 0;
            }
        }

        private void bomBun_05A_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.bomBun_05A_tripStatus == false)
            {
                Program.InputStatus_PLC3.bomBun_05A_tripStatus = true;
                ++trip_bomBun_05A;
            }
            else
            {
                Program.InputStatus_PLC3.bomBun_05A_tripStatus = false;
                trip_bomBun_05A = 0;
            }
        }

        private void bomBun_05B_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.bomBun_05B_tripStatus == false)
            {
                Program.InputStatus_PLC3.bomBun_05B_tripStatus = true;
                ++trip_bomBun_05B;
            }
            else
            {
                Program.InputStatus_PLC3.bomBun_05B_tripStatus = false;
                trip_bomBun_05B = 0;
            }
        }

        private void bomBun07A_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.bomBun_07A_tripStatus == false)
            {
                Program.InputStatus_PLC3.bomBun_07A_tripStatus = true;
                ++trip_bomBun_07A;
            }
            else
            {
                Program.InputStatus_PLC3.bomBun_07A_tripStatus = false;
                trip_bomBun_07A = 0;
            }
        }

        private void bomBun07B_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.bomBun_07B_tripStatus == false)
            {
                Program.InputStatus_PLC3.bomBun_07B_tripStatus = true;
                ++trip_bomBun_07B;
            }
            else
            {
                Program.InputStatus_PLC3.bomBun_07B_tripStatus = false;
                trip_bomBun_07B = 0;
            }
        }

        private void bomBunSP10_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.bomBun_SP10_tripStatus == false)
            {
                Program.InputStatus_PLC3.bomBun_SP10_tripStatus = true;
                ++trip_bomBun_SP10;
            }
            else
            {
                Program.InputStatus_PLC3.bomBun_SP10_tripStatus = false;
                trip_bomBun_SP10 = 0;
            }
        }

        private void phen03A_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.dlPhen_03A_tripStatus == false)
            {
                Program.InputStatus_PLC3.dlPhen_03A_tripStatus = true;
                ++trip_dlPhen_03A;
            }
            else
            {
                Program.InputStatus_PLC3.dlPhen_03A_tripStatus = false;
                trip_dlPhen_03A = 0;
            }
        }

        private void phen03B_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.dlPhen_03B_tripStatus == false)
            {
                Program.InputStatus_PLC3.dlPhen_03B_tripStatus = true;
                ++trip_dlPhen_03B;
            }
            else
            {
                Program.InputStatus_PLC3.dlPhen_03B_tripStatus = false;
                trip_dlPhen_03B = 0;
            }
        }

        private void poly04A_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.dlPolyme_04A_tripStatus == false)
            {
                Program.InputStatus_PLC3.dlPolyme_04A_tripStatus = true;
                ++trip_dlPolyme_04A;
            }
            else
            {
                Program.InputStatus_PLC3.dlPolyme_04A_tripStatus = false;
                trip_dlPolyme_04A = 0;
            }
        }

        private void phen04B_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.dlPolyme_04B_tripStatus == false)
            {
                Program.InputStatus_PLC3.dlPolyme_04B_tripStatus = true;
                ++trip_dlPolyme_04B;
            }
            else
            {
                Program.InputStatus_PLC3.dlPolyme_04B_tripStatus = false;
                trip_dlPolyme_04B = 0;
            }
        }

        private void xut05A_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.dlXut_05A_tripStatus == false)
            {
                Program.InputStatus_PLC3.dlXut_05A_tripStatus = true;
                ++trip_dlXut_05A;
            }
            else
            {
                Program.InputStatus_PLC3.dlXut_05A_tripStatus = false;
                trip_dlXut_05A = 0;
            }
        }

        private void xut05B_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.dlXut_05B_tripStatus == false)
            {
                Program.InputStatus_PLC3.dlXut_05B_tripStatus = true;
                ++trip_dlXut_05B;
            }
            else
            {
                Program.InputStatus_PLC3.dlXut_05B_tripStatus = false;
                trip_dlXut_05B = 0;
            }
        }

        private void dldd06a_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.dlDd_06A_tripStatus == false)
            {
                Program.InputStatus_PLC3.dlDd_06A_tripStatus = true;
                ++trip_dlDd_06A;
            }
            else
            {
                Program.InputStatus_PLC3.dlDd_06A_tripStatus = false;
                trip_dlDd_06A = 0;
            }
        }

        private void dlđ06b_Click(object sender, EventArgs e)
        {

            if (Program.InputStatus_PLC3.dlDd_06B_tripStatus == false)
            {
                Program.InputStatus_PLC3.dlDd_06B_tripStatus = true;
                ++trip_dlDd_06B;
            }
            else
            {
                Program.InputStatus_PLC3.dlDd_06B_tripStatus = false;
                trip_dlDd_06B = 0;
            }
        }

        private void khu07A_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.dlKhuTrung_07A_tripStatus == false)
            {
                Program.InputStatus_PLC3.dlKhuTrung_07A_tripStatus = true;
                ++trip_dlKhuTrung_07A;
            }
            else
            {
                Program.InputStatus_PLC3.dlKhuTrung_07A_tripStatus = false;
                trip_dlKhuTrung_07A = 0;
            }
        }

        private void khu07B_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC3.dlKhuTrung_07B_tripStatus == false)
            {
                Program.InputStatus_PLC3.dlKhuTrung_07B_tripStatus = true;
                ++trip_dlKhuTrung_07B;
            }
            else
            {
                Program.InputStatus_PLC3.dlKhuTrung_07B_tripStatus = false;
                trip_dlKhuTrung_07B = 0;
            }
        }

        private void anoxic1_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.anoxic1_tripStatus == false)
            {
                Program.InputStatus_PLC2.anoxic1_tripStatus = true;
                ++trip_anoxic1;
            }
            else
            {
                Program.InputStatus_PLC2.anoxic1_tripStatus = false;
                trip_anoxic1 = 0;
            }
        }

        private void anoxic2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.anoxic2_tripStatus == false)
            {
                Program.InputStatus_PLC2.anoxic2_tripStatus = true;
                ++trip_anoxic2;
            }
            else
            {
                Program.InputStatus_PLC2.anoxic2_tripStatus = false;
                trip_anoxic2 = 0;
            }
        }

        private void anoxic3_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.anoxic3_tripStatus == false)
            {
                Program.InputStatus_PLC2.anoxic3_tripStatus = true;
                ++trip_anoxic3;
            }
            else
            {
                Program.InputStatus_PLC2.anoxic3_tripStatus = false;
                trip_anoxic3 = 0;
            }
        }

        private void anoxic4_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.anoxic4_tripStatus == false)
            {
                Program.InputStatus_PLC2.anoxic4_tripStatus = true;
                ++trip_anoxic4;
            }
            else
            {
                Program.InputStatus_PLC2.anoxic4_tripStatus = false;
                trip_anoxic4 = 0;
            }
        }

        private void anoxic5_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.anoxic5_tripStatus == false)
            {
                Program.InputStatus_PLC2.anoxic5_tripStatus = true;
                ++trip_anoxic5;
            }
            else
            {
                Program.InputStatus_PLC2.anoxic5_tripStatus = false;
                trip_anoxic5 = 0;
            }
        }

        private void anoxic6_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.anoxic6_tripStatus == false)
            {
                Program.InputStatus_PLC2.anoxic6_tripStatus = true;
                ++trip_anoxic6;
            }
            else
            {
                Program.InputStatus_PLC2.anoxic6_tripStatus = false;
                trip_anoxic6 = 0;
            }
        }

        private void anoxic7_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.anoxic7_tripStatus == false)
            {
                Program.InputStatus_PLC2.anoxic7_tripStatus = true;
                ++trip_anoxic7;
            }
            else
            {
                Program.InputStatus_PLC2.anoxic7_tripStatus = false;
                trip_anoxic7 = 0;
            }
        }

        private void anoxic8_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.anoxic8_tripStatus == false)
            {
                Program.InputStatus_PLC2.anoxic8_tripStatus = true;
                ++trip_anoxic8;
            }
            else
            {
                Program.InputStatus_PLC2.anoxic8_tripStatus = false;
                trip_anoxic8 = 0;
            }
        }

        private void etanol1_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.etanol1_tripStatus == false)
            {
                Program.InputStatus_PLC2.etanol1_tripStatus = true;
                ++trip_etanol1;
            }
            else
            {
                Program.InputStatus_PLC2.etanol1_tripStatus = false;
                trip_etanol1 = 0;
            }
        }

        private void etanol2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.etanol2_tripStatus == false)
            {
                Program.InputStatus_PLC2.etanol2_tripStatus = true;
                ++trip_etanol2;
            }
            else
            {
                Program.InputStatus_PLC2.etanol2_tripStatus = false;
                trip_etanol2 = 0;
            }
        }

        private void metanol_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.metanol_tripStatus == false)
            {
                Program.InputStatus_PLC2.metanol_tripStatus = true;
                ++trip_metanol;
            }
            else
            {
                Program.InputStatus_PLC2.metanol_tripStatus = false;
                trip_metanol = 0;
            }
        }

        private void mkt01_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.mkt01_tripStatus == false)
            {
                Program.InputStatus_PLC2.mkt01_tripStatus = true;
                ++trip_mkt01;
            }
            else
            {
                Program.InputStatus_PLC2.mkt01_tripStatus = false;
                trip_mkt01 = 0;
            }
        }

        private void mkt02_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.mkt02_tripStatus == false)
            {
                Program.InputStatus_PLC2.mkt02_tripStatus = true;
                ++trip_mkt02;
            }
            else
            {
                Program.InputStatus_PLC2.mkt02_tripStatus = false;
                trip_mkt02 = 0;
            }
        }

        private void mkt03_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.mkt03_tripStatus == false)
            {
                Program.InputStatus_PLC2.mkt03_tripStatus = true;
                ++trip_mkt03;
            }
            else
            {
                Program.InputStatus_PLC2.mkt03_tripStatus = false;
                trip_mkt03 = 0;
            }
        }

        private void tuanHoan1_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.tuanHoan1_tripStatus == false)
            {
                Program.InputStatus_PLC2.tuanHoan1_tripStatus = true;
                ++trip_tuanHoan1;
            }
            else
            {
                Program.InputStatus_PLC2.tuanHoan1_tripStatus = false;
                trip_tuanHoan1 = 0;
            }
        }

        private void tuanHoan2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.tuanHoan2_tripStatus == false)
            {
                Program.InputStatus_PLC2.tuanHoan2_tripStatus = true;
                ++trip_tuanHoan2;
            }
            else
            {
                Program.InputStatus_PLC2.tuanHoan2_tripStatus = false;
                trip_tuanHoan2 = 0;
            }
        }

        private void tuanHoan3_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.tuanHoan3_tripStatus == false)
            {
                Program.InputStatus_PLC2.tuanHoan3_tripStatus = true;
                ++trip_tuanHoan3;
            }
            else
            {
                Program.InputStatus_PLC2.tuanHoan3_tripStatus = false;
                trip_tuanHoan3 = 0;
            }
        }

        private void gatBun_GD1MR_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.gatBun_tripStatus == false)
            {
                Program.InputStatus_PLC2.gatBun_tripStatus = true;
                ++trip_gatBun;
            }
            else
            {
                Program.InputStatus_PLC2.gatBun_tripStatus = false;
                trip_gatBun = 0;
            }
        }

        private void bomBun1_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.bomBun1_tripStatus == false)
            {
                Program.InputStatus_PLC2.bomBun1_tripStatus = true;
                ++trip_bomBun1;
            }
            else
            {
                Program.InputStatus_PLC2.bomBun1_tripStatus = false;
                trip_bomBun1 = 0;
            }
        }

        private void bomBun2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.bomBun2_tripStatus == false)
            {
                Program.InputStatus_PLC2.bomBun2_tripStatus = true;
                ++trip_bomBun2;
            }
            else
            {
                Program.InputStatus_PLC2.bomBun2_tripStatus = false;
                trip_bomBun2 = 0;
            }
        }

        private void khuayNaoh_GD1MR_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.khuayNaoh_tripStatus == false)
            {
                Program.InputStatus_PLC2.khuayNaoh_tripStatus = true;
                ++trip_khuayNaoh;
            }
            else
            {
                Program.InputStatus_PLC2.khuayNaoh_tripStatus = false;
                trip_khuayNaoh = 0;
            }
        }

        private void dlNaoh_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.dlNaoh_tripStatus == false)
            {
                Program.InputStatus_PLC2.dlNaoh_tripStatus = true;
                ++trip_dlNaoh;
            }
            else
            {
                Program.InputStatus_PLC2.dlNaoh_tripStatus = false;
                trip_dlNaoh = 0;
            }
        }

        private void al2so4_1_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.al2so4_1_tripStatus == false)
            {
                Program.InputStatus_PLC2.al2so4_1_tripStatus = true;
                ++trip_al2so4_1;
            }
            else
            {
                Program.InputStatus_PLC2.al2so4_1_tripStatus = false;
                trip_al2so4_1 = 0;
            }
        }

        private void al2so4_2_Click(object sender, EventArgs e)
        {
            if (Program.InputStatus_PLC2.al2so4_2_tripStatus == false)
            {
                Program.InputStatus_PLC2.al2so4_2_tripStatus = true;
                ++trip_al2so4_2;
            }
            else
            {
                Program.InputStatus_PLC2.al2so4_2_tripStatus = false;
                trip_al2so4_2 = 0;
            }
        }
    }
}
