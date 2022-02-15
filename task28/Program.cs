// Подсчитать сумму цифр в числе

Console.WriteLine("Введите целое число");
int a = int.Parse(Console.ReadLine());
int b = 0;

a = Math.Abs(a);

while (a > 0)
{
    b += a % 10;
    a /= 10;
}

Console.WriteLine(b);