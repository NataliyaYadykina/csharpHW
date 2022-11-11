// 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0


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

// метод подсчета суммы элементов, стоящих на нечетных позициях
int SumOddInArray(int[] array)
{
    int sumOdd = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumOdd += array[i];
    }
    return sumOdd;
}

// зададим размерность массива
Console.Write("Какое количество элементов будет в массиве: ");
int length = Convert.ToInt32(Console.ReadLine());

// создадим новый пустой массив заданной размерности
int[] arr = new int[length];
// заполним массив
int[] randomArr = RandomArray(arr, 10, 100);
// выведем массив в консоль
PrintArr(arr);
// посчитаем и покажем сумму элементов, стоящих на нечетных позициях
int sumOdd = SumOddInArray(arr);
Console.WriteLine(sumOdd);
