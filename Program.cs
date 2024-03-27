using System;
using System.Collections.Generic;


class Program
{

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        // Создаем список пар "поверхность-коэффициент трения"
        var surfacesWithFriction = new List<(string Surface, double FrictionCoefficient)>
        {
            ("Сухой асфальт", 0.7),
            ("Мокрый асфальт", 0.4),
            ("Лед", 0.1),
            ("Снег", 0.3),
            ("Сухой бетон", 0.62),
            ("Мокрый бетон", 0.5),
            ("Гравий", 0.6),
            ("Дерево", 0.5),
            ("Металл", 0.3),
            ("Пластик", 0.4)
        };
        Console.Write("Введите скорость в км / ч: ");
        double speedKmh = double.Parse(Console.ReadLine());
        // Преобразование скорости из км/ч в м/с
        double speedMs = speedKmh / 3.6;

        Console.Write("Введите коэффициент трения:");
        // Выводим информацию
        Console.WriteLine("Примеры: \n");
        foreach (var (Surface, FrictionCoefficient) in surfacesWithFriction)
        {
            Console.WriteLine($"{Surface}: {FrictionCoefficient}");
        }
        double frictionCoefficient = double.Parse(Console.ReadLine());

        double stoppingDistance = CalculateStoppingDistance(speedMs, frictionCoefficient);

        Console.WriteLine($"Тормозной путь составит: {stoppingDistance:F2} метров");
    }

    static double CalculateStoppingDistance(double speed, double frictionCoefficient)
    {
        const double gravityAcceleration = 9.81;
        return (speed * speed) / (2 * frictionCoefficient * gravityAcceleration);
    }
}
