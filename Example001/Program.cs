// По двум заданным числам проверить является ли первое квадратом второго
Console.WriteLine();

int a = 2;
int b = 4;

Console.WriteLine("Введите число ");
a = int.Parse(Console.ReadLine() ?? "0");
if (b == a * a)
{
    Console.WriteLine("Число является квадратом a");
}
else
{
    Console.WriteLine("Число не является квадратом a");
}
Console.WriteLine();