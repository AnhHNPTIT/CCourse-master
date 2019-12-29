using System;

namespace ShapesLibrary
{
    public abstract class Shape
    {
        internal string getShapeInfo()
        {
            return BorderColor;
        }

        public string BorderColor
        {
            get;set;
        }

        public abstract double CalculateArea();
    }
}
