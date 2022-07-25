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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pnInfo_loginPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_loginPage_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_loginPage_MouseHover(object sender, EventArgs e)
        {
            btnClose_loginPage.BackColor = Color.FromArgb(255, 240, 0, 0);
        }

        private void btnClose_loginPage_MouseLeave(object sender, EventArgs e)
        {
            btnClose_loginPage.BackColor = Color.FromArgb(150, 240, 240, 240);
        }

        private void tbSignIn_loginPage_Click(object sender, EventArgs e)
        {

            if((tbUserName_loginPage.Text == "admin") && (tbPassword_loginPage.Text == "12345"))
            {
                Program.Enable_ReadData = true;

                //Frame abc = new Frame();

                Program.framePage.ShowDialog();
                this.Close();

                //Program.framePage.ShowDialog();
                //this.Close();

            }
            else
            {
                MessageBox.Show("Nhập sai thông tin!");
            }    
        }

        private void tbPassword_loginPage_Enter(object sender, EventArgs e)
        {

        }
    }
}
