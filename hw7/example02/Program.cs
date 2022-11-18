// 50. Напишите программу, которая будет принимать от пользователя позицию (M, N)
// двумерного массива и возвращать значение элемента, стоящего в этой позиции.
// Если такой позиции в массиве нет, то сообщить об этом пользователю.
// Сгенерировать массив случайным образом. Размерность массива определить самостоятельно.
// Использование методов для заполнения массива обязательно.
// Остальное можно реализовать в главной программе.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// M = 1, N = 7->В массиве отсутствует элемент в такой позиции.

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

Console.Write("Введите индекс строки: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[new Random().Next(1, 10), new Random().Next(1, 10)];
FillArray(arr);
PrintArray(arr);

if(m < arr.GetLength(0) && m >= 0 && n < arr.GetLength(1) && n >= 0)
{
    Console.WriteLine($"Элемент из массива: {Math.Round(arr[m, n], 2)}");
}
else
{
    Console.WriteLine("В массиве отсутствует элемент в такой позиции.");
}
