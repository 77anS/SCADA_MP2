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

namespace MP2_V01
{
    public partial class Frame : Form
    {
        #region FIELDS
            private int borderSize = 2;
            private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
            
            bool count;

            HOME abc;

            public int timeUpdatePeriod = 1000;

            System.Timers.Timer timerFramePage = new System.Timers.Timer();

            TESTING_ENVIRONMENT abc1;
        #endregion

        #region CONSTRUCTORS
        public Frame()
        {
            InitializeComponent();

        }
        #endregion

        #region METHOD
        private void updateEventHandler(object sender, ElapsedEventArgs e)
        {
            lbl_datetime_framePage.BeginInvoke((MethodInvoker)delegate
            {
                lbl_datetime_framePage.Text = DateTime.Now.ToString();
            });
        }


        #endregion

        #region EVENT METHOD
        private void Frame_Load(object sender, EventArgs e)
        {
            //pnBody_framePage.Controls.Clear();
            //abc = new HOME();
            //abc.TopLevel = false;
            //abc.TopMost = true;
            //pnBody_framePage.Controls.Add(abc);
            //abc.Show();

            pnBody_framePage.Controls.Clear();
            TREND abc1 = new TREND();
            abc1.TopLevel = false;
            abc1.TopMost = true;
            pnBody_framePage.Controls.Add(abc1);
            abc1.Show();


            timerFramePage = new System.Timers.Timer();
            timerFramePage.Interval = this.timeUpdatePeriod;
            timerFramePage.Elapsed += updateEventHandler;
            timerFramePage.AutoReset = true;
            timerFramePage.Enabled = true;

            //pnBody_framePage.Controls.Clear();
            //ALARM abc1 = new ALARM();
            //abc1.TopLevel = false;
            //abc1.TopMost = true;
            //pnBody_framePage.Controls.Add(abc1);
            //abc1.Show();

            //pnbody_framepage.controls.clear();
            //program.alarmpage.toplevel = false;
            //program.alarmpage.topmost = true;
            //pnbody_framepage.controls.add(program.alarmpage);
            //program.alarmpage.show();

            //this.Refresh();
        }

        private void btnSystem_framePage_Click(object sender, EventArgs e)
        {
            /*
            pnBody_framePage.Controls.Clear(); 
            HOME abc = new HOME();
            abc.TopMost = true;
            abc.TopLevel = false;
            pnBody_framePage.Controls.Add(abc);
            abc.Show();
            */

            pnBody_framePage.Controls.Clear();
            Program.homePage.TopLevel = false;
            Program.homePage.TopMost = true;
            pnBody_framePage.Controls.Add(Program.homePage);
            Program.homePage.Show();

            //Program.deviceListPage = new DEVICE_LIST(this);
            //Program.homePage.Show();


        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnHeader_settingPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximize_framePage_Click(object sender, EventArgs e)
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

        private void btnMinimize_framePage_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_framePage_Click(object sender, EventArgs e)
        {
            timerFramePage.Stop();
            timerFramePage.Close();

            DialogResult res = MessageBox.Show("Bạn có muốn thoát chương trình?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }    


        }

        private void btnMinimize_framePage_MouseHover(object sender, EventArgs e)
        {
            btnMinimize_framePage.BackColor = Color.FromArgb(255, 24, 42, 91);
        }

        private void btnClose_framePage_MouseHover(object sender, EventArgs e)
        {
            btnClose_framePage.BackColor = Color.FromArgb(255, 240, 0, 0);
        }


        private void btnMinimize_framePage_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize_framePage.BackColor = Color.FromArgb(150, 24, 42, 91);
        }

        private void btnClose_framePage_MouseLeave(object sender, EventArgs e)
        {
            btnClose_framePage.BackColor = Color.FromArgb(255, 24, 42, 92);
        }

        private void Frame_Resize(object sender, EventArgs e)
        {
            //AdjustForm();
        }

        /*
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(2, 2, 2, 2);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        */
        private void btnSettting_framePage_Click(object sender, EventArgs e)
        {
            Program.settingPage = new SETTING(this);
            Program.settingPage.Show();
            Program.settingPage.TopMost = true;
        }

        private void btnChart_framePage_Click(object sender, EventArgs e)
        {
            //pnBody_framePage.Controls.Clear();
            //TREND myPhuocTrend = new TREND();
            //myPhuocTrend.TopLevel = false;
            //myPhuocTrend.TopMost = true;
            //pnBody_framePage.Controls.Add(myPhuocTrend);
            //myPhuocTrend.Show();

            pnBody_framePage.Controls.Clear();
            //TREND myPhuocTrend = new TREND();
            Program.trendPage.TopLevel = false;
            Program.trendPage.TopMost = true;
            pnBody_framePage.Controls.Add(Program.trendPage);
            Program.trendPage.Show();
        }

        private void btnAlarm_framePage_Click(object sender, EventArgs e)
        {
            /*
            pnBody_framePage.Controls.Clear();
            ALARM myPhuocAlarm = new ALARM();
            myPhuocAlarm.TopLevel = false;
            myPhuocAlarm.TopMost = true;
            pnBody_framePage.Controls.Add(myPhuocAlarm);
            myPhuocAlarm.Show();
            */
            pnBody_framePage.Controls.Clear();
            Program.alarmPage.TopMost = true;
            Program.alarmPage.TopLevel = false;

            pnBody_framePage.Controls.Add(Program.alarmPage);
            Program.alarmPage.Show();

        }

        private void btnRuntime_framePage_Click(object sender, EventArgs e)
        {
            Program.runtimeCollectionPage = new RUNTIME_COLLECTION(this);

            Program.runtimeCollectionPage.TopMost = true;
            Program.framePage.TopMost = false;

            Program.runtimeCollectionPage.Show();
        }

        private void btnCheck_framePage_Click(object sender, EventArgs e)
        {

        }

        private void btnAlarm_framePage_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnInfo_framePage_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnInfo_framePage_Click(object sender, EventArgs e)
        {
            Program.deviceListPage = new DEVICE_LIST(this);
            Program.deviceListPage.Show();
        }

        #endregion

        #region OVERIDING METHOD
        #endregion

        private void btnReset_framePage_Click(object sender, EventArgs e)
        {
            Program.resetPage = new RESET(this);
            Program.resetPage.ShowDialog();
        }

        private void btnReset_framePage_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnTesting_framePage_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.Enabled = false;

            //Program.testingEnvironmentPage = new TESTING_ENVIRONMENT(this);
            //Program.testingEnvironmentPage.Show();

            Program.adminPage = new ADMIN_PAGE(this);
            Program.adminPage.Show();
        }

