// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

if(num != 1)
{
    if(num < 1)
    {
        while(i >= num)
        {
            int remains = i % 2;
            if(remains == 0) Console.WriteLine(i);
            i = i - 1;
        }
    }
    else
    {
        while(i <= num)
        {
            int remains = i % 2;
            if(remains == 0) Console.WriteLine(i);
            i = i + 1;
        }
    }
}
else Console.WriteLine("Нет четных чисел в данном промежутке. Укажите другое число.");
