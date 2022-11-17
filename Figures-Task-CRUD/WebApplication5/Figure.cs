using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    public abstract class Figure
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public List<Point> Points { get; set; }
        public Point Center { get; set; }
        public static int ID{ get; private set; }
        public Figure()
        {

        }

        public Figure(List<Point> points)
        {
            Points = points;
            FindCenter();
            CalculateArea();
            CalculatePerimeter();
            ID++;
        }

        public abstract void FindCenter();
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
        public abstract void MoveFigure(int moveX, int moveY);
        public abstract void RotateFigure(double angle);
        public abstract void Scale(double scale);
        public abstract bool CheckID(int id);



    }
}
