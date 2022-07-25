using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Timers;

using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

using ElementBase_Template.Ultility;




namespace MP2_V01
{
    public partial class TREND : Form
    {
        #region FIELDS
            private int borderSize = 1;
            private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.

            public short updatePeriod { get; set; } = 200;
            public short tableUpdatePeriod { get; set; } = 3000;

            public float value_cod { get; set; } = -1.00f;
            public float value_tss { get; set; } = -1.00f;
            public float value_ph { get; set; } = -1.00f;
            public float value_color { get; set; } = -1.00f;
            public float value_temper { get; set; } = -1.00f;
            public float value_amoni { get; set; } = -1.00f;
            public float value_flow { get; set; } = -1.00f;

            // COD TOOLTIP
            Point? prevPosition = null;
            ToolTip tooltip = new ToolTip();

        /// <summary>
        ///Refresh chart
        /// </summary>
        int _countSecond_cod = 0;
        int _countSecond_tss = 0;
        int _countSecond_ph = 0;
        int _countSecond_colorTemp = 0;
        int _countSecond_amoni = 0;
        int _countSecond_flow = 0;


        //System.Timers.Timer runtimeTrendPage = new System.Timers.Timer();
        //System.Timers.Timer tableUpdateTimer = new System.Timers.Timer();


        #endregion

        #region CONSTRUCTOR
        public TREND()
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
            chartUpdate();
        }
        void chartUpdate()
        {
        }


        private void updateTableEventHandler(object sender, ElapsedEventArgs e)
        {

        }
        #endregion

