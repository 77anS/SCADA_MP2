using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SymbolFactoryDotNet;
using SCADA_MP2.Presentation;
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void facePlateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StandardControl entity = new StandardControl();
                entity = contextFacePlate.SourceControl as StandardControl;
                string entityName = entity.Name.ToString();
                Faceplate_Motor fp_device = new Faceplate_Motor(entityName);
                //fp_device.TopMost = true;
                //fp_device.TopLevel = true;
                fp_device.Text = entityName;
                //Control[] temp1 = fp_device.Controls.Find("lb_MotorName", true);
                //Control facePlateTitle = temp1[0];
                //facePlateTitle.Text = entityName;
                fp_device.Show();
;
            }   
            catch(Exception ex)
            {

            }

        }
    }
}
