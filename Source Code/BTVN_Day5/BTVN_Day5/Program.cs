using System;
using System.Collections;
using System.Linq;

namespace BTVN_Day5
{
    class CompareByLength : IComparer
    {
        public int Compare(object x, object y)
        {
            var string1 = (string)x;
            var string2 = (string)y;
            return string1.Length.CompareTo(string2.Length);
        }
    }

    class CompareByAlphabet : IComparer
    {
        public int Compare(object x, object y)
        {
            var string1 = (string)x;
            var string2 = (string)y;
            return string1.CompareTo(string2);
        }
    }

    static class MyStringExtension
    {
        public static int CountDigits(this string stringContent, bool isOdd = false)
        {
            int digit;
            if (!isOdd)
            {
                digit = stringContent.Count(c => Char.IsDigit(c));
            }
            else
            {
                digit = stringContent.Count(c => Char.IsDigit(c) && ((int)c % 2 == 1));
            }
            return digit;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //string[] words = { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"};
            //Array.Sort(words, new CompareByLength());
            //foreach (var item in words)
            //{
            //    Console.WriteLine($"{item} - {item.Length}");
            //}

            //var stringContent = "abc132x6y245z";
            //int digitCount = stringContent.Count(c => Char.IsDigit(c));
            //int oddDigitCount = stringContent.Count(c => Char.IsDigit(c) && ((int)c % 2 == 1));
            //Console.WriteLine(oddDigitCount);

            //Console.WriteLine(stringContent.CountDigits());
            //Console.WriteLine(stringContent.CountDigits(isOdd: true));

            StringRepository stringRepo = new StringRepository();
            Console.WriteLine(stringRepo.CountOccurences("Hello how hello how how","how"));
            Console.Read();
        }
    }
}
