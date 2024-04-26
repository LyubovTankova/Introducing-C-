// Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.Clear();

int[,] MatrixArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i+j;
        }
    }
    return matrix;
}
void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write(tab[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int m = 4;
int n = 4;
int[,] table = MatrixArray(m, n);
PrintTable(table);