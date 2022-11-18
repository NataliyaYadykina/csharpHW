// 52. Запросите от пользователя размерности двумерного массива.
// Напишите метод для заполнения массива случайными числами.
// Напишите метод для поиска ср. арифметического значения каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Заполнить массив.
double[,] FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
        }
    }
    return array;
}

// Вывести двумерный массив в консоль в виде матрицы.
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,8}", Math.Round(array[i, j], 2));
        }
        Console.WriteLine();
    }
}

// Найти среднее арифметическое каждого столбца массива
void AverageEveryColumnArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        double sumElementsColumn = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumElementsColumn += array[j, i];
        }
        double averageColumn = Math.Round(sumElementsColumn / array.GetLength(0), 2);
        Console.WriteLine($"Average of column {i} = {averageColumn}");
    }
}

Console.Write("Write m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];
FillArray(arr);
PrintArray(arr);
AverageEveryColumnArray(arr);