        private void btnExport_framePage_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.TopMost = false;

            Program.dataExportPage = new DATA_EXPORT(this);
            Program.dataExportPage.Show();
            
        }

        private void btnSystem_framePage_Click_1(object sender, EventArgs e)
        {
            /*
             pnBody_framePage.Controls.Clear(); 
             HOME abc = new HOME();
             abc.TopMost = true;
             abc.TopLevel = false;
             pnBody_framePage.Controls.Add(abc);
             abc.Show();
             */

            if(Program.loadF_homePage == false)
            {
                Program.loadF_homePage = true;

                pnBody_framePage.Controls.Clear();
                Program.homePage.TopLevel = false;
                Program.homePage.TopMost = true;
                pnBody_framePage.Controls.Add(Program.homePage);

                Program.homePage.WindowState = FormWindowState.Minimized;
                Program.homePage.Show();

                //Wait a minutes
                WaitForm waitDelay1 = new WaitForm(this);
                waitDelay1.Show();
                waitDelay1.TopMost = true;
                waitDelay1.TopLevel = true;

                DialogResult diagRes = MessageBox.Show("Tiếp tục hiển thị hay không?", "Hỏi hiển thị", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (diagRes == DialogResult.Yes)
                {
                    Program.homePage.WindowState = FormWindowState.Maximized;
                }

                //Program.deviceListPage = new DEVICE_LIST(this);
                //Program.homePage.Show();
            }
            else
            {
                pnBody_framePage.Controls.Clear();
                Program.homePage.TopLevel = false;
                Program.homePage.TopMost = true;
                pnBody_framePage.Controls.Add(Program.homePage);
                Program.homePage.Show();
            }    
        }

        private void btnSystem_framePage_MouseHover(object sender, EventArgs e)
        {
            btnSystem_framePage.BackColor = Color.FromArgb(255, 51, 84, 119);

            ToolTip toolTip_option = new ToolTip();
            toolTip_option.Active = true;
            toolTip_option.ForeColor = Color.Blue;
            toolTip_option.BackColor = Color.Purple;
            toolTip_option.ToolTipTitle = "TRANG CHỦ";
            toolTip_option.SetToolTip(btnSystem_framePage, "Giám sát và điều khiển hệ thống XLNT");

        }

        private void btnSystem_framePage_MouseLeave(object sender, EventArgs e)
        {
            btnSystem_framePage.BackColor = Color.FromArgb(255, 17, 55, 97);
        }

        private void btnSettting_framePage_Click_1(object sender, EventArgs e)
        {
            Program.settingPage = new SETTING(this);
            Program.settingPage.Show();
            Program.settingPage.TopMost = true;
        }

        private void btnChart_framePage_Click_1(object sender, EventArgs e)
        {

            //pnBody_framePage.Controls.Clear();
            //TREND myPhuocTrend = new TREND();
            //myPhuocTrend.TopLevel = false;
            //myPhuocTrend.TopMost = true;
            //pnBody_framePage.Controls.Add(myPhuocTrend);
            //myPhuocTrend.Show();

            pnBody_framePage.Controls.Clear();
            //TREND myPhuocTrend = new TREND();
            Program.trendPage.TopLevel = false;
            Program.trendPage.TopMost = true;
            pnBody_framePage.Controls.Add(Program.trendPage);
            Program.trendPage.Show();
        }

        private void btnAlarm_framePage_Click_1(object sender, EventArgs e)
        {
            /*
            pnBody_framePage.Controls.Clear();
            ALARM myPhuocAlarm = new ALARM();
            myPhuocAlarm.TopLevel = false;
            myPhuocAlarm.TopMost = true;
            pnBody_framePage.Controls.Add(myPhuocAlarm);
            myPhuocAlarm.Show();
            */
            pnBody_framePage.Controls.Clear();
            Program.alarmPage.TopMost = true;
            Program.alarmPage.TopLevel = false;

            pnBody_framePage.Controls.Add(Program.alarmPage);
            Program.alarmPage.Show();
        }

        private void btnRuntime_framePage_Click_1(object sender, EventArgs e)
        {
            Program.runtimeCollectionPage = new RUNTIME_COLLECTION(this);

            Program.runtimeCollectionPage.TopMost = true;
            Program.framePage.TopMost = false;

            Program.runtimeCollectionPage.Show();
        }

        private void btnReset_framePage_Click_1(object sender, EventArgs e)
        {
            Program.resetPage = new RESET(this);
            Program.resetPage.ShowDialog();
        }

        private void btn_Export_framePage_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.TopMost = false;

            Program.dataExportPage = new DATA_EXPORT(this);
            Program.dataExportPage.Show();
        }

