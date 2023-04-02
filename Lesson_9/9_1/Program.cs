// Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Hello, World!");

void VallueSet( int m, int n)
{
    if (n < m) return;
    VallueSet(m, n -1);
    Console.Write($" {n}" );
}
int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
VallueSet(num_1, num_2);
