using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilSahinPixelApp
{
    class Mod
    {
        public static int Get_Mod(List<int> a)
        {
            var max = (a.GroupBy(x => x)
                      .Select(x => new { num = x, cnt = x.Count() })
                      .OrderByDescending(g => g.cnt)
                      .Select(g => g.num).First());
            return max.Key;
        }
    }
}
