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

using ElementBase_Template.Ultility;
using MongoDB.Bson;
using MongoDB.Driver;

using ClosedXML.Excel;
using System.IO;
using System.Threading;

using ElementBase_Template;

namespace MP2_V01
{
    public partial class DATA_EXPORT : Form
    {
        public Form _parent { get; set; }

        public Timestamp.ultility getTime = new Timestamp.ultility();

        public Int32 TimeFrom { get; set; }
        public Int32 TimeTo { get; set; }

        public Int32 T2T1 { get; set; }

        public bool AllCheckResult { get; set; }
        public DATA_EXPORT()
        {
            InitializeComponent();
        }

        public DATA_EXPORT(Form _parent)
        {
            InitializeComponent();
            this._parent = _parent;

        }

        private void btnClose_exportPage_Click(object sender, EventArgs e)
        {
            this.TopMost = false;

            this._parent.TopMost = true;
            this._parent.Enabled = true;

            this.Close();
        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void DATA_EXPORT_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;

            //this.dtPicker_from.CustomFormat = "hh:mm tt";
            //this.dtPicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //this.dtPicker_from.ShowUpDown = true;

            this.dtPicker_from.CustomFormat = "dd:MM:yyyy hh:mm tt";
            this.dtPicker_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
           // this.dtPicker_from.ShowUpDown = true;

            this.dtPicker_to.CustomFormat = "dd:MM:yyyy hh:mm tt";
            this.dtPicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //this.dtPicker_to.ShowUpDown = true;


        }

        private void btnClose_exportPage_MouseHover(object sender, EventArgs e)
        {
            btnClose_exportPage.BackColor = Color.FromArgb(255, 240, 0, 0);
        }

        private void btnClose_exportPage_MouseLeave(object sender, EventArgs e)
        {
            btnClose_exportPage.BackColor = Color.FromArgb(150,153, 180, 209);
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

        private void btnExport_exportPage_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtPicker_from, ""); //Để xóa khi nhập lại
            errorProvider2.SetError(dtPicker_to, "");
            errorProvider3.SetError(cbx_chooseType, "");

            DateTime dateFrom = dtPicker_from.Value;
            DateTime dateTo = dtPicker_to.Value;

            TimeFrom = getTime.getTime_LocalToUTC_second(dateFrom); //=> GMT +7 Local TS
            TimeTo = getTime.getTime_LocalToUTC_second(dateTo);//=> GMT +7 Local TS

            var DateUTCFrom = new DateTime(dateFrom.Year,dateFrom.Month,dateFrom.Day,dateFrom.Hour,dateFrom.Minute,dateFrom.Second,dateFrom.Millisecond,DateTimeKind.Local);
            var DateUTCTo = new DateTime(dateTo.Year, dateTo.Month, dateTo.Day, dateTo.Hour, dateTo.Minute, dateTo.Second, dateTo.Millisecond, DateTimeKind.Local);

            BsonDateTime a = (BsonDateTime)DateUTCFrom;
            BsonDateTime b = (BsonDateTime)DateUTCTo;

            T2T1 = TimeTo - TimeFrom;


            if (T2T1 <= 0)
            {
                errorProvider1.SetError(dtPicker_from, "Thời gian bắt đầu phải được chọn trước thời gian kết thúc!");
                errorProvider2.SetError(dtPicker_to, "Thời gian bắt đầu phải được chọn trước thời gian kết thúc!");
                AllCheckResult = true;
            }    

            if(cbx_chooseType.SelectedIndex < 0)
            {
                errorProvider3.SetError(cbx_chooseType, "Chưa chọn loại dữ liệu!");
                AllCheckResult = true;
            }

