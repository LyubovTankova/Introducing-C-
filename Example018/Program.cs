// Написать программу вычисления произведения чисел от 1 до n
Console.Clear();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int work = 1;

for (int i = 1; i <= n; i++)
{
    work = work * i;
}

Console.WriteLine($"Произведение чисел от 1 до {n} равно {work}");