// Показать двумерный массив размером m×n заполненный вещественными числами
Console.Clear();

double[,] TablArray(int m, int n)
{
    double[,] tabl = new double[m, n];
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            tabl[i, j] = new Random().NextDouble() * 100;
        }
    }
    return tabl;
}
void PrintTabl(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
    Console.WriteLine();   
    }    
}

int m = 5;
int n = 5;
double[,] tabl = TablArray(m, n);
PrintTabl(tabl);