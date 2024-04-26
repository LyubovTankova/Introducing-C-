// Подсчитать сумму цифр в числе
Console.Clear();

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Сумма цифр числа {n} равна ");
int sumDigits = 0;

while (n > 0)
{
    int digit = n % 10;
    sumDigits = sumDigits + digit;
    n = n / 10;
}
Console.WriteLine(sumDigits);