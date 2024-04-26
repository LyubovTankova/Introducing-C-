// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Clear();

int size = new Random().Next(1,11);

double[] CountArrayArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000) / 100;
    }
    return array;
}
void MinMax(double[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write(arr[i] +  " ");
    }
    double raznost = arr.Max() - arr.Min();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"Минимальный элемент массива {arr.Min()}, максимальный элемент массива {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным элементом массива составляет {raznost}");
}
MinMax(CountArrayArray(size));
Console.WriteLine();