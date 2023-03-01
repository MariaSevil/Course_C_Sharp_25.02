// 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих
// пример: 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите 3 числа:");

string num_1 = Console.ReadLine()!;
string num_2 = Console.ReadLine()!;
string num_3 = Console.ReadLine()!;

int a = int.Parse(num_1);
int b = int.Parse(num_2);
int c = int.Parse(num_3);
int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

else Console.WriteLine("Наибольшее из введённых чисел -> " + max);



