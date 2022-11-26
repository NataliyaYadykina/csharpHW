// 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5-> "5, 4, 3, 2, 1"
// N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"

int PrintNumbers(int n)
{
    if (n == 1)
    {
        return 1;
    }

    int tempResult = n;
    Console.WriteLine(tempResult);
    return PrintNumbers(n - 1);
}

Console.Write("Write N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(n));
