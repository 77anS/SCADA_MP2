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

using System.Timers;
using System.Threading;
using S7.Net;

namespace MP2_V01
{
    public partial class RUNTIME_GD2 : Form
    {

        #region FIELDS
        private int borderSize = 1;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
        public short updatePeriod { get; set; } = 500;
        System.Timers.Timer runtimeGD2Page = new System.Timers.Timer();

        EngineCycle.PLC_GD2 PLC3_RT_Reset = new EngineCycle.PLC_GD2();
        #endregion

        #region CONSTRUCTOR
        public RUNTIME_GD2()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
        }
        #endregion

        #region METHOD
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

        public void updateEventHandler(object sender, ElapsedEventArgs e)
        {
            tbRuntime_mayTachRac_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_mayTachRac_runtimeGd2Page.Text = Program.Runtime_PLC3.mayTachRac_runtime.ToString();
            });

            tbRuntime_nt02a_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_nt02a_runtimeGd2Page.Text = Program.Runtime_PLC3.bomNt_02A_runtime.ToString();
            });
            tbRuntime_nt02b_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_nt02b_runtimeGd2Page.Text = Program.Runtime_PLC3.bomNt_02B_runtime.ToString();
            });
            tbRuntime_mtka_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_mtka_runtimeGd2Page.Text = Program.Runtime_PLC3.mtk_AB06A_runtime.ToString();
            });
            tbRuntime_mtkb_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_mtkb_runtimeGd2Page.Text = Program.Runtime_PLC3.mtk_AB06B_runtime.ToString();
            });
            tbRuntime_mtkc_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_mtkc_runtimeGd2Page.Text = Program.Runtime_PLC3.mtk_AB06C_runtime.ToString();
            });

            tbRuntime_khuayKeoTu_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_khuayKeoTu_runtimeGd2Page.Text = Program.Runtime_PLC3.khuayKeoTu_GD2_runtime.ToString();
            });
            tbRuntime_khuayTbA_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_khuayTbA_runtimeGd2Page.Text = Program.Runtime_PLC3.khuayTaoBong_A_runtime.ToString();
            });
            tbRuntime_khuayTbB_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_khuayTbB_runtimeGd2Page.Text = Program.Runtime_PLC3.khuayTaoBong_B_runtime.ToString();
            });


            tbRuntime_gbbl05_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_gbbl05_runtimeGd2Page.Text = Program.Runtime_PLC3.gbbl05_runtime.ToString();
            });
            tbRuntime_gbbl07_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_gbbl07_runtimeGd2Page.Text = Program.Runtime_PLC3.gbbl07_runtime.ToString();
            });
            tbRuntime_gbbl09_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_gbbl09_runtimeGd2Page.Text = Program.Runtime_PLC3.gbbl09_runtime.ToString();
            });
            tbRuntime_khuayPac_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_khuayPac_runtimeGd2Page.Text = Program.Runtime_PLC3.khuayPac_GD2_runtime.ToString();
            });
            tbRuntime_khuayPoly_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_khuayPoly_runtimeGd2Page.Text = Program.Runtime_PLC3.khuayPoly_GD2_runtime.ToString();
            });
            tbRuntime_bomBun05A_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_bomBun05A_runtimeGd2Page.Text = Program.Runtime_PLC3.bomBun_05A_runtime.ToString();
            });
            tbRuntime_bomBun05B_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_bomBun05B_runtimeGd2Page.Text = Program.Runtime_PLC3.bomBun_05B_runtime.ToString();
            });
            tbRuntime_bomBun07A_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_bomBun07A_runtimeGd2Page.Text = Program.Runtime_PLC3.bomBun_07A_runtime.ToString();
            });
            tbRuntime_bomBun07B_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_bomBun07B_runtimeGd2Page.Text = Program.Runtime_PLC3.bomBun_07B_runtime.ToString();
            });
            tbRuntime_bumBunSp10_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_bumBunSp10_runtimeGd2Page.Text = Program.Runtime_PLC3.bomBun_SP10_runtime.ToString();
            });

            tbRuntime_dlPhen03A_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlPhen03A_runtimeGd2Page.Text = Program.Runtime_PLC3.dlPhen_03A_runtime.ToString();
            });
            tbRuntime_dlPhen03B_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlPhen03B_runtimeGd2Page.Text = Program.Runtime_PLC3.dlPhen_03B_runtime.ToString();
            });
            tbRuntime_dlPoly04A_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlPoly04A_runtimeGd2Page.Text = Program.Runtime_PLC3.dlPoly_04A_runtime.ToString();
            });
            tbRuntime_dlPoly04B_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlPoly04B_runtimeGd2Page.Text = Program.Runtime_PLC3.dlPoly_04B_runtime.ToString();
            });
            tbRuntime_dlXut05A_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlXut05A_runtimeGd2Page.Text = Program.Runtime_PLC3.dlXut_05A_runtime.ToString();
            });
            tbRuntime_dlXut05B_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlXut05B_runtimeGd2Page.Text = Program.Runtime_PLC3.dlXut_05B_runtime.ToString();
            });
            tbRuntime_dldd06A_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dldd06A_runtimeGd2Page.Text = Program.Runtime_PLC3.dlDd_06A_runtime.ToString();
            });
            tbRuntime_dldd06B_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dldd06B_runtimeGd2Page.Text = Program.Runtime_PLC3.dlDd_06B_runtime.ToString();
            });
            tbRuntime_dlkt07A_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlkt07A_runtimeGd2Page.Text = Program.Runtime_PLC3.dlKhuTrung_07A_runtime.ToString();
            });
            tbRuntime_dlkt07B_runtimeGd2Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlkt07B_runtimeGd2Page.Text = Program.Runtime_PLC3.dlKhuTrung_07B_runtime.ToString();
            });
        }

        public void resetRT_PLC3(int numberOfDataBlock, int startByte, int startBit)
        {
            try
            {
                PLC3_RT_Reset.plc_connectError = PLC3_RT_Reset.plc.Open();
                PLC3_RT_Reset.plc_connected = PLC3_RT_Reset.plc.IsConnected;
                PLC3_RT_Reset.plc_isAvailable = PLC3_RT_Reset.plc.IsAvailable;
                if (PLC3_RT_Reset.plc_isAvailable)
                {
                    if (PLC3_RT_Reset.plc.IsConnected)
                    {
                        Program.PLC_GD3.plc.Write(DataType.DataBlock, numberOfDataBlock, startByte, true, startBit);
                        Thread.Sleep(100);
                        Program.PLC_GD3.plc.Write(DataType.DataBlock, numberOfDataBlock, startByte, false, startBit);
                    }
                    else
                        MessageBox.Show("Not Valid: PLC3 is not connnected");

                }
                else
                {
                    MessageBox.Show("Not Valid: PLC3 not available!");
                }

                PLC3_RT_Reset.plc.Close();

            }
            catch (Exception err)
            {
                PLC3_RT_Reset.plc.Close();
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region EVENT METHOD
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnHeader_runtimeGd2Page_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximize_runtimeGd2Page_Click(object sender, EventArgs e)
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

        private void btnMinimize_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RUNTIME_GD2_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void RUNTIME_GD2_Load(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = null;
                runtimeGD2Page.Interval = updatePeriod;
                runtimeGD2Page.Elapsed += updateEventHandler;
                runtimeGD2Page.AutoReset = true;
                runtimeGD2Page.Enabled = true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void btnReset_mayTachRac_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 0, 0);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_nt02a_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 0, 1);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_nt02b_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 0, 2);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_mtka_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 0, 3);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_mtkb_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 0, 4);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_mtkc_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 0, 5);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_khuayKeoTu_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 0, 6);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_khuayTbA_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 0, 7);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_khuayTbB_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 1, 0);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_gbbl05_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 1, 1);
            Program.plc3_stopOtherConnecting = false;
        }
        private void btnReset_gbbl07_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 1, 2);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_gbbn09_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 1, 3);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_khuayPac_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 1, 4);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_khuayPoly_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 1, 5);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_bomBun05A_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 1, 6);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_bomBun05B_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 1, 7);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_bomBun07A_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 2, 0);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_bomBun07B_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 2, 1);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_bomBunSP10_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 2, 2);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_dlPhen03A_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 2, 3);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_dlPhen03B_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 2, 4);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_dlPol04A_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 2, 5);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_dlPoly04B_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 2, 6);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_dlXut05A_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 2, 7);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_dlXut05B_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 3, 0);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_dldd06A_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 3, 1);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_dldd06B_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 3, 2);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_dlkt07A_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 3, 3);
            Program.plc3_stopOtherConnecting = false;
        }

        private void btnReset_dlkt07B_runtimeGd2Page_Click(object sender, EventArgs e)
        {
            Program.plc3_stopOtherConnecting = true;
            resetRT_PLC3(25, 3, 4);
            Program.plc3_stopOtherConnecting = false;
        }
        #endregion

        #region OVERIDE METHOD
        //Overriddens methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);

        }

        #endregion

      
    }
}
