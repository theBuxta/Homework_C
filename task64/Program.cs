// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

Console.Write("Задайте число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число n: ");
int n = int.Parse(Console.ReadLine());

void NaturalNumber(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m:d2} ");
        NaturalNumber(m + 1, n);
    }
    if (m > n)
    {
        Console.Write($"{m:d2} ");
        NaturalNumber(m - 1, n);
    }
    if (m == n) Console.Write($"{m:d2} ");
}
NaturalNumber(m, n);