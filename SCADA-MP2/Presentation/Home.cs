using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCADA_MP2.Presentation
{
    public partial class Home : Form
    {


        #region CONSTRUCTOR
        public Home()
        {
            InitializeComponent();
        }
        #endregion

        #region OVERIDING METHOD
        #endregion

        #region METHOD
        private void Home_Load(object sender, EventArgs e)
        {
            RunBackWorker();
            
        }
        #endregion

        private void Home_Deactivate(object sender, EventArgs e)
        {

        }

        private void Home_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
