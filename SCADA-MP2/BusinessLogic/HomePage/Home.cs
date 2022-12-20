using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using BSCADA_DataMapping = SCADA_MP2.Entity.DataMapping;
using B_SCADA_Library_dotNetFramework.BaseClass.File;
using B_SCADA_Library_dotNetFramework.BaseClass.FactoryControl;
namespace SCADA_MP2.Presentation
{
    public partial class Home
    {

        #region FIELD
        public System.ComponentModel.BackgroundWorker backWorker = new BackgroundWorker();
        public B_SCADA_Library_dotNetFramework.BaseClass.RandomObject.RandomValue fakeData = new B_SCADA_Library_dotNetFramework.BaseClass.RandomObject.RandomValue();
        public FMotorControl FMotorControl = new FMotorControl();
        public FFloatControl FFloatControl = new FFloatControl();
        #endregion

        #region METHOD
        /// <summary>
        /// Phương thức: Chạy BackgroundWorker
        /// </summary>
        public void RunBackWorker()
        {
            this.backWorker.WorkerReportsProgress = true;
            this.backWorker.WorkerSupportsCancellation = true;
            this.backWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(BackWorker_DoWork);
            this.backWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(BackWorker_ProgressChanged);
            this.backWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(BackWorker_RunWorkerCompleted);

            this.backWorker.RunWorkerAsync();
        }
        /// <summary>
        /// Phương thức: Dừng BackgroundWorker
        /// </summary>
        public void StopBackWorker()
        {
            try
            {
                if (!this.backWorker.IsBusy)
                {
                    this.backWorker.CancelAsync();
                }
            }
            catch (Exception ex)
            {
                string msg = $"[{DateTime.Now}] {ex.Message}";
                // Logs sự kiện vào DataBase/ Log files:
                FileText SysHisData = new FileText();

                //Console.WriteLine("ERR: " + err.Message);
                SysHisData.OpenNCreate(SysHisData.DefaultPath, "SystemHistoryData");
                SysHisData.WriteLine(SysHisData.DefaultPath, "SystemHistoryData", msg + "[Stack:" + ex.StackTrace + "]");
            }
        }
        #endregion

        #region OVERIDING METHOD
        /// <summary>: Kích hoạt luồng riêng xử lý tác vụ nặng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void BackWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                // CODE CHẠY TÁC VỤ Ở BACKGROUND TẠI LUỒNG RIÊNG:
                System.Threading.Thread.Sleep(1000);
                Program.HomePageData.FlowInCap = fakeData.random_float(70.5f, 75.55f);
                Program.HomePageData.FlowInTotal = fakeData.random_float(146586.57f, 146789.56f);
                Program.HomePageData.FlowOutCap = fakeData.random_float(14.5f, 15);
                Program.HomePageData.FlowOutTotal = fakeData.random_float(146586.57f, 146789.56f);
                Program.HomePageData.CodIndex = fakeData.random_float(1.55f, 2.55f);
                Program.HomePageData.TssIndex = fakeData.random_float(4.57f, 5.89f);
                Program.HomePageData.PHIndex = fakeData.random_float(6.5f, 7.5f);
                Program.HomePageData.AmoniIndex = fakeData.random_float(14.5f, 15);
                Program.HomePageData.TemperatureIndex = fakeData.random_float(25.25f, 25.89f);
                Program.HomePageData.ColorIndex = fakeData.random_float(5.5267f, 5.7556f);

                //Program.HomePageData.FlowInCap = Program.PLC1_DB44_QuanTracIndex.FlowInCap;
                //Program.HomePageData.FlowInTotal = Program.PLC1_DB44.FlowInTotal;
                //Program.HomePageData.FlowOutCap = Program.PLC1_DB44.FlowOutCap;
                //Program.HomePageData.FlowOutTotal = Program.PLC1_DB44.FlowOutTotal;
                //Program.HomePageData.CodIndex = Program.PLC1_DB44.Cod_Index;
                //Program.HomePageData.TssIndex = Program.PLC1_DB44.Tss_Index;
                //Program.HomePageData.PHIndex = Program.PLC1_DB44.Ph_Index;
                //Program.HomePageData.AmoniIndex = Program.PLC1_DB44.Nh3_Index;
                //Program.HomePageData.TemperatureIndex = Program.PLC1_DB44.Temper_Index;
                //Program.HomePageData.ColorIndex = Program.PLC1_DB44.Color_Index;

