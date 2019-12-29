using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_Day7
{
    public class TooShortStringException : Exception
    {
        public int LevelOfDanger { get; set; }
        public String FriendlyMessage { get; set; }
    }

    public class TooLongStringException : Exception
    {
        public int StringLength { get; set; }
        public String FriendlyErrorMessage { get; set; }
    }
}
