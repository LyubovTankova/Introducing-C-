// Найти третью цифру числа или сообщить, что её нет

int number = new Random().Next(1, 1200);
Console.WriteLine(number);

if(number / 100 > 0)
   {
    Console.WriteLine(number / 100 % 10);
   }
else
   {
    Console.WriteLine("У числа нет третьей цифры");
   }
Console.WriteLine();