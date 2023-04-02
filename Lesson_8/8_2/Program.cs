// : Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9




void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
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
 
int Vocab(int[,] arr)
 {
    int[] arr_new = new int[10];
    foreach(int a in arr) arr_new[a]++;
    return arr_new;
 }

 void Print_2(int[] arr)
 {
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($" {i}-{arr[i]}");
    }
 }
Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
Print_2(Vocab(mass));