                /// RUN:
                Program.HomePageData.mtk01.RunStatus = Program.PLC1_DB43_InputStatus.MTK01_mayTKBeDieuHoa_runStatus;
                Program.HomePageData.mtk02.RunStatus = Program.PLC1_DB43_InputStatus.MTK02_mayTKBeDieuHoa_runStatus;
                Program.HomePageData.mtk03.RunStatus = Program.PLC1_DB43_InputStatus.MTK03_mayTKBeDieuHoa_runStatus;
                Program.HomePageData.mtetn.RunStatus = Program.PLC2_DB63_InputStatus.MTETN_metanol_runStatus;
                Program.HomePageData.dpetn.RunStatus = Program.PLC2_DB63_InputStatus.DPETN_etanol1_runStatus;
                Program.HomePageData.dp03.RunStatus = Program.PLC1_DB43_InputStatus.DP03_DlNp_runStatus;
                Program.HomePageData.mt03.RunStatus = Program.PLC1_DB43_InputStatus.MT03_KhuayNp_runStatus;
                Program.HomePageData.mkt1.RunStatus = Program.PLC2_DB63_InputStatus.MKT1_mayTKAerotank1_runStatus;
                Program.HomePageData.mkt2.RunStatus = Program.PLC2_DB63_InputStatus.MKT2_mayTKAerotank2_runStatus;
                Program.HomePageData.mkt3.RunStatus = Program.PLC2_DB63_InputStatus.MKT3_mayTKAerotank3_runStatus;
                Program.HomePageData.mt05.RunStatus = Program.PLC1_DB43_InputStatus.MT05_KhuayPac_runStatus;
                Program.HomePageData.dp05.RunStatus = Program.PLC1_DB43_InputStatus.DP05_DlPac_runStatus;
                Program.HomePageData.dp06_1.RunStatus = Program.PLC1_DB43_InputStatus.DP06_1P1_DlPolyme1_runStatus;
                Program.HomePageData.mt06_1.RunStatus = Program.PLC1_DB43_InputStatus.MT06_1P1_KhuayPolyme1_runStatus;
                Program.HomePageData.bb1.RunStatus = Program.PLC2_DB63_InputStatus.BB1_bomBun1_runStatus;
                Program.HomePageData.bb2.RunStatus = Program.PLC2_DB63_InputStatus.BB2_bomBun2_runStatus;
                Program.HomePageData.p0101.RunStatus = Program.PLC1_DB43_InputStatus.P101_BeGom1_runStatus;
                Program.HomePageData.p0102.RunStatus = Program.PLC1_DB43_InputStatus.P102_BeGom2_runStatus;
                Program.HomePageData.p0103.RunStatus = Program.PLC1_DB43_InputStatus.P103_BeGom3_runStatus;
                Program.HomePageData.bs02a.RunStatus = Program.PLC3_DB55_InputStatus.BS02A_mayTachRac_runStatus;
                Program.HomePageData.p0201.RunStatus = Program.PLC1_DB43_InputStatus.P0201_bomBeDieuHoa_runStatus;
                Program.HomePageData.p0202.RunStatus = Program.PLC1_DB43_InputStatus.P0202_bomBeDieuHoa_runStatus;
                Program.HomePageData.wp02a.RunStatus = Program.PLC3_DB55_InputStatus.WP02A_bomNt_02A_runStatus;
                Program.HomePageData.wp02b.RunStatus = Program.PLC3_DB55_InputStatus.WP02B_bomNt_02B_runStatus;
                Program.HomePageData.sm01.RunStatus = Program.PLC2_DB63_InputStatus.SM01_anoxic1_runStatus;
                Program.HomePageData.sm02.RunStatus = Program.PLC2_DB63_InputStatus.SM02_anoxic2_runStatus;
                Program.HomePageData.sm03.RunStatus = Program.PLC2_DB63_InputStatus.SM03_anoxic3_runStatus;
                Program.HomePageData.sm04.RunStatus = Program.PLC2_DB63_InputStatus.SM04_anoxic4_runStatus;
                Program.HomePageData.sm05.RunStatus = Program.PLC2_DB63_InputStatus.SM05_anoxic5_runStatus;
                Program.HomePageData.sm06.RunStatus = Program.PLC2_DB63_InputStatus.SM06_anoxic6_runStatus;
                Program.HomePageData.sm07.RunStatus = Program.PLC2_DB63_InputStatus.SM07_anoxic7_runStatus;
                Program.HomePageData.sm08.RunStatus = Program.PLC2_DB63_InputStatus.SM08_anoxic8_runStatus;
                Program.HomePageData.th1.RunStatus = Program.PLC2_DB63_InputStatus.TH1_tuanHoan1_runStatus;
                Program.HomePageData.th2.RunStatus = Program.PLC2_DB63_InputStatus.TH2_tuanHoan2_runStatus;
                Program.HomePageData.th3.RunStatus = Program.PLC2_DB63_InputStatus.TH3_tuanHoan3_runStatus;
                Program.HomePageData.gb1.RunStatus = Program.PLC2_DB63_InputStatus.GB1_gatBun_runStatus;
                Program.HomePageData.mc04.RunStatus = Program.PLC3_DB55_InputStatus.MC04_khuayPoly_runStatus;
                Program.HomePageData.mc03.RunStatus = Program.PLC3_DB55_InputStatus.MC03_khuayPac_runStatus;
                Program.HomePageData.dp04a.RunStatus = Program.PLC3_DB55_InputStatus.DP04A_dlPolyme04A_runStatus;
                Program.HomePageData.dp04b.RunStatus = Program.PLC3_DB55_InputStatus.DP04B_dlPolyme04B_runStatus;
                //Program.HomePageData.dp03a.RunStatus = Program.PLC3_DB55_InputStatus.DP03A_dlPolyme03A_runStatus;
                Program.HomePageData.dp03b.RunStatus = Program.PLC3_DB55_InputStatus.DP03B_dlPhen03B_runStatus;
                Program.HomePageData.dp05a.RunStatus = Program.PLC3_DB55_InputStatus.DP05A_dlXut05A_runStatus;
                Program.HomePageData.dp05b.RunStatus = Program.PLC3_DB55_InputStatus.DP05B_dlXut05B_runStatus;
                Program.HomePageData.dp06a.RunStatus = Program.PLC3_DB55_InputStatus.DP06A_dlDd06A_runStatus;
                Program.HomePageData.dp06b.RunStatus = Program.PLC3_DB55_InputStatus.DP06B_dlDd06B_runStatus;
                Program.HomePageData.mi03.RunStatus = Program.PLC3_DB55_InputStatus.MI03_dlPhen03A_runStatus;
                Program.HomePageData.mi04a.RunStatus = Program.PLC3_DB55_InputStatus.MI04A_khuayTaoBongA_runStatus;
                Program.HomePageData.mi04b.RunStatus = Program.PLC3_DB55_InputStatus.MI04B_khuayTaoBongB_runStatus;
                Program.HomePageData.ms05.RunStatus = Program.PLC3_DB55_InputStatus.MS05_gbbl05_runStatus;
                Program.HomePageData.ab06a.RunStatus = Program.PLC3_DB55_InputStatus.AB06A_mayTKBiofor1_runStatus;
                Program.HomePageData.ab06b.RunStatus = Program.PLC3_DB55_InputStatus.AB06B_mayTKBiofor2_runStatus;
                Program.HomePageData.ab06c.RunStatus = Program.PLC3_DB55_InputStatus.AB06C_mayTKBiofor3_runStatus;
                Program.HomePageData.ms07.RunStatus = Program.PLC3_DB55_InputStatus.MS07_gbbl07_runStatus;
                //Program.HomePageData.mt02.RunStatus = Program.PLC1_DB43_InputStatus.MT02
                Program.HomePageData.dp02.RunStatus = Program.PLC1_DB43_InputStatus.DP02_DlXut_runStatus;
                Program.HomePageData.mt04.RunStatus = Program.PLC1_DB43_InputStatus.MT04_KhuayClo_runStatus;
                Program.HomePageData.dp04.RunStatus = Program.PLC1_DB43_InputStatus.DP04_DlClo_runStatus;
                Program.HomePageData.mt02b.RunStatus = Program.PLC1_DB43_InputStatus.MT02A_KhuayTaoBong1_runStatus;
                Program.HomePageData.mt02a.RunStatus = Program.PLC1_DB43_InputStatus.MT02B_KhuayTaoBong2_runStatus;
                Program.HomePageData.mt01.RunStatus = Program.PLC1_DB43_InputStatus.MT01_KhuayKeoTu_runStatus;
                Program.HomePageData.sp10.RunStatus = Program.PLC3_DB55_InputStatus.SP10_bomBunSP10_runStatus;
                //Program.HomePageData.dp04a_1.RunStatus = Program.PLC3_DB55_InputStatus.DP04A_dlPolyme04A_runStatus;
                //Program.HomePageData.dp04a_2.RunStatus = Program.PLC1_DB43_InputStatus.
                Program.HomePageData.ms09.RunStatus = Program.PLC3_DB55_InputStatus.MS09_gbbl09_runStatus;
                Program.HomePageData.sp05a.RunStatus = Program.PLC3_DB55_InputStatus.SP05A_bomBun05A_runStatus;
                Program.HomePageData.sp05b.RunStatus = Program.PLC3_DB55_InputStatus.SP05B_bomBun05B_runStatus;
                Program.HomePageData.sp07a.RunStatus = Program.PLC3_DB55_InputStatus.SP07A_bomBun07A_runStatus;
                Program.HomePageData.sp07b.RunStatus = Program.PLC3_DB55_InputStatus.SP07B_bomBun07B_runStatus;
                Program.HomePageData.dp07a.RunStatus = Program.PLC3_DB55_InputStatus.DP07A_dlKhuTrung_07A_runStatus;
                Program.HomePageData.dp07b.RunStatus = Program.PLC3_DB55_InputStatus.DP07B_dlKhuTrung_07B_runStatus;
                Program.HomePageData.sp11.RunStatus = Program.PLC3_DB55_InputStatus.SP10_bomBunSP10_runStatus;
                Program.HomePageData.ggb.RunStatus = Program.PLC1_DB43_InputStatus.GGB_MotorGatBun_runStatus;
                //Program.HomePageData.mc09.RunStatus = Program.PLC3_DB55_InputStatus.mc09
                //Program.HomePageData.dp09a.RunStatus = Program.PLC2_DB63_InputStatus.dp
                //Program.HomePageData.dp09b.RunStatus = Program.PLC1_DB43_InputStatus.
                //Program.HomePageData.dp01.RunStatus = Program.PLC3_DB55_InputStatus.dp01
                Program.HomePageData.dp06_2.RunStatus = Program.PLC1_DB43_InputStatus.DP06_2P2_DlPolyme2_runStatus;
                Program.HomePageData.mt06_2.RunStatus = Program.PLC1_DB43_InputStatus.MT06_2P2_KhuayPolyme2_runStatus;

