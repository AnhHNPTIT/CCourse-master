using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTVN_Day5
{
    class StringRepository : IRepository
    {
        public int CountOccurences(string text, string textToSearch)
        {
            //return text.Split().Count(w => w.Equals(textToSearch));

            char[] seperator = { ' ', ';', '!' };
            return text.Split(seperator, StringSplitOptions.None).Count(w => w.Equals(textToSearch));
        }
    }
}
