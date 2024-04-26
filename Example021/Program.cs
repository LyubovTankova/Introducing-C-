// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Console.Clear();

int minPosition = -9;
int maxPosition = 9;

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
int[] Sums(int[] array)
{
    int[] sums = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sums[0] = sums[0] + array[i];
        else 
        if(array[i] > 0) sums[1] = sums[1] +array[i];
    }
    return sums;
}
Console.Write("Enter size of erray: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = CountArray(length, minPosition, maxPosition);
PrintArray(array);
Console.WriteLine();
PrintArray(Sums(array));