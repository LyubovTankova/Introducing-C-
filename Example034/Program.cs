// Подсчёт количества вхождений элемента в массив.
// Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1.
// Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.
Console.Clear();

void PrintArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
        Console.Write($"{array[index]} ");

    Console.WriteLine();
}
void FillArray(int[] array, int min, int max)
{
    for (int index = 0; index < array.Length; index++)
        array[index] = new Random().Next(min, max);
}
int Count(int[] array, int value)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
        if (array[index] == value)
            count++;
    return count;
}
int IndexOf(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            return i;
        }
    }
    return -1;
}
bool CountFalse(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == value)
        return true; 
    }    
    return false; 
}
Console.WriteLine("Ведите ваш массив: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[size];
FillArray(array, 0, 9);
Console.WriteLine("Ваш массив: ");
PrintArray(array);
Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine() ?? "0");
int count = Count(array, value);
Console.WriteLine();
Console.WriteLine($"Заданный элемент {value} входит в массив {count} раз");
Console.WriteLine($"Индекс заданного элемента в массиве  {IndexOf(array, value)}");
if(CountFalse(array, value)) Console.WriteLine($"Элемент {value} есть в массиве");
else Console.WriteLine($"Элемента {value} нет в массиве");