using System;

namespace Day3
{
    class Program
    {
        const int RED = 1;
        const int GREEN = 2;
        const int BLUE = 3;
        static void PrintSelectedColor(int selectedCodeColor)
        {
            switch (selectedCodeColor)
            {
                case RED:
                    {
                        Console.WriteLine("RED");
                        break;
                    }
                case GREEN:
                    {
                        Console.WriteLine("GREEN");
                        break;
                    }
                case BLUE:
                    {
                        Console.WriteLine("BLUE");
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
          //  var k = MyLib.Math.Sum(5, 8);
            int enteredCodeColor = Convert.ToInt32(Console.ReadLine());
            //int color = int.Parse(Console.ReadLine());
            PrintSelectedColor(enteredCodeColor);
        }
    }
}
