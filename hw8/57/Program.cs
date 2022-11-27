// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

// Набор данных
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// Частотный массив
// 0 встречается 2 раза 
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// Набор данных
// 1, 2, 3 
// 4, 6, 1
// 2, 1, 6
// Частотный массив
// 1 встречается 3 раза 
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

// Проверить, повторяется ли заданное число в массиве.
bool FindValueInArray(int[,] array, int value, int countRowCheck, int countColCheck)
{
    bool check = false;
    for (int i = 0; i <= countRowCheck; i++)
    {
        int tempCountColCheck = 0;
        if (i < countRowCheck)
        {
            tempCountColCheck = array.GetLength(1);
        }
        if (i == countRowCheck)
        {
            tempCountColCheck = countColCheck;
        }
        for (int j = 0; j < tempCountColCheck; j++)
        {
            //Console.WriteLine($"Check value ({value}) and el ({i}, {j}) - {array[i, j]}.");
            if (array[i, j] == value)
            {
                //Console.WriteLine($"Value = element! REPEAT");
                check = true;
                i = countRowCheck;
                j = tempCountColCheck;
            }
        }
    }
    return check;
}

// Посчитать количество уникальных элементов массива.
int CountUniqueElementsInArray(int[,] array)
{
    int countUniqueElemets = 1;
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            if (k == 0 && l == 0) l = 1;
            //Console.WriteLine($"Check el ({k}, {l}) - {array[k, l]}.");
            if (!FindValueInArray(array, array[k, l], k, l))
            {
                //Console.WriteLine("Unique!");
                countUniqueElemets++;
            }
        }
    }
    //Console.WriteLine($"countUniqueElemets: {countUniqueElemets}.");
    return countUniqueElemets;
}

// Проверить, сколько раз встречается заданное число в массиве.
int CountValueInArray(int[,] array, int value)
{
    int countRepeatNumber = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == value)
            {
                countRepeatNumber++;
            }
        }
    }
    return countRepeatNumber;
}

// Составить частотный словарь повторяющихся элементов (new array [key, value])
int[,] DictionaryCountNumbers(int[,] arraySource, int[,] arrayDict)
{
    int rowDict = 1;
    arrayDict[0, 0] = arraySource[0, 0];
    arrayDict[0, 1] = CountValueInArray(arraySource, arraySource[0, 0]);
    for (int k = 0; k < arraySource.GetLength(0); k++)
    {
        for (int l = 0; l < arraySource.GetLength(1); l++)
        {
            if (k == 0 && l == 0) l = 1;
            if (!FindValueInArray(arraySource, arraySource[k, l], k, l))
            {
                arrayDict[rowDict, 0] = arraySource[k, l];
                arrayDict[rowDict, 1] = CountValueInArray(arraySource, arraySource[k, l]);
                rowDict++;
            }
        }
    }
    return arrayDict;
}

int[,] arr = new int[new Random().Next(2, 4), new Random().Next(2, 4)];
FillArray(arr);
Console.WriteLine();
Console.WriteLine("Source Array: ");
PrintArray(arr);
Console.WriteLine();

int[,] dictionaryCountRepeatElements = new int[CountUniqueElementsInArray(arr), 2];
Console.WriteLine("Dictionary [key, count]: ");
dictionaryCountRepeatElements = DictionaryCountNumbers(arr, dictionaryCountRepeatElements);
PrintArray(dictionaryCountRepeatElements);
Console.WriteLine();