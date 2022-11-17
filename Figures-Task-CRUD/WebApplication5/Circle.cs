using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    public class Circle : Figure
    {
        public static double Radius;
        public Circle() { }
        public int ID { get; set; }
        public Circle(List<Point> points) : base(points)
        {
            ID = Figure.ID;
            Radius = Math.Sqrt(Math.Pow((points[1].X - points[0].X), 2) + Math.Pow((points[1].Y - points[0].Y), 2));
            FindCenter(); 
            CalculateArea(); 
            CalculatePerimeter();
        }

        public override void FindCenter()
        {
            Center = Points[0];
        }

        public override double CalculateArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }

        public override double CalculatePerimeter()
        {
            Perimeter = 2 * Math.PI * Radius;
            return Perimeter;
        }

        public override void MoveFigure(int moveX, int moveY)
        {
            foreach (var point in Points)
            {
                point.X += moveX;
                point.Y += moveY;
            }
        }

        public override void RotateFigure(double angle)
        {
            Console.WriteLine("Rotated!");
        }

        public override void Scale(double scale)
        {
            Radius = Radius * scale;
            CalculateArea();
            CalculatePerimeter();
        }

        public override string ToString()
        {
            return $"Parameters of Circle :Center Points -> [{Center.X},{Center.Y}] ,Radius -> {Radius}, Area -> {Area}, Perimeter -> {Perimeter}";
        }

        public override bool CheckID(int id)
        {
            if (ID == id)
            {
                return true;
            }
            return false;
        }
    }
}
