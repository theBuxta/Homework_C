// Задача 8: Показать чётные числа от 1 до N.
int a = int.Parse(Console.ReadLine());
for (int i=1; i<=a; i++)
if (i%2 == 0)
{
    Console.Write(i + " ");
}
return;