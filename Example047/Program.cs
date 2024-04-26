// Написать программу возведения числа А в целую стень B
int Exponentiation(int a, int b)
{
    if (b == 1)
        return a;
    return (a * Exponentiation(a, b - 1));
}
Console.Clear();
int a = new Random().Next(1, 10);
Console.WriteLine($"Число А {a} ");
int b = new Random().Next(1, 5);
Console.WriteLine($"Число В {b} ");
Console.Write($"Число {a} ^ {b} =  ");
Console.WriteLine(Exponentiation(a, b));