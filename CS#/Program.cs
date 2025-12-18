using System;

class Program
{
    static void Main()
    {
        Circle c = new Circle(5);
        Rectangle r = new Rectangle(4, 6);
        Cylinder cy = new Cylinder(3, 10);

        c.printInfo();
        Console.WriteLine();

        r.printInfo();
        Console.WriteLine();

        cy.printInfo();
    }
}
