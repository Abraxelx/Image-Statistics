using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilSahinPixelApp
{
    class FillLists
    {
        public static void FillAllLists(List<int> Red, List<int> Green, List<int> Blue,Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Red.Add(bmp.GetPixel(i, j).R);
                    Green.Add(bmp.GetPixel(i, j).G);
                    Blue.Add(bmp.GetPixel(i, j).B);
                }
            }

        }
    }
}
