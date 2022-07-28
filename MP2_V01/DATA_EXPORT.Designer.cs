
namespace MP2_V01
{
    partial class DATA_EXPORT
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DATA_EXPORT));
            this.label73 = new System.Windows.Forms.Label();
            this.dtPicker_to = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPicker_from = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_chooseType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose_exportPage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExport_exportPage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMPERATURE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMONI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLOW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLOWOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.Color.White;
            this.label73.Location = new System.Drawing.Point(62, 89);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(270, 22);
            this.label73.TabIndex = 408;
            this.label73.Text = "CHỌN KHOẢNG THỜI GIAN:";
            this.label73.Click += new System.EventHandler(this.label73_Click);
            // 
            // dtPicker_to
            // 
            this.dtPicker_to.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_to.Location = new System.Drawing.Point(192, 195);
            this.dtPicker_to.Name = "dtPicker_to";
            this.dtPicker_to.Size = new System.Drawing.Size(217, 29);
            this.dtPicker_to.TabIndex = 409;
            this.dtPicker_to.Value = new System.DateTime(2022, 1, 2, 12, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 408;
            this.label2.Text = "Từ ngày:";
            this.label2.Click += new System.EventHandler(this.label73_Click);
            // 
            // dtPicker_from
            // 
            this.dtPicker_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_from.Location = new System.Drawing.Point(192, 134);
            this.dtPicker_from.Name = "dtPicker_from";
            this.dtPicker_from.Size = new System.Drawing.Size(217, 29);
            this.dtPicker_from.TabIndex = 409;
            this.dtPicker_from.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 408;
            this.label3.Text = "Đến ngày:";
            this.label3.Click += new System.EventHandler(this.label73_Click);
            // 
            // cbx_chooseType
            // 
            this.cbx_chooseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_chooseType.FormattingEnabled = true;
            this.cbx_chooseType.ItemHeight = 20;
            this.cbx_chooseType.Items.AddRange(new object[] {
            "CẢNH BÁO",
            "DỮ LIỆU QUAN TRẮC"});
            this.cbx_chooseType.Location = new System.Drawing.Point(484, 132);
            this.cbx_chooseType.Name = "cbx_chooseType";
            this.cbx_chooseType.Size = new System.Drawing.Size(195, 28);
            this.cbx_chooseType.TabIndex = 410;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(480, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 22);
            this.label4.TabIndex = 408;
            this.label4.Text = "CHỌN LOẠI DỮ LIỆU:";
            this.label4.Click += new System.EventHandler(this.label73_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(687, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 26);
            this.label1.TabIndex = 266;
            this.label1.Text = "HIỂN THỊ VÀ KẾT XUẤT DỮ LIỆU BÁO CÁO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose_exportPage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1921, 61);
            this.panel1.TabIndex = 412;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnClose_exportPage
            // 
            this.btnClose_exportPage.FlatAppearance.BorderSize = 0;
            this.btnClose_exportPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose_exportPage.Image = ((System.Drawing.Image)(resources.GetObject("btnClose_exportPage.Image")));
            this.btnClose_exportPage.Location = new System.Drawing.Point(1862, 3);
            this.btnClose_exportPage.Name = "btnClose_exportPage";
            this.btnClose_exportPage.Size = new System.Drawing.Size(54, 57);
            this.btnClose_exportPage.TabIndex = 413;
            this.btnClose_exportPage.UseVisualStyleBackColor = true;
            this.btnClose_exportPage.Click += new System.EventHandler(this.btnClose_exportPage_Click_1);
            this.btnClose_exportPage.MouseLeave += new System.EventHandler(this.btnClose_exportPage_MouseLeave_1);
            this.btnClose_exportPage.MouseHover += new System.EventHandler(this.btnClose_exportPage_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.COD,
            this.TSS,
            this.PH,
            this.COLOR,
            this.TEMPERATURE,
            this.AMONI,
            this.FLOW,
            this.FLOWOUT});
            this.dataGridView1.Location = new System.Drawing.Point(65, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1829, 729);
            this.dataGridView1.TabIndex = 413;
            // 
            // btnExport_exportPage
            // 
            this.btnExport_exportPage.BackColor = System.Drawing.Color.Lime;
            this.btnExport_exportPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport_exportPage.Location = new System.Drawing.Point(548, 178);
            this.btnExport_exportPage.Name = "btnExport_exportPage";
            this.btnExport_exportPage.Size = new System.Drawing.Size(131, 50);
            this.btnExport_exportPage.TabIndex = 411;
            this.btnExport_exportPage.Text = "XUẤT DỮ LIỆU";
            this.btnExport_exportPage.UseVisualStyleBackColor = false;
            this.btnExport_exportPage.Click += new System.EventHandler(this.btnExport_exportPage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MP2_V01.Properties.Resources.excel1;
            this.pictureBox1.Location = new System.Drawing.Point(484, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 414;
            this.pictureBox1.TabStop = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "MÃ NHẬN DẠNG";
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "NGÀY";
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // COD
            // 
            this.COD.HeaderText = "COD";
            this.COD.Name = "COD";
            // 
            // TSS
            // 
            this.TSS.HeaderText = "TSS";
            this.TSS.Name = "TSS";
            // 
            // PH
            // 
            this.PH.HeaderText = "PH";
            this.PH.Name = "PH";
            // 
            // COLOR
            // 
            this.COLOR.HeaderText = "MÀU SẮC";
            this.COLOR.Name = "COLOR";
            // 
            // TEMPERATURE
            // 
            this.TEMPERATURE.HeaderText = "NHIỆT ĐỘ";
            this.TEMPERATURE.Name = "TEMPERATURE";
            // 
            // AMONI
            // 
            this.AMONI.HeaderText = "AMONI";
            this.AMONI.Name = "AMONI";
            // 
            // FLOW
            // 
            this.FLOW.HeaderText = "LƯU LƯỢNG VÀO";
            this.FLOW.Name = "FLOW";
            this.FLOW.Width = 150;
            // 
            // FLOWOUT
            // 
            this.FLOWOUT.HeaderText = "LƯU LƯỢNG RA";
            this.FLOWOUT.Name = "FLOWOUT";
            this.FLOWOUT.Width = 150;
            // 
            // DATA_EXPORT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExport_exportPage);
            this.Controls.Add(this.cbx_chooseType);
            this.Controls.Add(this.dtPicker_to);
            this.Controls.Add(this.dtPicker_from);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label73);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DATA_EXPORT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DATA_EXPORT";
            this.Load += new System.EventHandler(this.DATA_EXPORT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.DateTimePicker dtPicker_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPicker_from;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_chooseType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExport_exportPage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose_exportPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PH;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMPERATURE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMONI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLOW;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLOWOUT;
    }
}