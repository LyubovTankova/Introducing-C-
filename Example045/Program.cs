// Показать натуральные числа от M до N, N и M заданы
// Найти сумму элементов от M до N, N и M заданы
string Numbers(int M, int N)
{
    if (M <= N)
        return Numbers(M + 1, N) + $"{M} ";
    else return String.Empty;
}
int SumElements(int M, int N)
{
    if (M == N)
        return M;
    else return M + SumElements(M + 1, N);
}
Console.Clear();
int M = new Random().Next(1, 4);
Console.WriteLine($"Число M {M} ");
int N = new Random().Next(5, 10);
Console.WriteLine($"Число N {N} ");
Console.Write("Числа от M до N: ");
Console.WriteLine(Numbers(M, N));
Console.Write("Сумма элементов от M до N = ");
Console.WriteLine(SumElements(M, N));