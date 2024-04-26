// Реализовать функцию, которая вычисляет число a в степени n
// Реализовать функцию, складывающую два целых числа
// Реализовать функцию, определяющую является ли число простым, 
// то есть возвращающую true, если число простое, иначе - false
// Реализовать функцию, которая вычисляет сумму цифр произвольного целого числа a
// Реализовать функцию, которая вычисляет факториал числа a
Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int n = new Random().Next(1, 10);

double Count(double a, int n)
{
    double result;
    result = 1;
    for (int i = 1; i <= n; i++)
        result = result * a;
    return result;
}
int SumNumber(int a, int n)
{
    return a + n;
}
bool Simple_NotSimple(int a)
{
    if (a > 1)
    {
        for (int i = 2; i < a; i++)
            while ((a % i) == 0)
                return false;
        return true;
    }
    return false;
}
int SumDigits(int a)
{
    int sum;
    sum = 0;
    int digit = 0;
    for (int i = 0; i <= a; i++)
    {
        if (a > 0)
            digit = a % 10;
        sum = sum + digit;
        a = a / 10;
    }
    return sum;
}
double Factorial(int a)
{
    double result;
    result = 1;
    for (int i = 1; i <= a; i++)
        result = result * i;
    return result;
}
double result = Count(a, n);
Console.WriteLine();
Console.WriteLine($"{a} ^ {n} = {result}");
int sum = SumNumber(a, n);
Console.Write($"Сумма чисел {a} и {n} равна = {sum}");
Console.WriteLine();
if (Simple_NotSimple(a)) Console.WriteLine($"Число {a} простое");
else Console.WriteLine($"Число {a} непростое");
int sumDigits = SumDigits(a);
Console.Write($"Сумма цифр числа {a} равна = {sumDigits}");
Console.WriteLine();
double resultFactorial = Factorial(a);
Console.WriteLine($"факториал числа {a} = {resultFactorial}");