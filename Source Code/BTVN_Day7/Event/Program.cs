using System;

namespace Event
{
    //để thông báo thông tin về event
    public class SampleEventArgs
    {
        public SampleEventArgs(string message) { Text = message; }
        public string Text { get; }
    }

    public class Publisher
    {
        public delegate void SampleEventHandler(object sender, SampleEventArgs e);
        public event SampleEventHandler NewBookPublished;

        protected virtual void RaiseNewBookEvent()
        {
            NewBookPublished?.Invoke(this, new SampleEventArgs($"{DateTime.Now} new book!"));
        }

        public void AddNewBook()
        {
            RaiseNewBookEvent();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            publisher.NewBookPublished += Publisher_NewBookPublished1;
            publisher.NewBookPublished += Publisher_NewBookPublished2;
            publisher.AddNewBook();
        }

        private static void Publisher_NewBookPublished1(object sender, SampleEventArgs e)
        {
            Console.WriteLine("Da nhan thong bao tu phia Publisher - client 1!");
            Console.WriteLine(e.Text);
        }
        private static void Publisher_NewBookPublished2(object sender, SampleEventArgs e)
        {
            Console.WriteLine("Da nhan thong bao tu phia Publisher - client 2!");
            Console.WriteLine(e.Text);
        }
    }
}
