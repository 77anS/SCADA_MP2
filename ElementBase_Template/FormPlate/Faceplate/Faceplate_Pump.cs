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

namespace ElementBase_Template.FormPlate.Faceplate
{
    public partial class Faceplate_Pump : Form
    {
        public Form _parent;
        public string entityName { get; set; }


        public Faceplate_Pump()
        {
            InitializeComponent();
        }

        public Faceplate_Pump(Form _parent)
        {
            InitializeComponent();
            this._parent = _parent;
        }

        private void Pump_Load(object sender, EventArgs e)
        {
          
        }

        private void exitFaceplate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
    }
}