            if(AllCheckResult)
            {
                return;
            }    
            else
            {
                if (cbx_chooseType.SelectedIndex == 0)
                {
                    Program.mongoDB_MP2.findDB(Program.mongoDB_MP2.dbClient, "MP2_2");
                    Program.mongoDB_MP2.getCollection(Program.mongoDB_MP2.dbClient, Program.mongoDB_MP2.database, "Alarm_Historian_Data");
                    //var documents = Program.mongoDB_MP2.findKey_Gt_Lt("timestamp", DateUTCFrom, DateUTCTo, Program.mongoDB_MP2.collection);
                    var documents = Program.mongoDB_MP2.findKey_Gt_Lt("timestamp", DateUTCFrom, DateUTCTo, Program.mongoDB_MP2.collection);
                    if (documents.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu!");
                    }
                    else
                    {
                        Thread t = new Thread((ThreadStart)(() =>
                        {
                            saveFileDialog1.Filter = "Microsoft Excel (*.xlsx) |*.xlsx";
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                string path = Path.GetFullPath(saveFileDialog1.FileName);
                                using (var workbook = new XLWorkbook())
                                {
                                    var worksheet = workbook.Worksheets.Add("Cảnh báo TRIP");
                                    worksheet.Cell(1, 1).Value = "DATE TIME";
                                    worksheet.Cell(1, 2).Value = "ENTITY NAME";
                                    worksheet.Cell(1, 3).Value = "ACTIVE STATUS";
                                    worksheet.Cell(1, 4).Value = "ALARM SEVERITY";
                                    worksheet.Cell(1, 5).Value = "ACKNOWLEDGEMENT";
                                    worksheet.Cell(1, 6).Value = "ERROR ID";
                                    worksheet.Cell(1, 7).Value = "STATUS";
                                    worksheet.Cell(1, 8).Value = "DESCRIPTION";
                                    int j = 2;
                                    foreach (BsonDocument doc in documents)
                                    {
                                        for (int i = 1; i < 12; i++)
                                        {
                                            if (i == 1)
                                                worksheet.Cell(j, i).Value = doc["timestamp"];
                                            if (i == 2)
                                                worksheet.Cell(j, i).Value = doc["entityName"];
                                            if (i == 3)
                                                worksheet.Cell(j, i).Value = doc["activeStatus"];
                                            if (i == 4)
                                                worksheet.Cell(j, i).Value = doc["alarmSeverity"];
                                            if (i == 5)
                                                worksheet.Cell(j, i).Value = doc["acknowledgment"];
                                            if (i == 6)
                                                worksheet.Cell(j, i).Value = doc["error_id"];
                                            if (i == 7)
                                                worksheet.Cell(j, i).Value = doc["status"];
                                            if (i == 8)
                                                worksheet.Cell(j, i).Value = doc["description"];
                                        }
                                        j++;
                                    }

                                    for (int ij = 1; ij < 9; ij++)
                                    {
                                        worksheet.Column(ij).AdjustToContents();
                                    }

                                    workbook.SaveAs(path);
                                }

                                FileInfo fi = new FileInfo(path);
                                if (fi.Exists)
                                {
                                    System.Diagnostics.Process.Start(path);
                                }
                                else
                                {
                                    //file doesn't exist
                                }


                                //MessageBox.Show("Lưu file thành công");
                            }
                            else
                            {
                                //MessageBox.Show("Thoát lưu tệp Excel!");
                            }
                        }));
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                        t.Join();
                    }    

                    
                }
                else if (cbx_chooseType.SelectedIndex == 1)
                {
                    Program.mongoDB_MP2.findDB(Program.mongoDB_MP2.dbClient, "MP2_2");
                    Program.mongoDB_MP2.getCollection(Program.mongoDB_MP2.dbClient, Program.mongoDB_MP2.database, "Environment_Index_Historian_Data");

                    var documents = Program.mongoDB_MP2.findKey_Gt_Lt("timestamp", DateUTCFrom, DateUTCTo, Program.mongoDB_MP2.collection);

                    if(documents.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu!");
                    }   
                    else
                    {
                        Thread t = new Thread((ThreadStart)(() =>
                        {
                            saveFileDialog1.Filter = "Microsoft Excel (*.xlsx) |*.xlsx ";
                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                string path = Path.GetFullPath(saveFileDialog1.FileName);
                                using (var workbook = new XLWorkbook())
                                {
                                    var worksheet = workbook.Worksheets.Add("Quan trắc môi trường");
                                    worksheet.Cell(1, 1).Value = "DATE TIME";
                                    worksheet.Cell(1, 2).Value = "COD";
                                    worksheet.Cell(1, 3).Value = "TSS";
                                    worksheet.Cell(1, 4).Value = "PH";
                                    worksheet.Cell(1, 5).Value = "COLOR";
                                    worksheet.Cell(1, 6).Value = "TEMPERATURE";
                                    worksheet.Cell(1, 7).Value = "NH3";
                                    worksheet.Cell(1, 8).Value = "FLOW IN TOTAL";
                                    worksheet.Cell(1, 9).Value = "FLOW IN CAP";
                                    worksheet.Cell(1, 10).Value = "FLOW OUT TOTAL";
                                    worksheet.Cell(1, 11).Value = "FLOW OUT CAP";
                                    int j = 2;
                                    foreach (BsonDocument doc in documents)
                                    {
                                        for (int i = 1; i < 12; i++)
                                        {
                                            if (i == 1)
                                                worksheet.Cell(j, i).Value = doc["timestamp"];
                                            if (i == 2)
                                                worksheet.Cell(j, i).Value = doc["cod_Index"];
                                            if (i == 3)
                                                worksheet.Cell(j, i).Value = doc["tss_Index"];
                                            if (i == 4)
                                                worksheet.Cell(j, i).Value = doc["ph_Index"];
                                            if (i == 5)
                                                worksheet.Cell(j, i).Value = doc["color_Index"];
                                            if (i == 6)
                                                worksheet.Cell(j, i).Value = doc["temper_Index"];
                                            if (i == 7)
                                                worksheet.Cell(j, i).Value = doc["nh3_Index"];
                                            if (i == 8)
                                                worksheet.Cell(j, i).Value = doc["flowInTotal"];
                                            if (i == 9)
                                                worksheet.Cell(j, i).Value = doc["flowInCap"];
                                            if (i == 10)
                                                worksheet.Cell(j, i).Value = doc["flowOutTotal"];
                                            if (i == 11)
                                                worksheet.Cell(j, i).Value = doc["flowOutCap"];

                                        }
                                        j++;
                                    }

                                    for (int ij = 1; ij < 12; ij++)
                                    {
                                        worksheet.Column(ij).AdjustToContents();
                                    }

                                    workbook.SaveAs(path);
                                }

                                FileInfo fi = new FileInfo(path);
                                if (fi.Exists)
                                {
                                    System.Diagnostics.Process.Start(path);
                                }
                                else
                                {
                                    //file doesn't exist
                                }


                                //MessageBox.Show("Lưu file thành công");
                            }
                            else
                            {
                                // MessageBox.Show("Thoát lưu tệp Excel!");
                            }
                        }));
                        t.SetApartmentState(ApartmentState.STA);
                        t.Start();
                        t.Join();
                    }    

                }
            }    
        }

        private void btnClose_exportPage_Click_1(object sender, EventArgs e)
        {
            this.TopMost = false;

            this._parent.TopMost = true;
            this._parent.Enabled = true;

            this.Close();
        }

        private void btnClose_exportPage_MouseLeave_1(object sender, EventArgs e)
        {
            btnClose_exportPage.BackColor = Color.FromArgb(255, 192, 192, 192);
        }
    }
}
