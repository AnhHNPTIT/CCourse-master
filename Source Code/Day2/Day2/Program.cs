using System;
using System.Collections;

namespace Day2
{
    class Program
    {
        UInt64 factorial(UInt64 n, UInt64 t)
        {
            if(n == 0)
            {
                return t;
            } else
            {
                return factorial(n-1, n*t);
            }
        }
        int sum(int n, int t)
        {
            if (n == 0)
            {
                return t;
            }
            else
            {
                return sum(n - 1, n + t);
            }
        }
        int fibonacci(int n)
        {
            if(n==0 || n == 1)
            {
                return n;
            }
            else
            {
                return fibonacci(n - 2) + fibonacci(n - 1);
            }
        }
        int fibonacci(int n, int a, int b)
        {
            if(n == 0)
            {
                return a;
            }
            if(n == 1)
            {
                return b;
            }
            return fibonacci(n - 1, b, a + b);

        }
        int findMin(int[] arr, int n)
        {
            if(n == 1)
            {
                return arr[0];
            }
            else
            {
                return Math.Min(arr[n-1], findMin(arr, n-1));
            }
        }
        static void Main(string[] args)
        {
            //Program p = new Program();
            ////Console.WriteLine(p.factorial(20, 1));
            //Console.WriteLine(p.sum(500, 0));
            // in chuỗi ngược
            //Stack st = new Stack();
            //st.Push("A");
            //st.Push("B");
            //st.Push("C");
            //st.Push("D");
            //st.Push("E");
            //st.Push("F");
            //while(st.Count != 0)
            //{
            //    Console.Write(st.Pop());
            //}
            // chuyển số decimal sang binary 
            //int n = 2;
            //Stack st = new Stack();
            //while(n != 0)
            //{
            //    int du = n % 2;
            //    st.Push(du);
            //    n /= 2;
            //}
            //while (st.Count != 0)
            //{
            //    Console.Write(st.Pop());
            //}   
            // tính biểu thức hậu tố
            //String str = "5 9 3 + 4 2 * * 7 + *";
            //String[] s = str.Split(" ");
            //Stack st = new Stack();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == "+")
            //    {
            //        int a = (int)st.Pop();
            //        int b = (int)st.Pop();
            //        st.Push(b + a);

            //    }
            //    else
            //    {
            //        if (s[i] == "-")
            //        {
            //            int a = (int)st.Pop();
            //            int b = (int)st.Pop();
            //            st.Push(b - a);
            //        }
            //        else
            //        {
            //            if (s[i] == "*")
            //            {
            //                int a = (int)st.Pop();
            //                int b = (int)st.Pop();
            //                st.Push(b * a);
            //            }
            //            else
            //            {
            //                if (s[i] == "/")
            //                {
            //                    int a = (int)st.Pop();
            //                    int b = (int)st.Pop();
            //                    st.Push(b / a);
            //                }
            //                else
            //                {
            //                    st.Push(int.Parse(s[i]));
            //                }
            //            }
 
            //        }

            //    }
            //}
            //Console.Write(st.Pop());

        }
    }
}
