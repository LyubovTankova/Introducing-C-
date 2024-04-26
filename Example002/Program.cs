//По заданному номеру дня недели вывести его название
Console.Clear();

int a;
Console.WriteLine("Введите номер дня недели : ");
a = int.Parse(Console.ReadLine() ?? "0");
{
    if(a == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else
    if(a == 2)
    {
        Console.WriteLine("Вторник");
    }
    else
    if(a == 3)
    {
        Console.WriteLine("Среда");
    }
    else
    if(a == 4)
    {
        Console.WriteLine("Четверг");
    }
    else
    if(a == 5)
    {
        Console.WriteLine("Пятница");
    }
    else
    if(a == 6)
    {
        Console.WriteLine("Суббота");
    }
    else
    if(a == 7)
    {
        Console.WriteLine("Воскресенье");
    }
    else
    if(a <= 100)
    {
        Console.WriteLine("Нет такого дня недели!");
    }
}
Console.WriteLine();