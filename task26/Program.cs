// Возведите число А в натуральную степень B используя цикл

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

for (int i = 1; i<=b; i++)
{
    Console.WriteLine($"{a}^{i} = {(long)Math.Pow(a, i):N0}"); 
}
