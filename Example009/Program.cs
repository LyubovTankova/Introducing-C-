//Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100, 999);
int number2 = 0;

int numberDel()
{
    number2 = number / 100 * 10 + number % 10;
    return number2;
}
numberDel();

Console.WriteLine(number);
Console.WriteLine(number2);