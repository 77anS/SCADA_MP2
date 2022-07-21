using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.Rule
{
    public interface IUpdateUI
    {
        /// <summary>
        /// Function update setting time of devices to UI
        /// </summary>
        /// <param name="focusOnEvent">focus on textbox of setting time</param>
        /// <param name="diffRealNUI">value notice difference data set and data setting time reality are on</param>
        /// <param name="element">id of textbox</param>
        void updateSettingTime(bool focusOnEvent,bool diffRealNUI, int element);
    }
}
