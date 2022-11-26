// 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int PrintSumNumbersFromMtoN(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return m + PrintSumNumbersFromMtoN(m + 1, n);
}

Console.Write("Write M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

Console.WriteLine(PrintSumNumbersFromMtoN(m, n));
