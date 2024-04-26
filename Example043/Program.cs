// Сформировать трехмерный массив показать его построчно на экран выводя индексы соответствующего элемента
int[,,] FillArray(int m, int n, int z)
{
    int[,,] matrix = new int[m, n, z];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
                matrix[i, j, k] = new Random().Next(10, 100);
    }
    return matrix;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"x ({i}) y ({j}) ");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"z({k}) = {array[i, j, k]};  ");
            }
        }
        Console.WriteLine();
    }
}
Console.Clear();
int z = 1;
int m = 4;
int n = 4;
int[,,] array = FillArray(m, n, z);
PrintArray(array);