bool[,] arr = new bool[4, 2]{{true, true}, {true, false}, {false, true}, {false, false}};

for (int i = 0; i < 4; i++)
{
    if (!(arr[i, 0] & arr[i, 1]) == !arr[i, 0] | !arr[i, 1])
    {
        Console.WriteLine("Значения переменных X = {0}, Y = {1}. Утверждение истинно", arr[i, 0], arr[i, 1]);
    }
    else 
    {
        Console.WriteLine("Значения переменных X = {0}, Y = {1}. Утверждение ложно", arr[i, 0], arr[i, 1]);
    }
}