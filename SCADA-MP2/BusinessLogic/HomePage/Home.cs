using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SCADA_baseClass = B_SCADA_Library_dotNetFramework.BaseClass;
namespace SCADA_MP2.Presentation
{
    public partial class Home
    {
        #region FIELD

        #endregion

        #region METHOD
        public void runTask()
        {
            SCADA_baseClass.Task.Task myTask = Program.B_SCADA.FindTask("homePageTask");
            myTask.runTask_read();
        }
        #endregion
    }
}
