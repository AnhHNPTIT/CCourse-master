using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary
{
    public class Triangle : Shape, IComparable 
        {
        public double A
        {
            get;set;
        }
        public double B
        {
            get; set;
        }
        public double C
        {
            get; set;
        }

        public override double CalculateArea()
        {
            double p = (A + B + C)/2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }



        public int CompareTo(object objToCompare)
        {
            if (objToCompare is Triangle)
            {
                var secondTriangle = (Triangle)objToCompare;
                return this.CalculateArea().CompareTo(secondTriangle.CalculateArea());
            }
            else
            {
                throw new ArgumentException("Object is not a Triangle");
            }
        }
    }
}
