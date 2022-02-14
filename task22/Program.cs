// Найти расстояние между точками в пространстве 2D/3D
using static System.Console;

Console.WriteLine("введите координаты двух точек");
Console.WriteLine("Точка А с координатами X, Y, Z");

Console.Write("X = ");
int xA = int.Parse(ReadLine());
Console.Write("Y = ");
int yA = int.Parse(ReadLine());
Console.Write("Z = ");
int zA = int.Parse(ReadLine());
Console.WriteLine("Точка B с координатами X, Y, Z)");
Console.Write("X = ");
int xB = int.Parse(ReadLine());
Console.Write("Y = ");
int yB = int.Parse(ReadLine());
Console.Write("Z = ");
int zB = int.Parse(ReadLine());

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));

WriteLine("Расстояние между точками " + distance);