                /// TRIP:
                Program.HomePageData.mtk01.TripStatus = Program.PLC1_DB43_InputStatus.MTK01_mayTKBeDieuHoa_tripStatus;
                Program.HomePageData.mtk02.TripStatus = Program.PLC1_DB43_InputStatus.MTK02_mayTKBeDieuHoa_tripStatus;
                Program.HomePageData.mtk03.TripStatus = Program.PLC1_DB43_InputStatus.MTK03_mayTKBeDieuHoa_tripStatus;
                Program.HomePageData.mtetn.TripStatus = Program.PLC2_DB63_InputStatus.MTETN_metanol_tripStatus;
                Program.HomePageData.dpetn.TripStatus = Program.PLC2_DB63_InputStatus.DPETN_etanol1_tripStatus;
                Program.HomePageData.dp03.TripStatus = Program.PLC1_DB43_InputStatus.DP03_DlNp_tripStatus;
                Program.HomePageData.mt03.TripStatus = Program.PLC1_DB43_InputStatus.MT03_KhuayNp_tripStatus;
                Program.HomePageData.mkt1.TripStatus = Program.PLC2_DB63_InputStatus.MKT1_mayTKAerotank1_tripStatus;
                Program.HomePageData.mkt2.TripStatus = Program.PLC2_DB63_InputStatus.MKT2_mayTKAerotank2_tripStatus;
                Program.HomePageData.mkt3.TripStatus = Program.PLC2_DB63_InputStatus.MKT3_mayTKAerotank3_tripStatus;
                Program.HomePageData.mt05.TripStatus = Program.PLC1_DB43_InputStatus.MT05_KhuayPac_tripStatus;
                Program.HomePageData.dp05.TripStatus = Program.PLC1_DB43_InputStatus.DP05_DlPac_tripStatus;
                Program.HomePageData.dp06_1.TripStatus = Program.PLC1_DB43_InputStatus.DP06_1P1_DlPolyme1_tripStatus;
                Program.HomePageData.mt06_1.TripStatus = Program.PLC1_DB43_InputStatus.MT06_1P1_KhuayPolyme1_tripStatus;
                Program.HomePageData.bb1.TripStatus = Program.PLC2_DB63_InputStatus.BB1_bomBun1_tripStatus;
                Program.HomePageData.bb2.TripStatus = Program.PLC2_DB63_InputStatus.BB2_bomBun2_tripStatus;
                Program.HomePageData.p0101.TripStatus = Program.PLC1_DB43_InputStatus.P101_BeGom1_tripStatus;
                Program.HomePageData.p0102.TripStatus = Program.PLC1_DB43_InputStatus.P102_BeGom2_tripStatus;
                Program.HomePageData.p0103.TripStatus = Program.PLC1_DB43_InputStatus.P103_BeGom3_tripStatus;
                Program.HomePageData.bs02a.TripStatus = Program.PLC3_DB55_InputStatus.BS02A_mayTachRac_tripStatus;
                Program.HomePageData.p0201.TripStatus = Program.PLC1_DB43_InputStatus.P0201_bomBeDieuHoa_tripStatus;
                Program.HomePageData.p0202.TripStatus = Program.PLC1_DB43_InputStatus.P0202_bomBeDieuHoa_tripStatus;
                Program.HomePageData.wp02a.TripStatus = Program.PLC3_DB55_InputStatus.WP02A_bomNt_02A_tripStatus;
                Program.HomePageData.wp02b.TripStatus = Program.PLC3_DB55_InputStatus.WP02B_bomNt_02B_tripStatus;
                Program.HomePageData.sm01.TripStatus = Program.PLC2_DB63_InputStatus.SM01_anoxic1_tripStatus;
                Program.HomePageData.sm02.TripStatus = Program.PLC2_DB63_InputStatus.SM02_anoxic2_tripStatus;
                Program.HomePageData.sm03.TripStatus = Program.PLC2_DB63_InputStatus.SM03_anoxic3_tripStatus;
                Program.HomePageData.sm04.TripStatus = Program.PLC2_DB63_InputStatus.SM04_anoxic4_tripStatus;
                Program.HomePageData.sm05.TripStatus = Program.PLC2_DB63_InputStatus.SM05_anoxic5_tripStatus;
                Program.HomePageData.sm06.TripStatus = Program.PLC2_DB63_InputStatus.SM06_anoxic6_tripStatus;
                Program.HomePageData.sm07.TripStatus = Program.PLC2_DB63_InputStatus.SM07_anoxic7_tripStatus;
                Program.HomePageData.sm08.TripStatus = Program.PLC2_DB63_InputStatus.SM08_anoxic8_tripStatus;
                Program.HomePageData.th1.TripStatus = Program.PLC2_DB63_InputStatus.TH1_tuanHoan1_tripStatus;
                Program.HomePageData.th2.TripStatus = Program.PLC2_DB63_InputStatus.TH2_tuanHoan2_tripStatus;
                Program.HomePageData.th3.TripStatus = Program.PLC2_DB63_InputStatus.TH3_tuanHoan3_tripStatus;
                Program.HomePageData.gb1.TripStatus = Program.PLC2_DB63_InputStatus.GB1_gatBun_tripStatus;
                Program.HomePageData.mc04.TripStatus = Program.PLC3_DB55_InputStatus.MC04_khuayPoly_tripStatus;
                Program.HomePageData.mc03.TripStatus = Program.PLC3_DB55_InputStatus.MC03_khuayPac_tripStatus;
                Program.HomePageData.dp04a.TripStatus = Program.PLC3_DB55_InputStatus.DP04A_dlPolyme04A_tripStatus;
                Program.HomePageData.dp04b.TripStatus = Program.PLC3_DB55_InputStatus.DP04B_dlPolyme04B_tripStatus;
                //Program.HomePageData.dp03a.TripStatus = Program.PLC3_DB55_InputStatus.DP03a_dlPolyme03A_tripStatus;
                Program.HomePageData.dp03b.TripStatus = Program.PLC3_DB55_InputStatus.DP03B_dlPhen03B_tripStatus;
                Program.HomePageData.dp05a.TripStatus = Program.PLC3_DB55_InputStatus.DP05A_dlXut05A_tripStatus;
                Program.HomePageData.dp05b.TripStatus = Program.PLC3_DB55_InputStatus.DP05B_dlXut05B_tripStatus;
                Program.HomePageData.dp06a.TripStatus = Program.PLC3_DB55_InputStatus.DP06A_dlDd06A_tripStatus;
                Program.HomePageData.dp06b.TripStatus = Program.PLC3_DB55_InputStatus.DP06B_dlDd06B_tripStatus;
                Program.HomePageData.mi03.TripStatus = Program.PLC3_DB55_InputStatus.MI03_dlPhen03A_tripStatus;
                Program.HomePageData.mi04a.TripStatus = Program.PLC3_DB55_InputStatus.MI04A_khuayTaoBongA_tripStatus;
                Program.HomePageData.mi04b.TripStatus = Program.PLC3_DB55_InputStatus.MI04B_khuayTaoBongB_tripStatus;
                Program.HomePageData.ms05.TripStatus = Program.PLC3_DB55_InputStatus.MS05_gbbl05_tripStatus;
                Program.HomePageData.ab06a.TripStatus = Program.PLC3_DB55_InputStatus.AB06A_mayTKBiofor1_tripStatus;
                Program.HomePageData.ab06b.TripStatus = Program.PLC3_DB55_InputStatus.AB06B_mayTKBiofor2_tripStatus;
                Program.HomePageData.ab06c.TripStatus = Program.PLC3_DB55_InputStatus.AB06C_mayTKBiofor3_tripStatus;
                Program.HomePageData.ms07.TripStatus = Program.PLC3_DB55_InputStatus.MS07_gbbl07_tripStatus;
                //Program.HomePageData.mt02.TripStatus = Program.PLC1_DB43_InputStatus.MT02
                Program.HomePageData.dp02.TripStatus = Program.PLC1_DB43_InputStatus.DP02_DlXut_tripStatus;
                Program.HomePageData.mt04.TripStatus = Program.PLC1_DB43_InputStatus.MT04_KhuayClo_tripStatus;
                Program.HomePageData.dp04.TripStatus = Program.PLC1_DB43_InputStatus.DP04_DlClo_tripStatus;
                Program.HomePageData.mt02b.TripStatus = Program.PLC1_DB43_InputStatus.MT02B_KhuayTaoBong2_tripStatus;
                Program.HomePageData.mt02a.TripStatus = Program.PLC1_DB43_InputStatus.MT02A_KhuayTaoBong1_runStatus;
                Program.HomePageData.mt01.TripStatus = Program.PLC1_DB43_InputStatus.MT01_KhuayKeoTu_tripStatus;
                Program.HomePageData.sp10.TripStatus = Program.PLC3_DB55_InputStatus.SP10_bomBunSP10_tripStatus;
                //Program.HomePageData.dp04a_1.TripStatus = Program.PLC3_DB55_InputStatus.DP04A_dlPolyme04A_tripStatus;
                //Program.HomePageData.dp04a_2.TripStatus = Program.PLC1_DB43_InputStatus.
                Program.HomePageData.ms09.TripStatus = Program.PLC3_DB55_InputStatus.MS09_gbbl09_tripStatus;
                Program.HomePageData.sp05a.TripStatus = Program.PLC3_DB55_InputStatus.SP05A_bomBun05A_tripStatus;
                Program.HomePageData.sp05b.TripStatus = Program.PLC3_DB55_InputStatus.SP05B_bomBun05B_tripStatus;
                Program.HomePageData.sp07a.TripStatus = Program.PLC3_DB55_InputStatus.SP07A_bomBun07A_tripStatus;
                Program.HomePageData.sp07b.TripStatus = Program.PLC3_DB55_InputStatus.SP07B_bomBun07B_tripStatus;
                Program.HomePageData.dp07a.TripStatus = Program.PLC3_DB55_InputStatus.DP07A_dlKhuTrung_07A_tripStatus;
                Program.HomePageData.dp07b.TripStatus = Program.PLC3_DB55_InputStatus.DP07B_dlKhuTrung_07B_tripStatus;
                Program.HomePageData.sp11.TripStatus = Program.PLC3_DB55_InputStatus.SP10_bomBunSP10_tripStatus;
                Program.HomePageData.ggb.TripStatus = Program.PLC1_DB43_InputStatus.GGB_MotorGatBun_tripStatus;
                //Program.HomePageData.mc09.TripStatus = Program.PLC3_DB55_InputStatus.mc09
                //Program.HomePageData.dp09a.TripStatus = Program.PLC2_DB63_InputStatus.dp
                //Program.HomePageData.dp09b.TripStatus = Program.PLC1_DB43_InputStatus.
                //Program.HomePageData.dp01.TripStatus = Program.PLC3_DB55_InputStatus.dp01
                Program.HomePageData.dp06_2.TripStatus = Program.PLC1_DB43_InputStatus.DP06_2P2_DlPolyme2_tripStatus;
                Program.HomePageData.mt06_2.TripStatus = Program.PLC1_DB43_InputStatus.MT06_2P2_KhuayPolyme2_tripStatus;


