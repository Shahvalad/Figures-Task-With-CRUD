using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point() { }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

    }
}
