// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

// Получаем таблицу кубов
void PrintSquaresToConsole(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintSquaresToConsole(n);
