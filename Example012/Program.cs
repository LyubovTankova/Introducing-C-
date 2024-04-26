// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Clear();

int a;
Console.WriteLine("Введите число дня недели : ");
a = int.Parse(Console.ReadLine() ?? "0");
{
    if (a <= 5)
    {
        Console.WriteLine("Рабочий день!");
    }
    if (a >= 6)
    {
        Console.WriteLine("Выходной день!");
    }
}
Console.WriteLine();