        private void btnInfo_framePage_Click_1(object sender, EventArgs e)
        {
            Program.deviceListPage = new DEVICE_LIST(this);
            Program.deviceListPage.Show();
        }

        private void btnSys_framePage_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            this.Enabled = false;

            //Program.testingEnvironmentPage = new TESTING_ENVIRONMENT(this);
            //Program.testingEnvironmentPage.Show();

            Program.adminPage = new ADMIN_PAGE(this);
            Program.adminPage.Show();
        }

        private void btnSettting_framePage_MouseHover(object sender, EventArgs e)
        {
            btnSettting_framePage.BackColor = Color.FromArgb(255, 51, 84, 119);

            ToolTip toolTip_option = new ToolTip();
            toolTip_option.Active = true;
            toolTip_option.ForeColor = Color.Blue;
            toolTip_option.BackColor = Color.Purple;
            toolTip_option.ToolTipTitle = "CÀI ĐẶT";
            toolTip_option.SetToolTip(btnSettting_framePage, "Thông số Runtime của thiết bị");
        }

        private void btnSettting_framePage_MouseLeave(object sender, EventArgs e)
        {
            btnSettting_framePage.BackColor = Color.FromArgb(255, 17, 55, 97);
        }

        private void btnChart_framePage_MouseHover(object sender, EventArgs e)
        {
            btnChart_framePage.BackColor = Color.FromArgb(255, 51, 84, 119);

            ToolTip toolTip_option = new ToolTip();
            toolTip_option.Active = true;
            toolTip_option.ForeColor = Color.Blue;
            toolTip_option.BackColor = Color.Purple;
            toolTip_option.ToolTipTitle = "ĐỒ THỊ";
            toolTip_option.SetToolTip(btnChart_framePage, "Biểu đồ dữ liệu quan trắc theo thời gian thực");
        }

        private void btnChart_framePage_MouseLeave(object sender, EventArgs e)
        {

            btnChart_framePage.BackColor = Color.FromArgb(255, 17, 55, 97);
        }

        private void btnAlarm_framePage_MouseHover(object sender, EventArgs e)
        {
            btnAlarm_framePage.BackColor = Color.FromArgb(255, 51, 84, 119);

            ToolTip toolTip_option = new ToolTip();
            toolTip_option.Active = true;
            toolTip_option.ForeColor = Color.Blue;
            toolTip_option.BackColor = Color.Purple;
            toolTip_option.ToolTipTitle = "CẢNH BÁO";
            toolTip_option.SetToolTip(btnAlarm_framePage, "Lịch sử cảnh báo lỗi hệ thống thiết bị");
        }

        private void btnRuntime_framePage_MouseHover(object sender, EventArgs e)
        {

            btnRuntime_framePage.BackColor = Color.FromArgb(255, 51, 84, 119);

            ToolTip toolTip_option = new ToolTip();
            toolTip_option.Active = true;
            toolTip_option.ForeColor = Color.Blue;
            toolTip_option.BackColor = Color.Purple;
            toolTip_option.ToolTipTitle = "RUNTIME";
            toolTip_option.SetToolTip(btnRuntime_framePage, "Thời gian hoạt động hệ thống thiết bị");
        }

        private void btnRuntime_framePage_MouseLeave(object sender, EventArgs e)
        {
            btnRuntime_framePage.BackColor = Color.FromArgb(255, 17, 55, 97);
        }

        private void btnReset_framePage_MouseHover(object sender, EventArgs e)
        {
            btnReset_framePage.BackColor = Color.FromArgb(255, 51, 84, 119);

            ToolTip toolTip_option = new ToolTip();
            toolTip_option.Active = true;
            toolTip_option.ForeColor = Color.Blue;
            toolTip_option.BackColor = Color.Purple;
            toolTip_option.ToolTipTitle = "RESET";
            toolTip_option.SetToolTip(btnReset_framePage, "Reset giá trị về mặt định");
        }

        private void btnReset_framePage_MouseLeave(object sender, EventArgs e)
        {
            btnReset_framePage.BackColor = Color.FromArgb(255, 17, 55, 97);
        }

        private void btn_Export_framePage_MouseHover(object sender, EventArgs e)
        {
            btn_Export_framePage.BackColor = Color.FromArgb(255, 51, 84, 119);

            ToolTip toolTip_option = new ToolTip();
            toolTip_option.Active = true;
            toolTip_option.ForeColor = Color.Blue;
            toolTip_option.BackColor = Color.Purple;
            toolTip_option.ToolTipTitle = "BÁO CÁO";
            toolTip_option.SetToolTip(btn_Export_framePage, "Truy xuất thông tin và xuất dữ liệu");
        }

        private void btn_Export_framePage_MouseLeave(object sender, EventArgs e)
        {
            btn_Export_framePage.BackColor = Color.FromArgb(255, 17, 55, 97);
        }

        private void btnInfo_framePage_MouseHover(object sender, EventArgs e)
        {
            btnInfo_framePage.BackColor = Color.FromArgb(255, 51, 84, 119);

            ToolTip toolTip_option = new ToolTip();
            toolTip_option.Active = true;
            toolTip_option.ForeColor = Color.Blue;
            toolTip_option.BackColor = Color.Purple;
            toolTip_option.ToolTipTitle = "THÔNG TIN";
            toolTip_option.SetToolTip(btnInfo_framePage, "Thông tin mã hiệu thiết bị");
        }

        private void btnInfo_framePage_MouseLeave(object sender, EventArgs e)
        {
            btnInfo_framePage.BackColor = Color.FromArgb(255, 17, 55, 97);
        }

        private void btnSys_framePage_MouseHover(object sender, EventArgs e)
        {
            btnSys_framePage.BackColor = Color.FromArgb(255, 51, 84, 119);

            ToolTip toolTip_option = new ToolTip();
            toolTip_option.Active = true;
            toolTip_option.ForeColor = Color.Blue;
            toolTip_option.BackColor = Color.Purple;
            toolTip_option.ToolTipTitle = "QUẢN TRỊ ADMIN";
            toolTip_option.SetToolTip(btnSys_framePage, "Thông số cài đặt hệ thống mở rộng quản trị viên");
        }

        private void btnSys_framePage_MouseLeave(object sender, EventArgs e)
        {
            btnSys_framePage.BackColor = Color.FromArgb(255, 17, 55, 97);
        }

        private void btnAlarm_framePage_MouseLeave(object sender, EventArgs e)
        {
            btnAlarm_framePage.BackColor = Color.FromArgb(255, 17, 55, 97);
        }
    }
}
