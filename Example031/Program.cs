// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
Console.Clear();

int[,] FillArray(int m, int n)
{
   int[,] array = new int[m, n];
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
         array[i, j] = new Random().Next(1, 5);
   }
   return array;
}
void PrintTable(int[,] tab)
{
   for (int i = 0; i < tab.GetLength(0); i++)
   {
      for (int j = 0; j < tab.GetLength(1); j++)
         Console.Write(tab[i, j] + "   ");
      Console.WriteLine();
   }
}
double[] ArrayMean(int[,] array)
{
   double[] average = new double[array.GetLength(1)];
   for (int j = 0; j < array.GetLength(1); j++)
   {
      double sum = 0;
      for (int i = 0; i < array.GetLength(0); i++)
         sum = sum + array[i, j];
         average[j] = sum / array.GetLength(1);     
   }
   return average;
}
void PrintMean(double[] tab)
{
   for (int j = 0; j < tab.Length; j++)
   {
      Console.Write(tab[j] + "   ");  
   }
}
int m = 4;
int n = 4;
int[,] array = FillArray(m, n);
PrintTable(array);
Console.WriteLine();
double[] average = ArrayMean(array);
PrintMean(average);