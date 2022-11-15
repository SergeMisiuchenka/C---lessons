using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4
{
    class Point
    {
        public double x, y;
        public string textPoint;

        public double Side1
        {
            get { return x; }
        }

        public double Side2
        {
            get { return y; }
        }

        public string TextPoint
        {
            get { return textPoint; }
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(string textPoint)
        {
            this.textPoint = textPoint;
        }


    }
}
