// Задача 2: Даны два числа. Показать большее и меньшее число
using System;

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Max = " + a);
    Console.WriteLine("Min = " + b);
}
else 
{
    Console.WriteLine("Max = " + b);
    Console.WriteLine("Min = " + a);
}