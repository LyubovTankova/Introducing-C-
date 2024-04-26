// Показать числа Фибоначчи
Console.Clear();

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}
int[] Fibonacci(int n)
{
    int a = 1;
    int b = 1;
    int[] fibonacci = new int[n];
    fibonacci[0] = 1;
    fibonacci[1] = 1;
    for (int i = 2; i < n; i++)
    {
        fibonacci[i] = a + b;
        a = b;
        b = fibonacci[i];
    }
    return fibonacci;
}

Console.WriteLine("До какого числа считать? ");
int n = int.Parse(Console.ReadLine() ?? "0");
PrintArray(Fibonacci(n));