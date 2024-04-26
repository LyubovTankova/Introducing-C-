//Выяснить является ли число чётным
Console.Clear();

int a;
Console.WriteLine("Введите число: ");
a = int.Parse(Console.ReadLine() ?? "0");
if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
Console.WriteLine();