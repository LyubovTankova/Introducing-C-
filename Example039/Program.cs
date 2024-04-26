// Написать программу масштабирования фигуры 

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"({matr[i, j]}, ");
            else Console.WriteLine($"{matr[i, j]})");
        }
    }
}
int[,] Matrix(int[] a, int[] b, int[] c, int[] d, int k)
{
    int[,] matrix = new int[4, 2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                matrix[0, j] = a[i];
                matrix[1, j] = (b[i] - a[i]) * k + a[i];
                matrix[2, j] = (c[i] - a[i]) * k + a[i];
                matrix[3, j] = (d[i] - a[i]) * k + a[i];
            }
        }
    }
    return matrix;
}

int k = 2;
int[] a = { 0, 0 };
int[] b = { 2, 0 };
int[] c = { 2, 2 };
int[] d = { 0, 2 };
int[,] matrix = Matrix(a, b, c, d, k);
PrintArray(matrix);