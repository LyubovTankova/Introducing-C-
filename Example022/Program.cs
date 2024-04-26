// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Clear();

int size = 7;

int[] CountArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }
    return arr;
}
void Print(int[] array)
{
    int even = 0;
    int not_even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if(array[i] % 2 == 0)
        even = even + 1;
        else not_even = not_even + 1;
    }

Console.WriteLine();
Console.WriteLine($"Колличество четных чисел {even}, количество нечетных чисел {not_even}");
}

Print(CountArray(size));