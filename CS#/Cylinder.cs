using System;

class Cylinder
{
    private double radius;
    private double length;

    public double Radius
    {
        get { return radius; }
        private set { radius = value; }
    }

    public double Length
    {
        get { return length; }
        private set { length = value; }
    }

    public Cylinder(double radius, double length)
    {
        Radius = radius;
        Length = length;
    }

    public double area()
    {
        return 2 * Math.PI * radius * radius;
    }

    public double volume()
    {
        return Math.PI * radius * radius * length;
    }

    public void printInfo()
    {
        Console.WriteLine("Cylinder");
        Console.WriteLine("Radius = " + radius);
        Console.WriteLine("Length = " + length);
        Console.WriteLine("Area = " + area());
        Console.WriteLine("Volume = " + volume());
    }
}
