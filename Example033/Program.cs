// Печать массива на экран. Поиск максимального. Поиск минимального. Подсчёт количества чётных элементов в массиве. Подсчёт количества нечётных элементов в массиве.
// Подсчёт количества положительных элементов в массиве. Подсчёт количества отрицательных элементов массива. Поиск произведения элементов массива.
// Поиск суммы элементов массива. Среднее арифметическое элеметов массива. Реализовать функцию, определяющую является ли число чётным,
// то есть возвращающую true, если число чётное, иначе - false. Проверка является ли массив отсортированным по возрастанию. 
// Если массив отсортирован, то возвращать true, иначе - false.
Console.Clear();

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}
int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(min, max);
    return array;
}
int Minimum(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}
int Maximum(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}
int Even(int[] array, int even)
{
    even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            even = even + 1;
    }
    return even;
}
int NotEven(int[] array, int not_even)
{
    not_even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
            not_even = not_even + 1;
    }
    return not_even;
}
int Plus(int[] array)
{
    int plus = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            plus++;
    return plus;
}
int Minus(int[] array)
{
    int minus = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < 0)
            minus++;
    return minus;
}
int WorkArray(int[] array)
{
    int work = 1;
    for (int i = 0; i < array.Length; i++)
    {
        work = work * array[i];
    }
    return work;
}
int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum = sum + array[i];
    return sum;
}
float ArrayMean(int[] array)
{
    return SumArray(array) / (float)array.Length;
}
bool ArrayEven(int[] array)
{
    return SumArray(array) % 2 == 0;
}
bool Sorted(int[] array)
{
    for (int index = 0; index < array.Length - 1; index++)
        if (array[index] > array[index + 1])
            return false;
    return true;
}
Console.Write("Введите массив ");
int length = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите минимальный интервал массива ");
int first = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите максимальный интервал массива ");
int next = int.Parse(Console.ReadLine() ?? "0");
int[] array = CreateArray(length, first, next);
Console.Write("Ваш массив ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Минимальное число в массиве {Minimum(array)}, максимальное число в массиве {Maximum(array)}");
int even = Even(array, length);
int not_even = NotEven(array, length);
Console.WriteLine($"Количество четных элементов в массиве {even}, количество нечетных элементов в массиве {not_even}");
Console.WriteLine($"Количество положительных элементов в массиве {Plus(array)}, количество отрицательных элементов в массиве {Minus(array)}");
Console.WriteLine($"Произведение элементов массива равно {WorkArray(array)}");
Console.WriteLine($"Сумма элементов массива: {SumArray(array)}");
Console.WriteLine($"Среднее арифметическое элеметов массива = {ArrayMean(array)}");
if (ArrayEven(array)) Console.WriteLine($"Сумма элементов = {SumArray(array)} - четная");
else Console.WriteLine($"Сумма элементов = {SumArray(array)} нечетная");
if (Sorted(array)) Console.WriteLine("Массив отсортирован по возрастанию");
else Console.WriteLine("Массив не отсортирован по возрастанию");