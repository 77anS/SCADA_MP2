using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Timers;
using System.Threading;

namespace MP2_V01
{
    public partial class WaitForm : Form
    {
        Form _parent;
        public WaitForm()
        {
            InitializeComponent();
        }

        public WaitForm(Form parent)
        {
            InitializeComponent();
            this._parent = parent;
        }

        private void WaitForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopLevel = false;

            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                proBar_1.Width += 3;
                if (proBar_1.Width >= 329)
                {
                this.timer1.Stop();
                this.timer1.Enabled = false;
                this.Close();

                }
        }
    }
}
