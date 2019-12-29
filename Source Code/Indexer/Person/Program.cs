
using System;
using System.Collections.Generic;

namespace Indexer
{
    class Person
    {
        string name;
        private List<Person> Children = new List<Person>();
        
        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }
        static void Main(string[] args)
        {
            Person sam = new Person();

            sam.Children.Add(new Person { name = "Anh" });
            sam.Children.Add(new Person { name = "Canh" });

            Console.WriteLine($"Sam's first child is {sam.Children[0].name}");
            Console.WriteLine($"Sam's second child is {sam.Children[1].name}");
            Console.WriteLine($"Sam's first child is {sam[0].name}");
            Console.WriteLine($"Sam's second child is {sam[1].name}");
        }
    }
}
