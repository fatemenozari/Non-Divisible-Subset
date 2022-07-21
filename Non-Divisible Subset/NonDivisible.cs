using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Divisible_Subset
{
    internal class NonDivisible
    {
        public static int nonDivisibleSubset(int k, List<int> s)
        {

                var result = 0;
                var buckets = new int[k];
                foreach (var S in s)
                {
                   buckets[S % k]++;
                }

                for (var i = 1; i < (k + 1) / 2; ++i)
                {
                    var a = buckets[i];
                    var b = buckets[k - i];
                    result += Math.Max(a, b);
                }

                if (k % 2 == 0 && buckets[k / 2] > 0)
                {
                    ++result;
                }

                if (buckets[0] > 0)
                {
                    ++result;
                }
                return result;
            

        }
    }
}
