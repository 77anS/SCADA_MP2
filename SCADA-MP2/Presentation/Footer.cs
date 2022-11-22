using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SCADA_footer = B_SCADA_Library_dotNetFramework.Resources.Library.Footer.style_1_bcmStyle.Footer;
//using SCADA_body = SCADA_MP2.Presentation.Home;
namespace SCADA_MP2.Presentation
{
    class Footer : SCADA_footer
    {

        public override void picBox_home_Click(Color backgroundColor, Form _parent, Form _body)
        {
            base.picBox_home_Click(backgroundColor, _parent, Program.homePage);
        }

        private void InitializeComponent()
        {
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_mainter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_trend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_alarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_home)).BeginInit();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1920, 57);
            this.Name = "Footer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_mainter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_trend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_alarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_home)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
