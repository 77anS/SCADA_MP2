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
    public partial class SIM_ON_OFF : Form
    {
        Form _parent;
        public SIM_ON_OFF()
        {
            InitializeComponent();
        }
        public SIM_ON_OFF(Form _parent)
        {
            InitializeComponent();
            this._parent = _parent;
        }

        private void btn_mtk01_Click(object sender, EventArgs e)
        {
            Program.InputStatus_PLC1.mtk01_runStatus = !Program.InputStatus_PLC1.mtk01_runStatus;
        }
    }
}
