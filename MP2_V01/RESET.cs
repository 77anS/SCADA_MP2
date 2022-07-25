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
    public partial class RESET : Form
    {
        public Form _parentForm;

        public short updatePeriod { get; set; } = 200;

        public System.Timers.Timer Timer_resetPage = new System.Timers.Timer();

        public EngineCycle.PLC_GD1 plc_resetPage = new EngineCycle.PLC_GD1();
        public RESET()
        {
            InitializeComponent();
        }
        public RESET(Form parent)
        {
            InitializeComponent();
            _parentForm = parent;
        }

        private void RESET_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            _parentForm.Enabled = false;
            _parentForm.TopMost = false;

            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;


            Timer_resetPage.Interval = updatePeriod;
            Timer_resetPage.Elapsed += updateEventHandler;
            Timer_resetPage.AutoReset = true;
            Timer_resetPage.Enabled = true;
        }

        private void updateEventHandler(object sender, ElapsedEventArgs e)
        {
            tbFlowInTotal_resetPage.Invoke((MethodInvoker)delegate
            {
                tbFlowInTotal_resetPage.Text = Program.QuanTracIndex_PLC1.flowInTotal.ToString();
            });

            tbFlowOutTotal_resetPage.Invoke((MethodInvoker)delegate
            {
                tbFlowOutTotal_resetPage.Text = Program.QuanTracIndex_PLC1.flowOutTotal.ToString();
            });
        }

        private void btn_exit_resetPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void RESET_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btn_resetFlowIn_resetPage_Click(object sender, EventArgs e)
        {
            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(14, 82, 0);
            Program.plc1_stopOtherConnecting = false;
        }

        public void resetRT_PLC1(int numberOfDataBlock, int startByte, int startBit)
        {
            try
            {
                plc_resetPage.plc_connectError = plc_resetPage.plc.Open();
                plc_resetPage.plc_connected = plc_resetPage.plc.IsConnected;
                plc_resetPage.plc_isAvailable = plc_resetPage.plc.IsAvailable;
                if (plc_resetPage.plc_isAvailable)
                {
                    if (plc_resetPage.plc.IsConnected)
                    {
                        Program.PLC_GD1.plc.Write(DataType.DataBlock, numberOfDataBlock, startByte, true, startBit);
                        Thread.Sleep(100);
                        Program.PLC_GD1.plc.Write(DataType.DataBlock, numberOfDataBlock, startByte, false,startBit);
                    }
                    else
                        MessageBox.Show("Not Valid: PLC1 is not connnected");

                }
                else
                {
                    MessageBox.Show("Not Valid: PLC1 not available!");
                }

                plc_resetPage.plc.Close();

            }
            catch (Exception err)
            {
                plc_resetPage.plc.Close();
                MessageBox.Show(err.Message);
            }
        }

        private void btn_resetFlowOut_resetPage_Click(object sender, EventArgs e)
        {
            Program.plc1_stopOtherConnecting = true;
            resetRT_PLC1(14, 76,0);
            Program.plc1_stopOtherConnecting = false;
        }

        private void btnClose_settingPage_MouseHover(object sender, EventArgs e)
        {
            btnClose_resetPage.BackColor = Color.FromArgb(255, 240, 0, 0);
        }

        private void btnClose_resetPage_Click(object sender, EventArgs e)
        {
            Timer_resetPage.Stop();
            Timer_resetPage.Close();

            _parentForm.Enabled = true;
            _parentForm.TopMost = true;

            this.TopMost = false;
            this.Close();
        }

        private void btnClose_resetPage_MouseLeave(object sender, EventArgs e)
        {
            btnClose_resetPage.BackColor = Color.FromArgb(255, 24, 42, 91); //227, 227, 227
        }
    }
}
