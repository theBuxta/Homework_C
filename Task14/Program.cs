// Найти третью цифру числа или сообщить, что её нет
Random rand = new Random();
int a = rand.Next(100,999);
int b = a/10;
Console.WriteLine("Третья цифра" + a + " = " + b);