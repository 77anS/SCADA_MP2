using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using S7.Net;

using System.Timers;
using ElementBase_Template.PLC.Data_Mapping;
using ElementBase_Template.PLC.Data_Mapping.Engine;
using ElementBase_Template.Rule; // namespace of Rule "IUpdateUI"

namespace MP2_V01
{
    public partial class SETTING : Form
    {
        #region FIELDS
            //private int borderSize = 1;
            private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.

            Form parentForm = new Form();

            public short updatePeriod { get; set; } = 500;
            System.Timers.Timer Timer_settingPage = new System.Timers.Timer();
            public short settingUpperThreshold { get; set; } = 120;
            public short settingLowerThreshold { get; set; } = 0;
            public bool updateEnable { get; set; } = true; // variable for enable update RUNTIMESETTING

            EngineCycle.PLC_GD1 PLC1_RT_Setting = new EngineCycle.PLC_GD1();
            EngineCycle.PLC_GD1MR PLC2_RT_Setting = new EngineCycle.PLC_GD1MR();
            EngineCycle.PLC_GD2 PLC3_RT_Setting = new EngineCycle.PLC_GD2();


            /// <summary>
            /// Variables that catch focus event on textbox of setting time
            /// </summary>
            #region focusOnEvent
                public bool tb_focusOn_stPage { get; set; } = false;
                public bool focusOnEvent_tb_mkt01_StPage { get; set; } // Textbox MTK01
                public bool focusOnEvent_tb_mkt02_StPage { get; set; } // Textbox MTK02
                public bool focusOnEvent_tb_mkt03_StPage { get; set; } // Textbox MTK03

                public bool focusOnEvent_tb_p101_StPage { get; set; } // Textbox P101
                public bool focusOnEvent_tb_p102_StPage { get; set; } // Textbox P102
                public bool focusOnEvent_tb_p103_StPage { get; set; } // Textbox P103

                public bool focusOnEvent_tb_p201_StPage { get; set; } // Textbox P201
                public bool focusOnEvent_tb_p202_StPage { get; set; } // Textbox P202

        
                public bool focusOnEvent_tb_th1_StPage { get; set; } // Textbox TH1
                public bool focusOnEvent_tb_th2_StPage { get; set; } // Textbox TH2
                public bool focusOnEvent_tb_th3_StPage { get; set; } // Textbox TH3


                public bool focusOnEvent_tb_sm01_StPage { get; set; } // Textbox Anoxic SM01
                public bool focusOnEvent_tb_sm02_StPage { get; set; } // Textbox Anoxic SM02

                public bool focusOnEvent_tb_wp02a_StPage { get; set; } // Textbox Bơm điều hòa WP02A
                public bool focusOnEvent_tb_wp02b_StPage { get; set; } // Textbox Bơm điều hòa WP02B

                public bool focusOnEvent_tb_sm03_StPage { get; set; } // Textbox Bơm Anoxic 34 "SM03"
                public bool focusOnEvent_tb_sm04_StPage { get; set; } // Textbox Bơm Anoxic 34 "SM04"

                public bool focusOnEvent_tb_ab06a_StPage { get; set; } // Textbox AB06A
                public bool focusOnEvent_tb_ab06b_StPage { get; set; } // Textbox AB06B
                public bool focusOnEvent_tb_ab06c_StPage { get; set; } // Textbox AB06C

                public bool focusOnEvent_tb_sm05_StPage { get; set; } // Textbox Bơm Anoxic 56 "SM05"
                public bool focusOnEvent_tb_sm06_StPage { get; set; } // Textbox Bơm Anoxic 56 "SM06"

                public bool focusOnEvent_tb_sm07_StPage { get; set; } // Textbox Bơm Anoxic 78 "SM07"
                public bool focusOnEvent_tb_sm08_StPage { get; set; } // Textbox Bơm Anoxic 78 "SM08"

                public bool focusOnEvent_tb_mtk01_StPage { get; set; } // Textbox MTK01
                public bool focusOnEvent_tb_mtk02_StPage { get; set; } // Textbox MTK02
                public bool focusOnEvent_tb_mtk03_StPage { get; set; } // Textbox MTK03

                public bool focusOnEvent_tb_bb12_on_StPage { get; set; } // Textbox thời gian bật bơm bùn 12
                public bool focusOnEvent_tb_bb12_off_StPage { get; set; } // Textbox thời gian tắt bơm bùn 12

                public bool focusOnEvent_tb_bomMetanol_on_StPage { get; set; } // Textbox thời gian bật bơm Metanol
                public bool focusOnEvent_tb_bomMetanol_off_StPage { get; set; } // Textbox thời gian tắt bơm Metanol

                public bool focusOnEvent_tb_gb1_on_StPage { get; set; } // Textbox thời gian bật gạt bùn 1
                public bool focusOnEvent_tb_gb1_off_StPage { get; set; } // Textbox thời gian tắt gạt bùn 1

                public bool focusOnEvent_tb_khuayNaoh_on_StPage { get; set; } // Textbox thời gian bật khuấy Naoh
                public bool focusOnEvent_tb_khuayNaoh_off_StPage { get; set; } // Textbox thời gian tắt khuấy NAOH

                public bool focusOnEvent_tb_ms05_on_StPage { get; set; } // Textbox thời gian bật khuấy Naoh
                public bool focusOnEvent_tb_ms05_off_StPage { get; set; } // Textbox thời gian tắt khuấy NAOH
                public bool focusOnEvent_tb_ms07_on_StPage { get; set; } // Textbox thời gian bật gạt bùn bể lắng 07
                public bool focusOnEvent_tb_ms07_off_StPage { get; set; } // Textbox thời gian tắt gạt bùn bể lắng 07

                public bool focusOnEvent_tb_sp05ab_on_StPage { get; set; } // Textbox thời gian bật bơm bùn 05
                public bool focusOnEvent_tb_sp05ab_off_StPage { get; set; } // Textbox thời gian tắt bơm bùn 05

                public bool focusOnEvent_tb_sp07ab_on_StPage { get; set; } // Textbox thời gian bật bơm bùn 07
                public bool focusOnEvent_tb_sp07ab_off_StPage { get; set; } // Textbox thời gian tắt bơm bùn 07

                public bool focusOnEvent_tb_ms09_on_StPage { get; set; } // Textbox thời gian bật gạt bùn bể nén SM09
                public bool focusOnEvent_tb_ms09_off_StPage { get; set; } // Textbox thời gian tắt gạt bùn bể nén SM09

                bool[] mangCheckFocus = new bool[45];
            #endregion

            #region variable for different data UI and Data of Device
                public bool diff_tb_mkt01_StPage { get; set; } // Textbox MTK01
                public bool diff_tb_mkt02_StPage { get; set; } // Textbox MTK02
                public bool diff_tb_mkt03_StPage { get; set; } // Textbox MTK03

                public bool diff_tb_p101_StPage { get; set; } // Textbox P101
                public bool diff_tb_p102_StPage { get; set; } // Textbox P102
                public bool diff_tb_p103_StPage { get; set; } // Textbox P103

                public bool diff_tb_p201_StPage { get; set; } // Textbox P201
                public bool diff_tb_p202_StPage { get; set; } // Textbox P202


                public bool diff_tb_th1_StPage { get; set; } // Textbox TH1
                public bool diff_tb_th2_StPage { get; set; } // Textbox TH2
                public bool diff_tb_th3_StPage { get; set; } // Textbox TH3


                public bool diff_tb_sm01_StPage { get; set; } // Textbox Anoxic SM01
                public bool diff_tb_sm02_StPage { get; set; } // Textbox Anoxic SM02

                public bool diff_tb_wp02a_StPage { get; set; } // Textbox Bơm điều hòa WP02A
                public bool diff_tb_wp02b_StPage { get; set; } // Textbox Bơm điều hòa WP02B

                public bool diff_tb_sm03_StPage { get; set; } // Textbox Bơm Anoxic 34 "SM03"
                public bool diff_tb_sm04_StPage { get; set; } // Textbox Bơm Anoxic 34 "SM04"

                public bool diff_tb_ab06a_StPage { get; set; } // Textbox AB06A
                public bool diff_tb_ab06b_StPage { get; set; } // Textbox AB06B
                public bool diff_tb_ab06c_StPage { get; set; } // Textbox AB06C

                public bool diff_tb_sm05_StPage { get; set; } // Textbox Bơm Anoxic 56 "SM05"
                public bool diff_tb_sm06_StPage { get; set; } // Textbox Bơm Anoxic 56 "SM06"

                public bool diff_tb_sm07_StPage { get; set; } // Textbox Bơm Anoxic 78 "SM07"
                public bool diff_tb_sm08_StPage { get; set; } // Textbox Bơm Anoxic 78 "SM08"

                public bool diff_tb_mtk01_StPage { get; set; } // Textbox MTK01
                public bool diff_tb_mtk02_StPage { get; set; } // Textbox MTK02
                public bool diff_tb_mtk03_StPage { get; set; } // Textbox MTK03

                public bool diff_tb_bb12_on_StPage { get; set; } // Textbox thời gian bật bơm bùn 12
                public bool diff_tb_bb12_off_StPage { get; set; } // Textbox thời gian tắt bơm bùn 12

                public bool diff_tb_bomMetanol_on_StPage { get; set; } // Textbox thời gian bật bơm Metanol
                public bool diff_tb_bomMetanol_off_StPage { get; set; } // Textbox thời gian tắt bơm Metanol

                public bool diff_tb_gb1_on_StPage { get; set; } // Textbox thời gian bật gạt bùn 1
                public bool diff_tb_gb1_off_StPage { get; set; } // Textbox thời gian tắt gạt bùn 1

                public bool diff_tb_khuayNaoh_on_StPage { get; set; } // Textbox thời gian bật khuấy Naoh
                public bool diff_tb_khuayNaoh_off_StPage { get; set; } // Textbox thời gian tắt khuấy NAOH

                public bool diff_tb_ms05_on_StPage { get; set; } // Textbox thời gian bật khuấy Naoh
                public bool diff_tb_ms05_off_StPage { get; set; } // Textbox thời gian tắt khuấy NAOH
                public bool diff_tb_ms07_on_StPage { get; set; } // Textbox thời gian bật gạt bùn bể lắng 07
                public bool diff_tb_ms07_off_StPage { get; set; } // Textbox thời gian tắt gạt bùn bể lắng 07

                public bool diff_tb_sp05ab_on_StPage { get; set; } // Textbox thời gian bật bơm bùn 05
                public bool diff_tb_sp05ab_off_StPage { get; set; } // Textbox thời gian tắt bơm bùn 05

                public bool diff_tb_sp07ab_on_StPage { get; set; } // Textbox thời gian bật bơm bùn 07
                public bool diff_tb_sp07ab_off_StPage { get; set; } // Textbox thời gian tắt bơm bùn 07

                public bool diff_tb_ms09_on_StPage { get; set; } // Textbox thời gian bật gạt bùn bể nén SM09
                public bool diff_tb_ms09_off_StPage { get; set; } // Textbox thời gian tắt gạt bùn bể nén SM09
            #endregion

            #region Variables for checking setting value (Error provider)
                short stTime_mkt01, stTime_mkt02, stTime_mkt03 = 0;
                short stTime_sm01, stTime_sm02, stTime_sm03 = 0;
                short stTime_sm04, stTime_sm05, stTime_sm06 = 0;
                short stTime_sm07, stTime_sm08 = 0;

                short stTime_sp05ab_on, stTime_sp05ab_off = 0;

                short stTime_p101, stTime_p102, stTime_p103 = 0;
                short stTime_th1, stTime_th2, stTime_th3 = 0;

                short stTime_mt1_on, stTime_mt1_off = 0;
                short stTime_gb1_on, stTime_gb1_off = 0;
                short stTime_naoh_on, stTime_naoh_off = 0;
                short stTime_mtk01, stTime_mtk02, stTime_mtk03 = 0;

                short stTime_sp07ab_on, stTime_sp07ab_off = 0;
                short stTime_p201, stTime_p202 = 0;
                short stTime_bb12_on, stTime_bb12_off = 0;

                short stTime_wp02a, stTime_wp02b = 0;
                short stTime_ab06a, stTime_ab06b, stTime_ab06c = 0;

                short stTime_ms05_on, stTime_ms05_off = 0;
                short stTime_ms07_on, stTime_ms07_off = 0;
                short stTime_ms09_on, stTime_ms09_off = 0;
                public bool allCheckResult { get; set; } // true => have error input
            #endregion

        #endregion

        #region CONSTRUCTOR
        public SETTING()
            {
                InitializeComponent();
                //this.Padding = new Padding(borderSize);
            }

            public SETTING(Form _frm)
            {
                InitializeComponent();
                parentForm = _frm;
            }
        #endregion

        #region EVENT METHOD
            private void standardControl1_Load(object sender, EventArgs e)
            {
            }

            private void SETTING_Load(object sender, EventArgs e)
            {
                parentForm.Enabled = false;
                parentForm.TopMost = false;

                try
                {
                    this.ActiveControl = null;

                    Timer_settingPage = new System.Timers.Timer();
                    Timer_settingPage.Interval = updatePeriod;
                    Timer_settingPage.Elapsed += updateEventHandler;
                    Timer_settingPage.AutoReset = true;
                    Timer_settingPage.Enabled = true;
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                
            }

          

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }

