using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice.CodeJamLib.Calculus
{
    public static class NutralNumbers
    {
        // greatest common factor
        static int GCF(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        // least common multiple
        static int LCM(int a, int b)
        {
            return (a / GCF(a, b)) * b;
        }
    }
}
