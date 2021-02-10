using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2Klasa
{
    public class clsMath
    {
        public long[] GenFibonacci(int brojClanova)
        {
            
            long[] result = new long[brojClanova];
            result[0] = 0;
            result[1] = 1;

            // petlja za Fibonacijev niz
            for (int i = 2; i < brojClanova; i++)
            {
                result[i] = result[i - 2] + result[i - 1];
            }

            return result;
        }
    }
}
