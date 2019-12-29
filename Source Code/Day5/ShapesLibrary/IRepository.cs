using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary
{
    public interface IRepository
    {
        int SearchStringInText(string text, string stringToSearch);
        void ReplaceStringInText(string text, string replace, string replaceTo);
    }
}
