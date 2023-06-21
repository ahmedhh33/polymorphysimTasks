using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphysim
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius,2);
        }

    }
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }
    }

    class Triangle : Shape
    {
        private double basement;
        private double height;

        public Triangle(double basement, double height)
        {
            this.basement = basement;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * basement * height;
        }

    }
}
