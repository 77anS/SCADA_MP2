using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SCADA_frame = B_SCADA_Library_dotNetFramework.Resources.Library.Frame.style_1_bcm.Frame;
using SCADA_footer = SCADA_MP2.Presentation.Footer;
namespace SCADA_MP2.Presentation
{
    public class Frame : SCADA_frame
    {
        public override void myFooter_Load(B_SCADA_Library_dotNetFramework.Resources.Library.Footer.style_1_bcmStyle.Footer footer, Form _parentOfFooter)
        {
            base.myFooter_Load(new SCADA_footer(), _parentOfFooter);
        }
    }
}
