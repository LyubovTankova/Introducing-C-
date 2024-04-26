// Написать программу вычисления функции Аккермана
int FunctionAckermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0 && m > 0) return FunctionAckermann(m - 1, 1);
    return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
}
Console.Clear();
Console.Write("Введите неотрицательное число m:  ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите неотрицательное число n:  ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(FunctionAckermann(m, n));