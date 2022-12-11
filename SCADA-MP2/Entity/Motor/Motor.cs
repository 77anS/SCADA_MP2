using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADA_MP2.Entity.Motor
{
    public class Motor : B_SCADA_Library_dotNetFramework.EntityType.Motor.Motor
    {
        public float RuntimeTotal { get; set; }
        public float RuntimeDutyOn { get; set; }
        public float RuntimeDutyOff { get; set; }
        public float RuntimeROn { get; set; }
        public float RuntimeROff { get; set; }
        public bool ResetRuntime { get; set; }

        public Motor() : base()
        {

        }
        public Motor(string Name): base(Name)
        {

        }
        public Motor(string Name, object _parent): base(Name,_parent)
        {

        }
    }
}
