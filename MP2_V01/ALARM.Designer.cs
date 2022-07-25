
namespace MP2_V01
{
    partial class ALARM
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
            this.ctMenu_alarmTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInfo_framePage = new System.Windows.Forms.Button();
            this.idColunm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.erIdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serverityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alarmTextColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ackColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alarmTable_alm_alarmPage = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ctMenu_alarmTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctMenu_alarmTable
            // 
            this.ctMenu_alarmTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.ctMenu_alarmTable.Name = "ctMenu_alarmTable";
            this.ctMenu_alarmTable.Size = new System.Drawing.Size(108, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.clearToolStripMenuItem.Text = "Delete";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(800, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 414;
            this.label3.Text = "ALARM TABLE";
            // 
            // btnInfo_framePage
            // 
            this.btnInfo_framePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(91)))));
            this.btnInfo_framePage.Enabled = false;
            this.btnInfo_framePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo_framePage.ForeColor = System.Drawing.Color.White;
            this.btnInfo_framePage.Location = new System.Drawing.Point(22, 867);
            this.btnInfo_framePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInfo_framePage.Name = "btnInfo_framePage";
            this.btnInfo_framePage.Size = new System.Drawing.Size(179, 45);
            this.btnInfo_framePage.TabIndex = 416;
            this.btnInfo_framePage.Text = "APPLY";
            this.btnInfo_framePage.UseVisualStyleBackColor = false;
            this.btnInfo_framePage.Visible = false;
            // 
            // idColunm
            // 
            this.idColunm.Text = "ID";
            this.idColunm.Width = 309;
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "DATE";
            this.dateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateColumn.Width = 120;
            // 
            // timeColum
            // 
            this.timeColum.Text = "TIME";
            this.timeColum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeColum.Width = 128;
            // 
            // durationColumn
            // 
            this.durationColumn.Text = "DURATION";
            this.durationColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.durationColumn.Width = 132;
            // 
            // erIdColumn
            // 
            this.erIdColumn.Text = "ERROR ID";
            this.erIdColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.erIdColumn.Width = 113;
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "STATUS";
            this.statusColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusColumn.Width = 222;
            // 
            // serverityColumn
            // 
            this.serverityColumn.Text = "SEVERITY";
            this.serverityColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.serverityColumn.Width = 144;
            // 
            // alarmTextColumn
            // 
            this.alarmTextColumn.Text = "DESCRIPTION";
            this.alarmTextColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alarmTextColumn.Width = 385;
            // 
            // ackColumn
            // 
            this.ackColumn.Text = "Acknowledgment";
            this.ackColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ackColumn.Width = 146;
            // 
            // alarmTable_alm_alarmPage
            // 
            this.alarmTable_alm_alarmPage.AutoArrange = false;
            this.alarmTable_alm_alarmPage.BackColor = System.Drawing.Color.White;
            this.alarmTable_alm_alarmPage.CheckBoxes = true;
            this.alarmTable_alm_alarmPage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColunm,
            this.dateColumn,
            this.timeColum,
            this.durationColumn,
            this.erIdColumn,
            this.statusColumn,
            this.serverityColumn,
            this.alarmTextColumn,
            this.ackColumn});
            this.alarmTable_alm_alarmPage.ContextMenuStrip = this.ctMenu_alarmTable;
            this.alarmTable_alm_alarmPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmTable_alm_alarmPage.FullRowSelect = true;
            this.alarmTable_alm_alarmPage.GridLines = true;
            this.alarmTable_alm_alarmPage.HideSelection = false;
            this.alarmTable_alm_alarmPage.Location = new System.Drawing.Point(22, 57);
            this.alarmTable_alm_alarmPage.Name = "alarmTable_alm_alarmPage";
            this.alarmTable_alm_alarmPage.Size = new System.Drawing.Size(1843, 747);
            this.alarmTable_alm_alarmPage.TabIndex = 413;
            this.alarmTable_alm_alarmPage.UseCompatibleStateImageBehavior = false;
            this.alarmTable_alm_alarmPage.View = System.Windows.Forms.View.Details;
            this.alarmTable_alm_alarmPage.SelectedIndexChanged += new System.EventHandler(this.gv_01p1_trendPage_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ON ACTIVE"});
            this.comboBox1.Location = new System.Drawing.Point(22, 829);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 415;
            this.comboBox1.Visible = false;
            // 
            // ALARM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(42)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnInfo_framePage);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alarmTable_alm_alarmPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ALARM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALARM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ALARM_Load);
            this.Resize += new System.EventHandler(this.ALARM_Resize);
            this.ctMenu_alarmTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip ctMenu_alarmTable;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button btnInfo_framePage;
        private System.Windows.Forms.ColumnHeader idColunm;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader timeColum;
        private System.Windows.Forms.ColumnHeader durationColumn;
        private System.Windows.Forms.ColumnHeader erIdColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.ColumnHeader serverityColumn;
        private System.Windows.Forms.ColumnHeader alarmTextColumn;
        private System.Windows.Forms.ColumnHeader ackColumn;
        private System.Windows.Forms.ListView alarmTable_alm_alarmPage;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}