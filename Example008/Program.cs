// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 99);
int max = 0;
int maxDigit()
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit)
    {
        max = firstDigit;
    }
    else
    {
        max = secondDigit;
    }

    return max;
}
maxDigit();
Console.WriteLine(number);
Console.Write("Наибольшая цифра числа: ");
Console.WriteLine(max);