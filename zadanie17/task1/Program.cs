using System;

namespace GeometryLibrary
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool Exists()
        {
            return A + B > C && A + C > B && B + C > A;
        }

        public double Perimeter()
        {
            return A + B + C;
        }

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public string Type()
        {
            if (A == B && B == C)
                return "Равносторонний";
            else if (A == B || B == C || A == C)
                return "Равнобедренный";
            else
                return "Разносторонний";
        }
    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public double Area()
        {
            return Width * Height;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        GeometryLibrary.Triangle triangle = new GeometryLibrary.Triangle(3, 4, 5);
        if (triangle.Exists())
        {
            Console.WriteLine($"Периметр треугольника: {triangle.Perimeter()}");
            Console.WriteLine($"Площадь треугольника: {triangle.Area()}");
            Console.WriteLine($"Тип треугольника: {triangle.Type()}");
        }
        else
        {
            Console.WriteLine("Треугольник с заданными сторонами не существует.");
        }

        GeometryLibrary.Rectangle rectangle = new GeometryLibrary.Rectangle(4, 5);
        Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter()}");
        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}");
        Console.ReadLine();
    }
}
