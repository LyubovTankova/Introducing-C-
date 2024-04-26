// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.Clear();

int minPosition = 0;
int maxPosition = 1;

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] CountArray(int length, int minPosition, int maxPosition)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(minPosition, maxPosition + 1);
    }
    return arr;
}
Console.Write("Enter size of erray: ");
int length = int.Parse(Console.ReadLine() ?? "0");
PrintArray(CountArray(length, minPosition, maxPosition));