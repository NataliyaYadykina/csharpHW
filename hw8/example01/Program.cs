// 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// Упорядочить по убыванию элементы каждой строки двумерного массива
void SortRowArrayMaxToMin(int[,] array)
{
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1) - 1; col++)
        {
            int maxPositionCol = col;
            for (int j = col + 1; j < array.GetLength(1); j++)
            {
                if (array[row, j] > array[row, maxPositionCol])
                {
                    maxPositionCol = j;
                }
            }
            int temp = array[row, col];
            array[row, col] = array[row, maxPositionCol];
            array[row, maxPositionCol] = temp;
        }
    }
}

int[,] arr = new int[new Random().Next(3, 5), new Random().Next(3, 5)];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();

SortRowArrayMaxToMin(arr);
PrintArray(arr);