        #region EVENT METHOD
        private void trendForm_Load(object sender, EventArgs e)
        {
            timer_cod.Enabled = true;
            timer_tss.Enabled = true;
            timer_ph.Enabled = true;
            timer_colorTemper.Enabled = true;
            timer_amoni.Enabled = true;
            timer_flow.Enabled = true;
            #region COD
            // Thiết lập khoảng giao động [min, max] của đồ thị theo trục X, Y
            chart_codIndex.ChartAreas[0].AxisY.Maximum = 15;
            chart_codIndex.ChartAreas[0].AxisY.Minimum = -1.5;
            chart_codIndex.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate(); // Lấy thời gian hiện tại hệ thống => thời gian OLE Automation date => làm mốc bắt đầu
            chart_codIndex.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate(); // Lấy thời gian hiện tại (thời gian OLE Automation date) + 1 phút => làm điểm cuối time của đồ thị.

            // Cấu hình định dạng nhãn (label) của trục X
            chart_codIndex.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            // Thiết lập loại giá trị trục X <=> DateTime
            chart_codIndex.Series[0].XValueType = ChartValueType.DateTime;

            chart_codIndex.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;// khoảng cách giữa 2 điểm dữ liệu => đơn vị: giây
            chart_codIndex.ChartAreas[0].AxisX.Interval = 5; // Khoảng cách 2 điểm dữ liệu => 5s

            #endregion

            #region TSS
            // Thiết lập khoảng giao động [min, max] của đồ thị theo trục X, Y
            chart_tssIndex.ChartAreas[0].AxisY.Maximum = 100;
            chart_tssIndex.ChartAreas[0].AxisY.Minimum = -100;
            chart_tssIndex.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate(); // Lấy thời gian hiện tại hệ thống => thời gian OLE Automation date => làm mốc bắt đầu
            chart_tssIndex.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate(); // Lấy thời gian hiện tại (thời gian OLE Automation date) + 1 phút => làm điểm cuối time của đồ thị.

            // Cấu hình định dạng nhãn (label) của trục X
            chart_tssIndex.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            // Thiết lập loại giá trị trục X <=> DateTime
            chart_tssIndex.Series[0].XValueType = ChartValueType.DateTime;

            chart_tssIndex.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;// khoảng cách giữa 2 điểm dữ liệu => đơn vị: giây
            chart_tssIndex.ChartAreas[0].AxisX.Interval = 5; // Khoảng cách 2 điểm dữ liệu => 5s

            #endregion

            #region PH
            // Thiết lập khoảng giao động [min, max] của đồ thị theo trục X, Y
            chart_phIndex.ChartAreas[0].AxisY.Maximum = 15;
            chart_phIndex.ChartAreas[0].AxisY.Minimum = 0;
            chart_phIndex.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate(); // Lấy thời gian hiện tại hệ thống => thời gian OLE Automation date => làm mốc bắt đầu
            chart_phIndex.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate(); // Lấy thời gian hiện tại (thời gian OLE Automation date) + 1 phút => làm điểm cuối time của đồ thị.

            // Cấu hình định dạng nhãn (label) của trục X
            chart_phIndex.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            // Thiết lập loại giá trị trục X <=> DateTime
            chart_phIndex.Series[0].XValueType = ChartValueType.DateTime;

            chart_phIndex.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;// khoảng cách giữa 2 điểm dữ liệu => đơn vị: giây
            chart_phIndex.ChartAreas[0].AxisX.Interval = 5; // Khoảng cách 2 điểm dữ liệu => 5s

            #endregion

            #region COLOR + TEMPERATURE
            // Thiết lập khoảng giao động [min, max] của đồ thị theo trục X, Y
            chart_colorTemperIndex.ChartAreas[0].AxisY.Maximum = 100;
            chart_colorTemperIndex.ChartAreas[0].AxisY.Minimum = 0;
            chart_colorTemperIndex.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate(); // Lấy thời gian hiện tại hệ thống => thời gian OLE Automation date => làm mốc bắt đầu
            chart_colorTemperIndex.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate(); // Lấy thời gian hiện tại (thời gian OLE Automation date) + 1 phút => làm điểm cuối time của đồ thị.

            // Cấu hình định dạng nhãn (label) của trục X
            chart_colorTemperIndex.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            // Thiết lập loại giá trị trục X <=> DateTime
            chart_colorTemperIndex.Series[0].XValueType = ChartValueType.DateTime;

            chart_colorTemperIndex.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;// khoảng cách giữa 2 điểm dữ liệu => đơn vị: giây
            chart_colorTemperIndex.ChartAreas[0].AxisX.Interval = 5; // Khoảng cách 2 điểm dữ liệu => 5s

            #endregion

            #region AMONI
            // Thiết lập khoảng giao động [min, max] của đồ thị theo trục X, Y
            chart_amoIndex.ChartAreas[0].AxisY.Maximum = 100;
            chart_amoIndex.ChartAreas[0].AxisY.Minimum = 0;
            chart_amoIndex.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate(); // Lấy thời gian hiện tại hệ thống => thời gian OLE Automation date => làm mốc bắt đầu
            chart_amoIndex.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate(); // Lấy thời gian hiện tại (thời gian OLE Automation date) + 1 phút => làm điểm cuối time của đồ thị.

            // Cấu hình định dạng nhãn (label) của trục X
            chart_amoIndex.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            // Thiết lập loại giá trị trục X <=> DateTime
            chart_amoIndex.Series[0].XValueType = ChartValueType.DateTime;

            chart_amoIndex.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;// khoảng cách giữa 2 điểm dữ liệu => đơn vị: giây
            chart_amoIndex.ChartAreas[0].AxisX.Interval = 5; // Khoảng cách 2 điểm dữ liệu => 5s

            #endregion

            #region FLOW
            // Thiết lập khoảng giao động [min, max] của đồ thị theo trục X, Y
            chart_flowIndex.ChartAreas[0].AxisY.Maximum = 100;
            chart_flowIndex.ChartAreas[0].AxisY.Minimum = 0;
            chart_flowIndex.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate(); // Lấy thời gian hiện tại hệ thống => thời gian OLE Automation date => làm mốc bắt đầu
            chart_flowIndex.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate(); // Lấy thời gian hiện tại (thời gian OLE Automation date) + 1 phút => làm điểm cuối time của đồ thị.

            // Cấu hình định dạng nhãn (label) của trục X
            chart_flowIndex.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            // Thiết lập loại giá trị trục X <=> DateTime
            chart_flowIndex.Series[0].XValueType = ChartValueType.DateTime;

            chart_flowIndex.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;// khoảng cách giữa 2 điểm dữ liệu => đơn vị: giây
            chart_flowIndex.ChartAreas[0].AxisX.Interval = 5; // Khoảng cách 2 điểm dữ liệu => 5s

            #endregion


        }



        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnHeader_trendPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximize_trendPage_Click(object sender, EventArgs e)
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

        private void btnMinimize_trendPage_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_trendPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TREND_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        #endregion

        /// <summary>
        /// Method for holding and moving Top Bar
        /// </summary>
        /// <param name="m"></param>
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

        private void chart_codIndex_Click(object sender, EventArgs e)
        {

        }

        private void timer_cod_Tick(object sender, EventArgs e)
        {

        }

        private void timer_cod_Tick_1(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now; // thời gian realtime

            #region COD
            ///FAKE VALUE:
            RandomValue fake_cod = new RandomValue();
            value_cod = fake_cod.random_float(5.5f, 10.0f);

            //value_cod = Program.QuanTracIndex_PLC1.cod_Index;

            chart_codIndex.Series[0].Points.AddXY(timeNow, value_cod);

            _countSecond_cod++;
            if (_countSecond_cod == 60)
            {
                _countSecond_cod = 0;
                chart_codIndex.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chart_codIndex.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                chart_codIndex.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart_codIndex.ChartAreas[0].AxisX.Interval = 5;
            }

            #endregion

        }

