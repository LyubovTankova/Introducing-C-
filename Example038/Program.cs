// Написать программу копирования массива
Console.Clear();

void FillArray(int[] array, int size)
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] array, int size)
{
    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
int[] Cop(int[] array)
{
    int[] cop = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        cop[i] = array[i];
    }
    return cop;
}
int size = 5;
int[] array = new int[size];
FillArray(array, size);
Console.WriteLine("Массив: ");
PrintArray(array, size);
Console.WriteLine();
int[] cop = Cop(array);
Console.WriteLine("Копия массива: ");
PrintArray(cop, size);