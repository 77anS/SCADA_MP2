using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BSCADA_Footer = B_SCADA_Library_dotNetFramework.Resources.Library.Footer.style_1_bcmStyle.Footer;
namespace SCADA_MP2.Presentation
{
    class Footer : BSCADA_Footer
    {

        public override void picBox_home_Click(Color backgroundColor, Form _parent, Form _body)
        {
            base.picBox_home_Click(backgroundColor, _parent, Program.homePage);
        }

        public override void picBox_trend_Click(Color backgroundColor, Form _parent, Form _body)
        {
            base.picBox_trend_Click(backgroundColor, _parent, _body);
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
            // defaultParent
            // 
            this.defaultParent.Location = new System.Drawing.Point(130, 130);
            // 
            // _parent
            // 
            this._parent.Location = new System.Drawing.Point(156, 156);
            // 
            // defaultBody
            // 
            this.defaultBody.Location = new System.Drawing.Point(182, 182);
            this.defaultBody.Load += new System.EventHandler(this.defaultBody_Load);
            // 
            // _body
            // 
            this._body.Location = new System.Drawing.Point(208, 208);
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

        private void defaultBody_Load(object sender, EventArgs e)
        {

        }
    }
}
