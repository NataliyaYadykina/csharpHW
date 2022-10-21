// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// Вывести, является ли число палиндромом
void PrintAboutNumber(int number)
{
    int min = 9999;
    int max = 100000;

    if((number > min && number < max) || (-1 * number > min && -1 * number < max))
    {
        
        int firstSymbol = number / 10000;
        int secondSymbol = (number / 1000) % 10;
        int lastSymbol = number % 10;
        int fourthSymbol = (number / 10) % 10;

        if (firstSymbol == lastSymbol && secondSymbol == fourthSymbol && number > 0)
        {
            Console.WriteLine("Введенное число - палиндром!");
        }
        else Console.WriteLine("Введенное число не является палиндромом!");

    }
    else Console.WriteLine("Введено не пятизначное число!");
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintAboutNumber(number);