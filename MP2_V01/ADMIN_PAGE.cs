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
    public partial class ADMIN_PAGE : Form
    {
        Form _parent;
        public ADMIN_PAGE()
        {
            InitializeComponent();
        }

        public ADMIN_PAGE(Form _parent)
        {
            InitializeComponent();
            this._parent = new Form();
            this._parent = _parent;
        }

        private void btn_tripSimu_systemPage_Click(object sender, EventArgs e)
        {
            Program.framePage.Enabled = false;
            Program.framePage.TopMost = false;

            Program.testingEnvironmentPage = new TESTING_ENVIRONMENT(Program.framePage);
            Program.testingEnvironmentPage.Show();
        }

        private void btnClose_systemPage_Click(object sender, EventArgs e)
        {
            this._parent.Enabled = true;
            this.Close();
        }

        private void btnMinimize_systemPage_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_systemPage_MouseHover(object sender, EventArgs e)
        {
            btnClose_systemPage.BackColor = Color.FromArgb(255, 240, 0, 0);
        }

        private void btnClose_systemPage_MouseLeave(object sender, EventArgs e)
        {
            btnClose_systemPage.BackColor = Color.FromArgb(150, 24, 42, 91);
        }

        private void btnMinimize_systemPage_MouseHover(object sender, EventArgs e)
        {
            btnMinimize_systemPage.BackColor = Color.FromArgb(50, 24, 42, 91);
        }

        private void btnMinimize_systemPage_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize_systemPage.BackColor = Color.FromArgb(255, 24, 42, 91);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.framePage.Enabled = false;
            Program.framePage.TopMost = false;

            Program.sim_on_off = new SIM_ON_OFF(this);
            Program.sim_on_off.Show();
        }
    }
}
