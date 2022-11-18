// 47. Запросите от пользователя размерности двумерного массива.
// Напишите метод для заполнения массива случайными числами.
// Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво).
// Округлите значения, генерируемые Random до двух знаков после запятой.
// m = 3, n = 4.
// 0,5 7 - 2 - 0,2
// 1 - 3,3 8 - 9,9
// 8 7,8 - 7,1 9

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

Console.Write("Write m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];
FillArray(arr);
PrintArray(arr);