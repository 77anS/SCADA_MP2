using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BSCADA_Entity = SCADA_MP2.Entity.Motor;
using BSCADA_Base = B_SCADA_Library_dotNetFramework.BaseClass.Faceplate.Motor;
using B_SCADA_Library_dotNetFramework.BaseClass.Driver.PLC.SIMATIC_S7;
namespace SCADA_MP2.Presentation
{
    public partial class Faceplate_Motor
    {
        #region FIELDS
        public BSCADA_Entity.Motor Motor = new BSCADA_Entity.Motor(); // CLASS FOR SAVE DATA OF FACEPLATE TO SEND THROUGH DO WORK METHOD
        public BSCADA_Entity.Motor UserState = new BSCADA_Entity.Motor(); // CLASS FOR COMPARE
        public BSCADA_Base.Faceplate_Motor faceplate_Motor = new BSCADA_Base.Faceplate_Motor();
        public Request requestPLC = new Request();
        #endregion

        #region CONSTRUCTOR
        public Faceplate_Motor() : base()
        {

        }
        public Faceplate_Motor(int period) : base()
        {
            this.period = period; // SET PERIOD OF DO WORK
        }

        public Faceplate_Motor(string entityName) : base(entityName)
        {
            
        }
        #endregion

        #region METHOD (OVERIDING)
        public override void Motor_Load(object sender, EventArgs e)
        {
            RunBackWorker(); // Run BackWorker

        }

        #region BACKWORKER 1: UPDATE UI
        public override void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            base.backWorker_DoWork(sender, e);
        }
        public override void doWork()
        {
            switch(this.entityName)
            {
                case "motor_mtk01":
                    Motor = Program.HomePageData.mtk01;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;

                case "motor_mtk02":
                    Motor = Program.HomePageData.mtk02;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mtk03":
                    Motor = Program.HomePageData.mtk03;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
            }
        }
        public override void backWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // base.backWorker_ProgressChanged(sender, e);
            
            switch((UserState = e.UserState as Entity.Motor.Motor).Name)
            {
                case "mtk01":
                    this.lb_MotorName.Text = "MÁY THỐI KHÍ - MTK01";
                    this.lb_Mode.Text = UserState.ControlMode.ToString();
                    this.faceplate_Motor.showMode(Program.HomePageData.mtk01.Mode_Auto, Program.HomePageData.mtk01.Mode_Man, Program.HomePageData.mtk01.Mode_Off, this.lb_Mode);
                    this.faceplate_Motor.showMode(Program.HomePageData.mtk01.Mode_Auto, Program.HomePageData.mtk01.Mode_Man, Program.HomePageData.mtk01.Mode_Off, this.btnModeAuto, this.btnModeMan, this.btnModeOff);
                    this.faceplate_Motor.showStatus(Program.HomePageData.mtk01.RunStatus, Program.HomePageData.mtk01.TripStatus, this.lb_Status);
                    this.faceplate_Motor.showStatus(Program.HomePageData.mtk01.RunStatus, Program.HomePageData.mtk01.TripStatus, this.btnOn, this.btnOff);
                    this.faceplate_Motor.showAlarmStatus(Program.HomePageData.mtk01.RunStatus, Program.HomePageData.mtk01.TripStatus, this.lb_Alarm);
                    this.tbRuntimeTotal.Text = Program.HomePageData.mtk01.RuntimeTotal.ToString();
                    this.tbRuntimeSetting_value.Text = Program.HomePageData.mtk01.RuntimeDutyOn.ToString();
                    this.tbStoptimeSetting_value.Text = Program.HomePageData.mtk01.RuntimeDutyOff.ToString();
                    break;
                case "mtk02":
                    this.lb_MotorName.Text = "MÁY THỐI KHÍ - MTK02";
                    break;
                case "mtk03":
                    this.lb_MotorName.Text = "MÁY THỐI KHÍ - MTK03";
                    break;
            }
        }
        #endregion

        #region BACKWORKER 2: CMD
        public override void RunBackWorker_CMD(string entityName, byte plcNumber)
        {
            base.RunBackWorker_CMD(entityName, plcNumber);
        }
        public override void StopBackWorker_CMD()
        {
            base.StopBackWorker_CMD();
        }
        public override void backWorker_CMD_DoWork(object sender, DoWorkEventArgs e)
        {
            base.backWorker_CMD_DoWork(sender, e);
        }

        public override void backWorker_CMD_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            base.backWorker_CMD_ProgressChanged(sender, e);
        }
        public override void backWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            base.backWorker_RunWorkerCompleted(sender, e);
        }
        public override void doWork_CMD()
        {
            // base.doWork_CMD();
            switch(this.entityName)
            {
                case "motor_mtk01":
                    switch(this.writeIndexOfFacePlate)
                    {
                        case 1: // SET [AUTO] MODE
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 2: // SET [MAN] MODE
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 3: // SET [OFF] MODE
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 4: // SET [START] CMD
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 5: // SET [STOP] CMD
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 6: // SET [RUNTIME SETTING] SET
                            requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 16,5, Convert.ToInt16(this.tbRuntimeSetting_setVallue.Text));
                            break;
                        case 7: // SET [STOPTIME SETTING] SET
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 8: // SET [RESET RUNTIME TOTAL] CMD
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                    }
                    break;
            }

        }
        #endregion

        public override void btnClose_Click(object sender, EventArgs e)
        {
            base.btnClose_Click(sender, e);
        }

        public override void btnModeAuto_Click(object sender, EventArgs e)
        {
            //base.btnModeAuto_Click(sender, e);
            switch (this.entityName)
            {
                case "motor_mtk01":
                    RunBackWorker_CMD(this.entityName, 1);
                    break;
            }
        }
        #endregion
    }
}
