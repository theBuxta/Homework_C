// 49. Показать двумерный массив размером m×n заполненный вещественными числами

double[,] GetTableDouble(int a, int b)
{
    double[,] mass = new double[a, b];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().NextDouble() * 100;
        }
    }
    return mass;
}

void PrintTable(double[,] x)
{
    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++)
        {
            System.Console.Write(x[i, j] + "    ");
        }
        System.Console.WriteLine();
    }
}

int a = 8;
int b = 4;
double[,] massD = GetTableDouble(a, b);
PrintTable(massD);