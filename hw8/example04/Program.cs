// 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)

// Заполнить трехмерный массив неповторяющимися 3-значными числами.
void FillArray(int[,,] array)
{
    int[] ElementsValueArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int indexElementsValueArray = 0;
    int tempValue = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                tempValue = new Random().Next(1, 30);
                Console.WriteLine($"Value el({i},{j},{k}) = {tempValue}.");
                for (int l = 0; l <= indexElementsValueArray; l++)
                {
                    Console.WriteLine($"Check l = {l}!");
                    if (tempValue == ElementsValueArray[l])
                    {
                        Console.WriteLine("Repeat!");
                        tempValue = new Random().Next(1, 30);
                        Console.WriteLine($"New Value el({i},{j},{k}) = {tempValue}.");
                        l = -1;
                        Console.WriteLine($"l = {l}");
                    }
                }
                ElementsValueArray[indexElementsValueArray] = tempValue;
                Console.WriteLine($"Елемент массива записанных значений {indexElementsValueArray}: {ElementsValueArray[indexElementsValueArray]}");
                array[i, j, k] = tempValue;
                indexElementsValueArray++;
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