using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class RectangleHelper
    {
        public static double AreaCalculator(double side1, double side2)
        {
            double area = side1 * side2;
            return area;
        }

        public static double PerimeterCalculator(double side1, double side2)
        {
            double perimeter = (side1 + side2) * 2;
            return perimeter;
        }
    }
}
