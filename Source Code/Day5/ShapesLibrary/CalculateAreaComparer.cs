using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary
{
    public class CalculateAreaComparer : IComparer<Triangle>
    {
        public int Compare(Triangle firstTriangle, Triangle secondTriangle)
        {
            return firstTriangle.CalculateArea().CompareTo(secondTriangle.CalculateArea());
        }
    }
}
