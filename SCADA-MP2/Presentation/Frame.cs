using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BSCADA_Frame = B_SCADA_Library_dotNetFramework.Resources.Library.Frame.style_1_bcm.Frame;
using BSCADA_Footer = SCADA_MP2.Presentation.Footer;
namespace SCADA_MP2.Presentation
{
    public class Frame : BSCADA_Frame
    {
        public override void myFooter_Load(B_SCADA_Library_dotNetFramework.Resources.Library.Footer.style_1_bcmStyle.Footer footer, Form _parentOfFooter)
        {
            base.myFooter_Load(new BSCADA_Footer(), this);
        }
    }
}
