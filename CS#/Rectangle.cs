using System;

class Rectangle
{
    private double width;
    private double height;

    public double Width
    {
        get { return width; }
        private set { width = value; }
    }

    public double Height
    {
        get { return height; }
        private set { height = value; }
    }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double area()
    {
        return width * height;
    }

    public void printInfo()
    {
        Console.WriteLine("Rectangle");
        Console.WriteLine("Width = " + width);
        Console.WriteLine("Height = " + height);
        Console.WriteLine("Area = " + area());
    }
}
