using System;

namespace FuncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> sum = (x, y) => { return x + y; };
            Console.WriteLine(sum(1, 2));

            Func<int, int, int> mul = (x, y) => { return x * y; };
            Console.WriteLine(mul(1, 2));
        }
    }
}
