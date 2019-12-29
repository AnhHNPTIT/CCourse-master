using System;
using System.Collections;

namespace IEnumerableDemo
{
    class Program
    {
        // Simple business object
        public class Person
        {
            public string firstName;
            public string lastName;
            public Person(string fName, string lName)
            {
                this.firstName = fName;
                this.lastName = lName;
            }
        }

        // Collection of Person objects. This class implements IEnumerable
        // so that it can be used with Foreach syntax
        public class People : IEnumerable
        {
            private Person[] listPeople;
            public People(Person[] lPeople)
            {
                listPeople = new Person[lPeople.Length];

                for (int i = 0; i < lPeople.Length; i++)
                {
                    listPeople[i] = lPeople[i];
                }
            }

            // Implementation for the GetEnumerator method
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)GetEnumerator();
            }

            public PeopleEnum GetEnumerator()
            {
                return new PeopleEnum(listPeople);
            }
        }

        // When you implement IEnumerable, you must also implement IEnumerator
        public class PeopleEnum : IEnumerator
        {
            public Person[] listPeople;

            // Enumerators are positioned before the first element until the first MoveNext() call
            int position = -1;

            public PeopleEnum(Person[] list)
            {
                listPeople = list;
            }
            public bool MoveNext()
            {
                position++;
                return (position < listPeople.Length);
            }

            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public Person Current
            {
                get
                {
                    try
                    {
                        return listPeople[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
            {
                new Person("Hoang", "Anh"),
                new Person("Do", "Canh"),
                new Person("Do", "Anh"),
            };

            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
            {
                Console.WriteLine(p.firstName + " " + p.lastName);
            }
        }
    }
}