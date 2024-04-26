//Найти максимальное из трех чисел
Console.Clear();

int a = 1;
int b = 20;
int c = 60;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);