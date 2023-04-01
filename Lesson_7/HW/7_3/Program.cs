// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
  
  void Print(int[,] arr)
{

    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

     for (int i = 0; i < row; i++)
     {
    for (int j = 0; j < column; j++)
        Console.Write($" {arr[i,j]} ");
         Console.WriteLine();
     }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
   int[,] arr = new int[row, column];
    
    for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
        arr[i,j] = new Random().Next(from, to);

    return arr;
}
  Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("------------------");
Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
}
Console.ReadLine();
int num_row = int.Parse(Console.ReadLine()!);
    int num_column = int.Parse(Console.ReadLine()!);
    int start = int.Parse(Console.ReadLine()!);
    int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row,num_column, start, stop);
    Print(mass);