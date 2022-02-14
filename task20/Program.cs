// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти");
int a = int.Parse(Console.ReadLine());

if (a == 1)
{
    Console.WriteLine("X = 0 ; -100");
    Console.WriteLine("Y = 0 ; +100");
    return;
}
if (a == 2)
{
    Console.WriteLine("X = 0 ; +100");
    Console.WriteLine("Y = 0 ; +100");
    return;
}
if (a == 3)
{
    Console.WriteLine("X = 0 ; -100");
    Console.WriteLine("Y = 0 ; -100");
    return;
}
if (a == 4)
{
    Console.WriteLine("X = 0 ; +100");
    Console.WriteLine("Y = 0 ; -100");
    return;
}
else
{
    Console.WriteLine("Неправильно введена четверть");
}