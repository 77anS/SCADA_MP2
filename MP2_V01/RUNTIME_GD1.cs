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
using S7.Net;

using System.Threading;

namespace MP2_V01
{
    public partial class RUNTIME_GD1 : Form
    {
        #region FIELDS
        private int borderSize = 1;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
        public short updatePeriod { get; set; } = 500;
        System.Timers.Timer Timer_runtimeGD1Page = new System.Timers.Timer();

        EngineCycle.PLC_GD1 PLC1_RT_Reset = new EngineCycle.PLC_GD1(); // Kế thừa đối tượng PLC đã khởi tạo kết nối trước đó.
        #endregion

        #region CONSTRUCTOR
        public RUNTIME_GD1()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
        }
        #endregion

        #region METHODS
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
            
            
            tbRuntime_beGom1_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_beGom1_runtimeGd1Page.Text = Program.Runtime_PLC1.beGom1_runtime.ToString();
            });

            tbRuntime_beGom2_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_beGom2_runtimeGd1Page.Text = Program.Runtime_PLC1.beGom2_runtime.ToString();
            });

            tbRuntime_beGom3_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_beGom3_runtimeGd1Page.Text = Program.Runtime_PLC1.beGom3_runtime.ToString();
            });

            tbRuntime_dieuHoa1_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dieuHoa1_runtimeGd1Page.Text = Program.Runtime_PLC1.dieuHoa1_runtime.ToString();
            });
            tbRuntime_dieuHoa2_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dieuHoa2_runtimeGd1Page.Text = Program.Runtime_PLC1.dieuHoa2_runtime.ToString();
            });
            

            tbRuntime_mtk1_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_mtk1_runtimeGd1Page.Text = Program.Runtime_PLC1.mtk1_runtime.ToString();
            });

            tbRuntime_mtk2_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_mtk2_runtimeGd1Page.Text = Program.Runtime_PLC1.mtk2_runtime.ToString();
            });
            tbRuntime_mtk3_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_mtk3_runtimeGd1Page.Text = Program.Runtime_PLC1.mtk3_runtime.ToString();
            });
            tbRuntime_dlAxit_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlAxit_runtimeGd1Page.Text = Program.Runtime_PLC1.dlAxit_runtime.ToString();
            });
            tbRuntime_dlXut_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlXut_runtimeGd1Page.Text = Program.Runtime_PLC1.dlXut_runtime.ToString();
            });

            tbRuntime_dlNp_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlNp_runtimeGd1Page.Text = Program.Runtime_PLC1.dlNp_runtime.ToString();
            });
            tbRuntime_dlClo_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlClo_runtimeGd1Page.Text = Program.Runtime_PLC1.dlClo_runtime.ToString();
            });
            tbRuntime_dlPac_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlPac_runtimeGd1Page.Text = Program.Runtime_PLC1.dlPac_runtime.ToString();
            });
            tbRuntime_dlPoly_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_dlPoly_runtimeGd1Page.Text = Program.Runtime_PLC1.dlPolyme_runtime.ToString();
            });
            tbRuntime_khuayNp_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_khuayNp_runtimeGd1Page.Text = Program.Runtime_PLC1.khuayNp_runtime.ToString();
            });
            tbRuntime_khuayClo_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_khuayClo_runtimeGd1Page.Text = Program.Runtime_PLC1.khuayClo_runtime.ToString();
            });
            tbRuntime_khuayPac_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_khuayPac_runtimeGd1Page.Text = Program.Runtime_PLC1.khuayPac_runtime.ToString();
            });
            tbRuntime_khuayPoly1_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_khuayPoly1_runtimeGd1Page.Text = Program.Runtime_PLC1.khuayPolyme1_runtime.ToString();
            });
            tbRuntime_khuayPoly2_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_khuayPoly2_runtimeGd1Page.Text = Program.Runtime_PLC1.khuayPolyme2_runtime.ToString();
            });
            tbRuntime_thNuoc_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_thNuoc_runtimeGd1Page.Text = Program.Runtime_PLC1.tuanHoanNuoc_runtime.ToString();
            });
            tbRuntime_thBun_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_thBun_runtimeGd1Page.Text = Program.Runtime_PLC1.tuanHoanBun_runtime.ToString();
            });
            tbRuntime_bunHoaLy1_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_bunHoaLy1_runtimeGd1Page.Text = Program.Runtime_PLC1.bunHoaLy1_runtime.ToString();
            });
            tbRuntime_bunHoaLy2_runtimeGd1Page.Invoke((MethodInvoker)delegate
            {
                tbRuntime_bunHoaLy2_runtimeGd1Page.Text = Program.Runtime_PLC1.bunHoaLy2_runtime.ToString();
            });
        }

        /// <summary>
        /// FUNC Reset Runtime PLC1
        /// </summary>
        /// <param name="numberOfDataBlock"></param>
        /// <param name="startByte"></param>
        /// <param name="startBit"></param>
        public void resetRT_PLC1(int numberOfDataBlock, int startByte, int startBit)
        {
            try
            {
                PLC1_RT_Reset.plc_connectError = PLC1_RT_Reset.plc.Open();
                PLC1_RT_Reset.plc_connected = PLC1_RT_Reset.plc.IsConnected;
                PLC1_RT_Reset.plc_isAvailable = PLC1_RT_Reset.plc.IsAvailable;
                if (PLC1_RT_Reset.plc_isAvailable)
                {
                    if (PLC1_RT_Reset.plc.IsConnected)
                    {
                        Program.PLC_GD1.plc.Write(DataType.DataBlock, numberOfDataBlock, startByte,true, startBit);
                        Thread.Sleep(100);
                        Program.PLC_GD1.plc.Write(DataType.DataBlock, numberOfDataBlock, startByte, false, startBit);
                    }
                    else
                        MessageBox.Show("Not Valid: PLC1 is not connnected");

                }
                else
                {
                    MessageBox.Show("Not Valid: PLC1 not available!");
                }

                PLC1_RT_Reset.plc.Close();

            }
            catch (Exception err)
            {
                PLC1_RT_Reset.plc.Close();
                MessageBox.Show(err.Message);
            }
        }


        #endregion

        #region EVENT_METHODS
        private void btnReset_beGom1_runtimeGd1Page_Click(object sender, EventArgs e)
        {
            Program.plc1_stopOtherConnecting = true;
            //Program.PLC_GD1.plc.Close();
            resetRT_PLC1(20, 0, 4);
            Program.plc1_stopOtherConnecting = false;
        }

        private void btnReset_beGom2_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            //Program.PLC_GD1.plc.Close();
            resetRT_PLC1(20, 0, 5);
            Program.plc1_stopOtherConnecting = false;
        }

        private void btnReset_beGom3_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
           // Program.PLC_GD1.plc.Close();
            resetRT_PLC1(20, 0, 6);
            Program.plc1_stopOtherConnecting = false;

        }

        private void btnReset_dieuHoa1_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 0, 7);
            Program.plc1_stopOtherConnecting = false;

        }

        private void btnReset_dieuHoa2_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 1, 0);
            Program.plc1_stopOtherConnecting = false;

        }

        private void btnReset_mtk01_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 1, 4);
            Program.plc1_stopOtherConnecting = false;

        }

        private void btnReset_mtk02_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 4, 5);
            Program.plc1_stopOtherConnecting = false;

        }

        private void btnReset_mtk03_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 4, 6);
            Program.plc1_stopOtherConnecting = false;

        }

        private void btnReset_dlAxit_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 1, 7);
            Program.plc1_stopOtherConnecting = false;

        }

        private void btnReset_dlXut_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 2, 0);
            Program.plc1_stopOtherConnecting = false;

        }

        private void btnReset_dlNp_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 2, 1);
            Program.plc1_stopOtherConnecting = false;

        }

        private void btnReset_dlClo_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 2, 2);
            Program.plc1_stopOtherConnecting = false;

        }

        private void btnReset_dlPac_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 2, 3);
            Program.plc1_stopOtherConnecting = false;

        }

        private void btnReset_dlPoly_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 2, 4);
            Program.plc1_stopOtherConnecting = false;
        }

        private void btnReset_khuayNp_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 2, 5);
            Program.plc1_stopOtherConnecting = false;
        }

        private void btnReset_khuayClo_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 2, 6);
            Program.plc1_stopOtherConnecting = false;
        }

        private void btnReset_khuayPac_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 2, 7);
            Program.plc1_stopOtherConnecting = false;
        }

        private void btnReset_khuayPoly1_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 3, 0);
            Program.plc1_stopOtherConnecting = false;
        }

        private void btnReset_khuayPoly2_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 3, 1);
            Program.plc1_stopOtherConnecting = false;
        }

        private void btnReset_thNuoc_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 0, 0);
            Program.plc1_stopOtherConnecting = false;
        }

        private void btnReset_thBun_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 0, 1);
            Program.plc1_stopOtherConnecting = false;
        }

        private void btnReset_bunHoaLy1_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 0, 2);
            Program.plc1_stopOtherConnecting = false;
        }

        private void btnReset_bunHoaLy2_runtimeGd1Page_Click(object sender, EventArgs e)
        {

            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(20, 0, 3);
            Program.plc1_stopOtherConnecting = false;
        }
                private void label4_Click(object sender, EventArgs e)
            {

            }

            private void RUNTIME_GD1_Load(object sender, EventArgs e)
            {
                try
                {
                    this.ActiveControl = null;
                    Timer_runtimeGD1Page.Interval = updatePeriod;
                    Timer_runtimeGD1Page.Elapsed += updateEventHandler;
                    Timer_runtimeGD1Page.AutoReset = true;
                    Timer_runtimeGD1Page.Enabled = true;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }

            [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
            [DllImport("user32.dll", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
            private void pnHeader_runtimeGd1Page_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }



            /// <summary>
            /// Three set Handler
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            /// HIT ON
            private void btnMinimize_runtimeGd1_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            private void btnMaximize_runtimeGd1_Click(object sender, EventArgs e)
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
            private void btnClose_runtimeGd1Page_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            // HOVER AND LEAVE OUT HANDLER
            private void btnMaximize_runtimeGd1_MouseHover(object sender, EventArgs e)
            {

            }
            private void btnMaximize_runtimeGd1_MouseLeave(object sender, EventArgs e)
            {

            }


            private void btnMinimize_runtimeGd1_MouseHover(object sender, EventArgs e)
            {

            }

            private void btnClose_runtimeGd1_MouseLeave(object sender, EventArgs e)
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

            private void btnMaximize_runtimeGd1Page_Click(object sender, EventArgs e)
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

            /// <summary>
            /// Method implement when a control is resized: Adjust border in some form view mode
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            /// 
            private void RUNTIME_GD1_Resize(object sender, EventArgs e)
            {
                AdjustForm();
            }
        #endregion

        #region OVERIDING METHOD
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
