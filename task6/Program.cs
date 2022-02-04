// Задача 6: Выяснить является ли число чётным
int a = int.Parse(Console.ReadLine());
int b = a%2;
if (b == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}