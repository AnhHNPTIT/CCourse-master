using System;

namespace ActionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int, int> myNotice = (x, y, z) => { Console.WriteLine($"3 numbers is {x} and {y} and {z}"); };
            myNotice(1, 2, 3);

            Action<int, int, int> sum = (x, y, z) => { Console.WriteLine($"Sum of 3 numbers is {x + y + z}"); };
            sum(1,2,3);
        }
    }
}
