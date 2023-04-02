// Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен 
// наименьший элемент массива.

void Print(int[,] arr)
{

    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);

    return arr;
}

int[] MinEl(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int min_num = arr[0, 0];
    int[] indexes = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (min_num > arr[i, j])
            {
                min_num = arr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.WriteLine(arr[indexes[0], indexes[1]]);
    return indexes;
}

void WithoutRC(int[,] arr, int[] m_indexes)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (m_indexes[0] == i || m_indexes[1] == j) continue;
            else Console.Write($" {arr[i, j],3}");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int num_row = int.Parse(Console.ReadLine()!);
int num_column = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
MinEl(mass);


Print(mass);