                /// RUNTIME:
                Program.HomePageData.mtk01.RuntimeTotal = Program.PLC1_DB19_Runtime.MTK01_mayTKBeDieuHoa_runtime;
                Program.HomePageData.mtk02.RuntimeTotal = Program.PLC1_DB19_Runtime.MTK02_mayTKBeDieuHoa_runtime;
                Program.HomePageData.mtk03.RuntimeTotal = Program.PLC1_DB19_Runtime.MTK03_mayTKBeDieuHoa_runtime;
                Program.HomePageData.mtetn.RuntimeTotal = Program.PLC2_DB39_Runtime.MTETN_metanol_runtime;
                Program.HomePageData.dpetn.RuntimeTotal = Program.PLC2_DB39_Runtime.DPETN_etanol1_runtime;
                Program.HomePageData.dp03.RuntimeTotal = Program.PLC1_DB19_Runtime.DP03_DlNp_runtime;
                Program.HomePageData.mt03.RuntimeTotal = Program.PLC1_DB19_Runtime.MT03_KhuayNp_runtime;
                Program.HomePageData.mkt1.RuntimeTotal = Program.PLC2_DB39_Runtime.MKT1_mkt01Aerotank_runtime;
                Program.HomePageData.mkt2.RuntimeTotal = Program.PLC2_DB39_Runtime.MKT2_mkt02Aerotank_runtime;
                Program.HomePageData.mkt3.RuntimeTotal = Program.PLC2_DB39_Runtime.MKT3_mkt03Aerotank_runtime;
                Program.HomePageData.mt05.RuntimeTotal = Program.PLC1_DB19_Runtime.MT05_KhuayPac_runtime;
                //Program.HomePageData.dp05.RuntimeTotal = Program.PLC1_DB19_Runtime.DP05_DlPac_runtime;
                Program.HomePageData.dp06_1.RuntimeTotal = Program.PLC1_DB19_Runtime.DP06_1P2_DlPac_runtime;
                Program.HomePageData.mt06_1.RuntimeTotal = Program.PLC1_DB19_Runtime.MT06_KhuayPolyme1_runtime;
                Program.HomePageData.bb1.RuntimeTotal = Program.PLC2_DB39_Runtime.BB1_bomBun1_runtime;
                Program.HomePageData.bb2.RuntimeTotal = Program.PLC2_DB39_Runtime.BB2_bomBun2_runtime;
                Program.HomePageData.p0101.RuntimeTotal = Program.PLC1_DB19_Runtime.P101_bomBeGom1_runtime;
                Program.HomePageData.p0102.RuntimeTotal = Program.PLC1_DB19_Runtime.P102_bomBeGom2_runtime;
                Program.HomePageData.p0103.RuntimeTotal = Program.PLC1_DB19_Runtime.P103_bomBeGom3_runtime;
                Program.HomePageData.bs02a.RuntimeTotal = Program.PLC3_DB24_Runtime.BS02A_mayTachRac_runtime;
                Program.HomePageData.p0201.RuntimeTotal = Program.PLC1_DB19_Runtime.P0201_bomDieuHoa1_runtime;
                Program.HomePageData.p0202.RuntimeTotal = Program.PLC1_DB19_Runtime.P0202_bomDieuHoa2_runtime;
                Program.HomePageData.wp02a.RuntimeTotal = Program.PLC3_DB24_Runtime.WP02A_bomNt02A_runtime;
                Program.HomePageData.wp02b.RuntimeTotal = Program.PLC3_DB24_Runtime.WP02B_bomN_02B_runtime;
                Program.HomePageData.sm01.RuntimeTotal = Program.PLC2_DB39_Runtime.SM01_anoxic1_runtime;
                Program.HomePageData.sm02.RuntimeTotal = Program.PLC2_DB39_Runtime.SM02_anoxic2_runtime;
                Program.HomePageData.sm03.RuntimeTotal = Program.PLC2_DB39_Runtime.SM03_anoxic3_runtime;
                Program.HomePageData.sm04.RuntimeTotal = Program.PLC2_DB39_Runtime.SM04_anoxic4_runtime;
                Program.HomePageData.sm05.RuntimeTotal = Program.PLC2_DB39_Runtime.SM05_anoxic5_runtime;
                Program.HomePageData.sm06.RuntimeTotal = Program.PLC2_DB39_Runtime.SM06_anoxic6_runtime;
                Program.HomePageData.sm07.RuntimeTotal = Program.PLC2_DB39_Runtime.SM07_anoxic7_runtime;
                Program.HomePageData.sm08.RuntimeTotal = Program.PLC2_DB39_Runtime.SM08_anoxic8_runtime;
                Program.HomePageData.th1.RuntimeTotal = Program.PLC2_DB39_Runtime.TH1_tuanHoan1_runtime;
                Program.HomePageData.th2.RuntimeTotal = Program.PLC2_DB39_Runtime.TH2_tuanHoan2_runtime;
                Program.HomePageData.th3.RuntimeTotal = Program.PLC2_DB39_Runtime.TH3_tuanHoan3_runtime;
                Program.HomePageData.gb1.RuntimeTotal = Program.PLC2_DB39_Runtime.GB1_gatBun_runtime;
                Program.HomePageData.mc04.RuntimeTotal = Program.PLC3_DB24_Runtime.MC04_khuayPolyGD2_runtime;
                Program.HomePageData.mc03.RuntimeTotal = Program.PLC3_DB24_Runtime.MC03_khuayPacGD2_runtime;
                Program.HomePageData.dp04a.RuntimeTotal = Program.PLC3_DB24_Runtime.DP04A_dlPoly04A_runtime;
                Program.HomePageData.dp04b.RuntimeTotal = Program.PLC3_DB24_Runtime.DP04B_dlPoly04B_runtime;
                Program.HomePageData.dp05a.RuntimeTotal = Program.PLC3_DB24_Runtime.DP05A_dlXut05A_runtime;
                Program.HomePageData.dp05b.RuntimeTotal = Program.PLC3_DB24_Runtime.DP05B_dlXut05B_runtime;
                Program.HomePageData.dp06a.RuntimeTotal = Program.PLC3_DB24_Runtime.DP06A_dlDD06A_runtime;
                Program.HomePageData.dp06b.RuntimeTotal = Program.PLC3_DB24_Runtime.DP06B_dlDD06B_runtime;
                Program.HomePageData.mi03.RuntimeTotal = Program.PLC3_DB24_Runtime.MI03_khuayKeoTuGD2_runtime;
                Program.HomePageData.mi04a.RuntimeTotal = Program.PLC3_DB24_Runtime.MI04A_khuayTaoBongA_runtime;
                Program.HomePageData.mi04b.RuntimeTotal = Program.PLC3_DB24_Runtime.MI04B_khuayTaoBongB_runtime;
                //Program.HomePageData.ms05.RuntimeTotal = Program.PLC3_DB24_Runtime.MS05_gbbl05_runtime;
                Program.HomePageData.ab06a.RuntimeTotal = Program.PLC3_DB24_Runtime.AB06A_mayTKBiofor1_runtime;
                Program.HomePageData.ab06b.RuntimeTotal = Program.PLC3_DB24_Runtime.AB06B_mayTKBiofor2_runtime;
                Program.HomePageData.ab06c.RuntimeTotal = Program.PLC3_DB24_Runtime.AB06C_mayTKBiofor3_runtime;
                //Program.HomePageData.ms07.RuntimeTotal = Program.PLC3_DB24_Runtime.MS07_gbbl07_runtime;
                //Program.HomePageData.mt02.RuntimeTotal = Program.PLC1_DB19_Runtime.MT02
                Program.HomePageData.dp02.RuntimeTotal = Program.PLC1_DB19_Runtime.DP02_DlXut_runtime;
                Program.HomePageData.mt04.RuntimeTotal = Program.PLC1_DB19_Runtime.MT04_KhuayClo_runtime;
                Program.HomePageData.dp04.RuntimeTotal = Program.PLC1_DB19_Runtime.DP04_DlClo_runtime;
                //Program.HomePageData.mt02b.RuntimeTotal = Program.PLC1_DB19_Runtime.MT02A_KhuayTaoBong1_runtime;
                //Program.HomePageData.mt02a.RuntimeTotal = Program.PLC1_DB19_Runtime.MT02B_KhuayTaoBong2_runtime;
                //Program.HomePageData.mt01.RuntimeTotal = Program.PLC1_DB19_Runtime.MT01_KhuayKeoTu_runtime;
                Program.HomePageData.sp10.RuntimeTotal = Program.PLC3_DB24_Runtime.SP10_bomBunSP10_runtime;
                //Program.HomePageData.dp04a_1.RuntimeTotal = Program.PLC3_DB24_Runtime.DP04A_dlPolyme04A_runtime;
                //Program.HomePageData.dp04a_2.RuntimeTotal = Program.PLC1_DB19_Runtime.
                //Program.HomePageData.ms09.RuntimeTotal = Program.PLC3_DB24_Runtime.MS09_gbbl09_runtime;
                Program.HomePageData.sp05a.RuntimeTotal = Program.PLC3_DB24_Runtime.SP05A_bomBun05A_runtime;
                Program.HomePageData.sp05b.RuntimeTotal = Program.PLC3_DB24_Runtime.SP05B_bomBun05B_runtime;
                Program.HomePageData.sp07a.RuntimeTotal = Program.PLC3_DB24_Runtime.SP07A_bomBun07A_runtime;
                Program.HomePageData.sp07b.RuntimeTotal = Program.PLC3_DB24_Runtime.SP07B_bomBun07B_runtime;
                Program.HomePageData.dp07a.RuntimeTotal = Program.PLC3_DB24_Runtime.DP07A_dlKhuTrung07A_runtime;
                Program.HomePageData.dp07b.RuntimeTotal = Program.PLC3_DB24_Runtime.DP07B_dlKhuTrung07B_runtime;
                Program.HomePageData.sp11.RuntimeTotal = Program.PLC3_DB24_Runtime.SP10_bomBunSP10_runtime;
                //Program.HomePageData.ggb.RuntimeTotal = Program.PLC1_DB19_Runtime.GGB_MotorGatBun_runtime;
                //Program.HomePageData.mc09.RuntimeTotal = Program.PLC3_DB24_Runtime.mc09
                //Program.HomePageData.dp09a.RuntimeTotal = Program.PLC2_DB39_Runtime.dp
                //Program.HomePageData.dp09b.RuntimeTotal = Program.PLC1_DB19_Runtime.
                //Program.HomePageData.dp01.RuntimeTotal = Program.PLC3_DB24_Runtime.dp01
                Program.HomePageData.dp06_2.RuntimeTotal = Program.PLC1_DB19_Runtime.DP06_2P2_DlPolyme_runtime;
                //Program.HomePageData.mt06_2.RuntimeTotal = Program.PLC1_DB19_Runtime.MT06_2P2_KhuayPolyme2_runtime;


