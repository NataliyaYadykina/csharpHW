// 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

// Заполнить массив.
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Вывести двумерный массив в консоль в виде матрицы.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3}", array[i, j]);
        }
        Console.WriteLine();
    }
}

// Найти и вывести, в какой строке - наименьшая сумма элементов.
int MinSumElementsInRowArray(int[,] array)
{
    int result = 0;
    int minSumRow = 999;
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }

        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            result = i;
        }
    }
    return result;
}

int[,] arr = new int[new Random().Next(3, 5), new Random().Next(3, 5)];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();

Console.Write("Номер строки с наименьшей суммой элементов: ");
int res = MinSumElementsInRowArray(arr);
Console.WriteLine(res);
