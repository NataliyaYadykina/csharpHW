// 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2-> 2
// 1, -7, 567, 89, 223-> 3

// метод вывода массива в консоль
void PrintArr(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Заполнить массив введенными числами
double[] WriteNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Write number {i + 1}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

// Посчитать количество положительных элементов массива
int CountPositive(double[] array)
{
    int countPositive = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) { 
            countPositive++; 
        }
    }
    return countPositive;
}

// Сколько чисел введем
Console.Write("How much numbers do you want to write: ");
int countNumbers = Convert.ToInt32(Console.ReadLine());

// Создаем пустой массив
double[] array = new double[countNumbers];

// Заполняем массив введенными числами и выводим его
double[] arrayNumbers = WriteNumbers(array);
PrintArr(arrayNumbers);

// Считаем и выводим, сколько чисел болльше нуля ввел пользователь
int countPos = CountPositive(arrayNumbers);
Console.WriteLine($"You writed {countPos} numbers greater than 0.");
