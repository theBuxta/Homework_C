// 42. Определить сколько чисел больше 0 введено с клавиатуры

System.Console.WriteLine("Введите 5 разных чисел через Enter");
int volume = 5;
int count = 0;

while (volume > 0)
{
    System.Console.Write("Введите число: ");
    string num = Console.ReadLine();
    int number = Convert.ToInt32(num);
    if (number > 0) count++;
    volume--;
}

System.Console.WriteLine($"Количество чисел больше 0: {count}");