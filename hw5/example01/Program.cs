// 34. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// метод заполнения массива случайными числами из определенного диапазона
int[] RandomArray(int[] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

// метод вывода массива в консоль
void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// метод подсчета количества четных элементов в массиве
int CountEvenInArray(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countEven++;
        }
    }
    return countEven;
}

// зададим размерность массива
Console.Write("Какое количество элементов будет в массиве: ");
int length = Convert.ToInt32(Console.ReadLine());

// создадим новый пустой массив заданной размерности
int[] arr = new int[length];
// заполним массив
int[] randomArr = RandomArray(arr, 100, 1000);
// выведем массив в консоль
PrintArr(arr);
// посчитаем и покажем количество четных элементов в массиве
int count = CountEvenInArray(arr);
Console.WriteLine(count);

