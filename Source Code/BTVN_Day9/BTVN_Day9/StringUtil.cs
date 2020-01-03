using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BTVN_Day9
{
    public class StringUtil
    {
        public static bool checkSpecialCharacterInString(string stringToCheck)
        {
            var regexItem = new Regex("^[a-zA-Z0-9]*$");
            return !regexItem.IsMatch(stringToCheck);
        }

        public static int CountDigitInString(string stringToCount)
        {
            if (stringToCount.Length == 0 || checkSpecialCharacterInString(stringToCount))
            {
                throw new ArgumentException("You must enter a string not contain special character!");
            }
            var result = 0;
            result = stringToCount.Count(c => char.IsDigit(c));
            return result;
        }
    }
}