        private void chart_codIndex_MouseHover(object sender, MouseEventArgs e)
        {
           
        }

        private void chart_codIndex_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart_codIndex.HitTest(pos.X, pos.Y, false,
                                            ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        // check if the cursor is really close to the point (2 pixels around the point)
                        if (Math.Abs(pos.X - pointXPixel) < 2 &&
                            Math.Abs(pos.Y - pointYPixel) < 2)
                        {
                            tooltip.Show("X=" + prop.XValue + ", Y=" + prop.YValues[0], this.chart_codIndex,
                                            pos.X, pos.Y - 15);
                        }
                    }
                }
            }
        }

        private void timer_tss_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now; // thời gian realtime

            #region TSS
            ///FAKE VALUE:
            RandomValue fake_tss = new RandomValue();
            value_tss = fake_tss.random_float(-50.0f, 50.0f);

            //value_tss = Program.QuanTracIndex_PLC1.tss_Index;

            chart_tssIndex.Series[0].Points.AddXY(timeNow, value_tss);

            _countSecond_tss++;
            if (_countSecond_tss == 60)
            {
                _countSecond_tss = 0;
                chart_tssIndex.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chart_tssIndex.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                chart_tssIndex.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart_tssIndex.ChartAreas[0].AxisX.Interval = 5;
            }

            #endregion
        }

        private void timer_ph_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now; // thời gian realtime

            #region PH
            ///FAKE VALUE:
            RandomValue fake_ph = new RandomValue();
            value_ph = fake_ph.random_float(7.0f, 8.5f);

            //value_ph = Program.QuanTracIndex_PLC1.ph_Index;

            chart_phIndex.Series[0].Points.AddXY(timeNow, value_ph);

            _countSecond_ph++;
            if (_countSecond_ph == 60)
            {
                _countSecond_ph = 0;
                chart_phIndex.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chart_phIndex.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                chart_phIndex.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart_phIndex.ChartAreas[0].AxisX.Interval = 5;
            }

            #endregion
        }

        private void timer_colorTemper_Tick(object sender, EventArgs e)
        {
            {
                DateTime timeNow = DateTime.Now; // thời gian realtime

                #region COLOR + TEMPERATURE
                ///FAKE COLOR VALUE:
                RandomValue fake_color = new RandomValue();
                value_color = fake_color.random_float(7.0f, 8.5f);

                ///FAKE TEMPERATURE VALUE:
                RandomValue fake_temper = new RandomValue();
                value_temper = fake_temper.random_float(20.0f, 25.5f);

                //value_color = Program.QuanTracIndex_PLC1.ph_Index;
                //value_temper = Program.QuanTracIndex_PLC1.temper_Index;

                chart_colorTemperIndex.Series[0].Points.AddXY(timeNow, value_color);
                chart_colorTemperIndex.Series[1].Points.AddXY(timeNow, value_temper);

                _countSecond_colorTemp++;
                if (_countSecond_colorTemp == 60)
                {
                    _countSecond_colorTemp = 0;
                    chart_colorTemperIndex.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                    chart_colorTemperIndex.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                    chart_colorTemperIndex.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                    chart_colorTemperIndex.ChartAreas[0].AxisX.Interval = 5;
                }

                #endregion
            }
        }

        private void timer_amoni_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now; // thời gian realtime

            #region AMONI
            ///FAKE VALUE:
            RandomValue fake_amoni = new RandomValue();
            value_amoni = fake_amoni.random_float(7.0f, 8.5f);

            //value_amoni = Program.QuanTracIndex_PLC1.amoni_Index;

            chart_amoIndex.Series[0].Points.AddXY(timeNow, value_amoni);

            _countSecond_amoni++;
            if (_countSecond_amoni == 60)
            {
                _countSecond_amoni = 0;
                chart_amoIndex.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chart_amoIndex.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                chart_amoIndex.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart_amoIndex.ChartAreas[0].AxisX.Interval = 5;
            }

            #endregion
        }

        private void timer_flow_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now; // thời gian realtime

            #region FLOW
            ///FAKE VALUE:
            RandomValue fake_flow = new RandomValue();
            value_flow = fake_flow.random_float(7.0f, 8.5f);

            //value_flow = Program.QuanTracIndex_PLC1.flow_Index;

            chart_flowIndex.Series[0].Points.AddXY(timeNow, value_flow);

            _countSecond_flow++;
            if (_countSecond_flow == 60)
            {
                _countSecond_flow = 0;
                chart_flowIndex.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chart_flowIndex.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                chart_flowIndex.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chart_flowIndex.ChartAreas[0].AxisX.Interval = 5;
            }

            #endregion
        }
    }
}
