using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UZTA1
{
    class VerticalProgressBar:ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams orintataion = base.CreateParams;
                orintataion.Style = 0x04;
                return orintataion;
            }
        }
    }
}
