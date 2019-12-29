using System;

namespace BTVN_Day8
{
    //để thông báo thông tin về event
    public class SampleEventArgs
    {
        public SampleEventArgs(string message) { Text = message; }
        public string Text { get; }
    }

    public class Add
    {
        public delegate void SampleEventHandler(object sender, SampleEventArgs e);
        public event SampleEventHandler NewOddNumberAdded;

        protected virtual void OddNumberAdded(int number)
        {
            Predicate<int> isOddDigit = (number) => { return (number % 2 == 1); };
            if (isOddDigit(number))
            {
                NewOddNumberAdded?.Invoke(this, new SampleEventArgs($"{DateTime.Now} new odd number!"));
                Console.WriteLine($"Odd Number: {number}");
            }
            else
            {
                Console.WriteLine("You haven't entered an odd number!");
            }
        }

        public void AddOddNumber()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            OddNumberAdded(number);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Add add = new Add();
            //add.NewOddNumberAdded += Add_NewOddNumberAdd;

            //add.NewOddNumberAdded += new Add.SampleEventHandler ( delegate(object sender, SampleEventArgs e) 
            //{
            //    Console.WriteLine("Da nhan thong bao tu phia Add - client 2!");
            //    Console.WriteLine(e.Text); 
            //});

            add.NewOddNumberAdded += ((s, e) =>
            {
                Console.WriteLine("Da nhan thong bao tu phia Add - client 3!");
                Console.WriteLine(e.Text);
            });
            add.AddOddNumber();
        }

        private static void Add_NewOddNumberAdd(object sender, SampleEventArgs e)
        {
            Console.WriteLine("Da nhan thong bao tu phia Add - client 1!");
            Console.WriteLine(e.Text);
        }
    }
}
