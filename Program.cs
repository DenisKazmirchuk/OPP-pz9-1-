using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть радіус кола: ");
        double radius = double.Parse(Console.ReadLine());

        Console.Write("Введіть сторону квадрата: ");
        double side = double.Parse(Console.ReadLine());

        // Лямбда-вирази для обчислення площ
        Func<double, double> circleArea = r => Math.PI * r * r;
        Func<double, double> squareArea = s => s * s;

        double areaCircle = circleArea(radius);
        double areaSquare = squareArea(side);

        Console.WriteLine($"Площа кола: {areaCircle}");
        Console.WriteLine($"Площа квадрата: {areaSquare}");

        if (areaCircle > areaSquare)
            Console.WriteLine("Коло має більшу площу.");
        else if (areaCircle < areaSquare)
            Console.WriteLine("Квадрат має більшу площу.");
        else
            Console.WriteLine("Площі рівні.");
    }
}