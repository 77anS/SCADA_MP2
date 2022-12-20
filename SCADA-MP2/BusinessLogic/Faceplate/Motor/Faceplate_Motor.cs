using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BSCADA_Entity = SCADA_MP2.Entity.Motor;
using BSCADA_Base = B_SCADA_Library_dotNetFramework.BaseClass.Faceplate.Motor;
using B_SCADA_Library_dotNetFramework.BaseClass.Driver.PLC.SIMATIC_S7;
using System.Windows.Forms;
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
            btnModeAuto.Enabled = false;
            btnModeMan.Enabled = false;
            btnModeOff.Enabled = false;
            btnOn.Enabled = false;
            btnOff.Enabled = false;
            btnStoptimeSetting_setCmd.Enabled = false;
        }

        #region BACKWORKER 1: UPDATE UI
        public override void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            base.backWorker_DoWork(sender, e);
        }
        public override void doWork()
        {

            switch (this.entityName)
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
                case "motor_mtetn":
                    Motor = Program.HomePageData.mtetn;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dpetn":
                    Motor = Program.HomePageData.dpetn;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp03":
                    Motor = Program.HomePageData.dp03;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mt03":
                    Motor = Program.HomePageData.mt03;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mkt01":
                    Motor = Program.HomePageData.mkt1;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mkt02":
                    Motor = Program.HomePageData.mkt2;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mkt03":
                    Motor = Program.HomePageData.mkt2;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mt05":
                    Motor = Program.HomePageData.mkt3;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp05":
                    Motor = Program.HomePageData.dp05;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp06_01p2":
                    Motor = Program.HomePageData.dp06_1;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mt06_01p2":
                    Motor = Program.HomePageData.mt06_1;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_bb1":
                    Motor = Program.HomePageData.bb1;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_bb2":
                    Motor = Program.HomePageData.bb2;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_gb1":
                    Motor = Program.HomePageData.gb1;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_th1":
                    Motor = Program.HomePageData.th1;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_th2":
                    Motor = Program.HomePageData.th2;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_th3":
                    Motor = Program.HomePageData.th3;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sm01":
                    Motor = Program.HomePageData.sm01;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sm02":
                    Motor = Program.HomePageData.sm02;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sm03":
                    Motor = Program.HomePageData.sm03;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sm04":
                    Motor = Program.HomePageData.sm04;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sm05":
                    Motor = Program.HomePageData.sm05;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sm06":
                    Motor = Program.HomePageData.sm06;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sm07":
                    Motor = Program.HomePageData.sm07;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sm08":
                    Motor = Program.HomePageData.sm08;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_p0201":
                    Motor = Program.HomePageData.p0201;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_p0202":
                    Motor = Program.HomePageData.p0202;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_wp02a":
                    Motor = Program.HomePageData.wp02a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_wp02b":
                    Motor = Program.HomePageData.wp02b;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_p0101":
                    Motor = Program.HomePageData.p0101;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_p0102":
                    Motor = Program.HomePageData.p0102;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_p0103":
                    Motor = Program.HomePageData.p0103;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break; 
                case "mayTachRac_bs02a":
                    Motor = Program.HomePageData.bs02a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mc04":
                    Motor = Program.HomePageData.mc04;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mc03":
                    Motor = Program.HomePageData.mc03;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp04a":
                    Motor = Program.HomePageData.dp04a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp04b":
                    Motor = Program.HomePageData.dp04b;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp03a":
                    Motor = Program.HomePageData.dp03a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp03b":
                    Motor = Program.HomePageData.dp03b;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp05a":
                    Motor = Program.HomePageData.dp05a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp05b":
                    Motor = Program.HomePageData.dp05b;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp06a":
                    Motor = Program.HomePageData.dp06a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp06b":
                    Motor = Program.HomePageData.dp06b;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mi03":
                    Motor = Program.HomePageData.mi03;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mi04a":
                    Motor = Program.HomePageData.mi04a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mi04b":
                    Motor = Program.HomePageData.mi04b;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_ms05":
                    Motor = Program.HomePageData.ms05;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_ab06a":
                    Motor = Program.HomePageData.ab06a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_ab06b":
                    Motor = Program.HomePageData.ab06b;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_ab06c":
                    Motor = Program.HomePageData.ab06c;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_ms07":
                    Motor = Program.HomePageData.ms07;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mt02":
                    Motor = Program.HomePageData.mt02;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp02":
                    Motor = Program.HomePageData.dp02;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mt04":
                    Motor = Program.HomePageData.mt04;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp04":
                    Motor = Program.HomePageData.dp04;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mt02b":
                    Motor = Program.HomePageData.mt02b;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mt02a":
                    Motor = Program.HomePageData.mt02a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mt01":
                    Motor = Program.HomePageData.mt01;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_ggb":
                    Motor = Program.HomePageData.ggb;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sp11":
                    Motor = Program.HomePageData.sp11;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp07a":
                    Motor = Program.HomePageData.dp07a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp07b":
                    Motor = Program.HomePageData.dp07b;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sp07b":
                    Motor = Program.HomePageData.sp07b;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sp07a":
                    Motor = Program.HomePageData.sp07a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sp05a":
                    Motor = Program.HomePageData.sp05a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sp05b":
                    Motor = Program.HomePageData.sp05b;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_ms09":
                    Motor = Program.HomePageData.ms09;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp04a_1p2":
                    Motor = Program.HomePageData.dp04a_1;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp04a_2p2":
                    Motor = Program.HomePageData.dp04a_2;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_sp10":
                    Motor = Program.HomePageData.sp10;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mc09":
                    Motor = Program.HomePageData.mc09;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp09a":
                    Motor = Program.HomePageData.dp09a;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp09b":
                    Motor = Program.HomePageData.dp09b;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp01":
                    Motor = Program.HomePageData.dp01;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_dp06_2p2":
                    Motor = Program.HomePageData.dp06_2;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                case "motor_mt06_2p2":
                    Motor = Program.HomePageData.mt06_2;
                    backWorker_FaceplateMotor.ReportProgress(0, Motor);
                    break;
                default:
                    break;
            }
            System.Threading.Thread.Sleep(100);
        }
        public override void backWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // base.backWorker_ProgressChanged(sender, e);
            UserState = e.UserState as Entity.Motor.Motor;
            if(UserState != null)
            {
                this.lb_Mode.Text = UserState.ControlMode.ToString();
                this.faceplate_Motor.showMode(UserState.Mode_Auto, UserState.Mode_Man, UserState.Mode_Off, this.lb_Mode);
                this.faceplate_Motor.showMode(UserState.Mode_Auto, UserState.Mode_Man, UserState.Mode_Off, this.btnModeAuto, this.btnModeMan, this.btnModeOff);
                this.faceplate_Motor.showStatus(UserState.RunStatus, UserState.TripStatus, this.lb_Status);
                this.faceplate_Motor.showStatus(UserState.RunStatus, UserState.TripStatus, this.btnOn, this.btnOff);
                this.faceplate_Motor.showAlarmStatus(UserState.RunStatus, UserState.TripStatus, this.lb_Alarm);
                this.tbRuntimeTotal.Text = UserState.RuntimeTotal.ToString();
                this.tbRuntimeSetting_value.Text = UserState.RuntimeDutyOn.ToString();
                this.tbStoptimeSetting_value.Text = UserState.RuntimeDutyOff.ToString();
            }
            System.Threading.Thread.Sleep(100);
        }
        #endregion

        #region BACKWORKER 2: CMD
        public override void RunBackWorker_CMD(string entityName, byte plcNumber, byte writeIndexOfFaceplate)
        {
            base.RunBackWorker_CMD(entityName, plcNumber, writeIndexOfFaceplate);
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
                case "motor_p0101":
                    switch (this.writeIndexOfFacePlate)
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
                            requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 16, 0, Convert.ToInt16(this.tbRuntimeSetting_setVallue.Text));
                            MessageBox.Show("SET SUCCESS! Runtime Setting 'P101'");
                            break;
                        case 7: // SET [STOPTIME SETTING] SET
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 8: // SET [RESET RUNTIME TOTAL] CMD
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                    }
                    break;
                case "motor_p0102":
                    switch (this.writeIndexOfFacePlate)
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
                            requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 16, 2, Convert.ToInt16(this.tbRuntimeSetting_setVallue.Text));
                            MessageBox.Show("SET SUCCESS! Runtime Setting 'P102'");
                            break;
                        case 7: // SET [STOPTIME SETTING] SET
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 8: // SET [RESET RUNTIME TOTAL] CMD
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                    }
                    break;
                case "motor_p0103":
                    switch (this.writeIndexOfFacePlate)
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
                            requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 16, 4, Convert.ToInt16(this.tbRuntimeSetting_setVallue.Text));
                            MessageBox.Show("SET SUCCESS! Runtime Setting 'P103'");
                            break;
                        case 7: // SET [STOPTIME SETTING] SET
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 8: // SET [RESET RUNTIME TOTAL] CMD
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                    }
                    break;
                case "motor_p0201":
                    switch (this.writeIndexOfFacePlate)
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
                            requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 16, 6, Convert.ToInt16(this.tbRuntimeSetting_setVallue.Text));
                            MessageBox.Show("SET SUCCESS! Runtime Setting 'P0201'");
                            break;
                        case 7: // SET [STOPTIME SETTING] SET
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 8: // SET [RESET RUNTIME TOTAL] CMD
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                    }
                    break;
                case "motor_p0202":
                    switch (this.writeIndexOfFacePlate)
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
                            requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 16, 8, Convert.ToInt16(this.tbRuntimeSetting_setVallue.Text));
                            MessageBox.Show("SET SUCCESS! Runtime Setting 'P202'");
                            break;
                        case 7: // SET [STOPTIME SETTING] SET
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 8: // SET [RESET RUNTIME TOTAL] CMD
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                    }
                    break;
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
                            requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 16,10, Convert.ToInt16(this.tbRuntimeSetting_setVallue.Text));
                            MessageBox.Show("SET SUCCESS! Runtime Setting 'MTK01'");
                            break;
                        case 7: // SET [STOPTIME SETTING] SET
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 8: // SET [RESET RUNTIME TOTAL] CMD
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                    }
                    break;
                case "motor_mtk02":
                    switch (this.writeIndexOfFacePlate)
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
                            requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 16, 12, Convert.ToInt16(this.tbRuntimeSetting_setVallue.Text));
                            MessageBox.Show("SET SUCCESS! Runtime Setting 'MTK02'");
                            break;
                        case 7: // SET [STOPTIME SETTING] SET
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 8: // SET [RESET RUNTIME TOTAL] CMD
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                    }
                    break;
                case "motor_mtk03":
                    switch (this.writeIndexOfFacePlate)
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
                            requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 16, 14, Convert.ToInt16(this.tbRuntimeSetting_setVallue.Text));
                            MessageBox.Show("SET SUCCESS! Runtime Setting 'MTK03'");
                            break;
                        case 7: // SET [STOPTIME SETTING] SET
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                        case 8: // SET [RESET RUNTIME TOTAL] CMD
                            //requestPLC.writePLC_DataBlock(Program.BSCADA.FindPLC("PLC1").plc, 100,2, true);
                            break;
                    }
                    break;
                default:
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
                    RunBackWorker_CMD(this.entityName,1,1);
                    break;
                case "motor_mtk02":
                    RunBackWorker_CMD(this.entityName, 1, 1);
                    break;
                case "motor_mtk03":
                    RunBackWorker_CMD(this.entityName, 1, 1);
                    break;
            }
        }

        public override void btnModeMan_Click(object sender, EventArgs e)
        {
            base.btnModeMan_Click(sender, e);
        }

        public override void btnModeOff_Click(object sender, EventArgs e)
        {
            base.btnModeOff_Click(sender, e);
        }

        public override void btnOn_Click(object sender, EventArgs e)
        {
            base.btnOn_Click(sender, e);
        }

        public override void btnOff_Click(object sender, EventArgs e)
        {
            base.btnOff_Click(sender, e);
        }

        public override void btnRuntimeSetting_SetCmd_Click(object sender, EventArgs e)
        {
            try
            {
                if(!backWorker_FaceplateMotor_CMD.IsBusy)
                {
                    switch (this.entityName)
                    {
                        case "motor_p0101":
                            RunBackWorker_CMD(this.entityName, 1, 6);
                            break;
                        case "motor_p0102":
                            RunBackWorker_CMD(this.entityName, 1, 6);
                            break;
                        case "motor_p0103":
                            RunBackWorker_CMD(this.entityName, 1, 6);
                            break;
                        case "motor_p0201":
                            RunBackWorker_CMD(this.entityName, 1, 6);
                            break;
                        case "motor_p0202":
                            RunBackWorker_CMD(this.entityName, 1, 6);
                            break;
                        case "motor_mtk01":
                            RunBackWorker_CMD(this.entityName, 1, 6);
                            break;
                        case "motor_mtk02":
                            RunBackWorker_CMD(this.entityName, 1, 6);
                            break;
                        case "motor_mtk03":
                            RunBackWorker_CMD(this.entityName, 1, 6);
                            break;
                        default:
                            break;

                    }
                }    
                else
                {
                    MessageBox.Show("Lệnh đã và đang thực hiện [Không thực hiện lần 2]!");
                }    

            }
            catch(Exception ex)
            {
                var a = MessageBox.Show(ex.Message);
            }
        }
        public override void btnStoptimeSetting_setCmd_Click(object sender, EventArgs e)
        {
            base.btnStoptimeSetting_setCmd_Click(sender, e);
        }

        public override void btnConfirm_Click(object sender, EventArgs e)
        {
            base.btnConfirm_Click(sender, e);
        }
        #endregion
    }
}
