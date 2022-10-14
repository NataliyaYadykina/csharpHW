// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine($"Среди чисел {a}, {b}, {c} максимальным числом является: {max}.");
