using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClosedXML.Excel;
using System.IO;

namespace ElementBase_Template.Ultility
{
    public class Excel
    {
        public Excel()
        {

        }

        public Excel(string name)
        {
        }

        public class WorkBook
        {
            public XLWorkbook workbook { get; set; }

            public WorkBook()
            {
                this.workbook = new XLWorkbook();
            }
            
            public void Create()
            {
                this.workbook = new XLWorkbook();
            }

            public void AddSheet(string SheetName)
            {
                this.workbook.AddWorksheet(SheetName);
            }

            public void AddShell(string ShellName, string SheetName, object value)
            {
                this.workbook.Worksheet(SheetName).Cell(ShellName).Value = value.ToString();
            }

            public void SaveAs(string FileName)
            {
                this.workbook.SaveAs(FileName);
            }
        }


        public static void open_Excel(string path)
        {
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
            {
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                //file doesn't exist
            }
        }

    }
}
