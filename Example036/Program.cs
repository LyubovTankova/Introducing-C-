// Реализовать функцию, которая проверяет является ли заданное число n полиндромом
Console.Clear();

bool IsPalindrome(string a)
{
    for (int i = 0; i < a.Length / 2; i++)
        if (a[i] != a[a.Length - i - 1])
        {
            return false;
        }
    return true;
}

Console.Write("Введите число или слово: ");
string a = Console.ReadLine();
if (IsPalindrome(a)) Console.WriteLine($"{a} является палиндромом");
else Console.WriteLine($"{a} не является палиндромом");