// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран. Заполнение массива производит пользователь.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void NewArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент с индексом {i} в массив: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Введен массив: [{0}]", string.Join(", ", array));
}

Console.Write("Какое количество элементов будет в массиве: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[count];
NewArray(arr);
