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
    public partial class DEVICE_LIST : Form
    {
        public Form _parentForm;
        public DEVICE_LIST()
        {
            InitializeComponent();
        }

        public DEVICE_LIST(Form _parentForm)
        {
            InitializeComponent();
            this._parentForm = _parentForm;

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_deviceListPage_Click(object sender, EventArgs e)
        {
            _parentForm.Enabled = true;
            this.TopMost = false;
            this.Close();
        }

        private void DEVICE_LIST_Load(object sender, EventArgs e)
        {
            _parentForm.Enabled = false;
            _parentForm.TopMost = false;

            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_deviceListPage_MouseHover(object sender, EventArgs e)
        {
            btnClose_deviceListPage.BackColor = Color.FromArgb(255, 240,0,0);
        }

        private void btnClose_deviceListPage_MouseLeave(object sender, EventArgs e)
        {
            btnClose_deviceListPage.BackColor = Color.FromArgb(255, 24, 42, 91);
        }
    }
}
