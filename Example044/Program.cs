// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
void TrianglePascal(int[,] triangle)
{
    for (int i = 1; i < triangle.GetLength(0); i++)
    {
        for (int j = 1; j < i + 1; j++)
        {
            triangle[i, j] = triangle[i - 1, j] + triangle[i - 1, j - 1];
        }
        for (int k = 1; k < triangle.GetLength(0); k++)
        {
            triangle[k, 0] = 1;
        }
    }
}
void PrintTriagle(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = array.GetLength(0); k > i; k--)
            Console.Write("  ");
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] != 0)
            {
                Console.Write("{0,4}", array[i, j]);
            }
        Console.WriteLine();
    }
}
Console.Clear();
Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] triangle = new int[n + 1, 2 * n + 1];
TrianglePascal(triangle);
Console.WriteLine();
PrintTriagle(triangle);