using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilSahinPixelApp
{
    class Standard_Deviation
    {
        public static double CalculateDeviation(List<int> list)
        {
            double average = list.Average();
            double TopValue = 0;
            for(int i =0; i<list.Count;i++)
            {
                TopValue = TopValue + Math.Pow((list[i] - average), 2);
            }
            return Math.Sqrt(TopValue / (list.Count - 1));
        }
    }
}