                /// RUNTIME SETTING:
                Program.HomePageData.mtk01.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.MTK01_mayTKbeDieuHoa_setTime;
                Program.HomePageData.mtk02.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.Mtk02_mayTKbeDieuHoa_setTime;
                Program.HomePageData.mtk03.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.Mtk03_mayTKbeDieuHoa_setTime;
                Program.HomePageData.mtetn.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.MTETN_metanol_setTime_on;
                Program.HomePageData.mtetn.RuntimeDutyOff = Program.PLC2_DB1_RuntimeSetting.MTETN_metanol_setTime_off;
                //Program.HomePageData.dpetn.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.DPETN_etanol1_runtime;
                //Program.HomePageData.dp03.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.DP03_DlNp_runtime;
                //Program.HomePageData.mt03.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.MT03_KhuayNp_runtime;
                Program.HomePageData.mkt1.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.MKT01_mayTKiAerotank_setTime;
                Program.HomePageData.mkt2.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.MKT02_mayTKAerotank_setTime;
                Program.HomePageData.mkt3.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.MKT03_mayTKAerotank_setTime;
                //Program.HomePageData.mt05.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.MT05_KhuayPac_runtime;
                //Program.HomePageData.dp05.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.DP05_DlPac_runtime;
                //Program.HomePageData.dp06_1.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.DP06_1P2_DlPac_runtime;
                // Program.HomePageData.mt06_1.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.MT06_KhuayPolyme1_runtime;
                Program.HomePageData.bb1.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.BB1_bomBun_setTime_on;
                Program.HomePageData.bb1.RuntimeDutyOff = Program.PLC2_DB1_RuntimeSetting.BB1_bomBun_setTime_off;
                //Program.HomePageData.bb2.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.BB2_bomBun2_runtime;
                Program.HomePageData.p0101.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.P101_bomBeGom1_setTime;
                Program.HomePageData.p0102.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.P102_bomBeGom2_setTime;
                Program.HomePageData.p0103.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.P103_BeGom3_setTime;
                //Program.HomePageData.bs02a.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.BS02A_mayTachRac_runtime;
                Program.HomePageData.p0201.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.P0201_bomDieuHoa1_setTime;
                Program.HomePageData.p0202.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.P0202_bomDieuHoa2_setTime;
                Program.HomePageData.wp02a.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.WP02A_bomNt02A_setTime;
                Program.HomePageData.wp02b.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.WP02B_bomNt02B_setTime;
                Program.HomePageData.sm01.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.SM01_anoxic1_setTime;
                Program.HomePageData.sm02.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.SM02_anoxic2_setTime;
                Program.HomePageData.sm03.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.SM03_anoxic3_setTime;
                Program.HomePageData.sm04.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.SM04_anoxic4_setTime;
                Program.HomePageData.sm05.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.SM05_anoxic5_setTime;
                Program.HomePageData.sm06.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.SM06_anoxic6_setTime;
                Program.HomePageData.sm07.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.SM07_anoxic7_setTime;
                Program.HomePageData.sm08.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.SM08_anoxic8_setTime;
                Program.HomePageData.th1.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.TH1_tuanHoan1_setTime;
                Program.HomePageData.th2.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.TH2_tuanHoan2_setTime;
                Program.HomePageData.th3.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.TH3_tuanHoan3_setTime;
                Program.HomePageData.gb1.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.GB1_gatBun_setTime_on;
                Program.HomePageData.gb1.RuntimeDutyOff = Program.PLC2_DB1_RuntimeSetting.GB1_gatBun_setTime_off;
                //Program.HomePageData.mc04.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.MC04_khuayPolyGD2_runtime;
                //Program.HomePageData.mc03.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.MC03_khuayPacGD2_runtime;
                //Program.HomePageData.dp04a.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.DP04A_dlPoly04A_runtime;
                //Program.HomePageData.dp04b.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.DP04B_dlPoly04B_runtime;
                //Program.HomePageData.dp03a.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.DP03A_dlPoly03A_runtime;
                //Program.HomePageData.dp03b.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.DP03B_dlPoly03B_runtime;
                //Program.HomePageData.dp05a.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.DP05A_dlXut05A_runtime;
                //Program.HomePageData.dp05b.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.DP05B_dlXut05B_runtime;
                //Program.HomePageData.dp06a.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.DP06A_dlDD06A_runtime;
                //Program.HomePageData.dp06b.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.DP06B_dlDD06B_runtime;
                //Program.HomePageData.mi03.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.MI03_khuayKeoTuGD2_runtime;
                //Program.HomePageData.mi04a.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.MI04A_khuayTaoBongA_runtime;
                //Program.HomePageData.mi04b.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.MI04B_khuayTaoBongB_runtime;
                //Program.HomePageData.ms05.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.MS05_gbbl05_runtime;
                Program.HomePageData.ab06a.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.AB06A_mtkAB06A_setTime;
                Program.HomePageData.ab06b.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.AB06B_mtkAB06B_setTime;
                Program.HomePageData.ab06c.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.AB06C_mtkAB06C_setTime;
                //Program.HomePageData.ms07.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.MS07_gbbl07_runtime;
                //Program.HomePageData.mt02.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.MT02
                //Program.HomePageData.dp02.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.DP02_DlXut_runtime;
                //Program.HomePageData.mt04.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.MT04_KhuayClo_runtime;
                //Program.HomePageData.dp04.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.DP04_DlClo_runtime;
                //Program.HomePageData.mt02b.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.MT02A_KhuayTaoBong1_runtime;
                //Program.HomePageData.mt02a.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.MT02B_KhuayTaoBong2_runtime;
                //Program.HomePageData.mt01.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.MT01_KhuayKeoTu_runtime;
                //Program.HomePageData.sp10.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.SP10_bomBunSP10_runtime;
                //Program.HomePageData.dp04a_1.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.DP04A_dlPolyme04A_runtime;
                //Program.HomePageData.dp04a_2.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.
                //Program.HomePageData.ms09.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.MS09_gbbl09_runtime;
                Program.HomePageData.sp05a.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.SP05AB_bomBun05AB_setTime_on;
                Program.HomePageData.sp05a.RuntimeDutyOff = Program.PLC3_DB19_RuntimeSetting.SP05AB_bomBun05AB_setTime_off;
                Program.HomePageData.sp05b.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.SP05AB_bomBun05AB_setTime_on;
                Program.HomePageData.sp05b.RuntimeDutyOff = Program.PLC3_DB19_RuntimeSetting.SP05AB_bomBun05AB_setTime_off;
                Program.HomePageData.sp07a.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.SP07AB_bomBun07AB_setTime_on;
                Program.HomePageData.sp07b.RuntimeDutyOff = Program.PLC3_DB19_RuntimeSetting.SP07ABbomBun07AB_setTime_off;
                //Program.HomePageData.dp07a.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.DP07A_dlKhuTrung07A_runtime;
                //Program.HomePageData.dp07b.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.DP07B_dlKhuTrung07B_runtime;
                //Program.HomePageData.sp11.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.SP10_bomBunSP10_runtime;
                //Program.HomePageData.ggb.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.GGB_MotorGatBun_runtime;
                //Program.HomePageData.mc09.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.mc09
                //Program.HomePageData.dp09a.RuntimeDutyOn = Program.PLC2_DB1_RuntimeSetting.dp
                //Program.HomePageData.dp09b.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.
                //Program.HomePageData.dp01.RuntimeDutyOn = Program.PLC3_DB19_RuntimeSetting.dp01
                //Program.HomePageData.dp06_2.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.DP06_2P2_DlPolyme_runtime;
                //Program.HomePageData.mt06_2.RuntimeDutyOn = Program.PLC1_DB16_RuntimeSetting.MT06_2P2_KhuayPolyme2_runtime;


