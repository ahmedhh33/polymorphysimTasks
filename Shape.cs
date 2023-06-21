using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphysim
{
    abstract class Shape
    {
        public string Name;
        public string area;
        public Shape(string name) 
        {
            Name = name;
        }
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(string name, double radius) :base(name) 
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

        public Rectangle(string name,double width, double height) : base(name) 
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

        public Triangle(string name ,double basement, double height): base(name) 
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
