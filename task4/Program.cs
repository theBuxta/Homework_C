// Задача 4: Найти максимальное из трёх чисел.
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;
if (b > a)
    {
    max = b;
    }
if (c > max)
    {
    max = c;
    }
Console.WriteLine("Максимально число " + max);