                /// RESET RUNTIME:
                Program.HomePageData.mtk01.ResetRuntime = Program.PLC1_DB20_ResetRuntime.MTK01_mayTKBeDieuHoa_resetCmd;
                Program.HomePageData.mtk02.ResetRuntime = Program.PLC1_DB20_ResetRuntime.MTK02_mayTKBeDieuHoa_resetCmd;
                Program.HomePageData.mtk03.ResetRuntime = Program.PLC1_DB20_ResetRuntime.MTK03_mayTKBeDieuHoa_resetCmd;
                Program.HomePageData.mtetn.ResetRuntime = Program.PLC2_DB38_ResetRuntime.MTETN_metanol_resetCmd;
                Program.HomePageData.dpetn.ResetRuntime = Program.PLC2_DB38_ResetRuntime.DPETN_etanol1_resetCmd;
                Program.HomePageData.dp03.ResetRuntime = Program.PLC1_DB20_ResetRuntime.DP03_DlNp_resetCmd;
                Program.HomePageData.mt03.ResetRuntime = Program.PLC1_DB20_ResetRuntime.MT03_KhuayNp_resetCmd;
                Program.HomePageData.mkt1.ResetRuntime = Program.PLC2_DB38_ResetRuntime.MKT1_mayTKBeAerotank_resetCmd;
                Program.HomePageData.mkt2.ResetRuntime = Program.PLC2_DB38_ResetRuntime.MKT2_mayTKBeAerotank_resetCmd;
                Program.HomePageData.mkt3.ResetRuntime = Program.PLC2_DB38_ResetRuntime.MKT3_mayTKBeAerotank_resetCmd;
                Program.HomePageData.mt05.ResetRuntime = Program.PLC1_DB20_ResetRuntime.MT05_KhuayPac_resetCmd;
                //Program.HomePageData.dp05.ResetRuntime = Program.PLC1_DB20_ResetRuntime.DP05_DlPac_runtime;
                Program.HomePageData.dp06_1.ResetRuntime = Program.PLC1_DB20_ResetRuntime.DP06_1P1_DlPolyme_resetCmd;
                Program.HomePageData.mt06_1.ResetRuntime = Program.PLC1_DB20_ResetRuntime.MT06_1P1_KhuayPoly1_resetCmd;
                Program.HomePageData.bb1.ResetRuntime = Program.PLC2_DB38_ResetRuntime.BB1_bomBun1_resetCmd;
                Program.HomePageData.bb2.ResetRuntime = Program.PLC2_DB38_ResetRuntime.BB2_bomBun2_resetCmd;
                Program.HomePageData.p0101.ResetRuntime = Program.PLC1_DB20_ResetRuntime.P101_BeGom1_resetCmd;
                Program.HomePageData.p0102.ResetRuntime = Program.PLC1_DB20_ResetRuntime.P102_BeGom2_resetCmd;
                Program.HomePageData.p0103.ResetRuntime = Program.PLC1_DB20_ResetRuntime.P103_BeGom3_resetCmd;
                Program.HomePageData.bs02a.ResetRuntime = Program.PLC3_DB25_ResetRuntime.BS02A_mayTachRac_resetCmd;
                Program.HomePageData.p0201.ResetRuntime = Program.PLC1_DB20_ResetRuntime.P0201_bomDieuHoa1_resetCmd;
                Program.HomePageData.p0202.ResetRuntime = Program.PLC1_DB20_ResetRuntime.P0202_bomDieuHoa2_resetCmd;
                Program.HomePageData.wp02a.ResetRuntime = Program.PLC3_DB25_ResetRuntime.WP02A_bomNt02A_resetCmd;
                Program.HomePageData.wp02b.ResetRuntime = Program.PLC3_DB25_ResetRuntime.WP02b_bomNt02B_resetCmd;
                Program.HomePageData.sm01.ResetRuntime = Program.PLC2_DB38_ResetRuntime.SM01_anoxic1_resetCmd;
                Program.HomePageData.sm02.ResetRuntime = Program.PLC2_DB38_ResetRuntime.SM02_anoxic2_resetCmd;
                Program.HomePageData.sm03.ResetRuntime = Program.PLC2_DB38_ResetRuntime.SM03_anoxic3_resetCmd;
                Program.HomePageData.sm04.ResetRuntime = Program.PLC2_DB38_ResetRuntime.SM04_anoxic4_resetCmd;
                Program.HomePageData.sm05.ResetRuntime = Program.PLC2_DB38_ResetRuntime.SM05_anoxic5_resetCmd;
                Program.HomePageData.sm06.ResetRuntime = Program.PLC2_DB38_ResetRuntime.SM06_anoxic6_resetCmd;
                Program.HomePageData.sm07.ResetRuntime = Program.PLC2_DB38_ResetRuntime.SM07_anoxic7_resetCmd;
                Program.HomePageData.sm08.ResetRuntime = Program.PLC2_DB38_ResetRuntime.SM08_anoxic8_resetCmd;
                Program.HomePageData.th1.ResetRuntime = Program.PLC2_DB38_ResetRuntime.TH1_tuanHoan1_resetCmd;
                Program.HomePageData.th2.ResetRuntime = Program.PLC2_DB38_ResetRuntime.TH2_tuanHoan2_resetCmd;
                Program.HomePageData.th3.ResetRuntime = Program.PLC2_DB38_ResetRuntime.TH3_tuanHoan3_resetCmd;
                Program.HomePageData.gb1.ResetRuntime = Program.PLC2_DB38_ResetRuntime.GB1_gatBun_resetCmd;
                Program.HomePageData.mc04.ResetRuntime = Program.PLC3_DB25_ResetRuntime.MC04_khuayPolyGD2_resetCmd;
                Program.HomePageData.mc03.ResetRuntime = Program.PLC3_DB25_ResetRuntime.MC03_khuayPacGD2_resetCmd;
                Program.HomePageData.dp04a.ResetRuntime = Program.PLC3_DB25_ResetRuntime.DP04A_dlPoly04A_resetCmd;
                Program.HomePageData.dp04b.ResetRuntime = Program.PLC3_DB25_ResetRuntime.DP04B_dlPoly04B_resetCmd;
                //Program.HomePageData.dp03a.ResetRuntime = Program.PLC3_DB25_ResetRuntime.DP03A_dlPoly03A_resetCmd;
                Program.HomePageData.dp03b.ResetRuntime = Program.PLC3_DB25_ResetRuntime.DP03B_dlPhen03B_resetCmd;
                Program.HomePageData.dp05a.ResetRuntime = Program.PLC3_DB25_ResetRuntime.DP05A_dlXut05A_resetCmd;
                Program.HomePageData.dp05b.ResetRuntime = Program.PLC3_DB25_ResetRuntime.DP05B_dlXut05B_resetCmd;
                Program.HomePageData.dp06a.ResetRuntime = Program.PLC3_DB25_ResetRuntime.DP06A_dlDd06A_resetCmd;
                Program.HomePageData.dp06b.ResetRuntime = Program.PLC3_DB25_ResetRuntime.DP06B_dlDd06B_resetCmd;
                Program.HomePageData.mi03.ResetRuntime = Program.PLC3_DB25_ResetRuntime.MI03_dlPhen03A_resetCmd;
                Program.HomePageData.mi04a.ResetRuntime = Program.PLC3_DB25_ResetRuntime.MI04A_khuayTaoBongA_resetCmd;
                Program.HomePageData.mi04b.ResetRuntime = Program.PLC3_DB25_ResetRuntime.MI04B_khuayTaoBongB_resetCmd;
                //Program.HomePageData.ms05.ResetRuntime = Program.PLC3_DB25_ResetRuntime.MS05_gbbl05_runtime;
                Program.HomePageData.ab06a.ResetRuntime = Program.PLC3_DB25_ResetRuntime.AB06A_mtkAB06A_resetCmd;
                Program.HomePageData.ab06b.ResetRuntime = Program.PLC3_DB25_ResetRuntime.AB06B_mtkAB06B_resetCmd;
                Program.HomePageData.ab06c.ResetRuntime = Program.PLC3_DB25_ResetRuntime.AB06C_mtkAB06C_resetCmd;
                //Program.HomePageData.ms07.ResetRuntime = Program.PLC3_DB25_ResetRuntime.MS07_gbbl07_runtime;
                //Program.HomePageData.mt02.ResetRuntime = Program.PLC1_DB20_ResetRuntime.MT02
                Program.HomePageData.dp02.ResetRuntime = Program.PLC1_DB20_ResetRuntime.DP02_DlXut_resetCmd;
                Program.HomePageData.mt04.ResetRuntime = Program.PLC1_DB20_ResetRuntime.MT04_KhuayClo_resetCmd;
                Program.HomePageData.dp04.ResetRuntime = Program.PLC1_DB20_ResetRuntime.DP04_DlClo_resetCmd;
                //Program.HomePageData.mt02b.ResetRuntime = Program.PLC1_DB20_ResetRuntime.MT02A_KhuayTaoBong1_runtime;
                //Program.HomePageData.mt02a.ResetRuntime = Program.PLC1_DB20_ResetRuntime.MT02B_KhuayTaoBong2_runtime;
                //Program.HomePageData.mt01.ResetRuntime = Program.PLC1_DB20_ResetRuntime.MT01_KhuayKeoTu_runtime;
                Program.HomePageData.sp10.ResetRuntime = Program.PLC3_DB25_ResetRuntime.SP10_bomBunSP10_resetCmd;
                //Program.HomePageData.dp04a_1.ResetRuntime = Program.PLC3_DB25_ResetRuntime.DP04A_dlPolyme04A_runtime;
                //Program.HomePageData.dp04a_2.ResetRuntime = Program.PLC1_DB20_ResetRuntime.
                //Program.HomePageData.ms09.ResetRuntime = Program.PLC3_DB25_ResetRuntime.MS09_gbbl09_runtime;
                Program.HomePageData.sp05a.ResetRuntime = Program.PLC3_DB25_ResetRuntime.SP05A_bomBun05A_resetCmd;
                Program.HomePageData.sp05b.ResetRuntime = Program.PLC3_DB25_ResetRuntime.SP05B_bomBun05B_resetCmd;
                Program.HomePageData.sp07a.ResetRuntime = Program.PLC3_DB25_ResetRuntime.SP07A_bomBun07A_resetCmd;
                Program.HomePageData.sp07b.ResetRuntime = Program.PLC3_DB25_ResetRuntime.SP07B_bomBun07B_resetCmd;
                Program.HomePageData.dp07a.ResetRuntime = Program.PLC3_DB25_ResetRuntime.DP07A_dlKhuTrung07A_resetCmd;
                Program.HomePageData.dp07b.ResetRuntime = Program.PLC3_DB25_ResetRuntime.DP07B_dlKhuTrung07B_resetCmd;
                //Program.HomePageData.sp11.ResetRuntime = Program.PLC3_DB25_ResetRuntime.SP10_bomBunSP10_runtime;
                //Program.HomePageData.ggb.ResetRuntime = Program.PLC1_DB20_ResetRuntime.GGB_MotorGatBun_runtime;
                //Program.HomePageData.mc09.ResetRuntime = Program.PLC3_DB25_ResetRuntime.mc09
                //Program.HomePageData.dp09a.ResetRuntime = Program.PLC2_DB38_ResetRuntime.dp
                //Program.HomePageData.dp09b.ResetRuntime = Program.PLC1_DB20_ResetRuntime.
                //Program.HomePageData.dp01.ResetRuntime = Program.PLC3_DB25_ResetRuntime.dp01
                Program.HomePageData.dp06_1.ResetRuntime = Program.PLC1_DB20_ResetRuntime.DP06_1P1_DlPolyme_resetCmd;
                //Program.HomePageData.dp06_2.ResetRuntime = Program.PLC1_DB20_ResetRuntime.DP06_2P2_DlPolyme_runtime;
                //Program.HomePageData.mt06_2.ResetRuntime = Program.PLC1_DB20_ResetRuntime.MT06_2P2_KhuayPolyme2_runtime;

