using System;
using System.Collections.Generic;

// Part 1 Abstraction:

//Describe the difference between a virtual method and an abstract method.
//Virtual method-A base class method that can be overridden by derived classes, with a default implementation.

//Explain why a developer would use abstraction.
//Abstraction simplifies code by hiding complex details. 
//It lets you use objects at a high level, like calling `CalculateArea()` without needing to know how each shape works.


//Part 2 Encapsulation:

//List two reasons why a developer would use accessors (getters and setters).

//1.Control Over Data- Ensures fields are modified correctly.

//2.Encapsulation:-Hides the inner details of an object while still allowing access to its data.



//Describe the difference between a private and protected attribute.

//Private -The attribute can only be accessed within the class it’s defined.

//Protected - The attribute can be accessed within the class and by subclasses.

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Triangle : Shape
{
    private double _base;
    private double _height;
    private double _sideA;
    private double _sideB;
    private double _sideC;
    private double _angleA;
    private double _angleB;
    private double _angleC;

    public double Base
    {
        get { return _base; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Base must be greater than zero.");
            _base = value;
        }
    }

    public double Height
    {
        get { return _height; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Height must be greater than zero.");
            _height = value;
        }
    }

    public double SideA
    {
        get { return _sideA; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("SideA must be greater than zero.");
            _sideA = value;
        }
    }

    public double SideB
    {
        get { return _sideB; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("SideB must be greater than zero.");
            _sideB = value;
        }
    }

    public double SideC
    {
        get { return _sideC; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("SideC must be greater than zero.");
            _sideC = value;
        }
    }

    public double AngleA
    {
        get { return _angleA; }
        set
        {
            if (value <= 0 || value >= 180)
                throw new ArgumentException("AngleA must be between 0 and 180 degrees.");
            _angleA = value;
        }
    }

    public double AngleB
    {
        get { return _angleB; }
        set
        {
            if (value <= 0 || value >= 180)
                throw new ArgumentException("AngleB must be between 0 and 180 degrees.");
            _angleB = value;
        }
    }

    public double AngleC
    {
        get { return _angleC; }
        set
        {
            if (value <= 0 || value >= 180)
                throw new ArgumentException("AngleC must be between 0 and 180 degrees.");
            _angleC = value;
        }
    }

    public Triangle(double baseLength, double height)
    {
        Base = baseLength;
        Height = height;
    }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public double CalculateArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public void DisplayAngles()
    {
        Console.WriteLine($"Angles: A={AngleA}, B={AngleB}, C={AngleC}");
    }
}

public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public double Width
    {
        get { return _width; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Width must be greater than zero.");
            _width = value;
        }
    }

    public double Height
    {
        get { return _height; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Height must be greater than zero.");
            _height = value;
        }
    }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    private double _radius;

    public double Radius
    {
        get { return _radius; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Radius must be greater than zero.");
            _radius = value;
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Shape myShape1 = new Triangle(3, 4);  
            Shape myShape2 = new Rectangle(5, 10); 
            Shape myShape3 = new Circle(7);        

            Console.WriteLine("Triangle Area: " + myShape1.CalculateArea());
            Console.WriteLine("Rectangle Area: " + myShape2.CalculateArea());
            Console.WriteLine("Circle Area: " + myShape3.CalculateArea());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
