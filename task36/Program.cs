// Задать массив, заполнить случайными положительными трёхзначными числами
// Показать количество нечётных/чётных чисел

int [] arr = new int [12];
int a = 0, b = 0;

for(int i=0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 1000);
    System.Console.Write($"{arr[i]} ");
    if (arr[i] % 2 == 0 ) a = a + 1;
    if (arr[i] % 2 != 0 ) b = b + 1;
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных элементов массива: {a}");
System.Console.WriteLine($"Количество нечетных элементов массива: {b}");
