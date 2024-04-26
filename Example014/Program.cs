// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();

int quarterNumber = new Random().Next(1, 5);
string result = "";

if(quarterNumber == 1) 
{
    result = "x > 0, y > 0";
}    
else 
if(quarterNumber == 2) 
{
    result = "x < 0, y > 0";
}
else 
if(quarterNumber == 3) 
{
    result = "x < 0, y < 0";
}
else 
if(quarterNumber == 4) 
{
    result = "x > 0, y < 0";
}
Console.WriteLine($"Для {quarterNumber} четверти, диапазон возможных координат ( {result} ) ");
Console.WriteLine();