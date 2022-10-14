// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2) Console.WriteLine($"Число {num1} равно числу {num2}.");
else
{
    if (num1 > num2) Console.WriteLine($"Число {num1} больше, чем число {num2}.");
    else Console.WriteLine($"Число {num1} меньше, чем число {num2}.");
}
