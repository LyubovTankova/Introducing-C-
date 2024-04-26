// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();

int n = new Random().Next(1, 10);
Console.WriteLine($"Число {n}");
int i = 1;
int cub3;

while (i <= n)
{
    cub3 = i * i * i;
    if (cub3 % 2 == 0)
        Console.WriteLine($"{i} = {cub3} заканчивается на четную цифру");
    i++;
}
Console.WriteLine();