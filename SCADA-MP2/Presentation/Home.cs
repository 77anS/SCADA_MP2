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
                if(entity != null)
                {
                    string entityName = entity.Name.ToString();
                    Faceplate_Motor fp_device = new Faceplate_Motor(entityName);
                    fp_device.TopMost = true;
                    fp_device.TopLevel = true;
                    fp_device.Text = entityName;
                    switch (entityName)
                    {
                        case "motor_mtk01":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MÁY THỐI KHÍ - MTK01";
                            break;
                        case "motor_mtk02":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MÁY THỐI KHÍ - MTK02";
                            break;
                        case "motor_mtk03":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MÁY THỐI KHÍ - MTK03";
                            break;
                        case "motor_mtetn":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MT-ETN";
                            break;
                        case "motor_dpetn":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MT-ETN";
                            break;
                        case "motor_dp03":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP-03";
                            break;
                        case "motor_mt03":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MT-03";
                            break;
                        case "motor_mkt01":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MKT1";
                            break;
                        case "motor_mkt02":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MKT2";
                            break;
                        case "motor_mkt03":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MKT3";
                            break;
                        case "motor_mt05":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MT-05";
                            break;
                        case "motor_dp05":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP-05";
                            break;
                        case "motor_dp06_01p2":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP-06 (1/2)";
                            break;
                        case "motor_mt06_01p2":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MT-06 (1/2)";
                            break;
                        case "motor_bb1":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "BB1";
                            break;
                        case "motor_bb2":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "BB2";
                            break;
                        case "motor_gb1":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "GB1";
                            break;
                        case "motor_th1":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "TH1";
                            break;
                        case "motor_th2":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "TH2";
                            break;
                        case "motor_th3":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "TH3";
                            break;
                        case "motor_sm01":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SM01";
                            break;
                        case "motor_sm02":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SM02";
                            break;
                        case "motor_sm03":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SM03";
                            break;
                        case "motor_sm04":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SM04";
                            break;
                        case "motor_sm05":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SM05";
                            break;
                        case "motor_sm06":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SM06";
                            break;
                        case "motor_sm07":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SM07";
                            break;
                        case "motor_sm08":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SM08";
                            break;
                        case "motor_p0201":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "P0201";
                            break;
                        case "motor_p0202":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "P0202";
                            break; 
                        case "motor_wp02a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "WP02A";
                            break;
                        case "motor_wp02b":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "WP02B";
                            break;
                        case "motor_p0101":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "P0101";
                            break;
                        case "motor_p0102":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "P0102";
                            break;
                        case "motor_p0103":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "P0103";
                            break;
                        case "mayTachRac_bs02a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MÁY TÁCH RÁC - BS02A";
                            break;
                        case "motor_mc04":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MC04";
                            break;
                        case "motor_mc03":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MC03";
                            break;
                        case "motor_dp04a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP04A";
                            break;
                        case "motor_dp04b":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP04B";
                            break;
                        case "motor_dp03a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP03A";
                            break;
                        case "motor_dp03b":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP03B";
                            break;
                        case "motor_dp05a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP05A";
                            break;
                        case "motor_dp05b":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP05B";
                            break;
                        case "motor_dp06a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP06A";
                            break;
                        case "motor_dp06b":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP06B";
                            break;
                        case "motor_mi03":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MI03";
                            break;
                        case "motor_mi04a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MI04A";
                            break;
                        case "motor_mi04b":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MI04B";
                            break;
                        case "motor_ms05":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MS05";
                            break;
                        case "motor_ab06a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "AB06A";
                            break;
                        case "motor_ab06b":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "AB06B";
                            break;
                        case "motor_ab06c":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "AB06C";
                            break;
                        case "motor_ms07":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MS07";
                            break;
                        case "motor_mt02":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MT-02";
                            break;
                        case "motor_dp02":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP-02";
                            break;
                        case "motor_mt04":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MT-04";
                            break;
                        case "motor_dp04":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP-04";
                            break;
                        case "motor_mt02b":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MT-02B";
                            break;
                        case "motor_mt02a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MT-02A";
                            break;
                        case "motor_mt01":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MT-01";
                            break;
                        case "motor_ggb":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "GGB";
                            break;
                        case "motor_sp11":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SP11";
                            break;
                        case "motor_dp07a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP07A";
                            break;
                        case "motor_dp07b":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP07B";
                            break;
                        case "motor_sp07b":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SP07B";
                            break;
                        case "motor_sp07a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SP07A";
                            break;
                        case "motor_sp05a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SP05A";
                            break;
                        case "motor_sp05b":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SP05B";
                            break;
                        case "motor_ms09":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MS09";
                            break;
                        case "motor_dp04a_1p2":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP04A (1/2)";
                            break;
                        case "motor_dp04a_2p2":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP04A (2/2)";
                            break;
                        case "motor_sp10":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "SP10";
                            break;
                        case "motor_mc09":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MC09";
                            break;
                        case "motor_dp09a":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP09A";
                            break;
                        case "motor_dp09b":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP09B";
                            break;
                        case "motor_dp01":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP-01";
                            break;
                        case "motor_dp06_2p2":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "DP-06";
                            break;
                        case "motor_mt06_2p2":
                            fp_device.Controls.Find("lb_MotorName", true)[0].Text = "MT-06";
                            break;
                        default:
                            break;

                    }
                    fp_device.Show();
                }    
                
            }
            catch (NullReferenceException Ex1)
            {
                MessageBox.Show(Ex1.Message);
            }
            catch (Exception Ex2)
            {
                MessageBox.Show(Ex2.Message);
            }

        }

        private void motor_ggb_Load(object sender, EventArgs e)
        {

        }

        private void motor_sp11_Load(object sender, EventArgs e)
        {

        }

        private void motor_dp07b_Load(object sender, EventArgs e)
        {

        }

        private void motor_dp07a_Load(object sender, EventArgs e)
        {

        }

        private void motor_sp07b_Load(object sender, EventArgs e)
        {

        }

        private void motor_sp07a_Load(object sender, EventArgs e)
        {

        }

        private void motor_sp05b_Load(object sender, EventArgs e)
        {

        }

        private void motor_sp05a_Load(object sender, EventArgs e)
        {

        }

        private void motor_ms09_Load(object sender, EventArgs e)
        {

        }

        private void motor_dp04a_1p2_Load(object sender, EventArgs e)
        {

        }

        private void motor_dp04b_2p2_Load(object sender, EventArgs e)
        {

        }

        private void motor_sp10_Load(object sender, EventArgs e)
        {

        }

        private void standardControl161_Load(object sender, EventArgs e)
        {

        }

        private void motor_dp09a_Load(object sender, EventArgs e)
        {

        }

        private void motor_dp09b_Load(object sender, EventArgs e)
        {

        }

        private void motor_dp01_Load(object sender, EventArgs e)
        {

        }

        private void motor_dp06_2p2_Load(object sender, EventArgs e)
        {

        }

        private void motor_mt06_2p2_Load(object sender, EventArgs e)
        {

        }
    }
}
