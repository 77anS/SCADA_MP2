using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Presentation
{
    public partial class Faceplate_Motor : B_SCADA_Library_dotNetFramework.Resources.Library.FacePlate.Motor.style_1_bcm.Motor
    {
        private void InitializeComponent()
        {
            this.pnSlot20.SuspendLayout();
            this.pnSlot10.SuspendLayout();
            this.pnSlot30.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // Faceplate_Motor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(575, 461);
            this.Name = "Faceplate_Motor";
            this.pnSlot20.ResumeLayout(false);
            this.pnSlot20.PerformLayout();
            this.pnSlot10.ResumeLayout(false);
            this.pnSlot10.PerformLayout();
            this.pnSlot30.ResumeLayout(false);
            this.pnSlot30.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.standardControl1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
