// По двум заданным числам проверить является ли одно квадратом другого
Console.Clear();

int a;
int b;
Console.WriteLine("Введите первое число: ");
a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
b = int.Parse(Console.ReadLine() ?? "0");
{
    if (a == b * b)
    {
        Console.WriteLine("Первое число является квадратом второго");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго");
    }

    if (b == a * a)
    {
        Console.WriteLine("Второе число является квадратом первого");
    }
    else
    {
        Console.WriteLine("Второе число не является квадратом первого");
    }
}
Console.WriteLine();