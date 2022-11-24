// 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)

// Проверить, есть ли заданное число в массиве.
bool FindValueInArray(int[,,] array, int value)
{
    bool check = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == value)
                {
                    check = true;
                    break;
                }  
            }
        }
    }
    return check;
}

// Заполнить трехмерный массив неповторяющимися 3-значными числами.
void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int tempValue = new Random().Next(1, 30);
                Console.WriteLine($"Value el({i},{j},{k}) = {tempValue}.");
                while (FindValueInArray(array, tempValue))
                {
                    Console.WriteLine("REPEAT! Change!");
                    tempValue = new Random().Next(1, 30);
                    Console.WriteLine($"NEW tempValue = {tempValue}. Check!");
                    FindValueInArray(array, tempValue);
                }
                array[i, j, k] = tempValue;
                Console.WriteLine($"SAVING Value el({i},{j},{k}) = {tempValue}.");
            }
        }
    }
}

// Вывести трехмерный массив в консоль построчно.
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] arr = new int[new Random().Next(2, 4), new Random().Next(2, 4), new Random().Next(2, 4)];
Console.WriteLine();

FillArray(arr);
Console.WriteLine($"Array size {arr.GetLength(0)} x {arr.GetLength(1)} x {arr.GetLength(2)}");
PrintArray(arr);