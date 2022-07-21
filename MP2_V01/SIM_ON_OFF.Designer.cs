
namespace MP2_V01
{
    partial class SIM_ON_OFF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_mtk01 = new System.Windows.Forms.Button();
            this.btn_mtk02 = new System.Windows.Forms.Button();
            this.btn_mtk03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mtk01
            // 
            this.btn_mtk01.Location = new System.Drawing.Point(34, 31);
            this.btn_mtk01.Name = "btn_mtk01";
            this.btn_mtk01.Size = new System.Drawing.Size(100, 38);
            this.btn_mtk01.TabIndex = 0;
            this.btn_mtk01.Text = "MTK01";
            this.btn_mtk01.UseVisualStyleBackColor = true;
            this.btn_mtk01.Click += new System.EventHandler(this.btn_mtk01_Click);
            // 
            // btn_mtk02
            // 
            this.btn_mtk02.Location = new System.Drawing.Point(152, 31);
            this.btn_mtk02.Name = "btn_mtk02";
            this.btn_mtk02.Size = new System.Drawing.Size(100, 38);
            this.btn_mtk02.TabIndex = 0;
            this.btn_mtk02.Text = "MTK02";
            this.btn_mtk02.UseVisualStyleBackColor = true;
            // 
            // btn_mtk03
            // 
            this.btn_mtk03.Location = new System.Drawing.Point(270, 31);
            this.btn_mtk03.Name = "btn_mtk03";
            this.btn_mtk03.Size = new System.Drawing.Size(100, 38);
            this.btn_mtk03.TabIndex = 0;
            this.btn_mtk03.Text = "MTK03";
            this.btn_mtk03.UseVisualStyleBackColor = true;
            // 
            // SIM_ON_OFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_mtk03);
            this.Controls.Add(this.btn_mtk02);
            this.Controls.Add(this.btn_mtk01);
            this.Name = "SIM_ON_OFF";
            this.Text = "SIM_ON_OFF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mtk01;
        private System.Windows.Forms.Button btn_mtk02;
        private System.Windows.Forms.Button btn_mtk03;
    }
}