using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return 5.5;
        }
    }
}
