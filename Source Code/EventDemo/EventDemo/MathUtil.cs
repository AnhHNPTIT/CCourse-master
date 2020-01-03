using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class MathUtil
    {
        public static long XOfN(int x, int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("N must >= 0");
            }
            long result = 1;
            for(int i = 1; i <= n; i++)
            {
                result *= x;
            }
            return result;
        }

        public static long Add(long num1, long num2)
        {
            return num1 + num2;
        }

        public static long Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Add2Numbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
