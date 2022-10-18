// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay > 0 && numberDay < 8)
{
    if (numberDay == 6 || numberDay == 7) Console.WriteLine($"День недели номер {numberDay} является выходным.");
    else Console.WriteLine($"День недели номер {numberDay} является рабочим.");
}
else Console.WriteLine("Введен неверный номер дня недели!");