// Удалить вторую цифру трёхзначного числа

Random rand = new Random();
int a = rand.Next(100,999);
int b = a/100;
int c = a%10;


Console.WriteLine(a);
Console.WriteLine(b +""+ c);