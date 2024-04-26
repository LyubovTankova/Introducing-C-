// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int number = new Random().Next(10, 99);
int number2 = new Random().Next(1, 19);
int ostatok = 0;

int ostatokDel()
   {
    ostatok = number % number2;
    return ostatok;
   }
ostatokDel();

if (ostatok == 0)
   {
    Console.WriteLine("Первое число кратно второму");
   }
else
   {
    Console.WriteLine("Первое число не кратно второму");
    Console.WriteLine("Остаток от деления");
   }
Console.WriteLine(number);
Console.WriteLine(number2);
Console.Write(ostatok);