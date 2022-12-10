using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BSCADA_BackWorker = B_SCADA_Library_dotNetFramework.BaseClass.BackWorker.BackWorker;
using SCADA_MP2.Entity.DataMapping; // Lớp chứa data cho UI "Home"
namespace SCADA_MP2.BusinessLogic.HomePage
{
    public class BackWorker_Home : BSCADA_BackWorker
    {
        public Page_Home HomePageData = new Page_Home();
        
        public override void backWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            base.backWorker_RunWorkerCompleted(sender, e);
        }
        public override void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.backWorker.ReportProgress(0, ReadData());
        }

        public override void backWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Page_Home od = e.UserState as Page_Home;
            // CODE CẬP NHẬT UI QUA từ dữ liệu thông số "e"
            Program.BSCADA.FindUI("homePage").Controls.Find("tbFlowInCap", true)[0].Text = od.FlowInCap.ToString();
        }

        public Page_Home ReadData()
        {
            HomePageData.FlowInCap = Program.PLC1_DB44_QuanTracIndex.FlowInCap;
            HomePageData.FlowInTotal = Program.PLC1_DB44_QuanTracIndex.FlowInTotal;
            HomePageData.FlowOutCap = Program.PLC1_DB44_QuanTracIndex.FlowOutCap;
            HomePageData.FlowOutTotal = Program.PLC1_DB44_QuanTracIndex.FlowOutTotal;
            return HomePageData;
        }
    }
}
