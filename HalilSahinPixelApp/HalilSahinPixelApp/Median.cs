using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalilSahinPixelApp
{
    class Median
    {

        public static float GetMedian(List<int> list)
        {
            float median =0;
            int t = list.Count / 2;

            if (list.Count % 2 == 0)
            {
                float val = list[t] + list[t + 1];
                median = val / 2;
            }
            else
            {
                t = list.Count / 2;
                median = list[t];
            }

            return median;
        }



    }
}
