//Показать вторую цифру трёхзначного числа
Console.Clear();

int number = new Random().Next(100, 999);
int result = number / 10 % 10;
Console.WriteLine(number);
Console.WriteLine(result);