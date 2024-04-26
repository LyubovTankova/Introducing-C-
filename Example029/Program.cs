// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.Clear();

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(5, 10);       
    }
    return array;
}
int[,] EvenArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] % 2 == 0)
            arr[i, j] = arr[i, j] * arr[i, j];   
    }
    return arr;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}   "); 
        }
    Console.WriteLine();
    }
}

int m = 5;
int n = 5;
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
int[,] even = EvenArray(array);
PrintArray(even);