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

namespace MP2_V01
{
    public partial class RUNTIME_COLLECTION : Form
    {
        Form _parentFrm;
        public RUNTIME_COLLECTION()
        {
            InitializeComponent();
        }
        public RUNTIME_COLLECTION(Form _frm)
        {
            InitializeComponent();
            _parentFrm = _frm;
        }

        private void btnClose_runtimeCollectionPage_Click(object sender, EventArgs e)
        {
            _parentFrm.Enabled = true;
            _parentFrm.TopMost = true;
            _parentFrm.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void btnClose_runtimeCollectionPage_MouseHover(object sender, EventArgs e)
        {
            btnClose_runtimeCollectionPage.BackColor = Color.FromArgb(255, 240, 0, 0);
        }

        private void btnClose_runtimeCollectionPage_MouseLeave(object sender, EventArgs e)
        {
            btnClose_runtimeCollectionPage.BackColor = Color.FromArgb(255, 192, 192, 192);
        }

        private void btnCancel_runtimeCollectionPage_Click(object sender, EventArgs e)
        {
            _parentFrm.Enabled = true;
            _parentFrm.TopMost = true;
            _parentFrm.WindowState = FormWindowState.Maximized;
            this.Close();
        }

        private void btnOk_runtimeCollectionPage_Click(object sender, EventArgs e)
        {
            int ketQuaChon = cboRt_runtimeCollectionPage.SelectedIndex;
            switch(ketQuaChon)
            {
                case 0:
                    Program.runtimeGD1Page.TopMost = true;
                    Program.runtimeGD1Page.TopLevel = false;

                    Control[] myPhuocPanel1 = _parentFrm.Controls.Find("pnBody_framePage", true); // true tìm cả các control con
                    myPhuocPanel1[0].Controls.Clear();
                    myPhuocPanel1[0].Controls.Add(Program.runtimeGD1Page);
                    Program.runtimeGD1Page.Show();

                    _parentFrm.Enabled = true;
                    _parentFrm.TopMost = true;
                    _parentFrm.WindowState = FormWindowState.Maximized;

                    break;
                case 1:
                    Program.runtimeGD1MRPage.TopMost = true;
                    Program.runtimeGD1MRPage.TopLevel = false;

                    Control[] myPhuocPanel2 = _parentFrm.Controls.Find("pnBody_framePage", true);
                    myPhuocPanel2[0].Controls.Clear();
                    myPhuocPanel2[0].Controls.Add(Program.runtimeGD1MRPage);
                    Program.runtimeGD1MRPage.Show();

                    _parentFrm.Enabled = true;
                    _parentFrm.TopMost = true;
                    _parentFrm.WindowState = FormWindowState.Maximized;
                    break;
                case 2:
                    Program.runtimeGD2Page.TopMost = true;
                    Program.runtimeGD2Page.TopLevel = false;

                    Control[] myPhuocPanel3 = _parentFrm.Controls.Find("pnBody_framePage", true);
                    myPhuocPanel3[0].Controls.Clear();
                    myPhuocPanel3[0].Controls.Add(Program.runtimeGD2Page);
                    Program.runtimeGD2Page.Show();

                    _parentFrm.Enabled = true;
                    _parentFrm.TopMost = true;
                    _parentFrm.WindowState = FormWindowState.Maximized;
                    break;
                default:
                    _parentFrm.Enabled = true;
                    _parentFrm.TopMost = true;
                    _parentFrm.WindowState = FormWindowState.Maximized;
                    break;
            }
            this.Close();
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnHeader_runtimeCollectionPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RUNTIME_COLLECTION_Load(object sender, EventArgs e)
        {
            _parentFrm.Enabled = false;
        }
    }
}
