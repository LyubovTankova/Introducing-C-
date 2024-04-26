// Написать программу, которая обменивает элементы первой строки и последней строки
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
int[,] ReplaseArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(1); i++)
   {
      int number = array[0, i];
      array[0, i] = array[array.GetLength(0) - 1, i];
      array[array.GetLength(0) - 1, i] = number;    
   }
   return array;
}
void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
         Console.Write(array[i, j] + "   ");
      Console.WriteLine();
   }
}
int m = 4;
int n = 4;
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
int[,] replase = ReplaseArray(array);
PrintArray(replase);