// 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

// метод заполнения массива случайными числами из определенного диапазона
double[] RandomArray(double[] array, double minValue, double maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return array;
}

// метод вывода массива в консоль
void PrintArr(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// метод нахождения разницы между максимальным и минимальным элементами массива
double DifferenceMaxMinArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    double difference = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min )
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    difference = max - min;
    return difference;
}

// зададим размерность массива
Console.Write("Какое количество элементов будет в массиве: ");
int length = Convert.ToInt32(Console.ReadLine());

// создадим новый пустой массив заданной размерности
double[] arr = new double[length];

// заполним массив
double[] randomArr = RandomArray(arr, -99.00, 100.00);
// выведем массив в консоль
PrintArr(randomArr);

// посчитаем и покажем разницу между максимальным и минимальным элементами массива
double differenceMaxMin = DifferenceMaxMinArray(randomArr);
Console.WriteLine(differenceMaxMin);
