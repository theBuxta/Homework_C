// Написать программу для замены элементов массива на противоположные

int [] arr = new int [12];

for (int i=0; i< arr.Length; i++)
{
    arr[i] = new Random().Next(-9, 10);
    System.Console.Write($"{arr[i]} ");
    arr[i] = arr[i]*(-1);
}

System.Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write($"{arr[i]} ");
}