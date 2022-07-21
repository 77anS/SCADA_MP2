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
    public partial class RUNTIME_GD1MR : Form
    {
        #region FIELDS

        private int borderSize = 1;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
        public short updatePeriod { get; set; } = 500;
        System.Timers.Timer runtimeGD1MRPage = new System.Timers.Timer();

        EngineCycle.PLC_GD1MR PLC2_RT_Reset = new EngineCycle.PLC_GD1MR();
        #endregion

        #region CONSTRUCTOR
        public RUNTIME_GD1MR()
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
            tbRuntime_anoxic1_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_anoxic1_runtimeGd1mrPage.Text = Program.Runtime_PLC2.anoxic1_runtime.ToString();
            });

            tbRuntime_anoxic2_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_anoxic2_runtimeGd1mrPage.Text = Program.Runtime_PLC2.anoxic2_runtime.ToString();
            });

            tbRuntime_anoxic3_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_anoxic3_runtimeGd1mrPage.Text = Program.Runtime_PLC2.anoxic3_runtime.ToString();
            });

            tbRuntime_anoxic4_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_anoxic4_runtimeGd1mrPage.Text = Program.Runtime_PLC2.anoxic4_runtime.ToString();
            });
            tbRuntime_anoxic5_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_anoxic5_runtimeGd1mrPage.Text = Program.Runtime_PLC2.anoxic5_runtime.ToString();
            });


            tbRuntime_anoxic6_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_anoxic6_runtimeGd1mrPage.Text = Program.Runtime_PLC2.anoxic6_runtime.ToString();
            });

            tbRuntime_anoxic7_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_anoxic7_runtimeGd1mrPage.Text = Program.Runtime_PLC2.anoxic7_runtime.ToString();
            });
            tbRuntime_anoxic8_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_anoxic8_runtimeGd1mrPage.Text = Program.Runtime_PLC2.anoxic8_runtime.ToString();
            });
            tbRuntime_etanol1_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_etanol1_runtimeGd1mrPage.Text = Program.Runtime_PLC2.etanol1_runtime.ToString();
            });
            tbRuntime_etanol2_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_etanol2_runtimeGd1mrPage.Text = Program.Runtime_PLC2.etanol2_runtime.ToString();
            });

            tbRuntime_metanol_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_metanol_runtimeGd1mrPage.Text = Program.Runtime_PLC2.metanol_runtime.ToString();
            });
            tbRuntime_mtk1_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_mtk1_runtimeGd1mrPage.Text = Program.Runtime_PLC2.mkt01_runtime.ToString();
            });
            tbRuntime_mkt2_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_mkt2_runtimeGd1mrPage.Text = Program.Runtime_PLC2.mkt02_runtime.ToString();
            });
            tbRuntime_mkt3_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_mkt3_runtimeGd1mrPage.Text = Program.Runtime_PLC2.mkt03_runtime.ToString();
            });
            tbRuntime_tuanHoan1_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_tuanHoan1_runtimeGd1mrPage.Text = Program.Runtime_PLC2.tuanHoan1_runtime.ToString();
            });
            tbRuntime_tuanHoan2_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_tuanHoan2_runtimeGd1mrPage.Text = Program.Runtime_PLC2.tuanHoan2_runtime.ToString();
            });
            tbRuntime_tuanHoan3_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_tuanHoan3_runtimeGd1mrPage.Text = Program.Runtime_PLC2.tuanHoan3_runtime.ToString();
            });
            tbRuntime_gatBun_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_gatBun_runtimeGd1mrPage.Text = Program.Runtime_PLC2.gatBun_runtime.ToString();
            });
            tbRuntime_bomBun1_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_bomBun1_runtimeGd1mrPage.Text = Program.Runtime_PLC2.bomBun1_runtime.ToString();
            });
            tbRuntime_bomBun2_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_bomBun2_runtimeGd1mrPage.Text = Program.Runtime_PLC2.bomBun2_runtime.ToString();
            });
            tbRuntime_khuayNaoh_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_khuayNaoh_runtimeGd1mrPage.Text = Program.Runtime_PLC2.khuayNaoh_runtime.ToString();
            });
            tbRuntime_dlNaoh_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlNaoh_runtimeGd1mrPage.Text = Program.Runtime_PLC2.dlNaoh_runtime.ToString();
            });
            tbRuntime_Al2so4_runtimeGd1mrPage.Invoke((MethodInvoker)delegate
            {
                tbRuntime_Al2so4_runtimeGd1mrPage.Text = Program.Runtime_PLC2.al2so4_1_runtime.ToString();
            });
        }

        public void resetRT_PLC2(int numberOfDataBlock, int startByte, int startBit)
        {
            try
            {
                PLC2_RT_Reset.plc_connectError = PLC2_RT_Reset.plc.Open();
                PLC2_RT_Reset.plc_connected = PLC2_RT_Reset.plc.IsConnected;
                PLC2_RT_Reset.plc_isAvailable = PLC2_RT_Reset.plc.IsAvailable;
                if (PLC2_RT_Reset.plc_isAvailable)
                {
                    if (PLC2_RT_Reset.plc.IsConnected)
                    {
                        Program.PLC_GD2.plc.Write(DataType.DataBlock, numberOfDataBlock, startByte, true, startBit);
                        Thread.Sleep(100);
                        Program.PLC_GD2.plc.Write(DataType.DataBlock, numberOfDataBlock, startByte, false, startBit);
                    }
                    else
                        MessageBox.Show("Not Valid: PLC2 is not connnected");

                }
                else
                {
                    MessageBox.Show("Not Valid: PLC2 not available!");
                }

                PLC2_RT_Reset.plc.Close();

            }
            catch (Exception err)
            {
                PLC2_RT_Reset.plc.Close();
                MessageBox.Show(err.Message);
            }
        }
        #endregion

        #region EVENT METHOD
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnHeader_runtimeGd1mrPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximize_runtimeGd1mrPage_Click(object sender, EventArgs e)
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

        private void btnMinimize_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RUNTIME_GD1MR_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void RUNTIME_GD1MR_Load(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = null;
                runtimeGD1MRPage.Interval = updatePeriod;
                runtimeGD1MRPage.Elapsed += updateEventHandler;
                runtimeGD1MRPage.AutoReset = true;
                runtimeGD1MRPage.Enabled = true;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void btnReset_anoxic1_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {

            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 0, 0);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_anoxic2_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {

            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 0, 1);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_anoxic3_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 0, 2);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_anoxic4_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 0, 3);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_anoxic5_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 0, 4);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_anoxic6_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 0, 5);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_anoxic7_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 0, 6);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_anoxic8_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 0, 7);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_etanol1_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 1, 0);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_etanol2_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 2, 6);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_metanol_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 1, 1);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_mtk1_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 1, 2);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_mtk2_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 1, 3);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_mtk3_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 1, 4);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_tuanHoan1_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 1, 5);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_tuanHoan2_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 1, 6);

            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_tuanHoan3_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 1, 7);

            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_gatBun_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 2, 0);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_bomBun1_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 2, 1);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_bomBun2_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 2, 5);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_khuayNaoh_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 2, 2);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_dlNaoh_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 2, 3);
            Program.plc2_stopOtherConnecting = false;
        }

        private void btnReset_Al2so4_runtimeGd1mrPage_Click(object sender, EventArgs e)
        {
            Program.plc2_stopOtherConnecting = true;
            resetRT_PLC2(38, 2, 4); // AL2SO4 1 & 2 ?????????
            Program.plc2_stopOtherConnecting = false;
        }
        #endregion

        #region OVERIDE METHOD
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
