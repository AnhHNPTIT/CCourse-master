using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class OddNumberAddedArgument
    {
        public int OddNumberAdded { get; set; }
    }
    public class NumberStore
    {
        public List<int> Numbers { get; }
        public delegate void OddNumberAddedHandler(object sender, OddNumberAddedArgument argument);
        public event OddNumberAddedHandler OddNumberAdded;

        public NumberStore()
        {
            Numbers = new List<int>();
        }
        protected void OnOddNumberAdded()
        {
            int lastOddNumber = Numbers[Numbers.Count - 1];
            OddNumberAdded?.Invoke(this, new OddNumberAddedArgument { OddNumberAdded = lastOddNumber});
        }

        public void AddNumberToStore(int number)
        {
            Numbers.Add(number);
            if(number % 2 == 1)
            {
                OnOddNumberAdded();
            }
        }
    }
}
