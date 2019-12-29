using System;

namespace Named_Delegate
{
    class Program
    {
        delegate int MyDelegate(int num1, int num2);
        static int Sum(int num1, int num2)
        {
            return (num1 + num2);
        }
        static void Main(string[] args)
        {
            //MyDelegate d = new MyDelegate(Sum);
            //Console.WriteLine(d(5, 6)); 


            //MyDelegate d = delegate (int num1, int num2)
            //{
            //    return (num1 + num2);
            //};
            //Console.WriteLine(d(5, 6));

            //MyDelegate d = (x, y) => { return (x + y); };
            //Console.WriteLine(d(5, 6));

            //Func<int, int, int> sum = (x, y) => { return x + y; };

            //Func<int, int, int, int> mul = (x, y, z) => { return x * y * z; };
            //Console.WriteLine(mul(1,2,3));

            //Func<int> myRandom = () =>
            //{
            //    Random rd = new Random();
            //    return rd.Next(0, 100);
            //};
            //Console.WriteLine(myRandom());

            Action myNotice = () => { Console.WriteLine("Hello World!"); };
            // Action<string> => string là chuỗi được truyền vào
            myNotice();


            Predicate<int> checkOddDigit = (number) => { return (number % 2 == 1); };
            int number = Convert.ToInt32(Console.ReadLine());
            if (checkOddDigit(number))
            {
                Console.WriteLine($"{number} is a Odd Digit");
            }
            else
            {
                Console.WriteLine($"{number} is not a Odd Digit");
            }
            Console.ReadKey();
        }
    }
}
