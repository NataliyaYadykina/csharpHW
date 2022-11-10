// Напишите программу, которая принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// Для решения задания использование цикла for является обязательным условием.
// Не использовать встроенный метод возведения в степень.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pov(int number1, int number2)
{
    int result = 1;
    
    for(int i = 1; i <= number2; i++)
    {
        result *= number1;
    }

    return result;
}

Console.Write("Write number A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Write number B: ");
int b = Convert.ToInt32(Console.ReadLine());

if(b < 0)
{
    b = -1 * b;
}

int res = Pov(a, b);
Console.WriteLine(res);
