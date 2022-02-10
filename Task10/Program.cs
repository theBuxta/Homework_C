// Показать вторую цифру трёхзначного числа

Random rand = new Random();
int a = rand.Next(100,999);
int b = a%100/10;
Console.WriteLine("Вторая цифра числа " + a + " = " + b);