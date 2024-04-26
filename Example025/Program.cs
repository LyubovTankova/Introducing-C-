// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Clear();

int size = new Random().Next(1, 20);
int minPosition = 1;
int maxPosition = 20;

int[] CountArray(int size, int minPosition, int maxPosition)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minPosition, maxPosition + 1);
    }
    return arr;
}
int[] Double_Par(int[] array2)
{
    int[] work = new int[array2.Length / 2];
    int last_number = array2.Length - 1;
    for (int i = 0; i < array2.Length / 2; i++)
    {
        work[i] = array2[i] * array2[last_number];
        last_number = last_number - 1;
    }
    return work;
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] array = CountArray(size, minPosition, maxPosition);
Print(array);
Console.WriteLine();
Print(Double_Par(array));