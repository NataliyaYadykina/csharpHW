// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// Вывести, является ли число палиндромом
void PrintAboutNumber(int number)
{
    int min = 9999;
    int max = 100000;
    int countSymbolNumber = 5;

    if((number > min && number < max) || (-1 * number > min && -1 * number < max))
    {
        int tempNumber = number;
        double reverseNumber = 0;

        while (tempNumber > 0)
        {
            reverseNumber = reverseNumber + tempNumber % 10 * Math.Pow(10, countSymbolNumber - 1);
            //Console.WriteLine(reverseNumber);
            countSymbolNumber--;
            tempNumber = tempNumber / 10;
        }

        if (number == (int)reverseNumber && number > 0)
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