// В матрице чисел найти сумму элементов главной диагонали
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
int MatrixArray(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      {  
         sum = sum + matrix[i, i];
      }
    }
   return sum;
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
int[,] array = FillArray(m, n);
PrintTable(array);
Console.WriteLine();
int sum = MatrixArray(array);
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");