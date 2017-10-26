using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilSahinPixelApp
{
    class Skewness_Stickiness
    {
        public static double Skewness(double Average, double Median,double Standard_Deviation)
        {
            return (Average - Median) / Standard_Deviation;
        }

        public static double Stickiness(List<int> list)
        {
            double average = list.Average();
            double KeepValue = 0;
            for (int i = 0; i<list.Count; i++)
            {

                KeepValue = KeepValue + Math.Pow((list[i] - average), 4);
            }
             return (KeepValue / (Math.Pow(list.Count, 4))) - 3;
        }
    }
}
