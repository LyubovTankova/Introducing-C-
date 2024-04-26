//Показать четные числа от 1 до N
Console.Clear();

Console.WriteLine("Enter a number: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
while (i <= n)
{
    if (i % 2 == 0)
        Console.WriteLine(i);
    i++;
}
Console.WriteLine();