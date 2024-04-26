// В двумерном массиве целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] FillArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10);
    }
    return matrix;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}  ");
        Console.WriteLine();
    }
}
int[] MinElement(int[,] array)
{
    int[] position = new int[2];
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < min)
            {
                min = array[i, j];
                position[0] = i;
                position[1] = j;
            }
    }
    return position;
}
int[,] DeleteRowCol(int[,] matrix, int[] array)
{
    int[,] delrow = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
    for (int i = 0; i < delrow.GetLength(0); i++)
    {
        for (int j = 0; j < delrow.GetLength(1); j++)
            if (i < array[0])
                delrow[i, j] = matrix[i, j];
            else
                delrow[i, j] = matrix[i + 1, j];

    }
    int[,] delcol = new int[delrow.GetLength(0), delrow.GetLength(1) - 1];
    {
        for (int i = 0; i < delcol.GetLength(0); i++)
        {
            for (int j = 0; j < delcol.GetLength(1); j++)
            {
                if (j < array[1])
                    delcol[i, j] = delrow[i, j];
                else
                    delcol[i, j] = delrow[i, j + 1];
            }
        }
    }
    return delcol;
}
Console.Clear();
int m = 4;
int n = 4;
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
int[] minPosition = new int[2];
minPosition = MinElement(array);
Console.WriteLine($"Строка с мин элементом {minPosition[0]}");
Console.WriteLine($"Столбец с мин элементом {minPosition[1]}");
int[,] matrix = DeleteRowCol(array, minPosition);
PrintArray(matrix);