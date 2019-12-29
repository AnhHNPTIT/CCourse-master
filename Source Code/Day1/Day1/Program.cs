using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)   
        {
            Console.WriteLine(
                format: "{0, -9} {1} {2, 15} {3, 31}",
                "Type", "Byte(s) of memory", "Min", "Max");
            Console.WriteLine(
                format: "{0, -9} {1} {2, 31} {3, 31}",
                "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine(
                format: "{0, -9} {1} {2, 31} {3, 31}",
                "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine(
                format: "{0, -9} {1} {2, 31} {3, 31}",
                "short", sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine(
                format: "{0, -9} {1} {2, 31} {3, 31}",
                "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine(
                format: "{0, -9} {1} {2, 31} {3, 31}",
                "int", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine(
                format: "{0, -9} {1} {2, 31} {3, 31}",
                "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine(
                format: "{0, -9} {1} {2, 31} {3, 31}",
                "long", sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine(
                format: "{0, -9} {1} {2, 31} {3, 31}",
                "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine(
                format: "{0, -9} {1} {2, 31} {3, 31}",
                "float", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine(
                format: "{0, -9} {1} {2, 31} {3, 31}",
                "double", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine(
                format: "{0, -9} {1} {2, 30} {3, 31}",
                "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        }
    }
}
