using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Timers;
using System.Runtime.InteropServices;

using ElementBase_Template.PLC.Data_Mapping;
using ElementBase_Template.PLC.Data_Mapping.Engine;

using SymbolFactoryDotNet;
using ElementBase_Template.FormPlate.Faceplate;


namespace MP2_V01
{
    public partial class HOME : Form
    {
        #region FIELDS
        private int borderSize = 1;
        //private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.

        public short updatePeriod { get; set; } = 500;
        System.Timers.Timer timerHome1 = null;

        EngineCycle.PLC_GD1 newValue1 = null;

        bool trip, run;
        #endregion

        #region CONSTRUCTORS
        public HOME()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
        }
        #endregion

        #region METHOD
        public void updateEventHandler(object sender, ElapsedEventArgs e)
        {
            //Input.mtk01_runStatus = !Input.mtk01_runStatus;
            try
            {
                /// <summary>
                /// Mỹ phước giai đoạn 1 "GD1"
                /// </summary>

                #region Tín hiệu phao bể gom - OLD version
                /*
                if (Program.InputStatus_PLC1.low_beGom_float == true)
            {
                floatLow_GD1_beGom_homePage.DiscreteValue1 = false;
                floatLow_GD1_beGom_homePage.DiscreteValue2 = true; // Green
            }
                 else
            {
                floatLow_GD1_beGom_homePage.DiscreteValue2 = false; // Green
                floatLow_GD1_beGom_homePage.DiscreteValue1 = true; //Grey
            }

            if (Program.InputStatus_PLC1.medium_beGom_float)
            {
                floatMedium_GD1_beGom_homePage.DiscreteValue1 = false;
                floatMedium_GD1_beGom_homePage.DiscreteValue2 = true; // Green
            }
            else
            {
                floatMedium_GD1_beGom_homePage.DiscreteValue1 = true; //Grey
                floatMedium_GD1_beGom_homePage.DiscreteValue2 = false; // Green
            }

            if (Program.InputStatus_PLC1.high_beGom_float)
            {
                floatHigh_GD1_beGom_homePage.DiscreteValue1 = false;
                floatHigh_GD1_beGom_homePage.DiscreteValue2 = true; // Green
            }
            else
            {
                floatHigh_GD1_beGom_homePage.DiscreteValue1 = true; //Grey
                floatHigh_GD1_beGom_homePage.DiscreteValue2 = false; // Green
            }
            */
                #endregion

                #region MỨC PHAO BỂ GOM
                // Mức thấp: Signal= true => low level
                bool lowValue = Program.InputStatus_PLC1.low_beGom_float;
                bool mediValue = Program.InputStatus_PLC1.medium_beGom_float;
                bool highValue = Program.InputStatus_PLC1.high_beGom_float;

                switch (lowValue)
                {
                    case false: // 0xx
                        switch (mediValue)
                        {
                            case false: // 00x
                                switch (highValue)
                                {
                                    case false: //=> LOW LEVEL
                                                // LOW LIGHT: TURN ON
                                        floatLow_GD1_beGom_homePage.DiscreteValue1 = true;
                                        floatLow_GD1_beGom_homePage.DiscreteValue2 = false;
                                        floatLow_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // MEDIUM LIGHT: TURN OFF
                                        floatMedium_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // HIGH LIGHT: TURN OFF
                                        floatHigh_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue3 = false;
                                        break;
                                    case true: // FLOAT ERROR : L-M-H: 001 => ALARM (H)
                                               // LOW LIGHT: TURN OFF
                                        floatLow_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatLow_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatLow_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // MEDIUM LIGHT: TURN OFF
                                        floatMedium_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // HIGH LIGHT: BLINK WITH YELLOW COLOR
                                        floatHigh_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue2 = false;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue3 = true;
                                        break;

                                }
                                break;
                            case true: // 01x
                                switch (highValue)
                                {
                                    case false: // 010 => ALARM (M)
                                                // LOW LIGHT: TURN OFF
                                        floatLow_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatLow_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatLow_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // MEDIUM LIGHT: BLINK WITH YELLOW COLOR
                                        floatMedium_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue2 = false;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue3 = true;
                                        // HIGH LIGHT: TURN OFF
                                        floatHigh_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue3 = false;
                                        break;
                                    case true: // FLOAT ERROR : L-M-H: 011 => ALARM (L)
                                               // LOW LIGHT: BLINK WITH YELLOW COLOR
                                        floatLow_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatLow_GD1_beGom_homePage.DiscreteValue2 = false;
                                        floatLow_GD1_beGom_homePage.DiscreteValue3 = true;
                                        // MEDIUM LIGHT: TURN OFF
                                        floatMedium_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // HIGH LIGHT: TURN OFF
                                        floatHigh_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue3 = false;
                                        break;

                                }
                                break;
                        }
                        break;
                    case true: // 1xx
                        switch (mediValue)
                        {
                            case false: // 10x
                                switch (highValue)
                                {
                                    case false: // 100 => LOW LEVEL
                                                // LOW LIGHT: TURN ON
                                        floatLow_GD1_beGom_homePage.DiscreteValue1 = true;
                                        floatLow_GD1_beGom_homePage.DiscreteValue2 = false;
                                        floatLow_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // MEDIUM LIGHT: TURN OFF
                                        floatMedium_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // HIGH LIGHT: TURN OFF
                                        floatHigh_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue3 = false;
                                        break;
                                    case true: // FLOAT ERROR : L-M-H: 101 => ALARM (H)
                                               // LOW LIGHT: TURN OFF
                                        floatLow_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatLow_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatLow_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // MEDIUM LIGHT: TURN OFF
                                        floatMedium_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // HIGH LIGHT: BLINK WITH YELLOW COLOR
                                        floatHigh_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue2 = false;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue3 = true;
                                        break;

                                }
                                break;
                            case true: // 11x
                                switch (highValue)
                                {
                                    case false: // L-M-H: 110 => MEDIUM LEVEL
                                                // LOW LIGHT: TURN OFF
                                        floatLow_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatLow_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatLow_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // MEDIUM LIGHT: TURN ON
                                        floatMedium_GD1_beGom_homePage.DiscreteValue1 = true;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue2 = false;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // HIGH LIGHT: TURN OFF
                                        floatHigh_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue3 = false;
                                        break;
                                    case true: // L-M-H: 111 => HIGH LEVEL
                                               // LOW LIGHT: TURN OFF
                                        floatLow_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatLow_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatLow_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // MEDIUM LIGHT: TURN OFF
                                        floatMedium_GD1_beGom_homePage.DiscreteValue1 = false;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue2 = true;
                                        floatMedium_GD1_beGom_homePage.DiscreteValue3 = false;
                                        // HIGH LIGHT: TURN ON
                                        floatHigh_GD1_beGom_homePage.DiscreteValue1 = true;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue2 = false;
                                        floatHigh_GD1_beGom_homePage.DiscreteValue3 = false;
                                        break;

                                }
                                break;
                        }
                        break;
                }

                #endregion

                #region Tín hiệu phao bể điều hòa

                if ((Program.InputStatus_PLC3.low_dieuHoa_float == false) && (Program.InputStatus_PLC3.high_dieuHoa_float == false))
                {
                    floatLow_GD1_beDieuHoa_mainPage.DiscreteValue1 = false; // Off
                    floatLow_GD1_beDieuHoa_mainPage.DiscreteValue2 = false; // Green
                    floatLow_GD1_beDieuHoa_mainPage.DiscreteValue3 = false; // Blink Yellow

                    floatHigh_GD1_beDieuHoa_mainPage.DiscreteValue1 = false; // Off
                    floatHigh_GD1_beDieuHoa_mainPage.DiscreteValue2 = false; // Green
                    floatHigh_GD1_beDieuHoa_mainPage.DiscreteValue3 = false; // Blink Yellow
                }

                if ((Program.InputStatus_PLC3.low_dieuHoa_float == false) && (Program.InputStatus_PLC3.high_dieuHoa_float == true))
                {
                    floatLow_GD1_beDieuHoa_mainPage.DiscreteValue1 = false; // Off
                    floatLow_GD1_beDieuHoa_mainPage.DiscreteValue2 = false; // Green
                    floatLow_GD1_beDieuHoa_mainPage.DiscreteValue3 = true; // Blink Yellow

                    floatHigh_GD1_beDieuHoa_mainPage.DiscreteValue1 = false; // Off
                    floatHigh_GD1_beDieuHoa_mainPage.DiscreteValue2 = false; // Green
                    floatHigh_GD1_beDieuHoa_mainPage.DiscreteValue3 = true; // Blink Yellow
                }

                if ((Program.InputStatus_PLC3.low_dieuHoa_float == true) && (Program.InputStatus_PLC3.high_dieuHoa_float == false))
                {
                    floatLow_GD1_beDieuHoa_mainPage.DiscreteValue1 = false; // Off
                    floatLow_GD1_beDieuHoa_mainPage.DiscreteValue2 = true; // Green
                    floatLow_GD1_beDieuHoa_mainPage.DiscreteValue3 = false; // Blink Yellow

                    floatHigh_GD1_beDieuHoa_mainPage.DiscreteValue1 = false; // Off
                    floatHigh_GD1_beDieuHoa_mainPage.DiscreteValue2 = false; // Green
                    floatHigh_GD1_beDieuHoa_mainPage.DiscreteValue3 = false; // Blink Yellow
                }

                if ((Program.InputStatus_PLC3.low_dieuHoa_float == true) && (Program.InputStatus_PLC3.high_dieuHoa_float == true))
                {
                    floatLow_GD1_beDieuHoa_mainPage.DiscreteValue1 = false; // Off
                    floatLow_GD1_beDieuHoa_mainPage.DiscreteValue2 = false; // Green
                    floatLow_GD1_beDieuHoa_mainPage.DiscreteValue3 = false; // Blink Yellow

                    floatHigh_GD1_beDieuHoa_mainPage.DiscreteValue1 = false; // Off
                    floatHigh_GD1_beDieuHoa_mainPage.DiscreteValue2 = true; // Green
                    floatHigh_GD1_beDieuHoa_mainPage.DiscreteValue3 = false; // Blink Yellow
                }
                #endregion

                #region Tín hiệu phao bể bùn

                if (Program.InputStatus_PLC3.float_beBun05_float)
                {
                    floatHigh_SP05_beBun_homePage.DiscreteValue1 = false;
                    floatHigh_SP05_beBun_homePage.DiscreteValue2 = true; // Green
                }
                else
                {
                    floatHigh_SP05_beBun_homePage.DiscreteValue1 = true; //Grey
                    floatHigh_SP05_beBun_homePage.DiscreteValue2 = false; // Green
                }

                if (Program.InputStatus_PLC3.float_beBun07_float)
                {
                    floatHigh_SP07_beBun_homePage.DiscreteValue1 = false;
                    floatHigh_SP07_beBun_homePage.DiscreteValue2 = true; // Green
                }
                else
                {
                    floatHigh_SP07_beBun_homePage.DiscreteValue1 = true; //Grey
                    floatHigh_SP07_beBun_homePage.DiscreteValue2 = false; // Green
                }

                if (Program.InputStatus_PLC3.float_beBunSP10_float)
                {
                    floatHigh_SP10_beBun_homePage.DiscreteValue1 = false;
                    floatHigh_SP10_beBun_homePage.DiscreteValue2 = true; // Green
                }
                else
                {
                    floatHigh_SP10_beBun_homePage.DiscreteValue1 = true; //Grey
                    floatHigh_SP10_beBun_homePage.DiscreteValue2 = false; // Green
                }
                #endregion



                #region Chỉ số quan trắc nước thải
                // CHỈ SỐ COD
                tb_codIndex_mainPage.BeginInvoke((MethodInvoker)delegate
                {
                    tb_codIndex_mainPage.Text = Program.QuanTracIndex_PLC1.cod_Index.ToString();
                });
                // CHỈ SỐ NH3
                tb_nh3Index_mainPage.BeginInvoke((MethodInvoker)delegate
                {
                    tb_nh3Index_mainPage.Text = Program.QuanTracIndex_PLC1.nh3_Index.ToString();
                });
                // CHỈ SỐ TSS
                tb_tssIndex_mainPage.BeginInvoke((MethodInvoker)delegate
                {
                    tb_tssIndex_mainPage.Text = Program.QuanTracIndex_PLC1.tss_Index.ToString();
                });
                // CHỈ SỐ PH
                tb_phIndex_mainPage.BeginInvoke((MethodInvoker)delegate
                {
                    tb_phIndex_mainPage.Text = Program.QuanTracIndex_PLC1.ph_Index.ToString();
                });
                // CHỈ SỐ COLOR
                tb_colorIndex_mainPage.BeginInvoke((MethodInvoker)delegate
                {
                    tb_colorIndex_mainPage.Text = Program.QuanTracIndex_PLC1.color_Index.ToString();
                });
                // CHỈ SỐ TEMPERATURE
                tb_temperIndex_mainPage.BeginInvoke((MethodInvoker)delegate
                {
                    tb_temperIndex_mainPage.Text = Program.QuanTracIndex_PLC1.temper_Index.ToString();
                });

                // Công suất NT đầu ra => Hiển thị trên bảng table
                tb_flowOutCap_mainPage_table.BeginInvoke((MethodInvoker)delegate
                {
                    tb_flowOutCap_mainPage_table.Text = Program.QuanTracIndex_PLC1.flowOutCap.ToString();
                });
                // Công suất NT đầu vào => Hiển thị trên bảng table
                tb_flowInCap_mainPage_table.BeginInvoke((MethodInvoker)delegate
                {
                    tb_flowInCap_mainPage_table.Text = Program.QuanTracIndex_PLC1.flowInCap.ToString();
                });

                // Công suất NT đầu ra
                tb_flowOutCap_mainPage.BeginInvoke((MethodInvoker)delegate
                {
                    tb_flowOutCap_mainPage.Text = Program.QuanTracIndex_PLC1.flowOutCap.ToString();
                });
                // Công suất NT đầu vào
                tb_flowInCap_mainPage.BeginInvoke((MethodInvoker)delegate
                {
                    tb_flowInCap_mainPage.Text = Program.QuanTracIndex_PLC1.flowInCap.ToString();
                });

                // Tổng nước thải đầu vào
                tb_flowInTotal_mainPage.BeginInvoke((MethodInvoker)delegate
                {
                    tb_flowInTotal_mainPage.Text = Program.QuanTracIndex_PLC1.flowInTotal.ToString();
                });

                // Tổng nước thải đầu ra
                tb_flowOutTotal_mainPage.BeginInvoke((MethodInvoker)delegate
                {
                    tb_flowOutTotal_mainPage.Text = Program.QuanTracIndex_PLC1.flowOutTotal.ToString();
                });

                #endregion

                #region Trạng thái RUN/ TRIP tải
                //VỊ TRÍ: BỂ GOM
                #region Bơm bể gom P0101
                // Bơm bể gom P0101
                if (Program.InputStatus_PLC1.beGom1_runStatus == true && Program.InputStatus_PLC1.beGom1_tripStatus == false)
                {
                    thuGomPump_p0101_mainPage.DiscreteValue1 = false;
                    thuGomPump_p0101_mainPage.DiscreteValue2 = true;
                    thuGomPump_p0101_mainPage.DiscreteValue3 = false;
                    thuGomPump_p0101_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.beGom1_runStatus == false && Program.InputStatus_PLC1.beGom1_tripStatus == true)
                {
                    thuGomPump_p0101_mainPage.DiscreteValue1 = false;
                    thuGomPump_p0101_mainPage.DiscreteValue2 = false;
                    thuGomPump_p0101_mainPage.DiscreteValue3 = true;
                    thuGomPump_p0101_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.beGom1_runStatus == true && Program.InputStatus_PLC1.beGom1_tripStatus == true)
                {
                    thuGomPump_p0101_mainPage.DiscreteValue1 = false;
                    thuGomPump_p0101_mainPage.DiscreteValue2 = false;
                    thuGomPump_p0101_mainPage.DiscreteValue3 = false;
                    thuGomPump_p0101_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    thuGomPump_p0101_mainPage.DiscreteValue1 = true;
                    thuGomPump_p0101_mainPage.DiscreteValue2 = false;
                    thuGomPump_p0101_mainPage.DiscreteValue3 = false;
                    thuGomPump_p0101_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region Bơm bể gom P0102
                // Bơm bể gom P0102
                if (Program.InputStatus_PLC1.beGom2_runStatus == true && Program.InputStatus_PLC1.beGom2_tripStatus == false)
                {
                    thuGomPump_p0102_mainPage.DiscreteValue1 = false;
                    thuGomPump_p0102_mainPage.DiscreteValue2 = true;
                    thuGomPump_p0102_mainPage.DiscreteValue3 = false;
                    thuGomPump_p0102_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.beGom2_runStatus == false && Program.InputStatus_PLC1.beGom2_tripStatus == true)
                {
                    thuGomPump_p0102_mainPage.DiscreteValue1 = false;
                    thuGomPump_p0102_mainPage.DiscreteValue2 = false;
                    thuGomPump_p0102_mainPage.DiscreteValue3 = true;
                    thuGomPump_p0102_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.beGom2_runStatus == true && Program.InputStatus_PLC1.beGom2_tripStatus == true)
                {
                    thuGomPump_p0102_mainPage.DiscreteValue1 = false;
                    thuGomPump_p0102_mainPage.DiscreteValue2 = false;
                    thuGomPump_p0102_mainPage.DiscreteValue3 = false;
                    thuGomPump_p0102_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    thuGomPump_p0102_mainPage.DiscreteValue1 = true;
                    thuGomPump_p0102_mainPage.DiscreteValue2 = false;
                    thuGomPump_p0102_mainPage.DiscreteValue3 = false;
                    thuGomPump_p0102_mainPage.DiscreteValue4 = false;
                }
                #endregion

                ////FOR TESTING-------------------------------------------------------
                //Console.WriteLine("P0103 1: ");
                //Console.WriteLine(Program.InputStatus_PLC1.beGom3_runStatus);
                //Console.WriteLine(Program.InputStatus_PLC1.beGom3_tripStatus);

                #region Bơm bể gom P0103
                // Bơm bể gom P0103
                if ((Program.InputStatus_PLC1.beGom3_runStatus == true) & (Program.InputStatus_PLC1.beGom3_tripStatus == false))
                {

                    Program.homePage.thuGomPump_p0103_mainPage.DiscreteValue1 = false;
                    Program.homePage.thuGomPump_p0103_mainPage.DiscreteValue2 = true;
                    Program.homePage.thuGomPump_p0103_mainPage.DiscreteValue3 = false;
                    Program.homePage.thuGomPump_p0103_mainPage.DiscreteValue4 = false;

                    //thuGomPump_p0103_mainPage.DiscreteValue1 = false;
                    //thuGomPump_p0103_mainPage.DiscreteValue2 = true;
                    //thuGomPump_p0103_mainPage.DiscreteValue3 = false;
                    //thuGomPump_p0103_mainPage.DiscreteValue4 = false;
                }
                else if ((Program.InputStatus_PLC1.beGom3_runStatus == false) & (Program.InputStatus_PLC1.beGom3_tripStatus == true))
                {
                    thuGomPump_p0103_mainPage.DiscreteValue1 = false;
                    thuGomPump_p0103_mainPage.DiscreteValue2 = false;
                    thuGomPump_p0103_mainPage.DiscreteValue3 = true;
                    thuGomPump_p0103_mainPage.DiscreteValue4 = false;
                }
                else if ((Program.InputStatus_PLC1.beGom3_runStatus == true) & (Program.InputStatus_PLC1.beGom3_tripStatus == true))
                {
                    thuGomPump_p0103_mainPage.DiscreteValue1 = false;
                    thuGomPump_p0103_mainPage.DiscreteValue2 = false;
                    thuGomPump_p0103_mainPage.DiscreteValue3 = false;
                    thuGomPump_p0103_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    thuGomPump_p0103_mainPage.DiscreteValue1 = true;
                    thuGomPump_p0103_mainPage.DiscreteValue2 = false;
                    thuGomPump_p0103_mainPage.DiscreteValue3 = false;
                    thuGomPump_p0103_mainPage.DiscreteValue4 = false;
                }
                #endregion

                // BỂ ĐIỀU HÒA
                #region Bơm điều hòa P201
                // Bơm điều hòa P201
                if (Program.InputStatus_PLC1.dieuHoa1_runStatus == true && Program.InputStatus_PLC1.dieuHoa1_tripStatus == false)
                {
                    dieuHoaPump_p0201_mainPage.DiscreteValue1 = false;
                    dieuHoaPump_p0201_mainPage.DiscreteValue2 = true;
                    dieuHoaPump_p0201_mainPage.DiscreteValue3 = false;
                    dieuHoaPump_p0201_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dieuHoa1_runStatus == false && Program.InputStatus_PLC1.dieuHoa1_tripStatus == true)
                {
                    dieuHoaPump_p0201_mainPage.DiscreteValue1 = false;
                    dieuHoaPump_p0201_mainPage.DiscreteValue2 = false;
                    dieuHoaPump_p0201_mainPage.DiscreteValue3 = true;
                    dieuHoaPump_p0201_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dieuHoa1_runStatus == true && Program.InputStatus_PLC1.dieuHoa1_tripStatus == true)
                {
                    dieuHoaPump_p0201_mainPage.DiscreteValue1 = false;
                    dieuHoaPump_p0201_mainPage.DiscreteValue2 = false;
                    dieuHoaPump_p0201_mainPage.DiscreteValue3 = false;
                    dieuHoaPump_p0201_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    dieuHoaPump_p0201_mainPage.DiscreteValue1 = true;
                    dieuHoaPump_p0201_mainPage.DiscreteValue2 = false;
                    dieuHoaPump_p0201_mainPage.DiscreteValue3 = false;
                    dieuHoaPump_p0201_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region Bơm điều hòa "P202"
                // Bơm điều hòa "P202" dieuHoaPump_p0202_mainPage
                if (Program.InputStatus_PLC1.dieuHoa2_runStatus == true && Program.InputStatus_PLC1.dieuHoa2_tripStatus == false)
                {
                    dieuHoaPump_p0202_mainPage.DiscreteValue1 = false;
                    dieuHoaPump_p0202_mainPage.DiscreteValue2 = true;
                    dieuHoaPump_p0202_mainPage.DiscreteValue3 = false;
                    dieuHoaPump_p0202_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dieuHoa2_runStatus == false && Program.InputStatus_PLC1.dieuHoa2_tripStatus == true)
                {
                    dieuHoaPump_p0202_mainPage.DiscreteValue1 = false;
                    dieuHoaPump_p0202_mainPage.DiscreteValue2 = false;
                    dieuHoaPump_p0202_mainPage.DiscreteValue3 = true;
                    dieuHoaPump_p0202_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dieuHoa2_runStatus == true && Program.InputStatus_PLC1.dieuHoa2_tripStatus == true)
                {
                    dieuHoaPump_p0202_mainPage.DiscreteValue1 = false;
                    dieuHoaPump_p0202_mainPage.DiscreteValue2 = false;
                    dieuHoaPump_p0202_mainPage.DiscreteValue3 = false;
                    dieuHoaPump_p0202_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    dieuHoaPump_p0202_mainPage.DiscreteValue1 = true;
                    dieuHoaPump_p0202_mainPage.DiscreteValue2 = false;
                    dieuHoaPump_p0202_mainPage.DiscreteValue3 = false;
                    dieuHoaPump_p0202_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY TÁCH RÁC "BS02A" - GD2
                if (Program.InputStatus_PLC3.mayTachRac_runStatus == true && Program.InputStatus_PLC3.mayTachRac_tripStatus == false)
                {
                    mayTachRac_bs02a_homePage.DiscreteValue1 = false;
                    mayTachRac_bs02a_homePage.DiscreteValue2 = true;
                    mayTachRac_bs02a_homePage.DiscreteValue3 = false;
                    mayTachRac_bs02a_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.mayTachRac_runStatus == false && Program.InputStatus_PLC3.mayTachRac_tripStatus == true)
                {
                    mayTachRac_bs02a_homePage.DiscreteValue1 = false;
                    mayTachRac_bs02a_homePage.DiscreteValue2 = false;
                    mayTachRac_bs02a_homePage.DiscreteValue3 = true;
                    mayTachRac_bs02a_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.mayTachRac_runStatus == true && Program.InputStatus_PLC3.mayTachRac_tripStatus == true)
                {
                    mayTachRac_bs02a_homePage.DiscreteValue1 = false;
                    mayTachRac_bs02a_homePage.DiscreteValue2 = false;
                    mayTachRac_bs02a_homePage.DiscreteValue3 = false;
                    mayTachRac_bs02a_homePage.DiscreteValue4 = true;
                }
                else
                {
                    mayTachRac_bs02a_homePage.DiscreteValue1 = true;
                    mayTachRac_bs02a_homePage.DiscreteValue2 = false;
                    mayTachRac_bs02a_homePage.DiscreteValue3 = false;
                    mayTachRac_bs02a_homePage.DiscreteValue4 = false;
                }
                #endregion

                #region BƠM NƯỚC THẢI 02A "WP02A" - GD2
                if (Program.InputStatus_PLC3.bomNt_02A_runStatus == true && Program.InputStatus_PLC3.bomNt_02A_tripStatus == false)
                {
                    bomNt_wp02a_mainPage.DiscreteValue1 = false;
                    bomNt_wp02a_mainPage.DiscreteValue2 = true;
                    bomNt_wp02a_mainPage.DiscreteValue3 = false;
                    bomNt_wp02a_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomNt_02A_runStatus == false && Program.InputStatus_PLC3.bomNt_02A_tripStatus == true)
                {
                    bomNt_wp02a_mainPage.DiscreteValue1 = false;
                    bomNt_wp02a_mainPage.DiscreteValue2 = false;
                    bomNt_wp02a_mainPage.DiscreteValue3 = true;
                    bomNt_wp02a_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomNt_02A_runStatus == true && Program.InputStatus_PLC3.bomNt_02A_tripStatus == true)
                {
                    bomNt_wp02a_mainPage.DiscreteValue1 = false;
                    bomNt_wp02a_mainPage.DiscreteValue2 = false;
                    bomNt_wp02a_mainPage.DiscreteValue3 = false;
                    bomNt_wp02a_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    bomNt_wp02a_mainPage.DiscreteValue1 = true;
                    bomNt_wp02a_mainPage.DiscreteValue2 = false;
                    bomNt_wp02a_mainPage.DiscreteValue3 = false;
                    bomNt_wp02a_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region BƠM NƯỚC THẢI 02B "WP02B" - GD2
                if (Program.InputStatus_PLC3.bomNt_02B_runStatus == true && Program.InputStatus_PLC3.bomNt_02B_tripStatus == false)
                {
                    bomNt_wp02b_mainPage.DiscreteValue1 = false;
                    bomNt_wp02b_mainPage.DiscreteValue2 = true;
                    bomNt_wp02b_mainPage.DiscreteValue3 = false;
                    bomNt_wp02b_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomNt_02B_runStatus == false && Program.InputStatus_PLC3.bomNt_02B_tripStatus == true)
                {
                    bomNt_wp02b_mainPage.DiscreteValue1 = false;
                    bomNt_wp02b_mainPage.DiscreteValue2 = false;
                    bomNt_wp02b_mainPage.DiscreteValue3 = true;
                    bomNt_wp02b_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomNt_02B_runStatus == true && Program.InputStatus_PLC3.bomNt_02B_tripStatus == true)
                {
                    bomNt_wp02b_mainPage.DiscreteValue1 = false;
                    bomNt_wp02b_mainPage.DiscreteValue2 = false;
                    bomNt_wp02b_mainPage.DiscreteValue3 = false;
                    bomNt_wp02b_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    bomNt_wp02b_mainPage.DiscreteValue1 = true;
                    bomNt_wp02b_mainPage.DiscreteValue2 = false;
                    bomNt_wp02b_mainPage.DiscreteValue3 = false;
                    bomNt_wp02b_mainPage.DiscreteValue4 = false;
                }
                #endregion

                //VỊ TRÍ: BỂ "ANOXIC"
                #region MÁY KHUẤY ANOXIC1 "SM01"
                if (Program.InputStatus_PLC2.anoxic1_runStatus == true && Program.InputStatus_PLC2.anoxic1_tripStatus == false)
                {
                    anoxicMotor_sm01_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm01_mainPage.DiscreteValue2 = true;
                    anoxicMotor_sm01_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm01_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic1_runStatus == false && Program.InputStatus_PLC2.anoxic1_tripStatus == true)
                {
                    anoxicMotor_sm01_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm01_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm01_mainPage.DiscreteValue3 = true;
                    anoxicMotor_sm01_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic1_runStatus == true && Program.InputStatus_PLC2.anoxic1_tripStatus == true)
                {
                    anoxicMotor_sm01_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm01_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm01_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm01_mainPage.DiscreteValue4 = true;
                }
                else if (Program.InputStatus_PLC2.anoxic1_runStatus == false && Program.InputStatus_PLC2.anoxic1_tripStatus == false)
                {
                    anoxicMotor_sm01_mainPage.DiscreteValue1 = true;
                    anoxicMotor_sm01_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm01_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm01_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY ANOXIC2 "SM02"
                if (Program.InputStatus_PLC2.anoxic2_runStatus == true && Program.InputStatus_PLC2.anoxic2_tripStatus == false)
                {
                    anoxicMotor_sm02_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm02_mainPage.DiscreteValue2 = true;
                    anoxicMotor_sm02_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm02_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic2_runStatus == false && Program.InputStatus_PLC2.anoxic2_tripStatus == true)
                {
                    anoxicMotor_sm02_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm02_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm02_mainPage.DiscreteValue3 = true;
                    anoxicMotor_sm02_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic2_runStatus == true && Program.InputStatus_PLC2.anoxic2_tripStatus == true)
                {
                    anoxicMotor_sm02_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm02_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm02_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm02_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    anoxicMotor_sm02_mainPage.DiscreteValue1 = true;
                    anoxicMotor_sm02_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm02_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm02_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY ANOXIC3 "SM03"
                if (Program.InputStatus_PLC2.anoxic3_runStatus == true && Program.InputStatus_PLC2.anoxic3_tripStatus == false)
                {
                    anoxicMotor_sm03_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm03_mainPage.DiscreteValue2 = true;
                    anoxicMotor_sm03_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm03_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic3_runStatus == false && Program.InputStatus_PLC2.anoxic3_tripStatus == true)
                {
                    anoxicMotor_sm03_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm03_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm03_mainPage.DiscreteValue3 = true;
                    anoxicMotor_sm03_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic3_runStatus == true && Program.InputStatus_PLC2.anoxic3_tripStatus == true)
                {
                    anoxicMotor_sm03_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm03_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm03_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm03_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    anoxicMotor_sm03_mainPage.DiscreteValue1 = true;
                    anoxicMotor_sm03_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm03_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm03_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY ANOXIC4 "SM04"
                if (Program.InputStatus_PLC2.anoxic4_runStatus == true && Program.InputStatus_PLC2.anoxic4_tripStatus == false)
                {
                    anoxicMotor_sm04_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm04_mainPage.DiscreteValue2 = true;
                    anoxicMotor_sm04_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm04_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic4_runStatus == false && Program.InputStatus_PLC2.anoxic4_tripStatus == true)
                {
                    anoxicMotor_sm04_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm04_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm04_mainPage.DiscreteValue3 = true;
                    anoxicMotor_sm04_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic4_runStatus == true && Program.InputStatus_PLC2.anoxic4_tripStatus == true)
                {
                    anoxicMotor_sm04_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm04_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm04_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm04_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    anoxicMotor_sm04_mainPage.DiscreteValue1 = true;
                    anoxicMotor_sm04_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm04_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm04_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY ANOXIC5 "SM05"
                if (Program.InputStatus_PLC2.anoxic5_runStatus == true && Program.InputStatus_PLC2.anoxic5_tripStatus == false)
                {
                    anoxicMotor_sm05_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm05_mainPage.DiscreteValue2 = true;
                    anoxicMotor_sm05_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm05_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic5_runStatus == false && Program.InputStatus_PLC2.anoxic5_tripStatus == true)
                {
                    anoxicMotor_sm05_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm05_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm05_mainPage.DiscreteValue3 = true;
                    anoxicMotor_sm05_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic5_runStatus == true && Program.InputStatus_PLC2.anoxic5_tripStatus == true)
                {
                    anoxicMotor_sm05_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm05_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm05_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm05_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    anoxicMotor_sm05_mainPage.DiscreteValue1 = true;
                    anoxicMotor_sm05_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm05_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm05_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY ANOXIC6 "SM06"
                if (Program.InputStatus_PLC2.anoxic6_runStatus == true && Program.InputStatus_PLC2.anoxic6_tripStatus == false)
                {
                    anoxicMotor_sm06_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm06_mainPage.DiscreteValue2 = true;
                    anoxicMotor_sm06_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm06_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic6_runStatus == false && Program.InputStatus_PLC2.anoxic6_tripStatus == true)
                {
                    anoxicMotor_sm06_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm06_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm06_mainPage.DiscreteValue3 = true;
                    anoxicMotor_sm06_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic6_runStatus == true && Program.InputStatus_PLC2.anoxic6_tripStatus == true)
                {
                    anoxicMotor_sm06_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm06_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm06_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm06_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    anoxicMotor_sm06_mainPage.DiscreteValue1 = true;
                    anoxicMotor_sm06_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm06_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm06_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY ANOXIC7 "SM07"
                if (Program.InputStatus_PLC2.anoxic7_runStatus == true && Program.InputStatus_PLC2.anoxic7_tripStatus == false)
                {
                    anoxicMotor_sm07_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm07_mainPage.DiscreteValue2 = true;
                    anoxicMotor_sm07_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm07_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic7_runStatus == false && Program.InputStatus_PLC2.anoxic7_tripStatus == true)
                {
                    anoxicMotor_sm07_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm07_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm07_mainPage.DiscreteValue3 = true;
                    anoxicMotor_sm07_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic7_runStatus == true && Program.InputStatus_PLC2.anoxic7_tripStatus == true)
                {
                    anoxicMotor_sm07_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm07_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm07_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm07_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    anoxicMotor_sm07_mainPage.DiscreteValue1 = true;
                    anoxicMotor_sm07_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm07_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm07_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY ANOXIC8 "SM08"
                if (Program.InputStatus_PLC2.anoxic8_runStatus == true && Program.InputStatus_PLC2.anoxic8_tripStatus == false)
                {
                    anoxicMotor_sm08_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm08_mainPage.DiscreteValue2 = true;
                    anoxicMotor_sm08_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm08_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic8_runStatus == false && Program.InputStatus_PLC2.anoxic8_tripStatus == true)
                {
                    anoxicMotor_sm08_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm08_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm08_mainPage.DiscreteValue3 = true;
                    anoxicMotor_sm08_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.anoxic8_runStatus == true && Program.InputStatus_PLC2.anoxic8_tripStatus == true)
                {
                    anoxicMotor_sm08_mainPage.DiscreteValue1 = false;
                    anoxicMotor_sm08_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm08_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm08_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    anoxicMotor_sm08_mainPage.DiscreteValue1 = true;
                    anoxicMotor_sm08_mainPage.DiscreteValue2 = false;
                    anoxicMotor_sm08_mainPage.DiscreteValue3 = false;
                    anoxicMotor_sm08_mainPage.DiscreteValue4 = false;
                }
                #endregion



                // VỊ TRÍ: BỂ AEROTANK 
                // BƠM TUẦN HOÀN
                #region BƠM TUẦN HOÀN 1 "TH1"
                if (Program.InputStatus_PLC2.tuanHoan1_runStatus == true && Program.InputStatus_PLC2.tuanHoan1_tripStatus == false)
                {
                    aeroPump_th1_mainPage.DiscreteValue1 = false;
                    aeroPump_th1_mainPage.DiscreteValue2 = true;
                    aeroPump_th1_mainPage.DiscreteValue3 = false;
                    aeroPump_th1_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.tuanHoan1_runStatus == false && Program.InputStatus_PLC2.tuanHoan1_tripStatus == true)
                {
                    aeroPump_th1_mainPage.DiscreteValue1 = false;
                    aeroPump_th1_mainPage.DiscreteValue2 = false;
                    aeroPump_th1_mainPage.DiscreteValue3 = true;
                    aeroPump_th1_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.tuanHoan1_runStatus == true && Program.InputStatus_PLC2.tuanHoan1_tripStatus == true)
                {
                    aeroPump_th1_mainPage.DiscreteValue1 = false;
                    aeroPump_th1_mainPage.DiscreteValue2 = false;
                    aeroPump_th1_mainPage.DiscreteValue3 = false;
                    aeroPump_th1_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    aeroPump_th1_mainPage.DiscreteValue1 = true;
                    aeroPump_th1_mainPage.DiscreteValue2 = false;
                    aeroPump_th1_mainPage.DiscreteValue3 = false;
                    aeroPump_th1_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region BƠM TUẦN HOÀN 2 "TH2"
                if (Program.InputStatus_PLC2.tuanHoan2_runStatus == true && Program.InputStatus_PLC2.tuanHoan2_tripStatus == false)
                {
                    aeroPump_th2_mainPage.DiscreteValue1 = false;
                    aeroPump_th2_mainPage.DiscreteValue2 = true;
                    aeroPump_th2_mainPage.DiscreteValue3 = false;
                    aeroPump_th2_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.tuanHoan2_runStatus == false && Program.InputStatus_PLC2.tuanHoan2_tripStatus == true)
                {
                    aeroPump_th2_mainPage.DiscreteValue1 = false;
                    aeroPump_th2_mainPage.DiscreteValue2 = false;
                    aeroPump_th2_mainPage.DiscreteValue3 = true;
                    aeroPump_th2_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.tuanHoan2_runStatus == true && Program.InputStatus_PLC2.tuanHoan2_tripStatus == true)
                {
                    aeroPump_th2_mainPage.DiscreteValue1 = false;
                    aeroPump_th2_mainPage.DiscreteValue2 = false;
                    aeroPump_th2_mainPage.DiscreteValue3 = false;
                    aeroPump_th2_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    aeroPump_th2_mainPage.DiscreteValue1 = true;
                    aeroPump_th2_mainPage.DiscreteValue2 = false;
                    aeroPump_th2_mainPage.DiscreteValue3 = false;
                    aeroPump_th2_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region BƠM TUẦN HOÀN 3 "TH3"
                if (Program.InputStatus_PLC2.tuanHoan3_runStatus == true && Program.InputStatus_PLC2.tuanHoan3_tripStatus == false)
                {
                    aeroPump_th3_mainPage.DiscreteValue1 = false;
                    aeroPump_th3_mainPage.DiscreteValue2 = true;
                    aeroPump_th3_mainPage.DiscreteValue3 = false;
                    aeroPump_th3_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.tuanHoan3_runStatus == false && Program.InputStatus_PLC2.tuanHoan3_tripStatus == true)
                {
                    aeroPump_th3_mainPage.DiscreteValue1 = false;
                    aeroPump_th3_mainPage.DiscreteValue2 = false;
                    aeroPump_th3_mainPage.DiscreteValue3 = true;
                    aeroPump_th3_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.tuanHoan3_runStatus == true && Program.InputStatus_PLC2.tuanHoan3_tripStatus == true)
                {
                    aeroPump_th3_mainPage.DiscreteValue1 = false;
                    aeroPump_th3_mainPage.DiscreteValue2 = false;
                    aeroPump_th3_mainPage.DiscreteValue3 = false;
                    aeroPump_th3_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    aeroPump_th3_mainPage.DiscreteValue1 = true;
                    aeroPump_th3_mainPage.DiscreteValue2 = false;
                    aeroPump_th3_mainPage.DiscreteValue3 = false;
                    aeroPump_th3_mainPage.DiscreteValue4 = false;
                }
                #endregion

                // VỊ TRÍ: BỂ LẮNG VI SINH 
                #region GẠT BÙN 1 "GB1"
                if (Program.InputStatus_PLC2.gatBun_runStatus == true && Program.InputStatus_PLC2.gatBun_tripStatus == false)
                {
                    motor_gb1_mainPage.DiscreteValue1 = false;
                    motor_gb1_mainPage.DiscreteValue2 = true;
                    motor_gb1_mainPage.DiscreteValue3 = false;
                    motor_gb1_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.gatBun_runStatus == false && Program.InputStatus_PLC2.gatBun_tripStatus == true)
                {
                    motor_gb1_mainPage.DiscreteValue1 = false;
                    motor_gb1_mainPage.DiscreteValue2 = false;
                    motor_gb1_mainPage.DiscreteValue3 = true;
                    motor_gb1_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.gatBun_runStatus == true && Program.InputStatus_PLC2.gatBun_tripStatus == true)
                {
                    motor_gb1_mainPage.DiscreteValue1 = false;
                    motor_gb1_mainPage.DiscreteValue2 = false;
                    motor_gb1_mainPage.DiscreteValue3 = false;
                    motor_gb1_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    motor_gb1_mainPage.DiscreteValue1 = true;
                    motor_gb1_mainPage.DiscreteValue2 = false;
                    motor_gb1_mainPage.DiscreteValue3 = false;
                    motor_gb1_mainPage.DiscreteValue4 = false;
                }
                #endregion

                // VỊ TRÍ: BỂ LẮNG
                #region GẠT BÙN 05 "MS05" - GD2
                if (Program.InputStatus_PLC3.gbbl05_runStatus == true && Program.InputStatus_PLC3.gbbl05_tripStatus == false)
                {
                    motor_MS05_mainPage.DiscreteValue1 = false;
                    motor_MS05_mainPage.DiscreteValue2 = true;
                    motor_MS05_mainPage.DiscreteValue3 = false;
                    motor_MS05_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.gbbl05_runStatus == false && Program.InputStatus_PLC3.gbbl05_tripStatus == true)
                {
                    motor_MS05_mainPage.DiscreteValue1 = false;
                    motor_MS05_mainPage.DiscreteValue2 = false;
                    motor_MS05_mainPage.DiscreteValue3 = true;
                    motor_MS05_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.gbbl05_runStatus == true && Program.InputStatus_PLC3.gbbl05_tripStatus == true)
                {
                    motor_MS05_mainPage.DiscreteValue1 = false;
                    motor_MS05_mainPage.DiscreteValue2 = false;
                    motor_MS05_mainPage.DiscreteValue3 = false;
                    motor_MS05_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    motor_MS05_mainPage.DiscreteValue1 = true;
                    motor_MS05_mainPage.DiscreteValue2 = false;
                    motor_MS05_mainPage.DiscreteValue3 = false;
                    motor_MS05_mainPage.DiscreteValue4 = false;
                }

                #endregion

                #region GẠT BÙN 07 "MS07" - GD2
                if (Program.InputStatus_PLC3.gbbl07_runStatus == true && Program.InputStatus_PLC3.gbbl07_tripStatus == false)
                {
                    motor_MS07_mainPage.DiscreteValue1 = false;
                    motor_MS07_mainPage.DiscreteValue2 = true;
                    motor_MS07_mainPage.DiscreteValue3 = false;
                    motor_MS07_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.gbbl07_runStatus == false && Program.InputStatus_PLC3.gbbl07_tripStatus == true)
                {
                    motor_MS07_mainPage.DiscreteValue1 = false;
                    motor_MS07_mainPage.DiscreteValue2 = false;
                    motor_MS07_mainPage.DiscreteValue3 = true;
                    motor_MS07_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.gbbl07_runStatus == true && Program.InputStatus_PLC3.gbbl07_tripStatus == true)
                {
                    motor_MS07_mainPage.DiscreteValue1 = false;
                    motor_MS07_mainPage.DiscreteValue2 = false;
                    motor_MS07_mainPage.DiscreteValue3 = false;
                    motor_MS07_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    motor_MS07_mainPage.DiscreteValue1 = true;
                    motor_MS07_mainPage.DiscreteValue2 = false;
                    motor_MS07_mainPage.DiscreteValue3 = false;
                    motor_MS07_mainPage.DiscreteValue4 = false;
                }

                #endregion

                #region GẠT BÙN 09 "MS09" - GD2
                if (Program.InputStatus_PLC3.gbbl09_runStatus == true && Program.InputStatus_PLC3.gbbl09_tripStatus == false)
                {
                    motor_MS09_mainPage.DiscreteValue1 = false;
                    motor_MS09_mainPage.DiscreteValue2 = true;
                    motor_MS09_mainPage.DiscreteValue3 = false;
                    motor_MS09_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.gbbl09_runStatus == false && Program.InputStatus_PLC3.gbbl09_tripStatus == true)
                {
                    motor_MS09_mainPage.DiscreteValue1 = false;
                    motor_MS09_mainPage.DiscreteValue2 = false;
                    motor_MS09_mainPage.DiscreteValue3 = true;
                    motor_MS09_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.gbbl09_runStatus == true && Program.InputStatus_PLC3.gbbl09_tripStatus == true)
                {
                    motor_MS09_mainPage.DiscreteValue1 = false;
                    motor_MS09_mainPage.DiscreteValue2 = false;
                    motor_MS09_mainPage.DiscreteValue3 = false;
                    motor_MS09_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    motor_MS09_mainPage.DiscreteValue1 = true;
                    motor_MS09_mainPage.DiscreteValue2 = false;
                    motor_MS09_mainPage.DiscreteValue3 = false;
                    motor_MS09_mainPage.DiscreteValue4 = false;
                }

                #endregion

                // VỊ TRÍ: BỂ LẮNG HÓA LÝ:
                #region GẠT BÙN  "GGB" - GD1
                if (Program.InputStatus_PLC1.motorGatBun_runStatus == true && Program.InputStatus_PLC1.motorGatBun_tripStatus == false)
                {
                    motor_ggb_mainPage.DiscreteValue1 = false;
                    motor_ggb_mainPage.DiscreteValue2 = true;
                    motor_ggb_mainPage.DiscreteValue3 = false;
                    motor_ggb_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.motorGatBun_runStatus == false && Program.InputStatus_PLC1.motorGatBun_tripStatus == true)
                {
                    motor_ggb_mainPage.DiscreteValue1 = false;
                    motor_ggb_mainPage.DiscreteValue2 = false;
                    motor_ggb_mainPage.DiscreteValue3 = true;
                    motor_ggb_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.motorGatBun_runStatus == true && Program.InputStatus_PLC1.motorGatBun_tripStatus == true)
                {
                    motor_ggb_mainPage.DiscreteValue1 = false;
                    motor_ggb_mainPage.DiscreteValue2 = false;
                    motor_ggb_mainPage.DiscreteValue3 = false;
                    motor_ggb_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    motor_ggb_mainPage.DiscreteValue1 = true;
                    motor_ggb_mainPage.DiscreteValue2 = false;
                    motor_ggb_mainPage.DiscreteValue3 = false;
                    motor_ggb_mainPage.DiscreteValue4 = false;
                }
                #endregion

                // VỊ TRÍ: BỂ TUẦN HOÀN
                #region BƠM BÙN 1  "BB1" - GD1MR
                if (Program.InputStatus_PLC2.bomBun1_runStatus == true && Program.InputStatus_PLC2.bomBun1_tripStatus == false)
                {
                    bomBun_bb1_mainPage.DiscreteValue1 = false;
                    bomBun_bb1_mainPage.DiscreteValue2 = true;
                    bomBun_bb1_mainPage.DiscreteValue3 = false;
                    bomBun_bb1_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.bomBun1_runStatus == false && Program.InputStatus_PLC2.bomBun1_tripStatus == true)
                {
                    bomBun_bb1_mainPage.DiscreteValue1 = false;
                    bomBun_bb1_mainPage.DiscreteValue2 = false;
                    bomBun_bb1_mainPage.DiscreteValue3 = true;
                    bomBun_bb1_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.bomBun1_runStatus == true && Program.InputStatus_PLC2.bomBun1_tripStatus == true)
                {
                    bomBun_bb1_mainPage.DiscreteValue1 = false;
                    bomBun_bb1_mainPage.DiscreteValue2 = false;
                    bomBun_bb1_mainPage.DiscreteValue3 = false;
                    bomBun_bb1_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    bomBun_bb1_mainPage.DiscreteValue1 = true;
                    bomBun_bb1_mainPage.DiscreteValue2 = false;
                    bomBun_bb1_mainPage.DiscreteValue3 = false;
                    bomBun_bb1_mainPage.DiscreteValue4 = false;
                }

                #endregion

                #region BƠM BÙN 2  "BB2" - GD1MR
                if (Program.InputStatus_PLC2.bomBun2_runStatus == true && Program.InputStatus_PLC2.bomBun2_tripStatus == false)
                {
                    bomBun_bb2_mainPage.DiscreteValue1 = false;
                    bomBun_bb2_mainPage.DiscreteValue2 = true;
                    bomBun_bb2_mainPage.DiscreteValue3 = false;
                    bomBun_bb2_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.bomBun2_runStatus == false && Program.InputStatus_PLC2.bomBun2_tripStatus == true)
                {
                    bomBun_bb2_mainPage.DiscreteValue1 = false;
                    bomBun_bb2_mainPage.DiscreteValue2 = false;
                    bomBun_bb2_mainPage.DiscreteValue3 = true;
                    bomBun_bb2_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.bomBun2_runStatus == true && Program.InputStatus_PLC2.bomBun2_tripStatus == true)
                {
                    bomBun_bb2_mainPage.DiscreteValue1 = false;
                    bomBun_bb2_mainPage.DiscreteValue2 = false;
                    bomBun_bb2_mainPage.DiscreteValue3 = false;
                    bomBun_bb2_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    bomBun_bb2_mainPage.DiscreteValue1 = true;
                    bomBun_bb2_mainPage.DiscreteValue2 = false;
                    bomBun_bb2_mainPage.DiscreteValue3 = false;
                    bomBun_bb2_mainPage.DiscreteValue4 = false;
                }

                #endregion

                // VỊ TRÍ: BỂ BÙN
                #region BƠM BÙN SP10  "SP10" - GD
                if (Program.InputStatus_PLC3.bomBun_SP10_runStatus == true && Program.InputStatus_PLC3.bomBun_SP10_tripStatus == false)
                {
                    bomBun_sp10_mainPage.DiscreteValue1 = false;
                    bomBun_sp10_mainPage.DiscreteValue2 = true;
                    bomBun_sp10_mainPage.DiscreteValue3 = false;
                    bomBun_sp10_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomBun_SP10_runStatus == false && Program.InputStatus_PLC3.bomBun_SP10_tripStatus == true)
                {
                    bomBun_sp10_mainPage.DiscreteValue1 = false;
                    bomBun_sp10_mainPage.DiscreteValue2 = false;
                    bomBun_sp10_mainPage.DiscreteValue3 = true;
                    bomBun_sp10_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomBun_SP10_runStatus == true && Program.InputStatus_PLC3.bomBun_SP10_tripStatus == true)
                {
                    bomBun_sp10_mainPage.DiscreteValue1 = false;
                    bomBun_sp10_mainPage.DiscreteValue2 = false;
                    bomBun_sp10_mainPage.DiscreteValue3 = false;
                    bomBun_sp10_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    bomBun_sp10_mainPage.DiscreteValue1 = true;
                    bomBun_sp10_mainPage.DiscreteValue2 = false;
                    bomBun_sp10_mainPage.DiscreteValue3 = false;
                    bomBun_sp10_mainPage.DiscreteValue4 = false;
                }

                #endregion

                // VỊ TRÍ: BỂ NÉN BÙN
                #region BƠM BÙN 05A  "SP05A" - GD2
                if (Program.InputStatus_PLC3.bomBun_05A_runStatus == true && Program.InputStatus_PLC3.bomBun_05A_tripStatus == false)
                {
                    bomBun_sp05a_mainPage.DiscreteValue1 = false;
                    bomBun_sp05a_mainPage.DiscreteValue2 = true;
                    bomBun_sp05a_mainPage.DiscreteValue3 = false;
                    bomBun_sp05a_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomBun_05A_runStatus == false && Program.InputStatus_PLC3.bomBun_05A_tripStatus == true)
                {
                    bomBun_sp05a_mainPage.DiscreteValue1 = false;
                    bomBun_sp05a_mainPage.DiscreteValue2 = false;
                    bomBun_sp05a_mainPage.DiscreteValue3 = true;
                    bomBun_sp05a_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomBun_05A_runStatus == true && Program.InputStatus_PLC3.bomBun_05A_tripStatus == true)
                {
                    bomBun_sp05a_mainPage.DiscreteValue1 = false;
                    bomBun_sp05a_mainPage.DiscreteValue2 = false;
                    bomBun_sp05a_mainPage.DiscreteValue3 = false;
                    bomBun_sp05a_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    bomBun_sp05a_mainPage.DiscreteValue1 = true;
                    bomBun_sp05a_mainPage.DiscreteValue2 = false;
                    bomBun_sp05a_mainPage.DiscreteValue3 = false;
                    bomBun_sp05a_mainPage.DiscreteValue4 = false;
                }

                #endregion


                #region BƠM BÙN 05B  "SP05B" - GD2
                if (Program.InputStatus_PLC3.bomBun_05B_runStatus == true && Program.InputStatus_PLC3.bomBun_05B_tripStatus == false)
                {
                    bomBun_sp05b_mainPage.DiscreteValue1 = false;
                    bomBun_sp05b_mainPage.DiscreteValue2 = true;
                    bomBun_sp05b_mainPage.DiscreteValue3 = false;
                    bomBun_sp05b_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomBun_05B_runStatus == false && Program.InputStatus_PLC3.bomBun_05B_tripStatus == true)
                {
                    bomBun_sp05b_mainPage.DiscreteValue1 = false;
                    bomBun_sp05b_mainPage.DiscreteValue2 = false;
                    bomBun_sp05b_mainPage.DiscreteValue3 = true;
                    bomBun_sp05b_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomBun_05B_runStatus == true && Program.InputStatus_PLC3.bomBun_05B_tripStatus == true)
                {
                    bomBun_sp05b_mainPage.DiscreteValue1 = false;
                    bomBun_sp05b_mainPage.DiscreteValue2 = false;
                    bomBun_sp05b_mainPage.DiscreteValue3 = false;
                    bomBun_sp05b_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    bomBun_sp05b_mainPage.DiscreteValue1 = true;
                    bomBun_sp05b_mainPage.DiscreteValue2 = false;
                    bomBun_sp05a_mainPage.DiscreteValue3 = false;
                    bomBun_sp05a_mainPage.DiscreteValue4 = false;
                }

                #endregion

                #region BƠM BÙN 07A  "SP07A" - GD2
                if (Program.InputStatus_PLC3.bomBun_07A_runStatus == true && Program.InputStatus_PLC3.bomBun_07A_tripStatus == false)
                {
                    bomBun_sp07a_mainPage.DiscreteValue1 = false;
                    bomBun_sp07a_mainPage.DiscreteValue2 = true;
                    bomBun_sp07a_mainPage.DiscreteValue3 = false;
                    bomBun_sp07a_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomBun_07A_runStatus == false && Program.InputStatus_PLC3.bomBun_07A_tripStatus == true)
                {
                    bomBun_sp07a_mainPage.DiscreteValue1 = false;
                    bomBun_sp07a_mainPage.DiscreteValue2 = false;
                    bomBun_sp07a_mainPage.DiscreteValue3 = true;
                    bomBun_sp07a_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomBun_07A_runStatus == true && Program.InputStatus_PLC3.bomBun_07A_tripStatus == true)
                {
                    bomBun_sp07a_mainPage.DiscreteValue1 = false;
                    bomBun_sp07a_mainPage.DiscreteValue2 = false;
                    bomBun_sp07a_mainPage.DiscreteValue3 = false;
                    bomBun_sp07a_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    bomBun_sp07a_mainPage.DiscreteValue1 = true;
                    bomBun_sp07a_mainPage.DiscreteValue2 = false;
                    bomBun_sp07a_mainPage.DiscreteValue3 = false;
                    bomBun_sp07a_mainPage.DiscreteValue4 = false;
                }

                #endregion

                #region BƠM BÙN 07B  "SP07B" - GD2
                if (Program.InputStatus_PLC3.bomBun_07B_runStatus == true && Program.InputStatus_PLC3.bomBun_07B_tripStatus == false)
                {
                    bomBun_sp07b_mainPage.DiscreteValue1 = false;
                    bomBun_sp07b_mainPage.DiscreteValue2 = true;
                    bomBun_sp07b_mainPage.DiscreteValue3 = false;
                    bomBun_sp07b_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomBun_07B_runStatus == false && Program.InputStatus_PLC3.bomBun_07B_tripStatus == true)
                {
                    bomBun_sp07b_mainPage.DiscreteValue1 = false;
                    bomBun_sp07b_mainPage.DiscreteValue2 = false;
                    bomBun_sp07b_mainPage.DiscreteValue3 = true;
                    bomBun_sp07b_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomBun_07B_runStatus == true && Program.InputStatus_PLC3.bomBun_07B_tripStatus == true)
                {
                    bomBun_sp07b_mainPage.DiscreteValue1 = false;
                    bomBun_sp07b_mainPage.DiscreteValue2 = false;
                    bomBun_sp07b_mainPage.DiscreteValue3 = false;
                    bomBun_sp07b_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    bomBun_sp07b_mainPage.DiscreteValue1 = true;
                    bomBun_sp07b_mainPage.DiscreteValue2 = false;
                    bomBun_sp07b_mainPage.DiscreteValue3 = false;
                    bomBun_sp07b_mainPage.DiscreteValue4 = false;
                }

                #endregion


                // VỊ TRÍ: BỂ BÙN
                #region BƠM BÙN 11  "SP11" - GD1MR => KHÔNG XÁC ĐỊNH ???
                if (Program.InputStatus_PLC3.bomBun_07B_runStatus == true && Program.InputStatus_PLC3.bomBun_07B_tripStatus == false)
                {
                    bomBun_sp07b_mainPage.DiscreteValue1 = false;
                    bomBun_sp07b_mainPage.DiscreteValue2 = true;
                    bomBun_sp07b_mainPage.DiscreteValue3 = false;
                    bomBun_sp07b_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomBun_07B_runStatus == false && Program.InputStatus_PLC3.bomBun_07B_tripStatus == true)
                {
                    bomBun_sp07b_mainPage.DiscreteValue1 = false;
                    bomBun_sp07b_mainPage.DiscreteValue2 = false;
                    bomBun_sp07b_mainPage.DiscreteValue3 = true;
                    bomBun_sp07b_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.bomBun_07B_runStatus == true && Program.InputStatus_PLC3.bomBun_07B_tripStatus == true)
                {
                    bomBun_sp07b_mainPage.DiscreteValue1 = false;
                    bomBun_sp07b_mainPage.DiscreteValue2 = false;
                    bomBun_sp07b_mainPage.DiscreteValue3 = false;
                    bomBun_sp07b_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    bomBun_sp07b_mainPage.DiscreteValue1 = true;
                    bomBun_sp07b_mainPage.DiscreteValue2 = false;
                    bomBun_sp07b_mainPage.DiscreteValue3 = false;
                    bomBun_sp07b_mainPage.DiscreteValue4 = false;
                }

                #endregion

                // BỂ ĐIỀU HÒA
                #region MÁY THỔI KHÍ "MTK01"
                if ((Program.InputStatus_PLC1.mtk01_runStatus == true) & (Program.InputStatus_PLC1.mtk01_tripStatus == false))
                {
                    airPump_mtk01_homePage.DiscreteValue1 = false;
                    airPump_mtk01_homePage.DiscreteValue2 = true;
                    airPump_mtk01_homePage.DiscreteValue3 = false;
                    airPump_mtk01_homePage.DiscreteValue4 = false;
                }
                else if ((Program.InputStatus_PLC1.mtk01_runStatus == false) & (Program.InputStatus_PLC1.mtk01_tripStatus == true))
                {
                    airPump_mtk01_homePage.DiscreteValue1 = false;
                    airPump_mtk01_homePage.DiscreteValue2 = false;
                    airPump_mtk01_homePage.DiscreteValue3 = true;
                    airPump_mtk01_homePage.DiscreteValue4 = false;
                }
                else if ((Program.InputStatus_PLC1.mtk01_runStatus == true) & (Program.InputStatus_PLC1.mtk01_tripStatus == true))
                {
                    airPump_mtk01_homePage.DiscreteValue1 = false;
                    airPump_mtk01_homePage.DiscreteValue2 = false;
                    airPump_mtk01_homePage.DiscreteValue3 = false;
                    airPump_mtk01_homePage.DiscreteValue4 = true;
                }
                else
                {
                    airPump_mtk01_homePage.DiscreteValue1 = true;
                    airPump_mtk01_homePage.DiscreteValue2 = false;
                    airPump_mtk01_homePage.DiscreteValue3 = false;
                    airPump_mtk01_homePage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY THỔI KHÍ "MTK02"
                if ((Program.InputStatus_PLC1.mtk02_runStatus == true) & (Program.InputStatus_PLC1.mtk02_tripStatus == false))
                {
                    airPump_mtk02_homePage.DiscreteValue1 = false;
                    airPump_mtk02_homePage.DiscreteValue2 = true;
                    airPump_mtk02_homePage.DiscreteValue3 = false;
                    airPump_mtk02_homePage.DiscreteValue4 = false;
                }
                else if ((Program.InputStatus_PLC1.mtk02_runStatus == false) & (Program.InputStatus_PLC1.mtk02_tripStatus == true))
                {
                    airPump_mtk02_homePage.DiscreteValue1 = false;
                    airPump_mtk02_homePage.DiscreteValue2 = false;
                    airPump_mtk02_homePage.DiscreteValue3 = true;
                    airPump_mtk02_homePage.DiscreteValue4 = false;
                }
                else if ((Program.InputStatus_PLC1.mtk02_runStatus == true) & (Program.InputStatus_PLC1.mtk02_tripStatus == true))
                {
                    airPump_mtk02_homePage.DiscreteValue1 = false;
                    airPump_mtk02_homePage.DiscreteValue2 = false;
                    airPump_mtk02_homePage.DiscreteValue3 = false;
                    airPump_mtk02_homePage.DiscreteValue4 = true;
                }
                else
                {
                    airPump_mtk02_homePage.DiscreteValue1 = true;
                    airPump_mtk02_homePage.DiscreteValue2 = false;
                    airPump_mtk02_homePage.DiscreteValue3 = false;
                    airPump_mtk02_homePage.DiscreteValue4 = false;
                }

                #endregion

                #region MÁY THỔI KHÍ "MTK03"
                if ((Program.InputStatus_PLC1.mtk03_runStatus == true) & (Program.InputStatus_PLC1.mtk03_tripStatus == false))
                {
                    airPump_mtk03_homePage.DiscreteValue1 = false;
                    airPump_mtk03_homePage.DiscreteValue2 = true;
                    airPump_mtk03_homePage.DiscreteValue3 = false;
                    airPump_mtk03_homePage.DiscreteValue4 = false;
                }
                else if ((Program.InputStatus_PLC1.mtk03_runStatus == false) & (Program.InputStatus_PLC1.mtk03_tripStatus == true))
                {
                    airPump_mtk03_homePage.DiscreteValue1 = false;
                    airPump_mtk03_homePage.DiscreteValue2 = false;
                    airPump_mtk03_homePage.DiscreteValue3 = true;
                    airPump_mtk03_homePage.DiscreteValue4 = false;
                }
                else if ((Program.InputStatus_PLC1.mtk03_runStatus == true) & (Program.InputStatus_PLC1.mtk03_tripStatus == true))
                {
                    airPump_mtk03_homePage.DiscreteValue1 = false;
                    airPump_mtk03_homePage.DiscreteValue2 = false;
                    airPump_mtk03_homePage.DiscreteValue3 = false;
                    airPump_mtk03_homePage.DiscreteValue4 = true;
                }
                else
                {
                    airPump_mtk03_homePage.DiscreteValue1 = true;
                    airPump_mtk03_homePage.DiscreteValue2 = false;
                    airPump_mtk03_homePage.DiscreteValue3 = false;
                    airPump_mtk03_homePage.DiscreteValue4 = false;
                }
                #endregion

                // BỂ AEROTANK
                #region MÁY THỔI KHÍ "MKT1"
                if (Program.InputStatus_PLC2.mkt01_runStatus == true && Program.InputStatus_PLC2.mkt01_tripStatus == false)
                {
                    airPump_mkt01_homePage.DiscreteValue1 = false;
                    airPump_mkt01_homePage.DiscreteValue2 = true;
                    airPump_mkt01_homePage.DiscreteValue3 = false;
                    airPump_mkt01_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.mkt01_runStatus == false && Program.InputStatus_PLC2.mkt01_tripStatus == true)
                {
                    airPump_mkt01_homePage.DiscreteValue1 = false;
                    airPump_mkt01_homePage.DiscreteValue2 = false;
                    airPump_mkt01_homePage.DiscreteValue3 = true;
                    airPump_mkt01_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.mkt01_runStatus == true && Program.InputStatus_PLC2.mkt01_tripStatus == true)
                {
                    airPump_mkt01_homePage.DiscreteValue1 = false;
                    airPump_mkt01_homePage.DiscreteValue2 = false;
                    airPump_mkt01_homePage.DiscreteValue3 = false;
                    airPump_mkt01_homePage.DiscreteValue4 = true;
                }
                else
                {
                    airPump_mkt01_homePage.DiscreteValue1 = true;
                    airPump_mkt01_homePage.DiscreteValue2 = false;
                    airPump_mkt01_homePage.DiscreteValue3 = false;
                    airPump_mkt01_homePage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY THỔI KHÍ "MTK02"
                if (Program.InputStatus_PLC2.mkt02_runStatus == true && Program.InputStatus_PLC2.mkt02_tripStatus == false)
                {
                    airPump_mkt02_homePage.DiscreteValue1 = false;
                    airPump_mkt02_homePage.DiscreteValue2 = true;
                    airPump_mkt02_homePage.DiscreteValue3 = false;
                    airPump_mkt02_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.mkt02_runStatus == false && Program.InputStatus_PLC2.mkt02_tripStatus == true)
                {
                    airPump_mkt02_homePage.DiscreteValue1 = false;
                    airPump_mkt02_homePage.DiscreteValue2 = false;
                    airPump_mkt02_homePage.DiscreteValue3 = true;
                    airPump_mkt02_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.mkt02_runStatus == true && Program.InputStatus_PLC2.mkt02_tripStatus == true)
                {
                    airPump_mkt02_homePage.DiscreteValue1 = false;
                    airPump_mkt02_homePage.DiscreteValue2 = false;
                    airPump_mkt02_homePage.DiscreteValue3 = false;
                    airPump_mkt02_homePage.DiscreteValue4 = true;
                }
                else
                {
                    airPump_mkt02_homePage.DiscreteValue1 = true;
                    airPump_mkt02_homePage.DiscreteValue2 = false;
                    airPump_mkt02_homePage.DiscreteValue3 = false;
                    airPump_mkt02_homePage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY THỔI KHÍ "MTK03"
                if (Program.InputStatus_PLC2.mkt03_runStatus == true && Program.InputStatus_PLC2.mkt03_tripStatus == false)
                {
                    airPump_mkt03_homePage.DiscreteValue1 = false;
                    airPump_mkt03_homePage.DiscreteValue2 = true;
                    airPump_mkt03_homePage.DiscreteValue3 = false;
                    airPump_mkt03_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.mkt03_runStatus == false && Program.InputStatus_PLC2.mkt03_tripStatus == true)
                {
                    airPump_mkt03_homePage.DiscreteValue1 = false;
                    airPump_mkt03_homePage.DiscreteValue2 = false;
                    airPump_mkt03_homePage.DiscreteValue3 = true;
                    airPump_mkt03_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.mkt03_runStatus == true && Program.InputStatus_PLC2.mkt03_tripStatus == true)
                {
                    airPump_mkt03_homePage.DiscreteValue1 = false;
                    airPump_mkt03_homePage.DiscreteValue2 = false;
                    airPump_mkt03_homePage.DiscreteValue3 = false;
                    airPump_mkt03_homePage.DiscreteValue4 = true;
                }
                else
                {
                    airPump_mkt03_homePage.DiscreteValue1 = true;
                    airPump_mkt03_homePage.DiscreteValue2 = false;
                    airPump_mkt03_homePage.DiscreteValue3 = false;
                    airPump_mkt03_homePage.DiscreteValue4 = false;
                }
                #endregion

                // BỂ BIOFOR
                #region MÁY THỔI KHÍ "AB06A"
                if (Program.InputStatus_PLC3.mtk_AB06A_runStatus == true && Program.InputStatus_PLC3.mtk_AB06A_tripStatus == false)
                {
                    airPump_ab06a_homePage.DiscreteValue1 = false;
                    airPump_ab06a_homePage.DiscreteValue2 = true;
                    airPump_ab06a_homePage.DiscreteValue3 = false;
                    airPump_ab06a_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.mtk_AB06A_runStatus == false && Program.InputStatus_PLC3.mtk_AB06A_tripStatus == true)
                {
                    airPump_ab06a_homePage.DiscreteValue1 = false;
                    airPump_ab06a_homePage.DiscreteValue2 = false;
                    airPump_ab06a_homePage.DiscreteValue3 = true;
                    airPump_ab06a_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.mtk_AB06A_runStatus == true && Program.InputStatus_PLC3.mtk_AB06A_tripStatus == true)
                {
                    airPump_ab06a_homePage.DiscreteValue1 = false;
                    airPump_ab06a_homePage.DiscreteValue2 = false;
                    airPump_ab06a_homePage.DiscreteValue3 = false;
                    airPump_ab06a_homePage.DiscreteValue4 = true;
                }
                else
                {
                    airPump_ab06a_homePage.DiscreteValue1 = true;
                    airPump_ab06a_homePage.DiscreteValue2 = false;
                    airPump_ab06a_homePage.DiscreteValue3 = false;
                    airPump_ab06a_homePage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY THỔI KHÍ "AB06B"
                if (Program.InputStatus_PLC3.mtk_AB06B_runStatus == true && Program.InputStatus_PLC3.mtk_AB06B_tripStatus == false)
                {
                    airPump_ab06b_homePage.DiscreteValue1 = false;
                    airPump_ab06b_homePage.DiscreteValue2 = true;
                    airPump_ab06b_homePage.DiscreteValue3 = false;
                    airPump_ab06b_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.mtk_AB06B_runStatus == false && Program.InputStatus_PLC3.mtk_AB06B_tripStatus == true)
                {
                    airPump_ab06b_homePage.DiscreteValue1 = false;
                    airPump_ab06b_homePage.DiscreteValue2 = false;
                    airPump_ab06b_homePage.DiscreteValue3 = true;
                    airPump_ab06b_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.mtk_AB06B_runStatus == true && Program.InputStatus_PLC3.mtk_AB06B_tripStatus == true)
                {
                    airPump_ab06b_homePage.DiscreteValue1 = false;
                    airPump_ab06b_homePage.DiscreteValue2 = false;
                    airPump_ab06b_homePage.DiscreteValue3 = false;
                    airPump_ab06b_homePage.DiscreteValue4 = true;
                }
                else
                {
                    airPump_ab06b_homePage.DiscreteValue1 = true;
                    airPump_ab06b_homePage.DiscreteValue2 = false;
                    airPump_ab06b_homePage.DiscreteValue3 = false;
                    airPump_ab06b_homePage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY THỔI KHÍ "AB06C"
                if (Program.InputStatus_PLC3.mtk_AB06C_runStatus == true && Program.InputStatus_PLC3.mtk_AB06C_tripStatus == false)
                {
                    airPump_ab06c_homePage.DiscreteValue1 = false;
                    airPump_ab06c_homePage.DiscreteValue2 = true;
                    airPump_ab06c_homePage.DiscreteValue3 = false;
                    airPump_ab06c_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.mtk_AB06C_runStatus == false && Program.InputStatus_PLC3.mtk_AB06C_tripStatus == true)
                {
                    airPump_ab06c_homePage.DiscreteValue1 = false;
                    airPump_ab06c_homePage.DiscreteValue2 = false;
                    airPump_ab06c_homePage.DiscreteValue3 = true;
                    airPump_ab06c_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.mtk_AB06C_runStatus == true && Program.InputStatus_PLC3.mtk_AB06C_tripStatus == true)
                {
                    airPump_ab06c_homePage.DiscreteValue1 = false;
                    airPump_ab06c_homePage.DiscreteValue2 = false;
                    airPump_ab06c_homePage.DiscreteValue3 = false;
                    airPump_ab06c_homePage.DiscreteValue4 = true;
                }
                else
                {
                    airPump_ab06c_homePage.DiscreteValue1 = true;
                    airPump_ab06c_homePage.DiscreteValue2 = false;
                    airPump_ab06c_homePage.DiscreteValue3 = false;
                    airPump_ab06c_homePage.DiscreteValue4 = false;
                }
                #endregion


                // MÁY KHUẤY
                #region MÁY KHUẤY Metanol GD1MR "MT-ETN"
                if (Program.InputStatus_PLC2.metanol_runStatus == true && Program.InputStatus_PLC2.metanol_tripStatus == false)
                {
                    mixer_mtetn_mainPage.DiscreteValue1 = false;
                    mixer_mtetn_mainPage.DiscreteValue2 = true;
                    mixer_mtetn_mainPage.DiscreteValue3 = false;
                    mixer_mtetn_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.metanol_runStatus == false && Program.InputStatus_PLC2.metanol_tripStatus == true)
                {
                    mixer_mtetn_mainPage.DiscreteValue1 = false;
                    mixer_mtetn_mainPage.DiscreteValue2 = false;
                    mixer_mtetn_mainPage.DiscreteValue3 = true;
                    mixer_mtetn_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.metanol_runStatus == true && Program.InputStatus_PLC2.metanol_tripStatus == true)
                {
                    mixer_mtetn_mainPage.DiscreteValue1 = false;
                    mixer_mtetn_mainPage.DiscreteValue2 = false;
                    mixer_mtetn_mainPage.DiscreteValue3 = false;
                    mixer_mtetn_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mtetn_mainPage.DiscreteValue1 = true;
                    mixer_mtetn_mainPage.DiscreteValue2 = false;
                    mixer_mtetn_mainPage.DiscreteValue3 = false;
                    mixer_mtetn_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY NP "MT-03" - GD1
                if (Program.InputStatus_PLC1.khuayNp_runStatus == true && Program.InputStatus_PLC1.khuayNp_tripStatus == false)
                {
                    mixer_mt03_mainPage.DiscreteValue1 = false;
                    mixer_mt03_mainPage.DiscreteValue2 = true;
                    mixer_mt03_mainPage.DiscreteValue3 = false;
                    mixer_mt03_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayNp_runStatus == false && Program.InputStatus_PLC1.khuayNp_tripStatus == true)
                {
                    mixer_mt03_mainPage.DiscreteValue1 = false;
                    mixer_mt03_mainPage.DiscreteValue2 = false;
                    mixer_mt03_mainPage.DiscreteValue3 = true;
                    mixer_mt03_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayNp_runStatus == true && Program.InputStatus_PLC1.khuayNp_tripStatus == true)
                {
                    mixer_mt03_mainPage.DiscreteValue1 = false;
                    mixer_mt03_mainPage.DiscreteValue2 = false;
                    mixer_mt03_mainPage.DiscreteValue3 = false;
                    mixer_mt03_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mt03_mainPage.DiscreteValue1 = true;
                    mixer_mt03_mainPage.DiscreteValue2 = false;
                    mixer_mt03_mainPage.DiscreteValue3 = false;
                    mixer_mt03_mainPage.DiscreteValue4 = false;
                }
                #endregion

                run = Program.InputStatus_PLC1.khuayPac_runStatus;
                trip = Program.InputStatus_PLC1.khuayPac_tripStatus;
                #region MÁY KHUẤY PAC "MT-05" => PAC GD1 ???
                if ((run == true) & (trip == false))
                {

                    mixer_mt05_mainPage.DiscreteValue1 = false;
                    mixer_mt05_mainPage.DiscreteValue2 = true;
                    mixer_mt05_mainPage.DiscreteValue3 = false;
                    mixer_mt05_mainPage.DiscreteValue4 = false;
                }
                if ((run == false) & (trip == true))
                {
                    mixer_mt05_mainPage.DiscreteValue1 = false;
                    mixer_mt05_mainPage.DiscreteValue2 = false;
                    mixer_mt05_mainPage.DiscreteValue3 = true;
                    mixer_mt05_mainPage.DiscreteValue4 = false;
                }
                else if ((Program.InputStatus_PLC1.khuayNp_runStatus == true) & (Program.InputStatus_PLC1.khuayNp_tripStatus == true))
                {
                    mixer_mt05_mainPage.DiscreteValue1 = false;
                    mixer_mt05_mainPage.DiscreteValue2 = false;
                    mixer_mt05_mainPage.DiscreteValue3 = false;
                    mixer_mt05_mainPage.DiscreteValue4 = true;

                }
                else
                {
                    mixer_mt05_mainPage.DiscreteValue1 = true;
                    mixer_mt05_mainPage.DiscreteValue2 = false;
                    mixer_mt05_mainPage.DiscreteValue3 = false;
                    mixer_mt05_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY POLYME 1  GD1 "MT-06"
                if (Program.InputStatus_PLC1.khuayPolyme1_runStatus == true && Program.InputStatus_PLC1.khuayPolyme1_tripStatus == false)
                {
                    mixer_mt06_mainPage_01p2.DiscreteValue1 = false;
                    mixer_mt06_mainPage_01p2.DiscreteValue2 = true;
                    mixer_mt06_mainPage_01p2.DiscreteValue3 = false;
                    mixer_mt06_mainPage_01p2.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayPolyme1_runStatus == false && Program.InputStatus_PLC1.khuayPolyme1_tripStatus == true)
                {
                    mixer_mt06_mainPage_01p2.DiscreteValue1 = false;
                    mixer_mt06_mainPage_01p2.DiscreteValue2 = false;
                    mixer_mt06_mainPage_01p2.DiscreteValue3 = true;
                    mixer_mt06_mainPage_01p2.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayPolyme1_runStatus == true && Program.InputStatus_PLC1.khuayPolyme1_tripStatus == true)
                {
                    mixer_mt06_mainPage_01p2.DiscreteValue1 = false;
                    mixer_mt06_mainPage_01p2.DiscreteValue2 = false;
                    mixer_mt06_mainPage_01p2.DiscreteValue3 = false;
                    mixer_mt06_mainPage_01p2.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mt06_mainPage_01p2.DiscreteValue1 = true;
                    mixer_mt06_mainPage_01p2.DiscreteValue2 = false;
                    mixer_mt06_mainPage_01p2.DiscreteValue3 = false;
                    mixer_mt06_mainPage_01p2.DiscreteValue4 = false;
                }
                #endregion


                #region MÁY KHUẤY POLYME 2  GD1 "MT-06"
                if (Program.InputStatus_PLC1.khuayPolyme2_runStatus == true && Program.InputStatus_PLC1.khuayPolyme2_tripStatus == false)
                {
                    mixer_mt06_mainPage_02p2.DiscreteValue1 = false;
                    mixer_mt06_mainPage_02p2.DiscreteValue2 = true;
                    mixer_mt06_mainPage_02p2.DiscreteValue3 = false;
                    mixer_mt06_mainPage_02p2.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayPolyme2_runStatus == false && Program.InputStatus_PLC1.khuayPolyme2_tripStatus == true)
                {
                    mixer_mt06_mainPage_02p2.DiscreteValue1 = false;
                    mixer_mt06_mainPage_02p2.DiscreteValue2 = false;
                    mixer_mt06_mainPage_02p2.DiscreteValue3 = true;
                    mixer_mt06_mainPage_02p2.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayPolyme2_runStatus == true && Program.InputStatus_PLC1.khuayPolyme2_tripStatus == true)
                {
                    mixer_mt06_mainPage_02p2.DiscreteValue1 = false;
                    mixer_mt06_mainPage_02p2.DiscreteValue2 = false;
                    mixer_mt06_mainPage_02p2.DiscreteValue3 = false;
                    mixer_mt06_mainPage_02p2.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mt06_mainPage_02p2.DiscreteValue1 = true;
                    mixer_mt06_mainPage_02p2.DiscreteValue2 = false;
                    mixer_mt06_mainPage_02p2.DiscreteValue3 = false;
                    mixer_mt06_mainPage_02p2.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY CLO  GD1 "MT-04"
                if (Program.InputStatus_PLC1.khuayClo_runStatus == true && Program.InputStatus_PLC1.khuayClo_tripStatus == false)
                {
                    mixer_mt04_mainPage.DiscreteValue1 = false;
                    mixer_mt04_mainPage.DiscreteValue2 = true;
                    mixer_mt04_mainPage.DiscreteValue3 = false;
                    mixer_mt04_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayClo_runStatus == false && Program.InputStatus_PLC1.khuayClo_tripStatus == true)
                {
                    mixer_mt04_mainPage.DiscreteValue1 = false;
                    mixer_mt04_mainPage.DiscreteValue2 = false;
                    mixer_mt04_mainPage.DiscreteValue3 = true;
                    mixer_mt04_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayClo_runStatus == true && Program.InputStatus_PLC1.khuayClo_tripStatus == true)
                {
                    mixer_mt04_mainPage.DiscreteValue1 = false;
                    mixer_mt04_mainPage.DiscreteValue2 = false;
                    mixer_mt04_mainPage.DiscreteValue3 = false;
                    mixer_mt04_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mt04_mainPage.DiscreteValue1 = true;
                    mixer_mt04_mainPage.DiscreteValue2 = false;
                    mixer_mt04_mainPage.DiscreteValue3 = false;
                    mixer_mt04_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY POLYME "MC04" - GD2
                if (Program.InputStatus_PLC3.khuayPoly_GD2_runStatus == true && Program.InputStatus_PLC3.khuayPoly_GD2_tripStatus == false)
                {
                    mixer_mc04_mainPage.DiscreteValue1 = false;
                    mixer_mc04_mainPage.DiscreteValue2 = true;
                    mixer_mc04_mainPage.DiscreteValue3 = false;
                    mixer_mc04_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.khuayPoly_GD2_runStatus == false && Program.InputStatus_PLC3.khuayPoly_GD2_tripStatus == true)
                {
                    mixer_mc04_mainPage.DiscreteValue1 = false;
                    mixer_mc04_mainPage.DiscreteValue2 = false;
                    mixer_mc04_mainPage.DiscreteValue3 = true;
                    mixer_mc04_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.khuayPoly_GD2_runStatus == true && Program.InputStatus_PLC3.khuayPoly_GD2_tripStatus == true)
                {
                    mixer_mc04_mainPage.DiscreteValue1 = false;
                    mixer_mc04_mainPage.DiscreteValue2 = false;
                    mixer_mc04_mainPage.DiscreteValue3 = false;
                    mixer_mc04_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mc04_mainPage.DiscreteValue1 = true;
                    mixer_mc04_mainPage.DiscreteValue2 = false;
                    mixer_mc04_mainPage.DiscreteValue3 = false;
                    mixer_mc04_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY PAC "MC03" - GD2
                if (Program.InputStatus_PLC3.khuayPac_GD2_runStatus == true && Program.InputStatus_PLC3.khuayPac_GD2_tripStatus == false)
                {
                    mixer_mc03_mainPage_n.DiscreteValue1 = false;
                    mixer_mc03_mainPage_n.DiscreteValue2 = true;
                    mixer_mc03_mainPage_n.DiscreteValue3 = false;
                    mixer_mc03_mainPage_n.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.khuayPac_GD2_runStatus == false && Program.InputStatus_PLC3.khuayPac_GD2_tripStatus == true)
                {
                    mixer_mc03_mainPage_n.DiscreteValue1 = false;
                    mixer_mc03_mainPage_n.DiscreteValue2 = false;
                    mixer_mc03_mainPage_n.DiscreteValue3 = true;
                    mixer_mc03_mainPage_n.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.khuayPac_GD2_runStatus == true && Program.InputStatus_PLC3.khuayPac_GD2_tripStatus == true)
                {
                    mixer_mc03_mainPage_n.DiscreteValue1 = false;
                    mixer_mc03_mainPage_n.DiscreteValue2 = false;
                    mixer_mc03_mainPage_n.DiscreteValue3 = false;
                    mixer_mc03_mainPage_n.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mc03_mainPage_n.DiscreteValue1 = true;
                    mixer_mc03_mainPage_n.DiscreteValue2 = false;
                    mixer_mc03_mainPage_n.DiscreteValue3 = false;
                    mixer_mc03_mainPage_n.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY ??? "MC09" - GD2 ???

                #endregion

                #region MÁY KHUẤY KEO TỤ "MI03" - GD2
                if (Program.InputStatus_PLC3.khuayKeoTu_GD2_runStatus == true && Program.InputStatus_PLC3.khuayKeoTu_GD2_tripStatus == false)
                {
                    mixer_mi03_mainPage.DiscreteValue1 = false;
                    mixer_mi03_mainPage.DiscreteValue2 = true;
                    mixer_mi03_mainPage.DiscreteValue3 = false;
                    mixer_mi03_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.khuayKeoTu_GD2_runStatus == false && Program.InputStatus_PLC3.khuayKeoTu_GD2_tripStatus == true)
                {
                    mixer_mi03_mainPage.DiscreteValue1 = false;
                    mixer_mi03_mainPage.DiscreteValue2 = false;
                    mixer_mi03_mainPage.DiscreteValue3 = true;
                    mixer_mi03_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.khuayKeoTu_GD2_runStatus == true && Program.InputStatus_PLC3.khuayKeoTu_GD2_tripStatus == true)
                {
                    mixer_mi03_mainPage.DiscreteValue1 = false;
                    mixer_mi03_mainPage.DiscreteValue2 = false;
                    mixer_mi03_mainPage.DiscreteValue3 = false;
                    mixer_mi03_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mi03_mainPage.DiscreteValue1 = true;
                    mixer_mi03_mainPage.DiscreteValue2 = false;
                    mixer_mi03_mainPage.DiscreteValue3 = false;
                    mixer_mi03_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY TẠO BÔNG A "MI04A" - GD2
                if (Program.InputStatus_PLC3.khuayTaoBong_A_runStatus == true && Program.InputStatus_PLC3.khuayTaoBong_A_tripStatus == false)
                {
                    mixer_mi04a_mainPage.DiscreteValue1 = false;
                    mixer_mi04a_mainPage.DiscreteValue2 = true;
                    mixer_mi04a_mainPage.DiscreteValue3 = false;
                    mixer_mi04a_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.khuayTaoBong_A_runStatus == false && Program.InputStatus_PLC3.khuayTaoBong_A_tripStatus == true)
                {
                    mixer_mi04a_mainPage.DiscreteValue1 = false;
                    mixer_mi04a_mainPage.DiscreteValue2 = false;
                    mixer_mi04a_mainPage.DiscreteValue3 = true;
                    mixer_mi04a_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.khuayTaoBong_A_runStatus == true && Program.InputStatus_PLC3.khuayTaoBong_A_tripStatus == true)
                {
                    mixer_mi04a_mainPage.DiscreteValue1 = false;
                    mixer_mi04a_mainPage.DiscreteValue2 = false;
                    mixer_mi04a_mainPage.DiscreteValue3 = false;
                    mixer_mi04a_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mi04a_mainPage.DiscreteValue1 = true;
                    mixer_mi04a_mainPage.DiscreteValue2 = false;
                    mixer_mi04a_mainPage.DiscreteValue3 = false;
                    mixer_mi04a_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY TẠO BÔNG B "MI04B" - GD2
                if (Program.InputStatus_PLC3.khuayTaoBong_B_runStatus == true && Program.InputStatus_PLC3.khuayTaoBong_B_tripStatus == false)
                {
                    mixer_mi04b_mainPage.DiscreteValue1 = false;
                    mixer_mi04b_mainPage.DiscreteValue2 = true;
                    mixer_mi04b_mainPage.DiscreteValue3 = false;
                    mixer_mi04b_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.khuayTaoBong_B_runStatus == false && Program.InputStatus_PLC3.khuayTaoBong_B_tripStatus == true)
                {
                    mixer_mi04b_mainPage.DiscreteValue1 = false;
                    mixer_mi04b_mainPage.DiscreteValue2 = false;
                    mixer_mi04b_mainPage.DiscreteValue3 = true;
                    mixer_mi04b_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.khuayTaoBong_B_runStatus == true && Program.InputStatus_PLC3.khuayTaoBong_B_tripStatus == true)
                {
                    mixer_mi04b_mainPage.DiscreteValue1 = false;
                    mixer_mi04b_mainPage.DiscreteValue2 = false;
                    mixer_mi04b_mainPage.DiscreteValue3 = false;
                    mixer_mi04b_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mi04b_mainPage.DiscreteValue1 = true;
                    mixer_mi04b_mainPage.DiscreteValue2 = false;
                    mixer_mi04b_mainPage.DiscreteValue3 = false;
                    mixer_mi04b_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region MÁY KHUẤY KEO TỤ "MT-01" - GD1
                if (Program.InputStatus_PLC1.khuayKeoTu_runStatus == true && Program.InputStatus_PLC1.khuayKeoTu_tripStatus == false)
                {
                    mixer_mt01_mainPage.DiscreteValue1 = false;
                    mixer_mt01_mainPage.DiscreteValue2 = true;
                    mixer_mt01_mainPage.DiscreteValue3 = false;
                    mixer_mt01_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayKeoTu_runStatus == false && Program.InputStatus_PLC1.khuayKeoTu_tripStatus == true)
                {
                    mixer_mt01_mainPage.DiscreteValue1 = false;
                    mixer_mt01_mainPage.DiscreteValue2 = false;
                    mixer_mt01_mainPage.DiscreteValue3 = true;
                    mixer_mt01_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayKeoTu_runStatus == true && Program.InputStatus_PLC1.khuayKeoTu_tripStatus == true)
                {
                    mixer_mt01_mainPage.DiscreteValue1 = false;
                    mixer_mt01_mainPage.DiscreteValue2 = false;
                    mixer_mt01_mainPage.DiscreteValue3 = false;
                    mixer_mt01_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mt01_mainPage.DiscreteValue1 = true;
                    mixer_mt01_mainPage.DiscreteValue2 = false;
                    mixer_mt01_mainPage.DiscreteValue3 = false;
                    mixer_mt01_mainPage.DiscreteValue4 = false;
                }
                #endregion


                #region MÁY KHUẤY TẠO BÔNG 1 "MT-02A" - GD1
                if (Program.InputStatus_PLC1.khuayTaoBong1_runStatus == true && Program.InputStatus_PLC1.khuayTaoBong1_tripStatus == false)
                {
                    mixer_mt02a_mainPage.DiscreteValue1 = false;
                    mixer_mt02a_mainPage.DiscreteValue2 = true;
                    mixer_mt02a_mainPage.DiscreteValue3 = false;
                    mixer_mt02a_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayTaoBong1_runStatus == false && Program.InputStatus_PLC1.khuayTaoBong1_tripStatus == true)
                {
                    mixer_mt02a_mainPage.DiscreteValue1 = false;
                    mixer_mt02a_mainPage.DiscreteValue2 = false;
                    mixer_mt02a_mainPage.DiscreteValue3 = true;
                    mixer_mt02a_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayTaoBong1_runStatus == true && Program.InputStatus_PLC1.khuayTaoBong1_tripStatus == true)
                {
                    mixer_mt02a_mainPage.DiscreteValue1 = false;
                    mixer_mt02a_mainPage.DiscreteValue2 = false;
                    mixer_mt02a_mainPage.DiscreteValue3 = false;
                    mixer_mt02a_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mt02a_mainPage.DiscreteValue1 = true;
                    mixer_mt02a_mainPage.DiscreteValue2 = false;
                    mixer_mt02a_mainPage.DiscreteValue3 = false;
                    mixer_mt02a_mainPage.DiscreteValue4 = false;
                }
                #endregion


                #region MÁY KHUẤY TẠO BÔNG 2 "MT-02B" - GD1
                if (Program.InputStatus_PLC1.khuayTaoBong2_runStatus == true && Program.InputStatus_PLC1.khuayTaoBong2_tripStatus == false)
                {
                    mixer_mt02b_mainPage.DiscreteValue1 = false;
                    mixer_mt02b_mainPage.DiscreteValue2 = true;
                    mixer_mt02b_mainPage.DiscreteValue3 = false;
                    mixer_mt02b_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayTaoBong2_runStatus == false && Program.InputStatus_PLC1.khuayTaoBong2_tripStatus == true)
                {
                    mixer_mt02b_mainPage.DiscreteValue1 = false;
                    mixer_mt02b_mainPage.DiscreteValue2 = false;
                    mixer_mt02b_mainPage.DiscreteValue3 = true;
                    mixer_mt02b_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.khuayTaoBong2_runStatus == true && Program.InputStatus_PLC1.khuayTaoBong2_tripStatus == true)
                {
                    mixer_mt02b_mainPage.DiscreteValue1 = false;
                    mixer_mt02b_mainPage.DiscreteValue2 = false;
                    mixer_mt02b_mainPage.DiscreteValue3 = false;
                    mixer_mt02b_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    mixer_mt02b_mainPage.DiscreteValue1 = true;
                    mixer_mt02b_mainPage.DiscreteValue2 = false;
                    mixer_mt02b_mainPage.DiscreteValue3 = false;
                    mixer_mt02b_mainPage.DiscreteValue4 = false;
                }
                #endregion

                // BƠM ĐỊNH LƯỢNG HÓA CHẤT
                #region Bơm định lượng Metanol "DPETN" - GD1MR
                if (Program.InputStatus_PLC2.etanol1_runStatus == true && Program.InputStatus_PLC2.etanol1_tripStatus == false)
                {
                    dlPump_dpetn_mainPage.DiscreteValue1 = false;
                    dlPump_dpetn_mainPage.DiscreteValue2 = true;
                    dlPump_dpetn_mainPage.DiscreteValue3 = false;
                    dlPump_dpetn_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.etanol1_runStatus == false && Program.InputStatus_PLC2.etanol1_tripStatus == true)
                {
                    dlPump_dpetn_mainPage.DiscreteValue1 = false;
                    dlPump_dpetn_mainPage.DiscreteValue2 = false;
                    dlPump_dpetn_mainPage.DiscreteValue3 = true;
                    dlPump_dpetn_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC2.etanol1_runStatus == true && Program.InputStatus_PLC2.etanol1_tripStatus == true)
                {
                    dlPump_dpetn_mainPage.DiscreteValue1 = false;
                    dlPump_dpetn_mainPage.DiscreteValue2 = false;
                    dlPump_dpetn_mainPage.DiscreteValue3 = false;
                    dlPump_dpetn_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_dpetn_mainPage.DiscreteValue1 = true;
                    dlPump_dpetn_mainPage.DiscreteValue2 = false;
                    dlPump_dpetn_mainPage.DiscreteValue3 = false;
                    dlPump_dpetn_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region Bơm định lượng NP "DP-03" - GD1
                if (Program.InputStatus_PLC1.dlNp_runStatus == true && Program.InputStatus_PLC1.dlNp_tripStatus == false)
                {
                    dlPump_dp03_mainPage.DiscreteValue1 = false;
                    dlPump_dp03_mainPage.DiscreteValue2 = true;
                    dlPump_dp03_mainPage.DiscreteValue3 = false;
                    dlPump_dp03_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dlNp_runStatus == false && Program.InputStatus_PLC1.dlNp_tripStatus == true)
                {
                    dlPump_dp03_mainPage.DiscreteValue1 = false;
                    dlPump_dp03_mainPage.DiscreteValue2 = false;
                    dlPump_dp03_mainPage.DiscreteValue3 = true;
                    dlPump_dp03_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dlNp_runStatus == true && Program.InputStatus_PLC1.dlNp_tripStatus == true)
                {
                    dlPump_dp03_mainPage.DiscreteValue1 = false;
                    dlPump_dp03_mainPage.DiscreteValue2 = false;
                    dlPump_dp03_mainPage.DiscreteValue3 = false;
                    dlPump_dp03_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_dp03_mainPage.DiscreteValue1 = true;
                    dlPump_dp03_mainPage.DiscreteValue2 = false;
                    dlPump_dp03_mainPage.DiscreteValue3 = false;
                    dlPump_dp03_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region Bơm định lượng PAC "DP-05" - GD1
                if (Program.InputStatus_PLC1.dlPac_runStatus == true && Program.InputStatus_PLC1.dlPac_tripStatus == false)

                {
                    dlPump_dp05_mainPage.DiscreteValue1 = false;
                    dlPump_dp05_mainPage.DiscreteValue2 = true;
                    dlPump_dp05_mainPage.DiscreteValue3 = false;
                    dlPump_dp05_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dlPac_runStatus == false && Program.InputStatus_PLC1.dlPac_tripStatus == true)
                {
                    dlPump_dp05_mainPage.DiscreteValue1 = false;
                    dlPump_dp05_mainPage.DiscreteValue2 = false;
                    dlPump_dp05_mainPage.DiscreteValue3 = true;
                    dlPump_dp05_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dlPac_runStatus == true && Program.InputStatus_PLC1.dlPac_tripStatus == true)
                {
                    dlPump_dp05_mainPage.DiscreteValue1 = false;
                    dlPump_dp05_mainPage.DiscreteValue2 = false;
                    dlPump_dp05_mainPage.DiscreteValue3 = false;
                    dlPump_dp05_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_dp05_mainPage.DiscreteValue1 = true;
                    dlPump_dp05_mainPage.DiscreteValue2 = false;
                    dlPump_dp05_mainPage.DiscreteValue3 = false;
                    dlPump_dp05_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region Bơm định lượng POLYME 1 "DP-06" - GD1
                if (Program.InputStatus_PLC1.dlPolyme1_runStatus == true && Program.InputStatus_PLC1.dlPolyme1_tripStatus == false)

                {
                    dlPump_dp06_mainPage_01p2.DiscreteValue1 = false;
                    dlPump_dp06_mainPage_01p2.DiscreteValue2 = true;
                    dlPump_dp06_mainPage_01p2.DiscreteValue3 = false;
                    dlPump_dp06_mainPage_01p2.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dlPolyme1_runStatus == false && Program.InputStatus_PLC1.dlPolyme1_tripStatus == true)
                {
                    dlPump_dp06_mainPage_01p2.DiscreteValue1 = false;
                    dlPump_dp06_mainPage_01p2.DiscreteValue2 = false;
                    dlPump_dp06_mainPage_01p2.DiscreteValue3 = true;
                    dlPump_dp06_mainPage_01p2.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dlPolyme1_runStatus == true && Program.InputStatus_PLC1.dlPolyme1_tripStatus == true)
                {
                    dlPump_dp06_mainPage_01p2.DiscreteValue1 = false;
                    dlPump_dp06_mainPage_01p2.DiscreteValue2 = false;
                    dlPump_dp06_mainPage_01p2.DiscreteValue3 = false;
                    dlPump_dp06_mainPage_01p2.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_dp06_mainPage_01p2.DiscreteValue1 = true;
                    dlPump_dp06_mainPage_01p2.DiscreteValue2 = false;
                    dlPump_dp06_mainPage_01p2.DiscreteValue3 = false;
                    dlPump_dp06_mainPage_01p2.DiscreteValue4 = false;
                }
                #endregion

                #region Bơm định lượng POLYME 2 "DP-06" - GD1
                if (Program.InputStatus_PLC1.dlPolyme2_runStatus == true && Program.InputStatus_PLC1.dlPolyme2_tripStatus == false)

                {
                    dlPump_dp06_mainPage_02p2.DiscreteValue1 = false;
                    dlPump_dp06_mainPage_02p2.DiscreteValue2 = true;
                    dlPump_dp06_mainPage_02p2.DiscreteValue3 = false;
                    dlPump_dp06_mainPage_02p2.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dlPolyme2_runStatus == false && Program.InputStatus_PLC1.dlPolyme2_tripStatus == true)
                {
                    dlPump_dp06_mainPage_02p2.DiscreteValue1 = false;
                    dlPump_dp06_mainPage_02p2.DiscreteValue2 = false;
                    dlPump_dp06_mainPage_02p2.DiscreteValue3 = true;
                    dlPump_dp06_mainPage_02p2.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dlPolyme2_runStatus == true && Program.InputStatus_PLC1.dlPolyme2_tripStatus == true)
                {
                    dlPump_dp06_mainPage_02p2.DiscreteValue1 = false;
                    dlPump_dp06_mainPage_02p2.DiscreteValue2 = false;
                    dlPump_dp06_mainPage_02p2.DiscreteValue3 = false;
                    dlPump_dp06_mainPage_02p2.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_dp06_mainPage_02p2.DiscreteValue1 = true;
                    dlPump_dp06_mainPage_02p2.DiscreteValue2 = false;
                    dlPump_dp06_mainPage_02p2.DiscreteValue3 = false;
                    dlPump_dp06_mainPage_02p2.DiscreteValue4 = false;
                }
                #endregion


                #region Bơm định lượng POLYME 4A "DP04A" - GD2
                if (Program.InputStatus_PLC3.dlPolyme_04A_runStatus == true && Program.InputStatus_PLC3.dlPolyme_04A_tripStatus == false)

                {
                    dlPump_DP04A_homePage.DiscreteValue1 = false;
                    dlPump_DP04A_homePage.DiscreteValue2 = true;
                    dlPump_DP04A_homePage.DiscreteValue3 = false;
                    dlPump_DP04A_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlPolyme_04A_runStatus == false && Program.InputStatus_PLC3.dlPolyme_04A_tripStatus == true)
                {
                    dlPump_DP04A_homePage.DiscreteValue1 = false;
                    dlPump_DP04A_homePage.DiscreteValue2 = false;
                    dlPump_DP04A_homePage.DiscreteValue3 = true;
                    dlPump_DP04A_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlPolyme_04A_runStatus == true && Program.InputStatus_PLC3.dlPolyme_04A_tripStatus == true)
                {
                    dlPump_DP04A_homePage.DiscreteValue1 = false;
                    dlPump_DP04A_homePage.DiscreteValue2 = false;
                    dlPump_DP04A_homePage.DiscreteValue3 = false;
                    dlPump_DP04A_homePage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_DP04A_homePage.DiscreteValue1 = true;
                    dlPump_DP04A_homePage.DiscreteValue2 = false;
                    dlPump_DP04A_homePage.DiscreteValue3 = false;
                    dlPump_DP04A_homePage.DiscreteValue4 = false;
                }
                #endregion


                #region Bơm định lượng POLYME 4B "DP04B" - GD2
                if (Program.InputStatus_PLC3.dlPolyme_04B_runStatus == true && Program.InputStatus_PLC3.dlPolyme_04B_tripStatus == false)

                {
                    dlPump_DP04B_homePage.DiscreteValue1 = false;
                    dlPump_DP04B_homePage.DiscreteValue2 = true;
                    dlPump_DP04B_homePage.DiscreteValue3 = false;
                    dlPump_DP04B_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlPolyme_04B_runStatus == false && Program.InputStatus_PLC3.dlPolyme_04B_tripStatus == true)
                {
                    dlPump_DP04B_homePage.DiscreteValue1 = false;
                    dlPump_DP04B_homePage.DiscreteValue2 = false;
                    dlPump_DP04B_homePage.DiscreteValue3 = true;
                    dlPump_DP04B_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlPolyme_04B_runStatus == true && Program.InputStatus_PLC3.dlPolyme_04B_tripStatus == true)
                {
                    dlPump_DP04B_homePage.DiscreteValue1 = false;
                    dlPump_DP04B_homePage.DiscreteValue2 = false;
                    dlPump_DP04B_homePage.DiscreteValue3 = false;
                    dlPump_DP04B_homePage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_DP04B_homePage.DiscreteValue1 = true;
                    dlPump_DP04B_homePage.DiscreteValue2 = false;
                    dlPump_DP04B_homePage.DiscreteValue3 = false;
                    dlPump_DP04B_homePage.DiscreteValue4 = false;
                }
                #endregion

                #region Bơm định lượng PHÈN 3A "DP03A" - GD2
                if (Program.InputStatus_PLC3.dlPhen_03A_runStatus == true && Program.InputStatus_PLC3.dlPhen_03A_tripStatus == false)

                {
                    dlPump_DP03A_homePage.DiscreteValue1 = false;
                    dlPump_DP03A_homePage.DiscreteValue2 = true;
                    dlPump_DP03A_homePage.DiscreteValue3 = false;
                    dlPump_DP03A_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlPhen_03A_runStatus == false && Program.InputStatus_PLC3.dlPhen_03A_tripStatus == true)
                {
                    dlPump_DP03A_homePage.DiscreteValue1 = false;
                    dlPump_DP03A_homePage.DiscreteValue2 = false;
                    dlPump_DP03A_homePage.DiscreteValue3 = true;
                    dlPump_DP03A_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlPhen_03A_runStatus == true && Program.InputStatus_PLC3.dlPhen_03A_tripStatus == true)
                {
                    dlPump_DP03A_homePage.DiscreteValue1 = false;
                    dlPump_DP03A_homePage.DiscreteValue2 = false;
                    dlPump_DP03A_homePage.DiscreteValue3 = false;
                    dlPump_DP03A_homePage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_DP03A_homePage.DiscreteValue1 = true;
                    dlPump_DP03A_homePage.DiscreteValue2 = false;
                    dlPump_DP03A_homePage.DiscreteValue3 = false;
                    dlPump_DP03A_homePage.DiscreteValue4 = false;
                }
                #endregion

                #region Bơm định lượng PHÈN 3B "DP03B" - GD2
                if (Program.InputStatus_PLC3.dlPhen_03B_runStatus == true && Program.InputStatus_PLC3.dlPhen_03B_tripStatus == false)

                {
                    dlPump_DP03B_homePage.DiscreteValue1 = false;
                    dlPump_DP03B_homePage.DiscreteValue2 = true;
                    dlPump_DP03B_homePage.DiscreteValue3 = false;
                    dlPump_DP03B_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlPhen_03B_runStatus == false && Program.InputStatus_PLC3.dlPhen_03B_tripStatus == true)
                {
                    dlPump_DP03B_homePage.DiscreteValue1 = false;
                    dlPump_DP03B_homePage.DiscreteValue2 = false;
                    dlPump_DP03B_homePage.DiscreteValue3 = true;
                    dlPump_DP03B_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlPhen_03B_runStatus == true && Program.InputStatus_PLC3.dlPhen_03B_tripStatus == true)
                {
                    dlPump_DP03B_homePage.DiscreteValue1 = false;
                    dlPump_DP03B_homePage.DiscreteValue2 = false;
                    dlPump_DP03B_homePage.DiscreteValue3 = false;
                    dlPump_DP03B_homePage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_DP03B_homePage.DiscreteValue1 = true;
                    dlPump_DP03B_homePage.DiscreteValue2 = false;
                    dlPump_DP03B_homePage.DiscreteValue3 = false;
                    dlPump_DP03B_homePage.DiscreteValue4 = false;
                }
                #endregion

                #region Bơm định lượng XÚT 05A "DP05A" - GD2
                if (Program.InputStatus_PLC3.dlXut_05A_runStatus == true && Program.InputStatus_PLC3.dlXut_05A_tripStatus == false)

                {
                    dlPump_DP05A_homePage.DiscreteValue1 = false;
                    dlPump_DP05A_homePage.DiscreteValue2 = true;
                    dlPump_DP05A_homePage.DiscreteValue3 = false;
                    dlPump_DP05A_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlXut_05A_runStatus == false && Program.InputStatus_PLC3.dlXut_05A_tripStatus == true)
                {
                    dlPump_DP05A_homePage.DiscreteValue1 = false;
                    dlPump_DP05A_homePage.DiscreteValue2 = false;
                    dlPump_DP05A_homePage.DiscreteValue3 = true;
                    dlPump_DP05A_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlXut_05A_runStatus == true && Program.InputStatus_PLC3.dlXut_05A_tripStatus == true)
                {
                    dlPump_DP05A_homePage.DiscreteValue1 = false;
                    dlPump_DP05A_homePage.DiscreteValue2 = false;
                    dlPump_DP05A_homePage.DiscreteValue3 = false;
                    dlPump_DP05A_homePage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_DP05A_homePage.DiscreteValue1 = true;
                    dlPump_DP05A_homePage.DiscreteValue2 = false;
                    dlPump_DP05A_homePage.DiscreteValue3 = false;
                    dlPump_DP05A_homePage.DiscreteValue4 = false;
                }
                #endregion


                #region Bơm định lượng XÚT 05B "DP05B" - GD2
                if (Program.InputStatus_PLC3.dlXut_05B_runStatus == true && Program.InputStatus_PLC3.dlXut_05B_tripStatus == false)

                {
                    dlPump_DP05B_homePage.DiscreteValue1 = false;
                    dlPump_DP05B_homePage.DiscreteValue2 = true;
                    dlPump_DP05B_homePage.DiscreteValue3 = false;
                    dlPump_DP05B_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlXut_05B_runStatus == false && Program.InputStatus_PLC3.dlXut_05B_tripStatus == true)
                {
                    dlPump_DP05B_homePage.DiscreteValue1 = false;
                    dlPump_DP05B_homePage.DiscreteValue2 = false;
                    dlPump_DP05B_homePage.DiscreteValue3 = true;
                    dlPump_DP05B_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlXut_05B_runStatus == true && Program.InputStatus_PLC3.dlXut_05B_tripStatus == true)
                {
                    dlPump_DP05B_homePage.DiscreteValue1 = false;
                    dlPump_DP05B_homePage.DiscreteValue2 = false;
                    dlPump_DP05B_homePage.DiscreteValue3 = false;
                    dlPump_DP05B_homePage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_DP05B_homePage.DiscreteValue1 = true;
                    dlPump_DP05B_homePage.DiscreteValue2 = false;
                    dlPump_DP05B_homePage.DiscreteValue3 = false;
                    dlPump_DP05B_homePage.DiscreteValue4 = false;
                }
                #endregion


                #region Bơm định lượng DD 06A "DP06A" - GD2
                if (Program.InputStatus_PLC3.dlDd_06A_runStatus == true && Program.InputStatus_PLC3.dlDd_06A_tripStatus == false)

                {
                    dlPump_DP06A_homePage.DiscreteValue1 = false;
                    dlPump_DP06A_homePage.DiscreteValue2 = true;
                    dlPump_DP06A_homePage.DiscreteValue3 = false;
                    dlPump_DP06A_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlDd_06A_runStatus == false && Program.InputStatus_PLC3.dlDd_06A_tripStatus == true)
                {
                    dlPump_DP06A_homePage.DiscreteValue1 = false;
                    dlPump_DP06A_homePage.DiscreteValue2 = false;
                    dlPump_DP06A_homePage.DiscreteValue3 = true;
                    dlPump_DP06A_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlDd_06A_runStatus == true && Program.InputStatus_PLC3.dlDd_06A_tripStatus == true)
                {
                    dlPump_DP06A_homePage.DiscreteValue1 = false;
                    dlPump_DP06A_homePage.DiscreteValue2 = false;
                    dlPump_DP06A_homePage.DiscreteValue3 = false;
                    dlPump_DP06A_homePage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_DP06A_homePage.DiscreteValue1 = true;
                    dlPump_DP06A_homePage.DiscreteValue2 = false;
                    dlPump_DP06A_homePage.DiscreteValue3 = false;
                    dlPump_DP06A_homePage.DiscreteValue4 = false;
                }
                #endregion


                #region Bơm định lượng DD 06B "DP06B" - GD2
                if (Program.InputStatus_PLC3.dlDd_06B_runStatus == true && Program.InputStatus_PLC3.dlDd_06B_tripStatus == false)

                {
                    dlPump_DP06B_homePage.DiscreteValue1 = false;
                    dlPump_DP06B_homePage.DiscreteValue2 = true;
                    dlPump_DP06B_homePage.DiscreteValue3 = false;
                    dlPump_DP06B_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlDd_06B_runStatus == false && Program.InputStatus_PLC3.dlDd_06B_tripStatus == true)
                {
                    dlPump_DP06B_homePage.DiscreteValue1 = false;
                    dlPump_DP06B_homePage.DiscreteValue2 = false;
                    dlPump_DP06B_homePage.DiscreteValue3 = true;
                    dlPump_DP06B_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlDd_06B_runStatus == true && Program.InputStatus_PLC3.dlDd_06B_tripStatus == true)
                {
                    dlPump_DP06B_homePage.DiscreteValue1 = false;
                    dlPump_DP06B_homePage.DiscreteValue2 = false;
                    dlPump_DP06B_homePage.DiscreteValue3 = false;
                    dlPump_DP06B_homePage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_DP06B_homePage.DiscreteValue1 = true;
                    dlPump_DP06B_homePage.DiscreteValue2 = false;
                    dlPump_DP06B_homePage.DiscreteValue3 = false;
                    dlPump_DP06B_homePage.DiscreteValue4 = false;
                }
                #endregion


                #region Bơm định lượng 09A "DP09A" - GD2 => ??? không xác định được Tag => Không có

                #endregion

                #region Bơm định lượng Xút "DP-02" - GD1
                if (Program.InputStatus_PLC1.dlXut_runStatus == true && Program.InputStatus_PLC1.dlXut_tripStatus == false)

                {
                    dlPump_dp02_mainPage.DiscreteValue1 = false;
                    dlPump_dp02_mainPage.DiscreteValue2 = true;
                    dlPump_dp02_mainPage.DiscreteValue3 = false;
                    dlPump_dp02_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dlXut_runStatus == false && Program.InputStatus_PLC1.dlXut_tripStatus == true)
                {
                    dlPump_dp02_mainPage.DiscreteValue1 = false;
                    dlPump_dp02_mainPage.DiscreteValue2 = false;
                    dlPump_dp02_mainPage.DiscreteValue3 = true;
                    dlPump_dp02_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dlXut_runStatus == true && Program.InputStatus_PLC1.dlXut_tripStatus == true)
                {
                    dlPump_dp02_mainPage.DiscreteValue1 = false;
                    dlPump_dp02_mainPage.DiscreteValue2 = false;
                    dlPump_dp02_mainPage.DiscreteValue3 = false;
                    dlPump_dp02_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_dp02_mainPage.DiscreteValue1 = true;
                    dlPump_dp02_mainPage.DiscreteValue2 = false;
                    dlPump_dp02_mainPage.DiscreteValue3 = false;
                    dlPump_dp02_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region Bơm định lượng CLO "DP-04" - GD2
                if (Program.InputStatus_PLC1.dlClo_runStatus == true && Program.InputStatus_PLC1.dlClo_tripStatus == false)

                {
                    dlPump_dp04_mainPage.DiscreteValue1 = false;
                    dlPump_dp04_mainPage.DiscreteValue2 = true;
                    dlPump_dp04_mainPage.DiscreteValue3 = false;
                    dlPump_dp04_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dlClo_runStatus == false && Program.InputStatus_PLC1.dlClo_tripStatus == true)
                {
                    dlPump_dp04_mainPage.DiscreteValue1 = false;
                    dlPump_dp04_mainPage.DiscreteValue2 = false;
                    dlPump_dp04_mainPage.DiscreteValue3 = true;
                    dlPump_dp04_mainPage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC1.dlClo_runStatus == true && Program.InputStatus_PLC1.dlClo_tripStatus == true)
                {
                    dlPump_dp04_mainPage.DiscreteValue1 = false;
                    dlPump_dp04_mainPage.DiscreteValue2 = false;
                    dlPump_dp04_mainPage.DiscreteValue3 = false;
                    dlPump_dp04_mainPage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_dp04_mainPage.DiscreteValue1 = true;
                    dlPump_dp04_mainPage.DiscreteValue2 = false;
                    dlPump_dp04_mainPage.DiscreteValue3 = false;
                    dlPump_dp04_mainPage.DiscreteValue4 = false;
                }
                #endregion

                #region Bơm định lượng KHỬ TRÙNG "DP07A" - GD2
                if (Program.InputStatus_PLC3.dlKhuTrung_07A_runStatus == true && Program.InputStatus_PLC3.dlKhuTrung_07A_tripStatus == false)

                {
                    dlPump_DP07A_homePage.DiscreteValue1 = false;
                    dlPump_DP07A_homePage.DiscreteValue2 = true;
                    dlPump_DP07A_homePage.DiscreteValue3 = false;
                    dlPump_DP07A_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlKhuTrung_07A_runStatus == false && Program.InputStatus_PLC3.dlKhuTrung_07A_tripStatus == true)
                {
                    dlPump_DP07A_homePage.DiscreteValue1 = false;
                    dlPump_DP07A_homePage.DiscreteValue2 = false;
                    dlPump_DP07A_homePage.DiscreteValue3 = true;
                    dlPump_DP07A_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlKhuTrung_07A_runStatus == true && Program.InputStatus_PLC3.dlKhuTrung_07A_tripStatus == true)
                {
                    dlPump_DP07A_homePage.DiscreteValue1 = false;
                    dlPump_DP07A_homePage.DiscreteValue2 = false;
                    dlPump_DP07A_homePage.DiscreteValue3 = false;
                    dlPump_DP07A_homePage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_DP07A_homePage.DiscreteValue1 = true;
                    dlPump_DP07A_homePage.DiscreteValue2 = false;
                    dlPump_DP07A_homePage.DiscreteValue3 = false;
                    dlPump_DP07A_homePage.DiscreteValue4 = false;
                }
                #endregion

                #region Bơm định lượng KHỬ TRÙNG "DP07B" - GD2
                if (Program.InputStatus_PLC3.dlKhuTrung_07B_runStatus == true && Program.InputStatus_PLC3.dlKhuTrung_07B_tripStatus == false)

                {
                    dlPump_DP07B_homePage.DiscreteValue1 = false;
                    dlPump_DP07B_homePage.DiscreteValue2 = true;
                    dlPump_DP07B_homePage.DiscreteValue3 = false;
                    dlPump_DP07B_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlKhuTrung_07B_runStatus == false && Program.InputStatus_PLC3.dlKhuTrung_07B_tripStatus == true)
                {
                    dlPump_DP07B_homePage.DiscreteValue1 = false;
                    dlPump_DP07B_homePage.DiscreteValue2 = false;
                    dlPump_DP07B_homePage.DiscreteValue3 = true;
                    dlPump_DP07B_homePage.DiscreteValue4 = false;
                }
                else if (Program.InputStatus_PLC3.dlKhuTrung_07B_runStatus == true && Program.InputStatus_PLC3.dlKhuTrung_07B_tripStatus == true)
                {
                    dlPump_DP07B_homePage.DiscreteValue1 = false;
                    dlPump_DP07B_homePage.DiscreteValue2 = false;
                    dlPump_DP07B_homePage.DiscreteValue3 = false;
                    dlPump_DP07B_homePage.DiscreteValue4 = true;
                }
                else
                {
                    dlPump_DP07B_homePage.DiscreteValue1 = true;
                    dlPump_DP07B_homePage.DiscreteValue2 = false;
                    dlPump_DP07B_homePage.DiscreteValue3 = false;
                    dlPump_DP07B_homePage.DiscreteValue4 = false;
                }
                #endregion

                #endregion





            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        #endregion

        #region EVENT METHOD
        private void btn_system_mainPage_Click(object sender, EventArgs e)
        {
        }

        private void airPump_mtk01_mainPage_Click(object sender, EventArgs e)
        {
        }
        private void btn_exitHomePage_Click(object sender, EventArgs e)
        {
        }


        #region trash do not delete
        private void sb_MS2_Click(object sender, EventArgs e)
        {

        }

        private void sb_MS2_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void standardControl8_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btn_caiDat_HomePage_Click(object sender, EventArgs e)
        {

        }
        private void HOME_Load(object sender, EventArgs e)
        {
            timerHome1 = new System.Timers.Timer();
            timerHome1.Interval = updatePeriod;
            timerHome1.Elapsed += updateEventHandler;
            timerHome1.AutoReset = true;
            timerHome1.Enabled = true;
        }
        #endregion

        #region OVERIDING METHOD
        #endregion






       




private void standardControl61_Load(object sender, EventArgs e)
        {

        }

        private void standardControl124_Load(object sender, EventArgs e)
        {

        }

        private void standardControl33_Load(object sender, EventArgs e)
        {

        }

        private void standardControl39_Load(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void facePlateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StandardControl entity = contextFacePlate.SourceControl as StandardControl;
            string entityName = entity.Tag.ToString();

            //Define faceplate - PUMP
            Faceplate_Pump fp_device = new Faceplate_Pump(this);
            fp_device.TopMost = true;
            fp_device.TopLevel = true;
            fp_device.Text = entityName;

            //SET TITLE FOR FACEPLATE
            Control[] temp1 = fp_device.Controls.Find("lb_PumpName", true);
            Control titleLabel = temp1[0];
            titleLabel.Text = entityName;
            fp_device.Show();

            bool onStatus,tripStatus;
            onStatus = tripStatus = false;

            if(entity.Name == "airPump_mtk01_homePage")
            {
                onStatus = Program.InputStatus_PLC1.mtk01_runStatus;
                tripStatus = Program.InputStatus_PLC1.mtk01_tripStatus;
            }

            if (entity.Name == "airPump_mtk02_homePage")
            {
                onStatus = Program.InputStatus_PLC1.mtk02_runStatus;
                tripStatus = Program.InputStatus_PLC1.mtk02_tripStatus;
            }

            if (entity.Name == "airPump_mtk03_homePage")
            {
                onStatus = Program.InputStatus_PLC1.mtk03_runStatus;
                tripStatus = Program.InputStatus_PLC1.mtk03_tripStatus;
            }
            if (entity.Name == "dlPump_dpetn_mainPage")
            {
                onStatus = Program.InputStatus_PLC2.etanol1_runStatus;
                tripStatus = Program.InputStatus_PLC2.etanol1_tripStatus;
            }

            if (entity.Name == "dlPump_dp03_mainPage")
            {
                onStatus = Program.InputStatus_PLC1.dlNp_runStatus;
                tripStatus = Program.InputStatus_PLC1.dlNp_tripStatus;
            }







            ///////////////////////////////////////////////////////////////////////////////////
            Control[] temp2 = fp_device.Controls.Find("lb_Status", true);
            Control deviceStatus = temp2[0];
            Control[] temp3 = fp_device.Controls.Find("lb_Alarm", true);
            Control deviceAlarm = temp3[0];
            Control[] temp4 = fp_device.Controls.Find("lb_Mode", true);
            Control deviceMode = temp4[0];

            Control[] temp5 = fp_device.Controls.Find("sb_ON", true);
            //Control deviceBtnOn_temp = temp5[0];
            StandardControl deviceBtnOn = temp5[0] as StandardControl;
            Control[] temp6 = fp_device.Controls.Find("sb_OFF", true);
            //Control deviceBtnOff = temp6[0];
            StandardControl deviceBtnOff = temp6[0] as StandardControl;
            Control[] temp7 = fp_device.Controls.Find("sb_TRIP", true);
            //Control deviceTripLight = temp7[0];
            StandardControl deviceTripLight = temp7[0] as StandardControl;

            Control[] temp8 = fp_device.Controls.Find("lb_Motor", true);
            Control deviceMotor = temp8[0];
            Control[] temp9 = fp_device.Controls.Find("lb_R_HOUR", true);
            Control deviceRhour = temp9[0];
            Control[] temp10 = fp_device.Controls.Find("lb_T_RUNNING_H", true);
            Control deviceRunH = temp10[0];
            Control[] temp11 = fp_device.Controls.Find("lb_T_RUNNING_M", true);
            Control deviceRunM = temp11[0];
            Control[] temp12 = fp_device.Controls.Find("lb_T_RUNNING_S", true);
            Control deviceRunS = temp12[0];

            deviceMode.Text = "UNDEFINED";


            if (onStatus == true && tripStatus == false)
            {
                deviceStatus.Text = "ON";
                deviceAlarm.Text = "DEACTIVE";
                deviceBtnOn.FillColor = Color.Lime;
                deviceBtnOff.FillColor = Color.FromArgb(255,193,0,0);
                deviceTripLight.FillColor = Color.FromArgb(255, 210, 210, 210);
            }
            else if (onStatus == false && tripStatus == true)
            {
                deviceStatus.Text = "TRIP";
                deviceAlarm.Text = "ACTIVE";
                deviceBtnOn.FillColor= Color.FromArgb(255, 0, 159, 0);
                deviceBtnOff.FillColor = Color.FromArgb(255, 193, 0, 0);
                deviceTripLight.FillColor = Color.Yellow;
            }
            else if (onStatus == false && tripStatus == false)
            {
                deviceStatus.Text = "OFF";
                deviceAlarm.Text = "DEACTIVE";
                deviceBtnOn.FillColor = Color.FromArgb(255,0,159,0);
                deviceBtnOff.FillColor = Color.Red;
                deviceTripLight.FillColor = Color.FromArgb(255, 210, 210, 210);
            }
            else
            {
                deviceStatus.Text = "UNDEFINED!";
                deviceAlarm.Text = "DEACTIVE";
                deviceBtnOn.FillColor = Color.FromArgb(255, 0, 159, 0);
                deviceBtnOff.FillColor = Color.FromArgb(255,193,0,0);
                deviceTripLight.FillColor = Color.FromArgb(255, 210, 210, 210);
            }

            //0;159;0 gREEN
            //193;0;0 rED
            //210;210;210 gREY


        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #endregion


    }
}
