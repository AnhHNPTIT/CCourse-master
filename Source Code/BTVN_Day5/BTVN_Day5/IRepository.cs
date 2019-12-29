using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN_Day5
{
    interface IRepository
    {
        int CountOccurences(string text, string textToSearch);
    }
}
