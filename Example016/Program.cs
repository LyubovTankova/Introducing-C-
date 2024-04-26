// Найти кубы чисел от 1 до n
Console.Clear();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int cube3;
for (int i = 1; i <= n; i++)
{
    cube3 = i * i * i;
    Console.WriteLine($"Куб числа {i} = {cube3}");
}

Console.WriteLine();