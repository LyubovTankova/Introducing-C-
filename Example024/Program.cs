// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Clear();

int size = 10;

int[] CountArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(10, 99);
    }
    return arr;
}
void Print(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (i % 2 > 0) 
        sum = sum + array[i];
    }
Console.WriteLine();
Console.WriteLine($"Сумма чисел одномерного массива стоящих на нечетной позиции равна {sum}");
}

Print(CountArray(size));