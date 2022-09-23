using System;

namespace OOP1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine("Площадь круга = " + circle.Area());
            
            Triangle triangle = new Triangle(11, 13, 20);
            Console.WriteLine("Площадь треугольника = " + triangle.Area()); 
            
            Square square = new Square(6);
            Console.WriteLine("Площадь квадрата = " + square.Area());
        }
    }
}