            /// <summary>
            /// Behavior as click on three set button
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnMaximize_settingPage_Click(object sender, EventArgs e)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    formSize = this.ClientSize;
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Size = formSize;
                }
            }

            private void btnClose_settingPage_Click(object sender, EventArgs e)
            {
                this.Close();
                parentForm.Enabled = true;
            }

            private void btnMinimize_settingPage_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            /// <summary>
            /// Tiền định nghĩa di chuyển panel header
            /// </summary>
            //Drag Form
            [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
            [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

            private void pnHeader_settingPage_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

            private void SETTING_Resize(object sender, EventArgs e)
            {
                //AdjustForm();
            }

            //private void AdjustForm()
            //{
            //    switch (this.WindowState)
            //    {
            //        case FormWindowState.Maximized: //Maximized form (After)
            //            this.Padding = new Padding(2, 2, 2, 2);
            //            break;
            //        case FormWindowState.Normal: //Restored form (After)
            //            if (this.Padding.Top != borderSize)
            //                this.Padding = new Padding(borderSize);
            //            break;
            //    }
            //}

            private void btnClose_settingPage_Click_1(object sender, EventArgs e)
            {
                this.updateEnable = false;
                Timer_settingPage.Enabled = false;

                parentForm.Enabled = true;
                parentForm.TopMost = true;
                parentForm.WindowState = FormWindowState.Maximized;
                this.Close();

                parentForm.Invalidate();
            }

            private void btnClose_settingPage_MouseHover(object sender, EventArgs e)
            {

            }

            private void btnClose_settingPage_MouseLeave(object sender, EventArgs e)
            {
            }

            private void btnExit_settingPage_Click(object sender, EventArgs e)
            {
                this.updateEnable = false;
                Timer_settingPage.Enabled = false;

                parentForm.Enabled = true;
                parentForm.TopMost = true;
                parentForm.WindowState = FormWindowState.Maximized;
                this.Close();

                Program.framePage.TopMost = true;
                Program.framePage.WindowState = FormWindowState.Maximized;

                parentForm.Invalidate();
            }

            #region Get focus on event fall on Textbox
                /// <summary>
                /// Get event focus on Textbox "MTK01"
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void tbMKT01_beDieuHoa_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_mtk01_StPage = true;
                    Console.WriteLine("Focus MTK01: true {0}", focusOnEvent_tb_mtk01_StPage);
                }

                private void tbMKT01_beDieuHoa_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_mtk01_StPage = false;
                    Console.WriteLine("Focus MTK01: false {0}", focusOnEvent_tb_mtk01_StPage);
                }

                private void tbMKT02_beDieuHoa_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_mtk02_StPage = true;
                }

                private void tbMKT02_beDieuHoa_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_mtk02_StPage = false;
                }

                private void tbMKT03_beDieuHoa_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_mtk03_StPage = true;
                }

                private void tbMKT03_beDieuHoa_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_mtk03_StPage = false;
                }

                private void tbSM01_beAnoxic_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm01_StPage = true;
                }

                private void tbSM01_beAnoxic_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm01_StPage = false;
                }

                private void tbSM02_beAnoxic_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm02_StPage = true;
                }

                private void tbSM02_beAnoxic_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm02_StPage = false;
                }

                private void tbSM03_beAnoxic_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm03_StPage = true;
                }

                private void tbSM03_beAnoxic_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm03_StPage = false;
                }

                private void tbSM04_beAnoxic_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm04_StPage = true;
                }

                private void tbSM04_beAnoxic_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm04_StPage = false;
                }

                private void tbSM05_beAnoxic_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm05_StPage = true;
                }

                private void tbSM05_beAnoxic_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm05_StPage = false;
                }

                private void tbSM06_beAnoxic_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm06_StPage = true;
                }

                private void tbSM06_beAnoxic_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm06_StPage = false;
                }

                private void tbSM07_beAnoxic_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm07_StPage = true;
                }

                private void tbSM07_beAnoxic_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm07_StPage = false;
                }

                private void tbSM08_beAnoxic_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm08_StPage = true;
                }

                private void tbSM08_beAnoxic_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sm08_StPage = false;
                }

                private void tbOn_bomBunSP05AB_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sp05ab_on_StPage = true;
                }

                private void tbOn_bomBunSP05AB_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sp05ab_on_StPage = true;
                }

                private void tbOff_bomBunSP05AB_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sp05ab_off_StPage = true;
                }

                private void tbOff_bomBunSP05AB_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sp05ab_off_StPage = false;
                }

                private void tbP0101_beGom_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_p101_StPage = true;
                }

                private void tbP0101_beGom_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_p101_StPage = false;
                }

                private void tbP0102_beGom_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_p102_StPage = true;
                }

                private void tbP0102_beGom_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_p102_StPage = false;
                }

                private void tbP0103_beGom_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_p103_StPage = true;
                }

                private void tbP0103_beGom_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_p103_StPage = false;
                }

                private void tbTH1_beTuanHoan_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_th1_StPage = true;
                }

                private void tbTH1_beTuanHoan_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_th1_StPage = false;
                }

                private void tbTH2_beTuanHoan_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_th2_StPage = true;
                }

                private void tbTH2_beTuanHoan_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_th2_StPage = false;
                }

                private void tbTH3_beTuanHoan_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_th3_StPage = true;
                }

                private void tbTH3_beTuanHoan_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_th3_StPage = false;
                }

                private void tbOn_bomHoaChatMT1_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_bomMetanol_on_StPage = true;
                }

                private void tbOn_bomHoaChatMT1_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_bomMetanol_on_StPage = false;
                }

                private void tbOff_bomHoaChatMT1_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_bomMetanol_off_StPage = true;
                }

                private void tbOff_bomHoaChatMT1_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_bomMetanol_off_StPage = false;
                }

                private void tbOn_gatBunGB1_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_gb1_on_StPage = true;
                }

                private void tbOn_gatBunGB1_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_gb1_off_StPage = false;
                }

                private void tbOff_gatBunGB1_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_gb1_off_StPage = true;
                }

                private void tbOff_gatBunGB1_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_gb1_off_StPage = false;
                }

                private void tbOn_khuayNaohNAOH_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_khuayNaoh_on_StPage = true;
                }

                private void tbOn_khuayNaohNAOH_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_khuayNaoh_on_StPage = false;
                }

                private void tbOff_khuayNaohNAOH_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_khuayNaoh_off_StPage = true;
                }

                private void tbOff_khuayNaohNAOH_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_khuayNaoh_off_StPage = false;
                }

                private void tbMTK1_beAerotank_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_mtk01_StPage = true;
                }

                private void tbMTK1_beAerotank_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_mtk01_StPage = false;
                }

                private void tbMTK2_beAerotank_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_mtk02_StPage = true;
                }

                private void tbMTK2_beAerotank_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_mtk02_StPage = false;
                }

                private void tbMTK3_beAerotank_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_mtk03_StPage = true;
                }

                private void tbMTK3_beAerotank_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_mtk03_StPage = false;
                }

                private void tbOn_bomBunSP07AB_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sp07ab_on_StPage = true;
                }

                private void tbOn_bomBunSP07AB_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sp07ab_on_StPage = false;
                }

                private void tbOff_bomBunSP07AB_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sp07ab_off_StPage = true;
                }

                private void tbOff_bomBunSP07AB_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_sp07ab_off_StPage = false;
                }

                private void tbP0201_beDieuHoa_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_p201_StPage = true;
                }

                private void tbP0201_beDieuHoa_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_p201_StPage = false;
                }

                private void tbP0202_beDieuHoa_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_p202_StPage = true;
                }

                private void tbP0202_beDieuHoa_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_p202_StPage = false;
                }

                private void tbOn_bomBunBB12_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_bb12_on_StPage = true;
                }

                private void tbOn_bomBunBB12_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_bb12_on_StPage = false;
                }

                private void tbOff_bomBunBB12_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_bb12_off_StPage = true;
                }

                private void tbOff_bomBunBB12_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_bb12_off_StPage = false;
                }

        private void btnExit_settingPage_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void SETTING_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void tbWP02A_beDieuHoa_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_wp02a_StPage = true;
                }

                private void tbWP02A_beDieuHoa_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_wp02a_StPage = false;
                }

        private void btnOk_settingPage_Click(object sender, EventArgs e)
        {
            checkInValueIn();

            if(allCheckResult == false)
            {
                updateEnable = false;// Dừng cho phép implement hàm cập nhật dữ liệu runtime
                Program.plc1_stopOtherConnecting = true;
                Program.plc2_stopOtherConnecting = true;
                Program.plc3_stopOtherConnecting = true;

                if (allCheckResult == false)
                {
                    writeRuntimeSetting();
                }
                else
                {
                    allCheckResult = false; // RESET VALUE OF CHECK ALL TEXTBOX ERROR
                }

                updateEnable = true; // Dừng cho phép implement hàm cập nhật dữ liệu runtime
                Program.plc1_stopOtherConnecting = false;
                Program.plc2_stopOtherConnecting = false;
                Program.plc3_stopOtherConnecting = false;

                parentForm.Enabled = true;
                parentForm.TopMost = true;
                parentForm.WindowState = FormWindowState.Maximized;
                this.Close();

                parentForm.Enabled = true;
                parentForm.Invalidate();
            }

        }

        private void SETTING_LocationChanged(object sender, EventArgs e)
        {

        }

        private void tbWP02B_beDieuHoa_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_wp02b_StPage = true;
                }

                private void tbWP02B_beDieuHoa_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_wp02b_StPage = false;
                }

                private void tbAB06A_beBiofor_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ab06a_StPage = true;
                }

                private void tbAB06A_beBiofor_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ab06a_StPage = false;
                }

                private void tbAB06B_beBiofor_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ab06b_StPage = true;
                }

                private void tbAB06B_beBiofor_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ab06b_StPage = false;
                }

                private void tbAB06C_beBiofor_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ab06c_StPage = true;
                }

                private void tbAB06C_beBiofor_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ab06c_StPage = false;
                }

                private void tbOn_gatBunMS05_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ms05_on_StPage = true;
                }

                private void tbOn_gatBunMS05_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ms05_on_StPage = false;
                }

                private void tbOff_gatBunMS05_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ms05_off_StPage = true;
                }

                private void tbOff_gatBunMS05_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ms05_off_StPage = false;
                }

                private void tbOn_gatBunMS07_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ms07_on_StPage = true;
                }

                private void tbOn_gatBunMS07_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ms07_on_StPage = false;
                }

                private void tbOff_gatBunMS07_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ms07_off_StPage = true;
                }

                private void tbOff_gatBunMS07_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ms07_off_StPage = false;
                }

                private void tbOn_gatBunMS09_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ms09_on_StPage = true;
                }

                private void tbOn_gatBunMS09_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ms09_on_StPage = false;
                }

                private void tbOff_gatBunMS09_settingPage_MouseEnter(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ms09_off_StPage = true;
                }

                private void tbOff_gatBunMS09_settingPage_MouseLeave(object sender, EventArgs e)
                {
                    focusOnEvent_tb_ms09_off_StPage = false;
                }

                private void btnApply_settingPage_Click(object sender, EventArgs e)
                {
                    updateEnable = false;// Dừng cho phép implement hàm cập nhật dữ liệu runtime setting 
                    Program.plc1_stopOtherConnecting = true;
                    Program.plc2_stopOtherConnecting = true;
                    Program.plc3_stopOtherConnecting = true;


                     this.ActiveControl = null; // Bỏ việc focus textbox
                    bool a = checkInValueIn();

                    if (allCheckResult == false)
                    {
                        writeRuntimeSetting();
                    }
                    else
                    {
                        allCheckResult = false; // RESET VALUE OF CHECK ALL TEXTBOX ERROR
                    }    

                    updateEnable = true;
                    Program.plc1_stopOtherConnecting = false;
                    Program.plc2_stopOtherConnecting = false;
                    Program.plc3_stopOtherConnecting = false;
        }
        #endregion
        #endregion

        #region METHOD
                // WORKING HANDLER
                #region Working Handler
                /// <summary>
                /// Update status of field devices to UI
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                public void updateEventHandler(object sender, ElapsedEventArgs e)
                    {
                            // MỨC PHAO BỂ GOM
                            #region MỨC PHAO BỂ GOM
                            // Mức thấp: Signal= true => low level
                            bool lowValue = Program.InputStatus_PLC1.low_beGom_float;
                            bool mediValue = Program.InputStatus_PLC1.medium_beGom_float;
                            bool highValue = Program.InputStatus_PLC1.high_beGom_float;

                            switch (lowValue)
                            {
                                case false: // 0xx
                                    switch (mediValue)
                                    {
                                        case false: // 00x
                                            switch (highValue)
                                            {
                                                case false: //=> LOW LEVEL
                                                            // LOW LIGHT: TURN ON
                                                    lowFloat_beGom_settingPage.DiscreteValue1 = true;
                                                    lowFloat_beGom_settingPage.DiscreteValue2 = false;
                                                    lowFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // MEDIUM LIGHT: TURN OFF
                                                    mediumFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    mediumFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    mediumFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // HIGH LIGHT: TURN OFF
                                                    highFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    highFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    highFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    break;
                                                case true: // FLOAT ERROR : L-M-H: 001 => ALARM (H)
                                                            // LOW LIGHT: TURN OFF
                                                    lowFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    lowFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    lowFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // MEDIUM LIGHT: TURN OFF
                                                    mediumFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    mediumFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    mediumFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // HIGH LIGHT: BLINK WITH YELLOW COLOR
                                                    highFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    highFloat_beGom_settingPage.DiscreteValue2 = false;
                                                    highFloat_beGom_settingPage.DiscreteValue3 = true;
                                                    break;

                                            }
                                            break;
                                        case true: // 01x
                                            switch (highValue)
                                            {
                                                case false: // 010 => ALARM (M)
                                                            // LOW LIGHT: TURN OFF
                                                    lowFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    lowFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    lowFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // MEDIUM LIGHT: BLINK WITH YELLOW COLOR
                                                    mediumFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    mediumFloat_beGom_settingPage.DiscreteValue2 = false;
                                                    mediumFloat_beGom_settingPage.DiscreteValue3 = true;
                                                    // HIGH LIGHT: TURN OFF
                                                    highFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    highFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    highFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    break;
                                                case true: // FLOAT ERROR : L-M-H: 011 => ALARM (L)
                                                            // LOW LIGHT: BLINK WITH YELLOW COLOR
                                                    lowFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    lowFloat_beGom_settingPage.DiscreteValue2 = false;
                                                    lowFloat_beGom_settingPage.DiscreteValue3 = true;
                                                    // MEDIUM LIGHT: TURN OFF
                                                    mediumFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    mediumFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    mediumFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // HIGH LIGHT: TURN OFF
                                                    highFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    highFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    highFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    break;

                                            }
                                            break;
                                    }
                                    break;
                                case true: // 1xx
                                    switch (mediValue)
                                    {
                                        case false: // 10x
                                            switch (highValue)
                                            {
                                                case false: // 100 => LOW LEVEL
                                                            // LOW LIGHT: TURN ON
                                                    lowFloat_beGom_settingPage.DiscreteValue1 = true;
                                                    lowFloat_beGom_settingPage.DiscreteValue2 = false;
                                                    lowFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // MEDIUM LIGHT: TURN OFF
                                                    mediumFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    mediumFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    mediumFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // HIGH LIGHT: TURN OFF
                                                    highFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    highFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    highFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    break;
                                                case true: // FLOAT ERROR : L-M-H: 101 => ALARM (H)
                                                            // LOW LIGHT: TURN OFF
                                                    lowFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    lowFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    lowFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // MEDIUM LIGHT: TURN OFF
                                                    mediumFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    mediumFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    mediumFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // HIGH LIGHT: BLINK WITH YELLOW COLOR
                                                    highFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    highFloat_beGom_settingPage.DiscreteValue2 = false;
                                                    highFloat_beGom_settingPage.DiscreteValue3 = true;
                                                    break;

                                            }
                                            break;
                                        case true: // 11x
                                            switch (highValue)
                                            {
                                                case false: // L-M-H: 110 => MEDIUM LEVEL
                                                            // LOW LIGHT: TURN OFF
                                                    lowFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    lowFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    lowFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // MEDIUM LIGHT: TURN ON
                                                    mediumFloat_beGom_settingPage.DiscreteValue1 = true;
                                                    mediumFloat_beGom_settingPage.DiscreteValue2 = false;
                                                    mediumFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // HIGH LIGHT: TURN OFF
                                                    highFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    highFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    highFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    break;
                                                case true: // L-M-H: 111 => HIGH LEVEL
                                                            // LOW LIGHT: TURN OFF
                                                    lowFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    lowFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    lowFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // MEDIUM LIGHT: TURN OFF
                                                    mediumFloat_beGom_settingPage.DiscreteValue1 = false;
                                                    mediumFloat_beGom_settingPage.DiscreteValue2 = true;
                                                    mediumFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    // HIGH LIGHT: TURN ON
                                                    highFloat_beGom_settingPage.DiscreteValue1 = true;
                                                    highFloat_beGom_settingPage.DiscreteValue2 = false;
                                                    highFloat_beGom_settingPage.DiscreteValue3 = false;
                                                    break;

                                            }
                                            break;
                                    }
                                    break;
                            }

                            #endregion

                            // MỨC PHAO BỂ ĐIỀU HÒA
                            #region MỨC PHAO BỂ ĐIỀU HÒA
                            // Mức thấp: Signal= true => low level
                            bool lowValueDH = Program.InputStatus_PLC3.low_dieuHoa_float;
                            bool highValueDH = Program.InputStatus_PLC3.high_dieuHoa_float;

                            switch (lowValueDH)
                            {
                                case false: //L-H: 0x
                                    switch (highValueDH)
                                    {
                                        case false: // L-H: 00 => LOW LEVEL
                                                    // LOW LIGHT: TURN ON
                                            lowFloat_beDieuHoa_settingPage.DiscreteValue1 = true;
                                            lowFloat_beDieuHoa_settingPage.DiscreteValue2 = false;
                                            lowFloat_beDieuHoa_settingPage.DiscreteValue3 = false;
                                            // HIGH LIGHT: TURN OFF
                                            highFloat_beDieuHoa_settingPage.DiscreteValue1 = false;
                                            highFloat_beDieuHoa_settingPage.DiscreteValue2 = true;
                                            highFloat_beDieuHoa_settingPage.DiscreteValue3 = false;
                                            break;
                                        case true:// L-H: 01 => ALARM
                                                    // LOW LIGHT: BLINK WITH YELLOW COLOR
                                            lowFloat_beDieuHoa_settingPage.DiscreteValue1 = false;
                                            lowFloat_beDieuHoa_settingPage.DiscreteValue2 = false;
                                            lowFloat_beDieuHoa_settingPage.DiscreteValue3 = true;
                                            // HIGH LIGHT: BLINK WITH YELLOW COLOR
                                            highFloat_beDieuHoa_settingPage.DiscreteValue1 = false;
                                            highFloat_beDieuHoa_settingPage.DiscreteValue2 = false;
                                            highFloat_beDieuHoa_settingPage.DiscreteValue3 = true;
                                            break;
                                    }
                                    break;
                                case true: //L-H: 1x
                                    switch (highValueDH)
                                    {
                                        case false: // L-H: 10 => LOW LEVEL
                                                    // LOW LIGHT: TURN ON
                                            lowFloat_beDieuHoa_settingPage.DiscreteValue1 = true;
                                            lowFloat_beDieuHoa_settingPage.DiscreteValue2 = false;
                                            lowFloat_beDieuHoa_settingPage.DiscreteValue3 = false;
                                            // HIGH LIGHT: TURN OFF
                                            highFloat_beDieuHoa_settingPage.DiscreteValue1 = false;
                                            highFloat_beDieuHoa_settingPage.DiscreteValue2 = true;
                                            highFloat_beDieuHoa_settingPage.DiscreteValue3 = false;
                                            break;
                                        case true:// L-H: 11 => HIGH LEVEL
                                                    // LOW LIGHT: TURN OFF
                                            lowFloat_beDieuHoa_settingPage.DiscreteValue1 = false;
                                            lowFloat_beDieuHoa_settingPage.DiscreteValue2 = true;
                                            lowFloat_beDieuHoa_settingPage.DiscreteValue3 = false;
                                            // HIGH LIGHT: TURN ON
                                            highFloat_beDieuHoa_settingPage.DiscreteValue1 = true;
                                            highFloat_beDieuHoa_settingPage.DiscreteValue2 = false;
                                            highFloat_beDieuHoa_settingPage.DiscreteValue3 = false;
                                            break;
                                    }
                                    break;
                            }
                            #endregion

                            // Compare data
                            compare_dataUi_dataDevice();

                            // CHECK FOCUS ON TEXTBOX
                            #region Check
                                mangCheckFocus[0] = focusOnEvent_tb_mkt01_StPage;  // textbox mtk01
                                mangCheckFocus[1] = focusOnEvent_tb_mkt02_StPage;  // textbox mtk02
                                mangCheckFocus[2] = focusOnEvent_tb_mkt03_StPage;  // textbox mtk03
                                mangCheckFocus[3] = focusOnEvent_tb_p101_StPage;  // textbox p101
                                mangCheckFocus[4] = focusOnEvent_tb_p102_StPage;  // textbox p102
                                mangCheckFocus[5] = focusOnEvent_tb_p103_StPage;  // textbox p103
                                mangCheckFocus[6] = focusOnEvent_tb_p201_StPage;  // textbox p201
                                mangCheckFocus[7] = focusOnEvent_tb_p202_StPage;  // textbox p202
                                mangCheckFocus[8] = focusOnEvent_tb_th1_StPage;  // textbox th1
                                mangCheckFocus[9] = focusOnEvent_tb_th2_StPage;  // textbox th2
                                mangCheckFocus[10] = focusOnEvent_tb_th3_StPage;  // textbox th3
                                mangCheckFocus[11] = focusOnEvent_tb_sm01_StPage;  // textbox anoxic sm01
                                mangCheckFocus[12] = focusOnEvent_tb_sm02_StPage;  // textbox anoxic sm02
                                mangCheckFocus[13] = focusOnEvent_tb_wp02a_StPage;  // textbox bơm điều hòa wp02a
                                mangCheckFocus[14] = focusOnEvent_tb_wp02b_StPage;  // textbox bơm điều hòa wp02b
                                mangCheckFocus[15] = focusOnEvent_tb_sm03_StPage;  // textbox bơm anoxic 34 "sm03"
                                mangCheckFocus[16] = focusOnEvent_tb_sm04_StPage;  // textbox bơm anoxic 34 "sm04"
                                mangCheckFocus[17] = focusOnEvent_tb_ab06a_StPage;  // textbox ab06a
                                mangCheckFocus[18] = focusOnEvent_tb_ab06b_StPage;  // textbox ab06b
                                mangCheckFocus[19] = focusOnEvent_tb_ab06c_StPage;  // textbox ab06c
                                mangCheckFocus[20] = focusOnEvent_tb_sm05_StPage;  // textbox bơm anoxic 56 "sm05"
                                mangCheckFocus[21] = focusOnEvent_tb_sm06_StPage;  // textbox bơm anoxic 56 "sm06"
                                mangCheckFocus[22] = focusOnEvent_tb_sm07_StPage;  // textbox bơm anoxic 78 "sm07"
                                mangCheckFocus[23] = focusOnEvent_tb_sm08_StPage;  // textbox bơm anoxic 78 "sm08"
                                mangCheckFocus[24] = focusOnEvent_tb_mtk01_StPage;  // textbox mtk01
                                mangCheckFocus[25] = focusOnEvent_tb_mtk02_StPage;  // textbox mtk02
                                mangCheckFocus[26] = focusOnEvent_tb_mtk03_StPage;  // textbox mtk03
                                mangCheckFocus[27] = focusOnEvent_tb_bb12_on_StPage;  // textbox thời gian bật bơm bùn 12
                                mangCheckFocus[28] = focusOnEvent_tb_bb12_off_StPage;  // textbox thời gian tắt bơm bùn 12
                                mangCheckFocus[29] = focusOnEvent_tb_bomMetanol_on_StPage;  // textbox thời gian bật bơm metanol
                                mangCheckFocus[30] = focusOnEvent_tb_bomMetanol_off_StPage;  // textbox thời gian tắt bơm metanol
                                mangCheckFocus[31] = focusOnEvent_tb_gb1_on_StPage;  // textbox thời gian bật gạt bùn 1
                                mangCheckFocus[32] = focusOnEvent_tb_gb1_off_StPage;  // textbox thời gian tắt gạt bùn 1
                                mangCheckFocus[33] = focusOnEvent_tb_khuayNaoh_on_StPage;  // textbox thời gian bật khuấy naoh
                                mangCheckFocus[34] = focusOnEvent_tb_khuayNaoh_off_StPage;  // textbox thời gian tắt khuấy naoh
                                mangCheckFocus[35] = focusOnEvent_tb_ms05_on_StPage;  // textbox thời gian bật khuấy naoh
                                mangCheckFocus[36] = focusOnEvent_tb_ms05_off_StPage;  // textbox thời gian tắt khuấy naoh
                                mangCheckFocus[37] = focusOnEvent_tb_ms07_on_StPage;  // textbox thời gian bật gạt bùn bể lắng 07
                                mangCheckFocus[38] = focusOnEvent_tb_ms07_off_StPage;  // textbox thời gian tắt gạt bùn bể lắng 07
                                mangCheckFocus[39] = focusOnEvent_tb_sp05ab_on_StPage;  // textbox thời gian bật bơm bùn 05
                                mangCheckFocus[40] = focusOnEvent_tb_sp05ab_off_StPage;  // textbox thời gian tắt bơm bùn 05
                                mangCheckFocus[41] = focusOnEvent_tb_sp07ab_on_StPage;  // textbox thời gian bật bơm bùn 07
                                mangCheckFocus[42] = focusOnEvent_tb_sp07ab_off_StPage;  // textbox thời gian tắt bơm bùn 07
                                mangCheckFocus[43] = focusOnEvent_tb_ms09_on_StPage;  // textbox thời gian bật gạt bùn bể nén sm09
                                mangCheckFocus[44] = focusOnEvent_tb_ms09_off_StPage;  // textbox thời gian tắt gạt bùn bể nén sm09

                                for(int i = 0; i < 45; i++)
                                {
                                    tb_focusOn_stPage = tb_focusOn_stPage | mangCheckFocus[i];
                                    if(tb_focusOn_stPage)
                                    {
                                        return;
                                    }  
                                }
                            #endregion

                            // Update Runtime Setting to UI
                            updateRuntimeSettingToUI(tb_focusOn_stPage, updateEnable);

                    }
                #endregion
           
                // FUNC hiển thị lỗi nhập => tên control "Error provider"
                public bool checkInValueIn()
                {
                    try{
                        allCheckResult = false;
                        errProv_mkt01.SetError(tbMKT01_beDieuHoa_settingPage, "");
                        errProv_mkt02.SetError(tbMKT02_beDieuHoa_settingPage, "");
                        errProv_mkt03.SetError(tbMKT03_beDieuHoa_settingPage, "");

                        errProv_sm01.SetError(tbSM01_beAnoxic_settingPage, "");
                        errProv_sm02.SetError(tbSM02_beAnoxic_settingPage, "");

                        errProv_sm03.SetError(tbSM03_beAnoxic_settingPage, "");
                        errProv_sm04.SetError(tbSM04_beAnoxic_settingPage, "");

                        errProv_sm05.SetError(tbSM05_beAnoxic_settingPage, "");
                        errProv_sm06.SetError(tbSM06_beAnoxic_settingPage, "");

                        errProv_sm07.SetError(tbSM07_beAnoxic_settingPage, "");
                        errProv_sm08.SetError(tbSM08_beAnoxic_settingPage, "");

                        errProv_sp05ab_on.SetError(tbOn_bomBunSP05AB_settingPage, "");
                        errProv_sp05ab_off.SetError(tbOff_bomBunSP05AB_settingPage, "");

                        errProv_p101.SetError(tbP0101_beGom_settingPage, "");
                        errProv_p102.SetError(tbP0102_beGom_settingPage, "");
                        errProv_p103.SetError(tbP0103_beGom_settingPage, "");

                        errProv_th1.SetError(tbTH1_beTuanHoan_settingPage, "");
                        errProv_th2.SetError(tbTH2_beTuanHoan_settingPage, "");
                        errProv_th3.SetError(tbTH3_beTuanHoan_settingPage, "");

                        errProv_mt1_on.SetError(tbOn_bomHoaChatMT1_settingPage, "");
                        errProv_mt1_off.SetError(tbOff_bomHoaChatMT1_settingPage, "");

                        errProv_gb1_on.SetError(tbOn_gatBunGB1_settingPage, "");
                        errProv_gb1_off.SetError(tbOff_gatBunGB1_settingPage, "");

                        errProv_naoh_on.SetError(tbOn_khuayNaohNAOH_settingPage, "");
                        errProv_naoh_off.SetError(tbOff_khuayNaohNAOH_settingPage, "");

                        errProv_mtk01.SetError(tbMTK1_beAerotank_settingPage, "");
                        errProv_mtk02.SetError(tbMTK2_beAerotank_settingPage, "");
                        errProv_mtk03.SetError(tbMTK3_beAerotank_settingPage, "");


                        errProv_sp07ab_on.SetError(tbOn_bomBunSP07AB_settingPage, "");
                        errProv_sp07ab_off.SetError(tbOff_bomBunSP07AB_settingPage, "");

                        errProv_p201.SetError(tbP0201_beDieuHoa_settingPage, "");
                        errProv_p202.SetError(tbP0202_beDieuHoa_settingPage, "");

                        errProv_bb12_on.SetError(tbOn_bomBunBB12_settingPage, "");
                        errProv_bb12_off.SetError(tbOff_bomBunBB12_settingPage, "");

                        errProv_wp02a.SetError(tbWP02A_beDieuHoa_settingPage, "");
                        errProv_wp02b.SetError(tbWP02B_beDieuHoa_settingPage, "");

                        errProv_ab06a.SetError(tbAB06A_beBiofor_settingPage, "");
                        errProv_ab06b.SetError(tbAB06B_beBiofor_settingPage, "");
                        errProv_ab06c.SetError(tbAB06C_beBiofor_settingPage, "");

                        errProv_ms05_on.SetError(tbOn_gatBunMS05_settingPage, "");
                        errProv_ms05_off.SetError(tbOff_gatBunMS05_settingPage, "");

                        errProv_ms07_on.SetError(tbOn_gatBunMS07_settingPage, "");
                        errProv_ms07_off.SetError(tbOff_gatBunMS07_settingPage, "");

                        errProv_ms09_on.SetError(tbOn_gatBunMS09_settingPage, "");
                        errProv_ms09_off.SetError(tbOff_gatBunMS09_settingPage, "");

                        // MKT01 - GD2
                        if (short.TryParse(tbMKT01_beDieuHoa_settingPage.Text, out stTime_mkt01) == false)
                        {
                            errProv_mkt01.SetError(tbMKT01_beDieuHoa_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_mkt01 < settingLowerThreshold | stTime_mkt01 > settingUpperThreshold)
                        {
                            errProv_mkt01.SetError(tbMKT01_beDieuHoa_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbMKT01_beDieuHoa_settingPage.Tag = stTime_mkt01;
                            Program.RuntimeSetting_UI_PLC2.mkt01_setTime_ui = stTime_mkt01; 
                        }
                

                        // MKT02 - GD2
                        if (short.TryParse(tbMKT02_beDieuHoa_settingPage.Text, out stTime_mkt02) == false)
                        {
                            errProv_mkt02.SetError(tbMKT02_beDieuHoa_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_mkt02 < settingLowerThreshold | stTime_mkt02 > settingUpperThreshold)
                        {
                            errProv_mkt02.SetError(tbMKT02_beDieuHoa_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbMKT02_beDieuHoa_settingPage.Tag = stTime_mkt02;
                            Program.RuntimeSetting_UI_PLC2.mkt02_setTime_ui = stTime_mkt02; //Cho SETTIME UI = Gía trị ô textbox
                        }

                        // MTK03
                        if (short.TryParse(tbMKT03_beDieuHoa_settingPage.Text, out stTime_mkt03) == false)
                        {
                            errProv_mkt03.SetError(tbMKT03_beDieuHoa_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_mkt03 < settingLowerThreshold | stTime_mkt03 > settingUpperThreshold)
                        {
                            errProv_mkt03.SetError(tbMKT03_beDieuHoa_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbMKT03_beDieuHoa_settingPage.Tag = stTime_mkt03;
                            Program.RuntimeSetting_UI_PLC2.mkt03_setTime_ui = stTime_mkt03;
                        }


                        // SM01 - GD1MR
                        if (short.TryParse(tbSM01_beAnoxic_settingPage.Text, out stTime_sm01) == false)
                        {
                            errProv_sm01.SetError(tbSM01_beAnoxic_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_sm01 < settingLowerThreshold | stTime_sm01 > settingUpperThreshold)
                        {
                            errProv_sm01.SetError(tbSM01_beAnoxic_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbSM01_beAnoxic_settingPage.Tag = stTime_sm01;
                            Program.RuntimeSetting_UI_PLC2.anoxic1_setTime_ui = stTime_sm01;
                        }

                        // SM02
                        if (short.TryParse(tbSM02_beAnoxic_settingPage.Text, out stTime_sm02) == false)
                        {
                            errProv_sm02.SetError(tbSM02_beAnoxic_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_sm02 < settingLowerThreshold | stTime_sm02 > settingUpperThreshold)
                        {
                            errProv_sm02.SetError(tbSM02_beAnoxic_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbSM02_beAnoxic_settingPage.Tag = stTime_sm02;
                            Program.RuntimeSetting_UI_PLC2.anoxic2_setTime_ui = stTime_sm02;
                            
                        }

                        // SM03
                        if (short.TryParse(tbSM03_beAnoxic_settingPage.Text, out stTime_sm03) == false)
                        {
                            errProv_sm03.SetError(tbSM03_beAnoxic_settingPage, "You have not entered correctly!");
                            allCheckResult = true;

                        }

                        else if (stTime_sm03 < settingLowerThreshold | stTime_sm03 > settingUpperThreshold)
                        {
                            errProv_sm03.SetError(tbSM03_beAnoxic_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;

                        }
                        else
                        {
                            tbSM03_beAnoxic_settingPage.Tag = stTime_sm03;
                            Program.RuntimeSetting_UI_PLC2.anoxic3_setTime_ui = stTime_sm03;
                        }

                        // SM04
                        if (short.TryParse(tbSM04_beAnoxic_settingPage.Text, out stTime_sm04) == false)
                        {
                            errProv_sm04.SetError(tbSM04_beAnoxic_settingPage, "You have not entered correctly!");
                            allCheckResult = true;

                        }

                        else if (stTime_sm04 < settingLowerThreshold | stTime_sm04 > settingUpperThreshold)
                        {
                            errProv_sm04.SetError(tbSM04_beAnoxic_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbSM04_beAnoxic_settingPage.Tag = stTime_sm04;
                            Program.RuntimeSetting_UI_PLC2.anoxic4_setTime_ui = stTime_sm04;
                        }

                        // SM05
                        if (short.TryParse(tbSM05_beAnoxic_settingPage.Text, out stTime_sm05) == false)
                        {
                            errProv_sm05.SetError(tbSM05_beAnoxic_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_sm05 < settingLowerThreshold | stTime_sm05 > settingUpperThreshold)
                        {
                            errProv_sm05.SetError(tbSM05_beAnoxic_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbSM05_beAnoxic_settingPage.Tag = stTime_sm05;
                            Program.RuntimeSetting_UI_PLC2.anoxic5_setTime_ui = stTime_sm05;
                        }

                        // SM06
                        if (short.TryParse(tbSM06_beAnoxic_settingPage.Text, out stTime_sm06) == false)
                        {
                            errProv_sm06.SetError(tbSM06_beAnoxic_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_sm06 < settingLowerThreshold | stTime_sm06 > settingUpperThreshold)
                        {
                            errProv_sm06.SetError(tbSM06_beAnoxic_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbSM06_beAnoxic_settingPage.Tag = stTime_sm06;
                            Program.RuntimeSetting_UI_PLC2.anoxic6_setTime_ui = stTime_sm06;
                        }

                        // SM07
                        if (short.TryParse(tbSM07_beAnoxic_settingPage.Text, out stTime_sm07) == false)
                        {
                            errProv_sm07.SetError(tbSM07_beAnoxic_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_sm07 < settingLowerThreshold | stTime_sm07 > settingUpperThreshold)
                        {
                            errProv_sm07.SetError(tbSM07_beAnoxic_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbSM07_beAnoxic_settingPage.Tag = stTime_sm07;
                            Program.RuntimeSetting_UI_PLC2.anoxic7_setTime_ui = stTime_sm07;
                        }

                        // SM08
                        if (short.TryParse(tbSM08_beAnoxic_settingPage.Text, out stTime_sm08) == false)
                        {
                            errProv_sm08.SetError(tbSM08_beAnoxic_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_sm08 < settingLowerThreshold | stTime_sm08 > settingUpperThreshold)
                        {
                            errProv_sm08.SetError(tbSM08_beAnoxic_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbSM08_beAnoxic_settingPage.Tag = stTime_sm08;
                            Program.RuntimeSetting_UI_PLC2.anoxic8_setTime_ui = stTime_sm08;
                        }

                        // SP05AB ON - 
                        if (short.TryParse(tbOn_bomBunSP05AB_settingPage.Text, out stTime_sp05ab_on) == false)
                        {
                            errProv_sp05ab_on.SetError(tbOn_bomBunSP05AB_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_sp05ab_on < settingLowerThreshold | stTime_sp05ab_on > settingUpperThreshold)
                        {
                            errProv_sp05ab_on.SetError(tbOn_bomBunSP05AB_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOn_bomBunSP05AB_settingPage.Tag = stTime_sp05ab_on;
                            Program.RuntimeSetting_UI_PLC3.bomBun_05AB_setTime_on_ui = stTime_sp05ab_on;
                        }


                        // SP05AB OFF
                        if (short.TryParse(tbOff_bomBunSP05AB_settingPage.Text, out stTime_sp05ab_off) == false)
                        {
                            errProv_sp05ab_off.SetError(tbOff_bomBunSP05AB_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_sp05ab_off < settingLowerThreshold | stTime_sp05ab_off > settingUpperThreshold)
                        {
                            errProv_sp05ab_off.SetError(tbOff_bomBunSP05AB_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOff_bomBunSP05AB_settingPage.Tag = stTime_sp05ab_off;
                            Program.RuntimeSetting_UI_PLC3.bomBun_05AB_setTime_off_ui = stTime_sp05ab_off;
                        }

                        // P101
                        if (short.TryParse(tbP0101_beGom_settingPage.Text, out stTime_p101) == false)
                        {
                            errProv_p101.SetError(tbP0101_beGom_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_p101 < settingLowerThreshold | stTime_p101 > settingUpperThreshold)
                        {
                            errProv_p101.SetError(tbP0101_beGom_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbP0101_beGom_settingPage.Tag = stTime_p101;
                            Program.RuntimeSetting_UI_PLC1.beGom1_setTime_ui = stTime_p101;
                        }

                        // P102
                        if (short.TryParse(tbP0102_beGom_settingPage.Text, out stTime_p102) == false)
                        {
                            errProv_p102.SetError(tbP0102_beGom_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_p102 < settingLowerThreshold | stTime_p102 > settingUpperThreshold)
                        {
                            errProv_p102.SetError(tbP0102_beGom_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbP0102_beGom_settingPage.Tag = stTime_p102;
                            Program.RuntimeSetting_UI_PLC1.beGom2_setTime_ui = stTime_p102;
                        }

                        // P103
                        if (short.TryParse(tbP0103_beGom_settingPage.Text, out stTime_p103) == false)
                        {
                            errProv_p103.SetError(tbP0103_beGom_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_p103 < settingLowerThreshold | stTime_p103 > settingUpperThreshold)
                        {
                            errProv_p103.SetError(tbP0103_beGom_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbP0103_beGom_settingPage.Tag = stTime_p103;
                            Program.RuntimeSetting_UI_PLC1.beGom3_setTime_ui = stTime_p103;
                        }

                        // TH1
                        if (short.TryParse(tbTH1_beTuanHoan_settingPage.Text, out stTime_th1) == false)
                        {
                            errProv_th1.SetError(tbTH1_beTuanHoan_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_th1 < settingLowerThreshold | stTime_th1 > settingUpperThreshold)
                        {
                            errProv_th1.SetError(tbTH1_beTuanHoan_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbTH1_beTuanHoan_settingPage.Tag = stTime_th1;
                            Program.RuntimeSetting_UI_PLC2.tuanHoan1_setTime_ui = stTime_th1;
                        }

                        // TH2
                        if (short.TryParse(tbTH2_beTuanHoan_settingPage.Text, out stTime_th2) == false)
                        {
                            errProv_th2.SetError(tbTH2_beTuanHoan_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_th2 < settingLowerThreshold | stTime_th2 > settingUpperThreshold)
                        {
                            errProv_th2.SetError(tbTH2_beTuanHoan_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbTH2_beTuanHoan_settingPage.Tag = stTime_th2;
                            Program.RuntimeSetting_UI_PLC2.tuanHoan2_setTime_ui = stTime_th2;
                        }

                        // TH3
                        if (short.TryParse(tbTH3_beTuanHoan_settingPage.Text, out stTime_th3) == false)
                        {
                            errProv_th3.SetError(tbTH3_beTuanHoan_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_th3 < settingLowerThreshold | stTime_th3 > settingUpperThreshold)
                        {
                            errProv_th3.SetError(tbTH3_beTuanHoan_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbTH3_beTuanHoan_settingPage.Tag = stTime_th3;
                            Program.RuntimeSetting_UI_PLC2.tuanHoan3_setTime_ui = stTime_th3;
                        }


                        // MT1 ON
                        if (short.TryParse(tbOn_bomHoaChatMT1_settingPage.Text, out stTime_mt1_on) == false)
                        {
                            errProv_mt1_on.SetError(tbOn_bomHoaChatMT1_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_mt1_on < settingLowerThreshold | stTime_mt1_on > settingUpperThreshold)
                        {
                            errProv_mt1_on.SetError(tbOn_bomHoaChatMT1_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOn_bomHoaChatMT1_settingPage.Tag = stTime_mt1_on;
                            Program.RuntimeSetting_UI_PLC2.metanol_setTime_on_ui = stTime_mt1_on;
                        }
                        // MT1 OFF
                        if (short.TryParse(tbOff_bomHoaChatMT1_settingPage.Text, out stTime_mt1_off) == false)
                        {
                            errProv_mt1_off.SetError(tbOff_bomHoaChatMT1_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_mt1_off < settingLowerThreshold | stTime_mt1_off > settingUpperThreshold)
                        {
                            errProv_mt1_off.SetError(tbOff_bomHoaChatMT1_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOff_bomHoaChatMT1_settingPage.Tag = stTime_mt1_off;
                            Program.RuntimeSetting_UI_PLC2.metanol_setTime_off_ui = stTime_mt1_off;
                        }

                        // "GB1" ON
                        if (short.TryParse(tbOn_gatBunGB1_settingPage.Text, out stTime_gb1_on) == false)
                        {
                            errProv_gb1_on.SetError(tbOn_gatBunGB1_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_gb1_on < settingLowerThreshold | stTime_gb1_on > settingUpperThreshold)
                        {
                            errProv_gb1_on.SetError(tbOn_gatBunGB1_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOn_gatBunGB1_settingPage.Tag = stTime_gb1_on;
                            Program.RuntimeSetting_UI_PLC2.gatBun_setTime_on_ui = stTime_gb1_on;
                        }

                        // "GB1" OFF
                        if (short.TryParse(tbOff_gatBunGB1_settingPage.Text, out stTime_gb1_off) == false)
                        {
                            errProv_gb1_off.SetError(tbOff_gatBunGB1_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_gb1_off < settingLowerThreshold | stTime_gb1_off > settingUpperThreshold)
                        {
                            errProv_gb1_off.SetError(tbOff_gatBunGB1_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOff_gatBunGB1_settingPage.Tag = stTime_gb1_off;
                            Program.RuntimeSetting_UI_PLC2.gatBun_setTime_off_ui = stTime_gb1_off;
                        }
                        // "NAOH" ON
                        if (short.TryParse(tbOn_khuayNaohNAOH_settingPage.Text, out stTime_naoh_on) == false)
                        {
                            errProv_naoh_on.SetError(tbOn_khuayNaohNAOH_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_naoh_on < settingLowerThreshold | stTime_naoh_on > settingUpperThreshold)
                        {
                            errProv_naoh_on.SetError(tbOn_khuayNaohNAOH_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOn_khuayNaohNAOH_settingPage.Tag = stTime_naoh_on;
                            Program.RuntimeSetting_UI_PLC2.khuayNaoh_setTime_on_ui = stTime_naoh_on;
                        }

                        // "NAOH" OFF
                        if (short.TryParse(tbOff_khuayNaohNAOH_settingPage.Text, out stTime_naoh_off) == false)
                        {
                            errProv_naoh_off.SetError(tbOff_khuayNaohNAOH_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_naoh_off < settingLowerThreshold | stTime_naoh_off > settingUpperThreshold)
                        {
                            errProv_naoh_off.SetError(tbOff_khuayNaohNAOH_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOff_khuayNaohNAOH_settingPage.Tag = stTime_naoh_off;
                            Program.RuntimeSetting_UI_PLC2.khuayNaoh_setTime_off_ui = stTime_naoh_off;
                        }

                        // MTK01
                        if (short.TryParse(tbMTK1_beAerotank_settingPage.Text, out stTime_mtk01) == false)
                        {
                            errProv_mtk01.SetError(tbMTK1_beAerotank_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_mtk01 < settingLowerThreshold | stTime_mtk01 > settingUpperThreshold)
                        {
                            errProv_mtk01.SetError(tbMTK1_beAerotank_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbMTK1_beAerotank_settingPage.Tag = stTime_mtk01;
                            Program.RuntimeSetting_UI_PLC1.mtk01_setTime_ui = stTime_mtk01;
                        }

                        // MTK02
                        if (short.TryParse(tbMTK2_beAerotank_settingPage.Text, out stTime_mtk02) == false)
                        {
                            errProv_mtk02.SetError(tbMTK2_beAerotank_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_mtk02 < settingLowerThreshold | stTime_mtk02 > settingUpperThreshold)
                        {
                            errProv_mtk02.SetError(tbMTK2_beAerotank_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbMTK2_beAerotank_settingPage.Tag = stTime_mtk02;
                            Program.RuntimeSetting_UI_PLC1.mtk02_setTime_ui = stTime_mtk02;
                        }

                        // MTK03
                        if (short.TryParse(tbMTK3_beAerotank_settingPage.Text, out stTime_mtk03) == false)
                        {
                            errProv_mtk03.SetError(tbMTK3_beAerotank_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_mtk03 < settingLowerThreshold | stTime_mtk03 > settingUpperThreshold)
                        {
                            errProv_mtk03.SetError(tbMTK3_beAerotank_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbMTK3_beAerotank_settingPage.Tag = stTime_mtk03;
                            Program.RuntimeSetting_UI_PLC1.mtk03_setTime_ui = stTime_mtk03;
                        }

                        // "SP07A" ON
                        if (short.TryParse(tbOn_bomBunSP07AB_settingPage.Text, out stTime_sp07ab_on) == false)
                        {
                            errProv_sp07ab_on.SetError(tbOn_bomBunSP07AB_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_sp07ab_on < settingLowerThreshold | stTime_sp07ab_on > settingUpperThreshold)
                        {
                            errProv_sp07ab_on.SetError(tbOn_bomBunSP07AB_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOn_bomBunSP07AB_settingPage.Tag = stTime_sp07ab_on;
                            Program.RuntimeSetting_UI_PLC3.bomBun_07AB_setTime_on_ui = stTime_sp07ab_on;
                        }

                        // "SP07A" OFF
                        if (short.TryParse(tbOff_bomBunSP07AB_settingPage.Text, out stTime_sp07ab_off) == false)
                        {
                            errProv_sp07ab_off.SetError(tbOff_bomBunSP07AB_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_sp07ab_off < settingLowerThreshold | stTime_sp07ab_off > settingUpperThreshold)
                        {
                            errProv_sp07ab_off.SetError(tbOff_bomBunSP07AB_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOff_bomBunSP07AB_settingPage.Tag = stTime_sp07ab_off;
                            Program.RuntimeSetting_UI_PLC3.bomBun_07AB_setTime_off_ui = stTime_sp07ab_off;
                        }

                        // "P201"
                        if (short.TryParse(tbP0201_beDieuHoa_settingPage.Text, out stTime_p201) == false)
                        {
                            errProv_p201.SetError(tbP0201_beDieuHoa_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_p201 < settingLowerThreshold | stTime_p201 > settingUpperThreshold)
                        {
                            errProv_p201.SetError(tbP0201_beDieuHoa_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbP0201_beDieuHoa_settingPage.Tag = stTime_p201;
                            Program.RuntimeSetting_UI_PLC1.dieuHoa1_setTime_ui = stTime_p201;
                        }

                        // "P202"
                        if (short.TryParse(tbP0202_beDieuHoa_settingPage.Text, out stTime_p202) == false)
                        {
                            errProv_p202.SetError(tbP0202_beDieuHoa_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_p202 < settingLowerThreshold | stTime_p202 > settingUpperThreshold)
                        {
                            errProv_p202.SetError(tbP0202_beDieuHoa_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbP0202_beDieuHoa_settingPage.Tag = stTime_p202;
                            Program.RuntimeSetting_UI_PLC1.dieuHoa2_setTime_ui = stTime_p202;
                        }

                        // "BB12" ON
                        if (short.TryParse(tbOn_bomBunBB12_settingPage.Text, out stTime_bb12_on) == false)
                        {
                            errProv_bb12_on.SetError(tbOn_bomBunBB12_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_bb12_on < settingLowerThreshold | stTime_bb12_on > settingUpperThreshold)
                        {
                            errProv_bb12_on.SetError(tbOn_bomBunBB12_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOn_bomBunBB12_settingPage.Tag = stTime_bb12_on;
                            Program.RuntimeSetting_UI_PLC2.bomBun_setTime_on_ui = stTime_bb12_on;
                        }

                        // "BB12" OFF
                        if (short.TryParse(tbOff_bomBunBB12_settingPage.Text, out stTime_bb12_off) == false)
                        {
                            errProv_bb12_off.SetError(tbOff_bomBunBB12_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_bb12_off < settingLowerThreshold | stTime_bb12_off > settingUpperThreshold)
                        {
                            errProv_bb12_off.SetError(tbOff_bomBunBB12_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOff_bomBunBB12_settingPage.Tag = stTime_bb12_off;
                            Program.RuntimeSetting_UI_PLC2.bomBun_setTime_off_ui = stTime_bb12_off;
                        }

                        // "WP02A"
                        if (short.TryParse(tbWP02A_beDieuHoa_settingPage.Text, out stTime_wp02a) == false)
                        {
                            errProv_wp02a.SetError(tbWP02A_beDieuHoa_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_wp02a < settingLowerThreshold | stTime_wp02a > settingUpperThreshold)
                        {
                            errProv_wp02a.SetError(tbWP02A_beDieuHoa_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbWP02A_beDieuHoa_settingPage.Tag = stTime_wp02a;
                            Program.RuntimeSetting_UI_PLC3.bomNt_02A_setTime_ui = stTime_wp02a;
                        }

                        // "WP02B"
                        if (short.TryParse(tbWP02B_beDieuHoa_settingPage.Text, out stTime_wp02b) == false)
                        {
                            errProv_wp02b.SetError(tbWP02B_beDieuHoa_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_wp02b < settingLowerThreshold | stTime_wp02b > settingUpperThreshold)
                        {
                            errProv_wp02b.SetError(tbWP02B_beDieuHoa_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbWP02B_beDieuHoa_settingPage.Tag = stTime_wp02b;
                            Program.RuntimeSetting_UI_PLC3.bomNt_02B_setTime_ui = stTime_wp02b;
                        }

                        // "AB06A"
                        if (short.TryParse(tbAB06A_beBiofor_settingPage.Text, out stTime_ab06a) == false)
                        {
                            errProv_ab06a.SetError(tbAB06A_beBiofor_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_ab06a < settingLowerThreshold | stTime_ab06a > settingUpperThreshold)
                        {
                            errProv_ab06a.SetError(tbAB06A_beBiofor_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbAB06A_beBiofor_settingPage.Tag = stTime_ab06a;
                            Program.RuntimeSetting_UI_PLC3.mtk_AB06A_setTime_ui = stTime_ab06a;
                        }

                        // "AB06B"
                        if (short.TryParse(tbAB06B_beBiofor_settingPage.Text, out stTime_ab06b) == false)
                        {
                            errProv_ab06b.SetError(tbAB06B_beBiofor_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_ab06b < settingLowerThreshold | stTime_ab06b > settingUpperThreshold)
                        {
                            errProv_ab06a.SetError(tbAB06B_beBiofor_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbAB06B_beBiofor_settingPage.Tag = stTime_ab06b;
                            Program.RuntimeSetting_UI_PLC3.mtk_AB06B_setTime_ui = stTime_ab06b;
                        }


                        // "AB06C"
                        if (short.TryParse(tbAB06C_beBiofor_settingPage.Text, out stTime_ab06c) == false)
                        {
                            errProv_ab06c.SetError(tbAB06C_beBiofor_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_ab06c < settingLowerThreshold | stTime_ab06c > settingUpperThreshold)
                        {
                            errProv_ab06a.SetError(tbAB06C_beBiofor_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbAB06C_beBiofor_settingPage.Tag = stTime_ab06c;
                            Program.RuntimeSetting_UI_PLC3.mtk_AB06C_setTime_ui = stTime_ab06c;
                        }

                        // "MS05" ON
                        if (short.TryParse(tbOn_gatBunMS05_settingPage.Text, out stTime_ms05_on) == false)
                        {
                            errProv_ms05_on.SetError(tbOn_gatBunMS05_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_ms05_on < settingLowerThreshold | stTime_ms05_on > settingUpperThreshold)
                        {
                            errProv_ms05_on.SetError(tbOn_gatBunMS05_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOn_gatBunMS05_settingPage.Tag = stTime_ms05_on;
                            Program.RuntimeSetting_UI_PLC3.gbbl05_setTime_on_ui = stTime_ms05_on;
                        }

                        // "MS05" OFF
                        if (short.TryParse(tbOff_gatBunMS05_settingPage.Text, out stTime_ms05_off) == false)
                        {
                            errProv_ms05_off.SetError(tbOff_gatBunMS05_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_ms05_off < settingLowerThreshold | stTime_ms05_off > settingUpperThreshold)
                        {
                            errProv_ms05_off.SetError(tbOff_gatBunMS05_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOff_gatBunMS05_settingPage.Tag = stTime_ms05_off;
                            Program.RuntimeSetting_UI_PLC3.gbbl05_setTime_off_ui = stTime_ms05_off;
                        }

                        // "MS07" ON
                        if (short.TryParse(tbOn_gatBunMS07_settingPage.Text, out stTime_ms07_on) == false)
                        {
                            errProv_ms07_on.SetError(tbOn_gatBunMS07_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_ms07_on < settingLowerThreshold | stTime_ms07_on > settingUpperThreshold)
                        {
                            errProv_ms07_on.SetError(tbOn_gatBunMS07_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOn_gatBunMS07_settingPage.Tag = stTime_ms07_on;
                            Program.RuntimeSetting_UI_PLC3.gbbl07_setTime_on_ui = stTime_ms07_on;
                        }

                        // "MS07" OFF
                        if (short.TryParse(tbOff_gatBunMS07_settingPage.Text, out stTime_ms07_off) == false)
                        {
                            errProv_ms07_off.SetError(tbOff_gatBunMS07_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_ms07_off < settingLowerThreshold | stTime_ms07_off > settingUpperThreshold)
                        {
                            errProv_ms07_off.SetError(tbOff_gatBunMS07_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOff_gatBunMS07_settingPage.Tag = stTime_ms07_off;
                            Program.RuntimeSetting_UI_PLC3.gbbl07_setTime_off_ui = stTime_ms07_off;
                        }

                        // "MS09" ON
                        if (short.TryParse(tbOn_gatBunMS09_settingPage.Text, out stTime_ms09_on) == false)
                        {
                            errProv_ms09_on.SetError(tbOn_gatBunMS09_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_ms09_on < settingLowerThreshold | stTime_ms09_on > settingUpperThreshold)
                        {
                            errProv_ms09_on.SetError(tbOn_gatBunMS09_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOn_gatBunMS09_settingPage.Tag = stTime_ms09_on;
                            Program.RuntimeSetting_UI_PLC3.gbbl09_setTime_on_ui = stTime_ms09_on;
                        }

                        // "MS09" OFF
                        if (short.TryParse(tbOff_gatBunMS09_settingPage.Text, out stTime_ms09_off) == false)
                        {
                            errProv_ms09_off.SetError(tbOff_gatBunMS09_settingPage, "You have not entered correctly!");
                            allCheckResult = true;
                        }

                        else if (stTime_ms09_off < settingLowerThreshold | stTime_ms09_off > settingUpperThreshold)
                        {
                            errProv_ms09_off.SetError(tbOff_gatBunMS09_settingPage, $"You have entered out of range {settingLowerThreshold}-{settingUpperThreshold}!");
                            allCheckResult = true;
                        }
                        else
                        {
                            tbOff_gatBunMS09_settingPage.Tag = stTime_ms09_off;
                            Program.RuntimeSetting_UI_PLC3.gbbl09_setTime_off_ui = stTime_ms09_off;
                        }

                    }
                    catch(Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                    return allCheckResult;
                }

                // FUNC cập nhật giá trị RUNTIME
                /// <summary>
                /// Function for updating values RUNTIMESETTING to UI
                /// </summary>
                /// <param name="tb_Focus">variable express having focus on textbox on "Setting Page"</param>
                /// <param name="enableUpdate">enable this function</param>
                public void updateRuntimeSettingToUI(bool tb_Focus, bool enableUpdate)
                {
                    if (enableUpdate == false)
                    {
                        return;
                    }
                    else if ((enableUpdate == true) && (tb_Focus == false))
                    {
                        // MKT01
                        tbMKT01_beDieuHoa_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbMKT01_beDieuHoa_settingPage.Text = Program.RuntimeSetting_PLC2.mkt01_setTime.ToString();
                        });
                
                        // MTK02
                        tbMKT02_beDieuHoa_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbMKT02_beDieuHoa_settingPage.Text = Program.RuntimeSetting_PLC2.mkt02_setTime.ToString();
                        });

                        // MTK03
                        tbMKT03_beDieuHoa_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbMKT03_beDieuHoa_settingPage.Text = Program.RuntimeSetting_PLC2.mkt03_setTime.ToString();
                        });

                        // SM01
                        tbSM01_beAnoxic_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbSM01_beAnoxic_settingPage.Text = Program.RuntimeSetting_PLC2.anoxic1_setTime.ToString();
                        });

                        // SM02
                        tbSM02_beAnoxic_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbSM02_beAnoxic_settingPage.Text = Program.RuntimeSetting_PLC2.anoxic2_setTime.ToString();
                        });

                        // SM03
                        tbSM03_beAnoxic_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbSM03_beAnoxic_settingPage.Text = Program.RuntimeSetting_PLC2.anoxic3_setTime.ToString();
                        });

                        // SM04
                        tbSM04_beAnoxic_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbSM04_beAnoxic_settingPage.Text = Program.RuntimeSetting_PLC2.anoxic4_setTime.ToString();
                        });

                        // SM05
                        tbSM05_beAnoxic_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbSM05_beAnoxic_settingPage.Text = Program.RuntimeSetting_PLC2.anoxic5_setTime.ToString();
                        });

                        // SM06
                        tbSM06_beAnoxic_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbSM06_beAnoxic_settingPage.Text = Program.RuntimeSetting_PLC2.anoxic6_setTime.ToString();
                        });

                        // SM07
                        tbSM07_beAnoxic_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbSM07_beAnoxic_settingPage.Text = Program.RuntimeSetting_PLC2.anoxic7_setTime.ToString();
                        });

                        // SM08
                        tbSM08_beAnoxic_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbSM08_beAnoxic_settingPage.Text = Program.RuntimeSetting_PLC2.anoxic8_setTime.ToString();
                        });

                        // SP05AB ON
                        tbOn_bomBunSP05AB_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOn_bomBunSP05AB_settingPage.Text = Program.RuntimeSetting_PLC3.bomBun_05AB_setTime_on.ToString();
                        });

                        // SP05AB OFF
                        tbOff_bomBunSP05AB_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOff_bomBunSP05AB_settingPage.Text = Program.RuntimeSetting_PLC3.bomBun_05AB_setTime_off.ToString();
                        });

                        //  P0101
                        tbP0101_beGom_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbP0101_beGom_settingPage.Text = Program.RuntimeSetting_PLC1.beGom1_setTime.ToString();
                        });

                        // P102
                        tbP0102_beGom_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbP0102_beGom_settingPage.Text = Program.RuntimeSetting_PLC1.beGom2_setTime.ToString();
                        });

                        // P0103
                        tbP0103_beGom_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbP0103_beGom_settingPage.Text = Program.RuntimeSetting_PLC1.beGom3_setTime.ToString();
                        });

                        // TH1
                        tbTH1_beTuanHoan_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbTH1_beTuanHoan_settingPage.Text = Program.RuntimeSetting_PLC2.tuanHoan1_setTime.ToString();
                        });

                        // TH2
                        tbTH2_beTuanHoan_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbTH2_beTuanHoan_settingPage.Text = Program.RuntimeSetting_PLC2.tuanHoan2_setTime.ToString();
                        });

                        // TH3
                        tbTH3_beTuanHoan_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbTH3_beTuanHoan_settingPage.Text = Program.RuntimeSetting_PLC2.tuanHoan3_setTime.ToString();
                        });

                        // MT1 - ON
                        tbOn_bomHoaChatMT1_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOn_bomHoaChatMT1_settingPage.Text = Program.RuntimeSetting_PLC2.metanol_setTime_on.ToString();
                        });

                        // MT1  OFF
                        tbOff_bomHoaChatMT1_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOff_bomHoaChatMT1_settingPage.Text = Program.RuntimeSetting_PLC2.metanol_setTime_off.ToString();
                        });

                        // GB1 ON
                        tbOn_gatBunGB1_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOn_gatBunGB1_settingPage.Text = Program.RuntimeSetting_PLC2.gatBun_setTime_on.ToString();
                        });

                        // GB1 OFF
                        tbOff_gatBunGB1_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOff_gatBunGB1_settingPage.Text = Program.RuntimeSetting_PLC2.gatBun_setTime_off.ToString();
                        });

                        // NAOH
                        tbOn_khuayNaohNAOH_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOn_khuayNaohNAOH_settingPage.Text = Program.RuntimeSetting_PLC2.khuayNaoh_setTime_on.ToString();
                        });

                        // NAOH
                        tbOff_khuayNaohNAOH_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOff_khuayNaohNAOH_settingPage.Text = Program.RuntimeSetting_PLC2.khuayNaoh_setTime_off.ToString();
                        });

                        // MTK1
                        tbMTK1_beAerotank_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbMTK1_beAerotank_settingPage.Text = Program.RuntimeSetting_PLC2.mkt01_setTime.ToString();
                        });

                        // MTK2
                        tbMTK2_beAerotank_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbMTK2_beAerotank_settingPage.Text = Program.RuntimeSetting_PLC2.mkt02_setTime.ToString();
                        });

                        // MTK3
                        tbMTK3_beAerotank_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbMTK3_beAerotank_settingPage.Text = Program.RuntimeSetting_PLC2.mkt03_setTime.ToString();
                        });

                        // SP07AB - on
                        tbOn_bomBunSP07AB_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOn_bomBunSP07AB_settingPage.Text = Program.RuntimeSetting_PLC3.bomBun_07AB_setTime_on.ToString();
                        });

                        // SP07AB
                        tbOff_bomBunSP07AB_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOff_bomBunSP07AB_settingPage.Text = Program.RuntimeSetting_PLC3.bomBun_07AB_setTime_off.ToString();
                        });

                        // P0201
                        tbP0201_beDieuHoa_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbP0201_beDieuHoa_settingPage.Text = Program.RuntimeSetting_PLC1.dieuHoa1_setTime.ToString();
                        });

                        // P202
                        tbP0202_beDieuHoa_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbP0202_beDieuHoa_settingPage.Text = Program.RuntimeSetting_PLC1.dieuHoa2_setTime.ToString();
                        });

                        // BB12 - ON
                        tbOn_bomBunBB12_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOn_bomBunBB12_settingPage.Text = Program.RuntimeSetting_PLC2.bomBun_setTime_on.ToString();
                        });

                        // BB12 - OFF
                        tbOff_bomBunBB12_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOff_bomBunBB12_settingPage.Text = Program.RuntimeSetting_PLC2.bomBun_setTime_off.ToString();
                        });

                
                        // WP02A
                        tbWP02A_beDieuHoa_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbWP02A_beDieuHoa_settingPage.Text = Program.RuntimeSetting_PLC1.dieuHoa1_setTime.ToString();
                        });

                        // WP02B
                        tbWP02B_beDieuHoa_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbWP02B_beDieuHoa_settingPage.Text = Program.RuntimeSetting_PLC1.dieuHoa2_setTime.ToString();
                        });

                        // AB06A
                        tbAB06A_beBiofor_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbAB06A_beBiofor_settingPage.Text = Program.RuntimeSetting_PLC3.mtk_AB06A_setTime.ToString();
                        });

                        // AB06B
                        tbAB06B_beBiofor_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbAB06B_beBiofor_settingPage.Text = Program.RuntimeSetting_PLC3.mtk_AB06B_setTime.ToString();
                        });
                
                        // AB06C
                        tbAB06C_beBiofor_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbAB06C_beBiofor_settingPage.Text = Program.RuntimeSetting_PLC3.mtk_AB06C_setTime.ToString();
                        });

                        // MS05 - ON
                        tbOn_gatBunMS05_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOn_gatBunMS05_settingPage.Text = Program.RuntimeSetting_PLC3.gbbl05_setTime_on.ToString();
                        });
                
                        // MS05 - OFF
                        tbOff_gatBunMS05_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOff_gatBunMS05_settingPage.Text = Program.RuntimeSetting_PLC3.gbbl05_setTime_off.ToString();
                        });

                        // MS07 - ON
                        tbOn_gatBunMS07_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOn_gatBunMS07_settingPage.Text = Program.RuntimeSetting_PLC3.gbbl07_setTime_on.ToString();
                        });

                        // MS07 - OFF
                        tbOff_gatBunMS07_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOff_gatBunMS07_settingPage.Text = Program.RuntimeSetting_PLC3.gbbl07_setTime_off.ToString();
                        });

                        // MS09 - ON
                        tbOn_gatBunMS09_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOn_gatBunMS09_settingPage.Text = Program.RuntimeSetting_PLC3.gbbl09_setTime_on.ToString();
                        });
               
                        // MS09 - OFF
                        tbOff_gatBunMS09_settingPage.BeginInvoke((MethodInvoker)delegate
                        {
                            tbOff_gatBunMS09_settingPage.Text = Program.RuntimeSetting_PLC3.gbbl09_setTime_off.ToString();
                        });


            }

                }

                // "WRITE" DATA
                
                public void writeRuntimeSetting()
                        {
                            
                            #region Write PLC1
                            try
                            {
                                if (PLC1_RT_Setting.plc.IsAvailable)
                                {

                                    PLC1_RT_Setting.plc_connectError = PLC1_RT_Setting.plc.Open();
                                    PLC1_RT_Setting.plc_connected = PLC1_RT_Setting.plc.IsConnected;
                                    PLC1_RT_Setting.plc_isAvailable = PLC1_RT_Setting.plc.IsAvailable;

                                    if (PLC1_RT_Setting.plc_connected)
                                    {
                                        if (diff_tb_p101_StPage)
                                        {
                                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 0, Program.RuntimeSetting_UI_PLC1.beGom1_setTime_ui);
                                        }
                                        if (diff_tb_p102_StPage)
                                        {
                                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 2, Program.RuntimeSetting_UI_PLC1.beGom2_setTime_ui);
                                        }
                                        if (diff_tb_p103_StPage)
                                        {
                                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 4, Program.RuntimeSetting_UI_PLC1.beGom3_setTime_ui);
                                        }
                                        if (diff_tb_p201_StPage)
                                        {
                                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 6, Program.RuntimeSetting_UI_PLC1.dieuHoa1_setTime_ui);
                                        }
                                        if (diff_tb_p202_StPage)
                                        {
                                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 8, Program.RuntimeSetting_UI_PLC1.dieuHoa2_setTime_ui);
                                        }
                                        if (diff_tb_mtk01_StPage)
                                        {
                                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 10, Program.RuntimeSetting_UI_PLC1.mtk01_setTime_ui);
                                        }
                                        if (diff_tb_mtk02_StPage)
                                        {
                                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 12, Program.RuntimeSetting_UI_PLC1.mtk02_setTime_ui);
                                        }
                                        if (diff_tb_mtk03_StPage)
                                        {
                                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 14, Program.RuntimeSetting_UI_PLC1.mtk03_setTime_ui);
                                        }
                                        PLC1_RT_Setting.plc.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("PLC1 is not available to write");
                                }
                            }
                            catch (Exception err1)
                            {
                                 MessageBox.Show("PLC1 Error: " + err1.Message);
                             }
                            #endregion
                            
                           
                            #region Write PLC2
                            try
                            {
                                if (PLC2_RT_Setting.plc.IsAvailable)
                                {
                                    PLC2_RT_Setting.plc_connectError = PLC2_RT_Setting.plc.Open();
                                    PLC2_RT_Setting.plc_connected = PLC2_RT_Setting.plc.IsConnected;
                                    PLC2_RT_Setting.plc_isAvailable = PLC2_RT_Setting.plc.IsAvailable;

                                    if (PLC2_RT_Setting.plc_connected)
                                    {
                                        if (diff_tb_sm01_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 0, Program.RuntimeSetting_UI_PLC2.anoxic1_setTime_ui);
                                        }
                                        if (diff_tb_sm02_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 2, Program.RuntimeSetting_UI_PLC2.anoxic2_setTime_ui);
                                        }
                                        if (diff_tb_sm03_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 4, Program.RuntimeSetting_UI_PLC2.anoxic3_setTime_ui);
                                        }
                                        if (diff_tb_sm04_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 6, Program.RuntimeSetting_UI_PLC2.anoxic4_setTime_ui);
                                        }
                                        if (diff_tb_sm05_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 8, Program.RuntimeSetting_UI_PLC2.anoxic5_setTime_ui);
                                        }
                                        if (diff_tb_sm06_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 10, Program.RuntimeSetting_UI_PLC2.anoxic6_setTime_ui);
                                        }
                                        if (diff_tb_sm07_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 12, Program.RuntimeSetting_UI_PLC2.anoxic7_setTime_ui);
                                        }
                                        if (diff_tb_sm08_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 14, Program.RuntimeSetting_UI_PLC2.anoxic8_setTime_ui);
                                        }
                                        if (diff_tb_bomMetanol_on_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 16, Program.RuntimeSetting_UI_PLC2.metanol_setTime_on_ui);
                                        }
                                        if (diff_tb_bomMetanol_off_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 18, Program.RuntimeSetting_UI_PLC2.metanol_setTime_off_ui);
                                        }
                                        if (diff_tb_th1_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 20, Program.RuntimeSetting_UI_PLC2.tuanHoan1_setTime_ui);
                                        }
                                        if (diff_tb_th2_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 22, Program.RuntimeSetting_UI_PLC2.tuanHoan2_setTime_ui);
                                        }
                                        if (diff_tb_th3_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 24, Program.RuntimeSetting_UI_PLC2.tuanHoan3_setTime_ui);
                                        }

                                        if (diff_tb_gb1_on_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 26, Program.RuntimeSetting_UI_PLC2.gatBun_setTime_on_ui);
                                        }

                                        if (diff_tb_gb1_off_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 28, Program.RuntimeSetting_UI_PLC2.gatBun_setTime_off_ui);
                                        }
                                        if (diff_tb_bb12_on_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 30, Program.RuntimeSetting_UI_PLC2.bomBun_setTime_on_ui);
                                        }
                                        if (diff_tb_bb12_off_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 32, Program.RuntimeSetting_UI_PLC2.bomBun_setTime_off_ui);
                                        }
                                        if (diff_tb_khuayNaoh_on_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 34, Program.RuntimeSetting_UI_PLC2.khuayNaoh_setTime_on_ui);
                                        }
                                        if (diff_tb_khuayNaoh_off_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 36, Program.RuntimeSetting_UI_PLC2.khuayNaoh_setTime_off_ui);
                                        }
                                        if (diff_tb_mkt01_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 38, Program.RuntimeSetting_UI_PLC2.mkt01_setTime_ui);
                                        }
                                        if (diff_tb_mkt02_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 40, Program.RuntimeSetting_UI_PLC2.mkt02_setTime_ui);
                                        }
                                        if (diff_tb_mkt03_StPage)
                                        {
                                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 42, Program.RuntimeSetting_UI_PLC2.mkt03_setTime_ui);
                                        }
                                        PLC2_RT_Setting.plc.Close();
                                    }

                                }

                                else
                                {
                                        MessageBox.Show("PLC2 is not available to write");
                                }
                            }
                            catch (Exception err2)
                            {
                                MessageBox.Show("PLC2 Error: " + err2.Message);
                            }
                            #endregion
                            

                            #region Write PLC3
                            try
                            {
                                if (PLC2_RT_Setting.plc.IsAvailable)
                                {
                                    PLC2_RT_Setting.plc_connectError = PLC2_RT_Setting.plc.Open();
                                    PLC2_RT_Setting.plc_connected = PLC2_RT_Setting.plc.IsConnected;
                                    PLC2_RT_Setting.plc_isAvailable = PLC2_RT_Setting.plc.IsAvailable;

                                    if (PLC2_RT_Setting.plc_connected)
                                    {

                                        // 2 bơm nước thải 02a và B ????
                                        if (diff_tb_wp02a_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 0, Program.RuntimeSetting_UI_PLC3.bomNt_02A_setTime_ui);
                                        }
                                        if (diff_tb_wp02b_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 2, Program.RuntimeSetting_UI_PLC3.bomNt_02B_setTime_ui);
                                        }
                                        if (diff_tb_ab06a_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 4, Program.RuntimeSetting_UI_PLC3.mtk_AB06A_setTime_ui);
                                        }
                                        if (diff_tb_ab06b_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 6, Program.RuntimeSetting_UI_PLC3.mtk_AB06B_setTime_ui);
                                        }
                                        if (diff_tb_ab06c_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 8, Program.RuntimeSetting_UI_PLC3.mtk_AB06C_setTime_ui);
                                        }
                                        if (diff_tb_ms05_on_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 10, Program.RuntimeSetting_UI_PLC3.gbbl05_setTime_on_ui);
                                        }
                                        if (diff_tb_ms05_off_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 12, Program.RuntimeSetting_UI_PLC3.gbbl05_setTime_off_ui);
                                        }
                                        if (diff_tb_ms07_on_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 14, Program.RuntimeSetting_UI_PLC3.gbbl07_setTime_on_ui);
                                        }
                                        if (diff_tb_ms07_off_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 16, Program.RuntimeSetting_UI_PLC3.gbbl07_setTime_off_ui);
                                        }
                                        if (diff_tb_ms09_on_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 18, Program.RuntimeSetting_UI_PLC3.gbbl09_setTime_on_ui);
                                        }
                                        if (diff_tb_ms09_off_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 20, Program.RuntimeSetting_UI_PLC3.gbbl09_setTime_off_ui);
                                        }
                                        if (diff_tb_sp05ab_on_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 22, Program.RuntimeSetting_UI_PLC3.bomBun_05AB_setTime_on_ui);
                                        }
                                        if (diff_tb_sp05ab_off_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 24, Program.RuntimeSetting_UI_PLC3.bomBun_05AB_setTime_off_ui);
                                        }
                                        if (diff_tb_sp07ab_on_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 26, Program.RuntimeSetting_UI_PLC3.bomBun_07AB_setTime_on_ui);
                                        }
                                        if (diff_tb_sp07ab_off_StPage)
                                        {
                                            PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 28, Program.RuntimeSetting_UI_PLC3.bomBun_07AB_setTime_off_ui);
                                        }
                                    }

                                    PLC2_RT_Setting.plc.Close();
                                }
                                else
                                {
                                   MessageBox.Show("PLC3 is not available to write");
                                }
                            }
                            catch (Exception err3)
                            {
                                MessageBox.Show("PLC3 Error: " + err3.Message);
                            }
                            #endregion

            
                        }
                /*
                #region WRITE - OLD VERSION
        public void writeRuntimeSetting()
        {

            #region Write PLC1
            try
            {
                if (PLC1_RT_Setting.plc.IsAvailable)
                {

                    PLC1_RT_Setting.plc_GD1_connectError = PLC1_RT_Setting.plc.Open();
                    PLC1_RT_Setting.plc_GD1_connected = PLC1_RT_Setting.plc.IsConnected;
                    PLC1_RT_Setting.plc_GD1_isAvailable = PLC1_RT_Setting.plc.IsAvailable;

                    if (PLC1_RT_Setting.plc.IsConnected)
                    {
                        if (diff_tb_p101_StPage)
                        {
                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 0, Program.RuntimeSetting_UI_PLC1.beGom1_setTime_ui);
                        }
                        if (diff_tb_p102_StPage)
                        {
                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 2, Program.RuntimeSetting_UI_PLC1.beGom2_setTime_ui);
                        }
                        if (diff_tb_p103_StPage)
                        {
                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 4, Program.RuntimeSetting_UI_PLC1.beGom3_setTime_ui);
                        }
                        if (diff_tb_p201_StPage)
                        {
                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 6, Program.RuntimeSetting_UI_PLC1.dieuHoa1_setTime_ui);
                        }
                        if (diff_tb_p202_StPage)
                        {
                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 8, Program.RuntimeSetting_PLC1.dieuHoa2_setTime);
                        }
                        if (diff_tb_mtk01_StPage)
                        {
                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 10, Program.RuntimeSetting_PLC1.mtk01_setTime);
                        }
                        if (diff_tb_mtk02_StPage)
                        {
                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 12, Program.RuntimeSetting_PLC1.mtk02_setTime);
                        }
                        if (diff_tb_mtk03_StPage)
                        {
                            PLC1_RT_Setting.plc.Write(DataType.DataBlock, 16, 14, Program.RuntimeSetting_PLC1.mtk03_setTime);
                        }
                        PLC1_RT_Setting.plc.Close();
                    }
                }
                else
                {
                    Console.WriteLine("PLC1 is not available");
                }
            }
            catch (Exception err1)
            {
                Console.WriteLine(err1.Message);
            }
            #endregion

            #region Write PLC2
            try
            {
                if (PLC2_RT_Setting.plc.IsAvailable)
                {
                    PLC2_RT_Setting.plc_GD1MR_connectError = PLC2_RT_Setting.plc.Open();
                    PLC2_RT_Setting.plc_GD1MR_connected = PLC2_RT_Setting.plc.IsConnected;
                    PLC2_RT_Setting.plc_GD1MR_isAvailable = PLC2_RT_Setting.plc.IsAvailable;

                    if (PLC1_RT_Setting.plc.IsConnected)
                    {
                        if (diff_tb_sm01_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 0, Program.RuntimeSetting_PLC2.anoxic1_setTime);
                        }
                        if (diff_tb_sm02_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 2, Program.RuntimeSetting_PLC2.anoxic2_setTime);
                        }
                        if (diff_tb_sm03_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 4, Program.RuntimeSetting_PLC2.anoxic3_setTime);
                        }
                        if (diff_tb_sm04_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 6, Program.RuntimeSetting_PLC2.anoxic4_setTime);
                        }
                        if (diff_tb_sm05_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 8, Program.RuntimeSetting_PLC2.anoxic5_setTime);
                        }
                        if (diff_tb_sm06_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 10, Program.RuntimeSetting_PLC2.anoxic6_setTime);
                        }
                        if (diff_tb_sm07_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 12, Program.RuntimeSetting_PLC2.anoxic7_setTime);
                        }
                        if (diff_tb_sm08_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 14, Program.RuntimeSetting_PLC2.anoxic8_setTime);
                        }
                        if (diff_tb_bomMetanol_on_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 16, Program.RuntimeSetting_PLC2.metanol_setTime_on);
                        }
                        if (diff_tb_bomMetanol_off_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 18, Program.RuntimeSetting_PLC2.metanol_setTime_off);
                        }
                        if (diff_tb_th1_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 20, Program.RuntimeSetting_PLC2.tuanHoan1_setTime);
                        }
                        if (diff_tb_th2_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 22, Program.RuntimeSetting_PLC2.tuanHoan2_setTime);
                        }
                        if (diff_tb_th3_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 24, Program.RuntimeSetting_PLC2.tuanHoan3_setTime);
                        }

                        if (diff_tb_gb1_on_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 26, Program.RuntimeSetting_PLC2.gatBun_setTime_on);
                        }

                        if (diff_tb_gb1_off_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 28, Program.RuntimeSetting_PLC2.gatBun_setTime_off);
                        }
                        if (diff_tb_bb12_on_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 30, Program.RuntimeSetting_PLC2.bomBun_setTime_on);
                        }
                        if (diff_tb_bb12_off_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 32, Program.RuntimeSetting_PLC2.bomBun_setTime_off);
                        }
                        if (diff_tb_khuayNaoh_on_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 34, Program.RuntimeSetting_PLC2.khuayNaoh_setTime_on);
                        }
                        if (diff_tb_khuayNaoh_off_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 36, Program.RuntimeSetting_PLC2.khuayNaoh_setTime_off);
                        }
                        if (diff_tb_mkt01_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 38, Program.RuntimeSetting_PLC2.mkt01_setTime);
                        }
                        if (diff_tb_mkt02_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 40, Program.RuntimeSetting_PLC2.mkt02_setTime);
                        }
                        if (diff_tb_mkt03_StPage)
                        {
                            PLC2_RT_Setting.plc.Write(DataType.DataBlock, 1, 42, Program.RuntimeSetting_PLC2.mkt03_setTime);
                        }
                        PLC2_RT_Setting.plc.Close();
                    }

                    else
                    {
                        Console.WriteLine("PLC2 is not available");
                    }
                }
            }
            catch (Exception err2)
            {
                Console.WriteLine(err2.Message);
            }
            #endregion

            #region Write PLC3
            try
            {
                if (PLC2_RT_Setting.plc.IsAvailable)
                {
                    PLC2_RT_Setting.plc_GD1MR_connectError = PLC2_RT_Setting.plc.Open();
                    PLC2_RT_Setting.plc_GD1MR_connected = PLC2_RT_Setting.plc.IsConnected;
                    PLC2_RT_Setting.plc_GD1MR_isAvailable = PLC2_RT_Setting.plc.IsAvailable;

                    // 2 bơm nước thải 02a và B ????
                    if (diff_tb_wp02a_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 0, Program.RuntimeSetting_PLC3.bomNt_02A_setTime);
                    }
                    if (diff_tb_wp02b_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 2, Program.RuntimeSetting_PLC3.bomNt_02B_setTime);
                    }
                    if (diff_tb_ab06a_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 4, Program.RuntimeSetting_PLC3.mtk_AB06A_setTime);
                    }
                    if (diff_tb_ab06b_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 6, Program.RuntimeSetting_PLC3.mtk_AB06B_setTime);
                    }
                    if (diff_tb_ab06c_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 8, Program.RuntimeSetting_PLC3.mtk_AB06C_setTime);
                    }
                    if (diff_tb_ms05_on_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 10, Program.RuntimeSetting_PLC3.gbbl05_setTime_on);
                    }
                    if (diff_tb_ms05_off_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 12, Program.RuntimeSetting_PLC3.gbbl05_setTime_off);
                    }
                    if (diff_tb_ms07_on_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 14, Program.RuntimeSetting_PLC3.gbbl07_setTime_on);
                    }
                    if (diff_tb_ms07_off_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 16, Program.RuntimeSetting_PLC3.gbbl07_setTime_off);
                    }
                    if (diff_tb_ms09_on_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 18, Program.RuntimeSetting_PLC3.gbbl09_setTime_on);
                    }
                    if (diff_tb_ms09_off_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 20, Program.RuntimeSetting_PLC3.gbbl09_setTime_off);
                    }
                    if (diff_tb_sp05ab_on_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 22, Program.RuntimeSetting_PLC3.bomBun_05AB_setTime_on);
                    }
                    if (diff_tb_sp05ab_off_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 24, Program.RuntimeSetting_PLC3.bomBun_05AB_setTime_off);
                    }
                    if (diff_tb_sp07ab_on_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 26, Program.RuntimeSetting_PLC3.bomBun_07AB_setTime_on);
                    }
                    if (diff_tb_sp07ab_off_StPage)
                    {
                        PLC3_RT_Setting.plc.Write(DataType.DataBlock, 19, 28, Program.RuntimeSetting_PLC3.bomBun_07AB_setTime_off);
                    }

                    PLC2_RT_Setting.plc.Close();
                }
                else
                {
                    Console.WriteLine("PLC3 is not available");
                }
            }
            catch (Exception err3)
            {
                Console.WriteLine(err3.Message);
            }
            #endregion
        }
        #endregion
                */

        // FUNC kiểm tra dữ liệu đọc và hiển thị -- ERROR?????????????????????
        /// <summary>
        /// Hàm kiểm tra sự khác nhau của dữ liệu đọc lên và dữ liệu hiển thị trên UI
        /// </summary>
        public void compare_dataUi_dataDevice()
                 {
                            // Bơm điều hòa 1, 2, 3 (Bể gom): P101, P102, P103
                            if(Program.RuntimeSetting_PLC1.beGom1_setTime != Program.RuntimeSetting_UI_PLC1.beGom1_setTime_ui)
                                diff_tb_p101_StPage = true; 
                            else
                                diff_tb_p101_StPage = false;

                            if (Program.RuntimeSetting_PLC1.beGom2_setTime != Program.RuntimeSetting_UI_PLC1.beGom2_setTime_ui)
                                diff_tb_p102_StPage = true;
                            else
                                diff_tb_p102_StPage = false;

                            if (Program.RuntimeSetting_PLC1.beGom3_setTime != Program.RuntimeSetting_UI_PLC1.beGom3_setTime_ui)
                                diff_tb_p103_StPage = true;
                            else
                                diff_tb_p103_StPage = false;

                            // Bể điều hòa: P0201, P0202
                            if (Program.RuntimeSetting_PLC1.dieuHoa1_setTime != Program.RuntimeSetting_UI_PLC1.dieuHoa1_setTime_ui)
                                diff_tb_p201_StPage = true;
                            else
                                diff_tb_p201_StPage = false;

                            if (Program.RuntimeSetting_PLC1.dieuHoa2_setTime != Program.RuntimeSetting_UI_PLC1.dieuHoa1_setTime_ui)
                                diff_tb_p202_StPage = true;
                            else
                                diff_tb_p202_StPage = false;

                            // Máy thổi khí MTK01, 02, 03: MKT01, MKT02, MKT03
                            if (Program.RuntimeSetting_PLC1.mtk01_setTime != Program.RuntimeSetting_UI_PLC2.mkt01_setTime_ui)
                                diff_tb_mkt01_StPage = true;
                            else
                                diff_tb_mkt01_StPage = false;

                            if (Program.RuntimeSetting_PLC1.mtk02_setTime != Program.RuntimeSetting_UI_PLC2.mkt02_setTime_ui)
                                diff_tb_mkt02_StPage = true;
                            else
                                diff_tb_mkt01_StPage = false;

                            if (Program.RuntimeSetting_PLC1.mtk03_setTime != Program.RuntimeSetting_UI_PLC2.mkt03_setTime_ui)
                                diff_tb_mkt03_StPage = true;
                            else
                                diff_tb_mkt03_StPage = false;

                            // Bơm tuần hoàn: TH1, TH2, TH3
                            if (Program.RuntimeSetting_PLC2.tuanHoan1_setTime != Program.RuntimeSetting_UI_PLC2.tuanHoan1_setTime_ui)
                                diff_tb_th1_StPage = true;
                            else
                                diff_tb_th1_StPage = false;

                            if (Program.RuntimeSetting_PLC2.tuanHoan2_setTime != Program.RuntimeSetting_UI_PLC2.tuanHoan2_setTime_ui)
                                diff_tb_th2_StPage = true;
                            else
                                diff_tb_th2_StPage = false;

                            if (Program.RuntimeSetting_PLC2.tuanHoan3_setTime != Program.RuntimeSetting_UI_PLC2.tuanHoan3_setTime_ui)
                                diff_tb_th3_StPage = true;
                            else
                                diff_tb_th3_StPage = false;

                            // Bơm bùn 12 => Bơm bùn 1 & 2 use a same setting time : BB12
                            if (Program.RuntimeSetting_PLC2.bomBun_setTime_on != Program.RuntimeSetting_UI_PLC2.bomBun_setTime_on_ui)
                                diff_tb_bb12_on_StPage = true;
                            else
                                diff_tb_bb12_on_StPage = false;

                            if (Program.RuntimeSetting_PLC2.bomBun_setTime_off != Program.RuntimeSetting_UI_PLC2.bomBun_setTime_off_ui)
                                diff_tb_bb12_off_StPage = true;
                            else
                                diff_tb_bb12_off_StPage = false;

                            // Bơm Metanol: MT1
                            if (Program.RuntimeSetting_PLC2.metanol_setTime_on != Program.RuntimeSetting_UI_PLC2.metanol_setTime_on_ui)
                                diff_tb_bomMetanol_on_StPage = true;
                            else
                                diff_tb_bomMetanol_on_StPage = false;

                            if (Program.RuntimeSetting_PLC2.bomBun_setTime_off != Program.RuntimeSetting_UI_PLC2.metanol_setTime_off_ui)
                                diff_tb_bomMetanol_off_StPage = true;
                            else
                                diff_tb_bomMetanol_off_StPage = false;

                            // Gạt bùn: GB1
                            if (Program.RuntimeSetting_PLC2.gatBun_setTime_on != Program.RuntimeSetting_UI_PLC2.gatBun_setTime_on_ui)
                                diff_tb_gb1_on_StPage = true;
                            else
                                diff_tb_gb1_on_StPage = false;

                            if (Program.RuntimeSetting_PLC2.gatBun_setTime_on != Program.RuntimeSetting_UI_PLC2.gatBun_setTime_off_ui)
                                diff_tb_gb1_off_StPage = true;
                            else
                                diff_tb_gb1_off_StPage = false;

                            // Bơm Anoxic 12
                            if (Program.RuntimeSetting_PLC2.anoxic1_setTime != Program.RuntimeSetting_UI_PLC2.anoxic1_setTime_ui)
                                diff_tb_sm01_StPage = true;
                            else
                                diff_tb_sm01_StPage = false;

                            if (Program.RuntimeSetting_PLC2.anoxic2_setTime != Program.RuntimeSetting_UI_PLC2.anoxic2_setTime_ui)
                                diff_tb_sm02_StPage = true;
                            else
                                diff_tb_sm02_StPage = false;


                            // Bơm Anoxic 34
                            if (Program.RuntimeSetting_PLC2.anoxic3_setTime != Program.RuntimeSetting_UI_PLC2.anoxic3_setTime_ui)
                                diff_tb_sm03_StPage = true;
                            else
                                diff_tb_sm03_StPage = false;

                            if (Program.RuntimeSetting_PLC2.anoxic4_setTime != Program.RuntimeSetting_UI_PLC2.anoxic4_setTime_ui)
                                diff_tb_sm04_StPage = true;
                            else
                                diff_tb_sm04_StPage = false;

                            // Bơm Anoxic 56
                            if (Program.RuntimeSetting_PLC2.anoxic5_setTime != Program.RuntimeSetting_UI_PLC2.anoxic5_setTime_ui)
                                diff_tb_sm05_StPage = true;
                            else
                                diff_tb_sm05_StPage = false;

                            if (Program.RuntimeSetting_PLC2.anoxic6_setTime != Program.RuntimeSetting_UI_PLC2.anoxic6_setTime_ui)
                                diff_tb_sm06_StPage = true;
                            else
                                diff_tb_sm06_StPage = false;

                            // Bơm Anoxic 78
                            if (Program.RuntimeSetting_PLC2.anoxic7_setTime != Program.RuntimeSetting_UI_PLC2.anoxic7_setTime_ui)
                                diff_tb_sm07_StPage = true;
                            else
                                diff_tb_sm07_StPage = false;

                            if (Program.RuntimeSetting_PLC2.anoxic8_setTime != Program.RuntimeSetting_UI_PLC2.anoxic8_setTime_ui)
                                diff_tb_sm08_StPage = true;
                            else
                                diff_tb_sm08_StPage = false;

                            // Bơm bùn 05 GĐ2: SP05A, SP05B
                            if (Program.RuntimeSetting_PLC3.bomBun_05AB_setTime_on != Program.RuntimeSetting_UI_PLC3.bomBun_05AB_setTime_on_ui)
                                diff_tb_sp05ab_on_StPage = true;
                            else
                                diff_tb_sp05ab_on_StPage = false;

                            if (Program.RuntimeSetting_PLC3.bomBun_05AB_setTime_off != Program.RuntimeSetting_UI_PLC3.bomBun_05AB_setTime_off_ui)
                                diff_tb_sp05ab_off_StPage = true;
                            else
                                diff_tb_sp05ab_off_StPage = false;

                        // Khuấy NAOH: NAOH
                        if (Program.RuntimeSetting_PLC2.khuayNaoh_setTime_on != Program.RuntimeSetting_UI_PLC2.khuayNaoh_setTime_on_ui)
                            diff_tb_khuayNaoh_on_StPage = true;
                        else
                            diff_tb_khuayNaoh_on_StPage = false;

                        if (Program.RuntimeSetting_PLC2.khuayNaoh_setTime_off != Program.RuntimeSetting_UI_PLC2.khuayNaoh_setTime_off_ui)
                            diff_tb_khuayNaoh_off_StPage = true;
                        else
                            diff_tb_khuayNaoh_off_StPage = false;

                        // Máy thổi khí GĐ1MR: MTK01, MTK02, MTK03
                        if (Program.RuntimeSetting_PLC1.mtk01_setTime != Program.RuntimeSetting_UI_PLC1.mtk01_setTime_ui)
                            diff_tb_mtk01_StPage = true;
                        else
                            diff_tb_mtk01_StPage = false;

                        if (Program.RuntimeSetting_PLC1.mtk02_setTime != Program.RuntimeSetting_UI_PLC1.mtk02_setTime_ui)
                            diff_tb_mtk02_StPage = true;
                        else
                            diff_tb_mtk02_StPage = false;

                        if (Program.RuntimeSetting_PLC1.mtk03_setTime != Program.RuntimeSetting_UI_PLC1.mtk03_setTime_ui)
                            diff_tb_mtk03_StPage = true;
                        else
                            diff_tb_mtk03_StPage = false;

                        // Bơm bùn 07 GĐ2: SP07A, SP07B
                        if (Program.RuntimeSetting_PLC3.bomBun_07AB_setTime_on != Program.RuntimeSetting_UI_PLC3.bomBun_07AB_setTime_on_ui)
                            diff_tb_sp05ab_on_StPage = true;
                        else
                            diff_tb_sp05ab_on_StPage = false;

                        if (Program.RuntimeSetting_PLC3.bomBun_07AB_setTime_off != Program.RuntimeSetting_UI_PLC3.bomBun_07AB_setTime_off_ui)
                            diff_tb_sp05ab_off_StPage = true;
                        else
                            diff_tb_sp05ab_off_StPage = false;

                        // Bơm điều hòa GĐ2: WP02A, WP02B
                        if (Program.RuntimeSetting_PLC3.bomNt_02A_setTime != Program.RuntimeSetting_UI_PLC3.bomNt_02A_setTime_ui)
                            diff_tb_wp02a_StPage = true;
                        else
                            diff_tb_wp02a_StPage = false;

                        if (Program.RuntimeSetting_PLC3.bomNt_02B_setTime != Program.RuntimeSetting_UI_PLC3.bomNt_02B_setTime_ui)
                            diff_tb_wp02b_StPage = true;
                        else
                            diff_tb_wp02b_StPage = false;

                        // Máy thổi khí GĐ2: AB06A, AB06B, AB06C
                        if (Program.RuntimeSetting_PLC3.mtk_AB06A_setTime != Program.RuntimeSetting_UI_PLC3.mtk_AB06A_setTime_ui)
                            diff_tb_ab06a_StPage = true;
                        else
                            diff_tb_ab06a_StPage = false;

                        if (Program.RuntimeSetting_PLC3.mtk_AB06B_setTime != Program.RuntimeSetting_UI_PLC3.mtk_AB06B_setTime_ui)
                            diff_tb_ab06b_StPage = true;
                        else
                            diff_tb_ab06b_StPage = false;

                        if (Program.RuntimeSetting_PLC3.mtk_AB06C_setTime != Program.RuntimeSetting_UI_PLC3.mtk_AB06C_setTime_ui)
                            diff_tb_ab06c_StPage = true;
                        else
                            diff_tb_ab06c_StPage = false;


                        // Gạt bùn bể lắng GĐ2: MS05
                        if (Program.RuntimeSetting_PLC3.gbbl05_setTime_on != Program.RuntimeSetting_UI_PLC3.gbbl05_setTime_on_ui)
                            diff_tb_ms05_on_StPage = true;
                        else
                            diff_tb_ms05_on_StPage = false;

                        if (Program.RuntimeSetting_PLC3.gbbl05_setTime_off != Program.RuntimeSetting_UI_PLC3.gbbl05_setTime_off_ui)
                            diff_tb_ms05_off_StPage = true;
                        else
                            diff_tb_ms05_off_StPage = false;

                        // Gạt bùn bể lắng GĐ2: MS07
                        if (Program.RuntimeSetting_PLC3.gbbl07_setTime_on != Program.RuntimeSetting_UI_PLC3.gbbl07_setTime_on_ui)
                            diff_tb_ms07_on_StPage = true;
                        else
                            diff_tb_ms07_on_StPage = false;

                        if (Program.RuntimeSetting_PLC3.gbbl07_setTime_off != Program.RuntimeSetting_UI_PLC3.gbbl07_setTime_off_ui)
                            diff_tb_ms07_off_StPage = true;
                        else
                            diff_tb_ms07_off_StPage = false;

                        // Gạt bùn bể lắng GĐ2: MS09
                        if (Program.RuntimeSetting_PLC3.gbbl09_setTime_on != Program.RuntimeSetting_UI_PLC3.gbbl09_setTime_on_ui)
                            diff_tb_ms09_on_StPage = true;
                        else
                            diff_tb_ms09_on_StPage = false;

                        if (Program.RuntimeSetting_PLC3.gbbl09_setTime_off != Program.RuntimeSetting_UI_PLC3.gbbl09_setTime_off_ui)
                            diff_tb_ms09_off_StPage = true;
                        else
                            diff_tb_ms09_off_StPage = false;

                    }
        #endregion

    }
}
