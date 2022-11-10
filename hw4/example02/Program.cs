// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Для решения задания использование цикла for является обязательным условием
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int CountSymbols(int number)
{
    int count = 0;
    while(number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

int Sum(int number, int count)
{
    int result = 0;
    for(int i = 0; i < count; i++)
    {
        result += number%10;
        number /= 10;
        Console.WriteLine(number%10);
        Console.WriteLine(result);
        Console.WriteLine();
    }
    return result;
}

Console.Write("Write number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
{
    n = -1 * n;
}

int count = CountSymbols(n);
int res = Sum(n, count);
Console.WriteLine(res);
