// Написать программу показывающую первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем
string ShowNumbers(int a, int b, int n)
{
    if (n >= 0) return $"{a} " + ShowNumbers(b, a + b, n - 1);
    return string.Empty;
}
Console.Clear();
Console.Write("Введите первое число:  ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число:  ");
int b = int.Parse(Console.ReadLine() ?? "0");
int n = new Random().Next(5, 10);
Console.WriteLine(ShowNumbers(a, b, n));