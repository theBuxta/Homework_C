// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[,] arr = new int [2,4];

for (int i = 0; i <arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {   
        arr [i,j] = new Random().Next(0,2);
        Console.Write($"{arr[i,j]}");
    }
    Console.WriteLine();
}