                // Báo các lên UI
                backWorker.ReportProgress(0, Program.HomePageData); // Cần bỏ đi line này khi overide lại method
            }
            catch (Exception ex)
            {
                string msg = $"[{DateTime.Now}] {ex.Message} ";
                // Logs sự kiện vào DataBase/ Log files:
                FileText SysHisData = new FileText();

                //Console.WriteLine("ERR: " + err.Message);
                SysHisData.OpenNCreate(SysHisData.DefaultPath, "SystemHistoryData");
                SysHisData.WriteLine(SysHisData.DefaultPath, "SystemHistoryData", msg + "[Stack:" + ex.StackTrace + "]");
            }
        }
        /// <summary>
        /// Phương thức: Cập nhật dữ liệu lên UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void BackWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Tác vụ gọi và set control trên UI:
            BSCADA_DataMapping.Page_Home od = e.UserState as BSCADA_DataMapping.Page_Home;

            tbFlowInCap.Text = od.FlowInCap.ToString();
            tbFlowInTotal.Text = od.FlowInTotal.ToString();
            tbFlowOutCap.Text = od.FlowInCap.ToString();
            tbFlowOutTotal.Text = od.FlowOutTotal.ToString();

            tbFlowInCap_table.Text = od.FlowInCap.ToString();
            tbFlowOutCap_table.Text = od.FlowOutCap.ToString();
            tbCodIndex.Text = od.CodIndex.ToString();
            tbTssIndex.Text = od.TssIndex.ToString();
            tbPhIndex.Text = od.PHIndex.ToString();
            tbNh3Index.Text = od.AmoniIndex.ToString();
            tbTemperIndex.Text = od.TemperatureIndex.ToString();
            tbColorIndex.Text = od.ColorIndex.ToString();

            #region RUN/ TRIP: UPDATE UI
            #region P0101: BƠM BỂ GOM
            FMotorControl.ShowStatus(Program.HomePageData.p0101.RunStatus, Program.HomePageData.p0101.TripStatus, motor_p0101);
            #endregion

            #region P0102: BƠM BỂ GOM
            FMotorControl.ShowStatus(Program.HomePageData.p0102.RunStatus, Program.HomePageData.p0102.TripStatus, motor_p0102);
            #endregion

            #region P0103: BƠM BỂ GOM
            FMotorControl.ShowStatus(Program.HomePageData.p0103.RunStatus, Program.HomePageData.p0103.TripStatus, motor_p0103);
            #endregion

            #region P0201: BƠM ĐIỀU HÒA
            FMotorControl.ShowStatus(Program.HomePageData.p0201.RunStatus, Program.HomePageData.p0201.TripStatus, motor_p0201);
            #endregion

            #region P0202: BƠM ĐIỀU HÒA
            FMotorControl.ShowStatus(Program.HomePageData.p0202.RunStatus, Program.HomePageData.p0202.TripStatus, motor_p0202);
            #endregion

            #region BS02A: MÁY TÁCH RÁC
            FMotorControl.ShowStatus(Program.HomePageData.bs02a.RunStatus, Program.HomePageData.bs02a.TripStatus, mayTachRac_bs02a);
            #endregion

            #region WP02A: BƠM NƯỚC THẢI
            FMotorControl.ShowStatus(Program.HomePageData.wp02a.RunStatus, Program.HomePageData.wp02a.TripStatus, motor_wp02a);
            #endregion

            #region WP02B: BƠM NƯỚC THẢI
            FMotorControl.ShowStatus(Program.HomePageData.wp02b.RunStatus, Program.HomePageData.wp02b.TripStatus, motor_wp02b);
            #endregion

            #region SM01: KHUÂY ANOXIC 1
            FMotorControl.ShowStatus(Program.HomePageData.sm01.RunStatus, Program.HomePageData.sm01.TripStatus, motor_sm01);
            #endregion

            #region SM02: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.sm02.RunStatus, Program.HomePageData.sm02.TripStatus, motor_sm02);
            #endregion

            #region SM03: KHUÂY ANOXIC 3
            FMotorControl.ShowStatus(Program.HomePageData.sm03.RunStatus, Program.HomePageData.sm03.TripStatus, motor_sm03);
            #endregion

            #region SM04: KHUÂY ANOXIC 4
            FMotorControl.ShowStatus(Program.HomePageData.sm02.RunStatus, Program.HomePageData.sm04.TripStatus, motor_sm04);
            #endregion

            #region SM05: KHUÂY ANOXIC 5
            FMotorControl.ShowStatus(Program.HomePageData.sm02.RunStatus, Program.HomePageData.sm05.TripStatus, motor_sm05);
            #endregion

            #region SM06: KHUÂY ANOXIC 6
            FMotorControl.ShowStatus(Program.HomePageData.sm02.RunStatus, Program.HomePageData.sm06.TripStatus, motor_sm06);
            #endregion

            #region SM07: KHUÂY ANOXIC 7
            FMotorControl.ShowStatus(Program.HomePageData.sm02.RunStatus, Program.HomePageData.sm07.TripStatus, motor_sm07);
            #endregion

            #region SM08: KHUÂY ANOXIC 8
            FMotorControl.ShowStatus(Program.HomePageData.sm02.RunStatus, Program.HomePageData.sm08.TripStatus, motor_sm08);
            #endregion

            #region TH1: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.th1.RunStatus, Program.HomePageData.th1.TripStatus, motor_th1);
            #endregion

            #region TH2: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.th2.RunStatus, Program.HomePageData.th2.TripStatus, motor_th2);
            #endregion

            #region TH3: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.th3.RunStatus, Program.HomePageData.th3.TripStatus, motor_th3);
            #endregion

            #region MS05: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.ms05.RunStatus, Program.HomePageData.ms05.TripStatus, motor_ms05);
            #endregion

            #region MS07: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.ms07.RunStatus, Program.HomePageData.ms07.TripStatus, motor_ms07);

            #region MS09: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.ms09.RunStatus, Program.HomePageData.ms09.TripStatus, motor_ms09);
            #endregion

            #region GGB: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.ggb.RunStatus, Program.HomePageData.ggb.TripStatus, motor_ggb);
            #endregion

            #region BB1: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.bb1.RunStatus, Program.HomePageData.bb1.TripStatus, motor_bb1);
            #endregion

            #region BB2: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.bb2.RunStatus, Program.HomePageData.bb2.TripStatus, motor_bb2);
            #endregion

            #region SP10: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.sp10.RunStatus, Program.HomePageData.sp10.TripStatus, motor_sp10);
            #endregion

            #region SP05A: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.sp05a.RunStatus, Program.HomePageData.sp05a.TripStatus, motor_sp05a);
            #endregion

            #region SP05B: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.sp05b.RunStatus, Program.HomePageData.sp05b.TripStatus, motor_sp05b);
            #endregion

            #region SP07A: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.sp07a.RunStatus, Program.HomePageData.sp07a.TripStatus, motor_sp07a);
            #endregion

            #region SP07B: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.sp07b.RunStatus, Program.HomePageData.sp07b.TripStatus, motor_sp07b);
            #endregion

            #region MTK01: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mtk01.RunStatus, Program.HomePageData.mtk01.TripStatus, motor_mtk01);
            #endregion

            #region MTK02: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mtk02.RunStatus, Program.HomePageData.mtk02.TripStatus, motor_mtk02);
            #endregion

            #region MTK03: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mtk03.RunStatus, Program.HomePageData.mtk03.TripStatus, motor_mtk03);
            #endregion

            #region AB06A: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.ab06a.RunStatus, Program.HomePageData.ab06a.TripStatus, motor_ab06a);
            #endregion

            #region AB06B: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.ab06b.RunStatus, Program.HomePageData.ab06b.TripStatus, motor_ab06b);
            #endregion

            #region AB06C: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.ab06c.RunStatus, Program.HomePageData.ab06c.TripStatus, motor_ab06c);
            #endregion

            #region MT-ETN: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mtetn.RunStatus, Program.HomePageData.mtetn.TripStatus, motor_mtetn);
            #endregion

            #region MT-03: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mt03.RunStatus, Program.HomePageData.mt03.TripStatus, motor_mt03);
            #endregion

            #region MT-05: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mt05.RunStatus, Program.HomePageData.mt05.TripStatus, motor_mt05);
            #endregion

            #region MT-06_1: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mt06_1.RunStatus, Program.HomePageData.mt06_1.TripStatus, motor_mt06_01p2);
            #endregion

            #region MT-06_2: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mt06_2.RunStatus, Program.HomePageData.mt06_2.TripStatus, motor_mt06_2p2);
            #endregion

            #region MT-04: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mt04.RunStatus, Program.HomePageData.mt04.TripStatus, motor_mt04);
            #endregion

            #region MC04: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mc04.RunStatus, Program.HomePageData.mc04.TripStatus, motor_mc04);
            #endregion

            #region MC04: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mc04.RunStatus, Program.HomePageData.mc04.TripStatus, motor_mc04);
            #endregion

            #region MC03: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mc03.RunStatus, Program.HomePageData.mc03.TripStatus, motor_mc03);
            #endregion

            #region MI03: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mi03.RunStatus, Program.HomePageData.mi03.TripStatus, motor_mi03);
            #endregion

            #region MI04A: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mi04a.RunStatus, Program.HomePageData.mi04a.TripStatus, motor_mi04a);
            #endregion
            #region MI04B: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mi04b.RunStatus, Program.HomePageData.mi04b.TripStatus, motor_mi04b);
            #endregion

            #region MT-01: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mt01.RunStatus, Program.HomePageData.mt01.TripStatus, motor_mt01);
            #endregion

            #region MT-02A: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mt02a.RunStatus, Program.HomePageData.mt02a.TripStatus, motor_mt02a);
            #endregion

            #region MT02B: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.mt02b.RunStatus, Program.HomePageData.mt02b.TripStatus, motor_mt02b);
            #endregion

            #region DPETN: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dpetn.RunStatus, Program.HomePageData.dpetn.TripStatus, motor_dpetn);
            #endregion

            #region DP-03: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp03.RunStatus, Program.HomePageData.dp03.TripStatus, motor_dp03);
            #endregion

            #region DP-05: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp05.RunStatus, Program.HomePageData.dp05.TripStatus, motor_dp05);
            #endregion

            #region DP06_1: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp06_1.RunStatus, Program.HomePageData.dp06_1.TripStatus, motor_dp06_01p2);
            #endregion

            #region DP06_2: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp06_2.RunStatus, Program.HomePageData.dp06_2.TripStatus, motor_dp06_2p2);
            #endregion

            #region DP04A: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp04a.RunStatus, Program.HomePageData.dp04a.TripStatus, motor_dp04a);
            #endregion

            #region DP04B: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp04b.RunStatus, Program.HomePageData.dp04b.TripStatus, motor_dp04b);
            #endregion

            #region DP03A: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp03a.RunStatus, Program.HomePageData.dp03a.TripStatus, motor_dp03a);
            #endregion

            #region DP03B: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp03b.RunStatus, Program.HomePageData.dp03b.TripStatus, motor_dp03b);
            #endregion

            #region DP05A: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp05a.RunStatus, Program.HomePageData.dp05a.TripStatus, motor_dp05a);
            #endregion

            #region DP05B: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp05b.RunStatus, Program.HomePageData.dp05b.TripStatus, motor_dp05b);
            #endregion

            #region DP06A: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp06a.RunStatus, Program.HomePageData.dp06a.TripStatus, motor_dp06a);
            #endregion

            #region DP06B: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp06b.RunStatus, Program.HomePageData.dp06b.TripStatus, motor_dp06b);
            #endregion

            #region DP09A: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp09a.RunStatus, Program.HomePageData.dp09a.TripStatus, motor_dp09a);
            #endregion

            #region DP-02: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp02.RunStatus, Program.HomePageData.dp02.TripStatus, motor_dp02);
            #endregion

            #region DP04: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp04.RunStatus, Program.HomePageData.dp04.TripStatus, motor_dp04);
            #endregion

            #region DP07A: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp07a.RunStatus, Program.HomePageData.dp07a.TripStatus, motor_dp07a);
            #endregion

            #region DP07B: KHUÂY ANOXIC 2
            FMotorControl.ShowStatus(Program.HomePageData.dp07b.RunStatus, Program.HomePageData.dp07b.TripStatus, motor_dp07b);
            #endregion

            #endregion
            #endregion

            #region PHAO BỂ GOM
            FFloatControl.showStatus_Float3Level(Convert.ToBoolean(Program.HomePageData.ll101.Value), 
             Convert.ToBoolean(Program.HomePageData.ml101.Value), Convert.ToBoolean(Program.HomePageData.hl101.Value),
             ll101_phaoBeGom_low,ml101_phaoBeGom_medium,hl101_phaoBeGom_high);
            #endregion

            #region PHAO BỂ ĐIỀU HÒA
            FFloatControl.showStatus_Float2Level(Convert.ToBoolean(Program.HomePageData.ll201.Value), Convert.ToBoolean(Program.HomePageData.hl201.Value),
                ll201_phaoBeDieuHoa_low, hl201_phaoBeDieuHoa_high);

            #endregion

            #region HL10: PHAO BỂ BÙN
            FFloatControl.showStatus_Float1Level(Convert.ToBoolean(Program.HomePageData.hl10.Value), hl10_phaoBeBun_high);
            #endregion

            #region HL05: PHAO BỂ BÙN
            FFloatControl.showStatus_Float1Level(Convert.ToBoolean(Program.HomePageData.hl05.Value),hl05_phaoBeBun_high);
            #endregion

            #region HL07: PHAO BỂ BÙN
            FFloatControl.showStatus_Float1Level(Convert.ToBoolean(Program.HomePageData.hl07.Value), hl07_phaoBeBun_high);
            #endregion
            
        }
        /// <summary>
        /// Phương thức: Thực hiện lặp lại BackWorker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void BackWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.backWorker.RunWorkerAsync();
        }

        #endregion
        
        /*
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Home";
            this.Text = "ỀU ";
            this.ResumeLayout(false);

        }
        */
    }
}
