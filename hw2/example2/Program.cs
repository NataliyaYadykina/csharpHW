// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = -1;

if(n < 0) n = -1 * n;

if(n > 99)
{
    while(n > 99)
    {
        result = n % 10;
        n = (n - result) / 10;
    }
    Console.WriteLine($"Третья цифра введенного числа: {result}");
}
else Console.WriteLine("У введенного числа нет третьей цифры!");