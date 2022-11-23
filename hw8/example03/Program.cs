// 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write("{0,5}", array[i, j]);
        }
        Console.WriteLine();
    }
}

// Найти произведение двух матриц.
int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] resMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for(int row = 0; row < array1.GetLength(0); row++)
    {
        for(int col1 = 0; col1 < array1.GetLength(1); col1++)
        {
            for(int col2 = 0; col2 < array2.GetLength(1); col2++)
            {
                resMatrix[row, col2] += array1[row, col1] * array2[col1, col2];
            }
        }
    }
    return resMatrix;
}

int size = new Random().Next(2, 6);
int[,] arr1 = new int[new Random().Next(2, 6), size];
int[,] arr2 = new int[size, new Random().Next(2, 6)];

Console.WriteLine();
Console.WriteLine("Array 1:");
FillArray(arr1);
PrintArray(arr1);
Console.WriteLine();

Console.WriteLine("Array 2:");

FillArray(arr2);
PrintArray(arr2);
Console.WriteLine();

Console.WriteLine("Array Result:");
PrintArray(MatrixMultiplication(arr1, arr2));
Console.WriteLine();