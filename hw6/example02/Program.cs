// 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// k1 * x + b1 = k2 * x + b2  =>  k1x - k2x = b2 - b1  =>  x = (b2 - b1) / (k1 - k2)
// y = k1 * (b2 - b1) / (k1 - k2) + b1

void Intersection(double b1, double k1, double b2, double k2)
{
    if ( k1 != k2 )
    {
        double x = Math.Round((b2 - b1) / (k1 - k2), 2);
        double y = Math.Round(k1 * x + b1, 2);
        Console.WriteLine($"Точкой пересечения заданных прямых является точка с координатами ({x}, {y}).");
    }
    else
    {
        Console.WriteLine("Заданные прямые параллельны и не пересекаются!");
    }
}

Console.Write("Введите значения b1 и k1 для первой прямой: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Уравнение первой прямой: y = {k1} * x + {b1}");

Console.Write("Введите значения b2 и k2 для второй прямой: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Уравнение второй прямой: y = {k2} * x + {b2}");

Intersection(b1, k1, b2, k2);
