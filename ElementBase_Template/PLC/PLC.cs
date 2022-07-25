using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;

using System.Timers;

namespace ElementBase_Template.PLC.Data_Mapping.Engine
{
    public class PLC
    {
        #region FIELDS
        public string plcName { get; set; } = "Undefined";
        public CpuType cpuType { get; set; } = CpuType.S71200;
        public string ipAddress { get; set; } = "192.168.100.10";
        public int port { get; set; } = 502;
        public string subnetMask { get; set; } = "255.255.255.0";

        public short rack { get; set; } = 0;
        public short slot { get; set; } = 1;

        public int updatePeriod { get; set; } = 500;

        public Plc plc { get; set; }

        public string plc_error { get; set; } // Lỗi trong khi thao tác với PLC
        public ErrorCode plc_connectError { get; set; } // Lỗi khi kết nối PLC
        public bool plc_connected { get; set; } = false; // True: PLC đã được kết nối
        public bool plc_isAvailable { get; set; } = false; // True: PLC đã sẵn sàng

        public Timer timer_plc { get; set; }

        #endregion

        #region CONSTRUCTOR

            public PLC()
            {
                plc = new Plc(this.cpuType, this.ipAddress, this.rack, this.slot);
            }
             /// <summary>
            /// CONSTRUCTOR FOR INITILIZING CLASS
            /// </summary>
            /// <param name="plcName">Specify name for PLC</param>
            /// <param name="cpuType">Type of PLC</param>
            /// <param name="ipAddress">IP Address of PLC</param>
            /// <param name="rack">Number of rack</param>
            /// <param name="slot">Slot number</param>
            /// <param name="updatedPeriod">Period for connecting and readding DATA from PLC</param>
            public PLC(string plcName, CpuType cpuType, string ipAddress, short rack, short slot, int updatedPeriod)
            {
                this.plcName = plcName;
                this.cpuType = cpuType;
                this.ipAddress = ipAddress;
                this.rack = rack;
                this.slot = slot;
                this.updatePeriod = updatedPeriod;

                this.plc = new Plc(this.cpuType, this.ipAddress, this.rack, this.slot);
            }

            /// <summary>
            /// CONSTRUCTOR FOR INITILIZING CLASS
            /// </summary>
            /// <param name="plcName">Specify name for PLC</param>
            /// <param name="cpuType">Type of PLC</param>
            /// <param name="ipAddress">IP Address of PLC</param>
            /// <param name="rack">Number of rack</param>
            /// <param name="slot">Slot number</param>
            /// <param name="port">port number</param>
            /// <param name="subnetmask">Subnet mask</param>
            /// <param name="updatedPeriod">Period for connecting and readding DATA from PLC</param>
            public PLC(string plcName, CpuType cpuType, string ipAddress, short rack, short slot, int port, string subnetmask, int updatedPeriod)
            {
                this.plcName = plcName;
                this.cpuType = cpuType;
                this.ipAddress = ipAddress;
                this.port = port;
                this.subnetMask = subnetMask;
                this.rack = rack;
                this.slot = slot;
                this.updatePeriod = updatedPeriod;

                this.plc = new Plc(this.cpuType, this.ipAddress, this.rack, this.slot);
        }
        #endregion

        #region METHODS
            /// <summary>
            /// DO SOMETHING AT PERIOD
            /// </summary>
            /// <param name="plc_stopOtherConnecting">True: Allow do something in period</param>
            public void updatedEngine(bool plc_stopOtherConnecting)
            {
                timer_plc = new Timer(this.updatePeriod);
                timer_plc.Elapsed += this.updateEventHandler;
                timer_plc.AutoReset = true;
                timer_plc.Enabled = plc_stopOtherConnecting;
        }

            public virtual void updateEventHandler(object sender, ElapsedEventArgs e)
            {
                //Do something here
            }
        #endregion

    }
}
