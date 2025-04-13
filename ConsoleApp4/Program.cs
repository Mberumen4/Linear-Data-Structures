using System;

namespace InheritanceShapes
{
    // Abstract Base Class
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    // Rectangle Class
    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public double Length
        {
            get { return length; }
            set { length = (value > 0) ? value : throw new ArgumentException("Length must be positive"); }
        }

        public double Width
        {
            get { return width; }
            set { width = (value > 0) ? value : throw new ArgumentException("Width must be positive"); }
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

    // Circle Class
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = (value > 0) ? value : throw new ArgumentException("Radius must be positive"); }
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Triangle Class
    class Triangle : Shape
    {
        private double baseLength;
        private double height;
        private double sideA, sideB, sideC;
        private double angleA, angleB, angleC;

        // Constructor for Base & Height
        public Triangle(double baseLength, double height)
        {
            this.BaseLength = baseLength;
            this.Height = height;
        }

        // Constructor for Three Sides
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        // Constructor for Angles
        public Triangle(double angleA, double angleB, double angleC, bool isAngleBased)
        {
            this.AngleA = angleA;
            this.AngleB = angleB;
            this.AngleC = angleC;
        }

        public double BaseLength
        {
            get { return baseLength; }
            set { baseLength = (value > 0) ? value : throw new ArgumentException("Base must be positive"); }
        }

        public double Height
        {
            get { return height; }
            set { height = (value > 0) ? value : throw new ArgumentException("Height must be positive"); }
        }

        public double SideA
        {
            get { return sideA; }
            set { sideA = (value > 0) ? value : throw new ArgumentException("Side A must be positive"); }
        }

        public double SideB
        {
            get { return sideB; }
            set { sideB = (value > 0) ? value : throw new ArgumentException("Side B must be positive"); }
        }

        public double SideC
        {
            get { return sideC; }
            set { sideC = (value > 0) ? value : throw new ArgumentException("Side C must be positive"); }
        }

        public double AngleA
        {
            get { return angleA; }
            set { angleA = (value >= 0 && value <= 180) ? value : throw new ArgumentException("Angle A must be between 0 and 180 degrees"); }
        }

        public double AngleB
        {
            get { return angleB; }
            set { angleB = (value >= 0 && value <= 180) ? value : throw new ArgumentException("Angle B must be between 0 and 180 degrees"); }
        }

        public double AngleC
        {
            get { return angleC; }
            set { angleC = (value >= 0 && value <= 180) ? value : throw new ArgumentException("Angle C must be between 0 and 180 degrees"); }
        }

        // Overriding CalculateArea for Base & Height
        public override double CalculateArea()
        {
            if (BaseLength > 0 && Height > 0)
                return 0.5 * BaseLength * Height;
            else
                throw new InvalidOperationException("Base and Height must be set for this method.");
        }

        // Overloaded CalculateArea for Three Sides (Heron's Formula)
        public double CalculateArea(double s1, double s2, double s3)
        {
            double s = (s1 + s2 + s3) / 2;
            return Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3));
        }

        public void DisplayAngles()
        {
            Console.WriteLine($"Triangle Angles: A = {AngleA}, B = {AngleB}, C = {AngleC}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creating Rectangle Object
                Rectangle rect = new Rectangle(5, 10);
                Console.WriteLine($"Rectangle Area: {rect.CalculateArea()}");

                // Creating Circle Object
                Circle circle = new Circle(7);
                Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

                // Creating Triangle Objects
                Triangle triangle1 = new Triangle(6, 4); // Using base & height
                Console.WriteLine($"Triangle Area (Base & Height): {triangle1.CalculateArea()}");

                Triangle triangle2 = new Triangle(3, 4, 5); // Using three sides
                Console.WriteLine($"Triangle Area (Three Sides - Heron's Formula): {triangle2.CalculateArea(3, 4, 5)}");

                Triangle triangle3 = new Triangle(60, 60, 60, true); // Using angles
                triangle3.DisplayAngles();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

