using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalilSahinPixelApp
{
    class OpenFD
    {
        public static System.Windows.Forms.OpenFileDialog ofd()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            return ofd;
        }
    }
}
