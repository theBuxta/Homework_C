// Показать кубы чисел, заканчивающихся на четную цифру

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

for (int i = a; i <= b; i++)
{
    if (Math.Pow(i, 3) % 2 == 0) Console.WriteLine("{0, 5}^3 = {1, -20}", i, Math.Pow(i, 3));
}