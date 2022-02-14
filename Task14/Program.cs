// Найти третью цифру числа или сообщить, что её нет

string num = Console.ReadLine();
int a = Convert.ToInt32(num);

if ((a + 100 ) / 100 > 1)
    {
    Console.WriteLine ("Третья цифра числа " + num + " - " + num[2]);
    }
else
    {
Console.WriteLine ("В числе " + num + " нет третьей цифры");
    }