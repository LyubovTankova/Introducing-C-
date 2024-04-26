// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();

int size = 123;
int minPosition = -200;
int maxPosition = 300;

int[] CountArray(int size, int minPosition, int maxPosition)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minPosition, maxPosition + 1);
    }
    return arr;
}
void Print(int[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] >= 10 && array[i] <= 99) 
        count = count + 1;
    }
Console.WriteLine();
Console.WriteLine($"Колличество элементов из отрезка [10, 99], равно {count}");
}

Print(CountArray(size, minPosition, maxPosition));