﻿// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();

double xA, xB, yA, yB, zA, zB, distance;

Console.WriteLine("Расстояние между двумя точками в пространстве: ");
Console.WriteLine("Введите координаты xA: ");
xA = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты xB: ");
xB = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты yA: ");
yA = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты yB: ");
yB = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты zA: ");
zA = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты zB: ");
zB = double.Parse(Console.ReadLine() ?? "0");
distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

Console.WriteLine();
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
Console.WriteLine();