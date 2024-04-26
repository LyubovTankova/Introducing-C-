// Найти произведение двух матриц
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 5);
    }
}
void WorkMatrix(int[,] matrixA, int[,] matrixB, int[,] work)
{
    for (int i = 0; i < work.GetLength(0); i++)
    {
        for (int j = 0; j < work.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
                sum += matrixA[i, k] * matrixB[k, j];
            work[i, j] = sum;
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}
Console.Clear();
Console.WriteLine("Введите число строк Матрицы А ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число столбцов Матрицы А и строк Матрицы В ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число столбцов Матрицы В ");
int p = int.Parse(Console.ReadLine() ?? "0");
int[,] matrixA = new int[m, n];
FillArray(matrixA);
Console.WriteLine("Матрица А ");
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = new int[n, p];
FillArray(matrixB);
Console.WriteLine("Матрица В ");
PrintMatrix(matrixB);
int[,] work = new int[m, p];
WorkMatrix(matrixA, matrixB, work);
Console.WriteLine("Произведение двух матриц ");
PrintMatrix(work);