// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

Console.WriteLine("Hello, World!");

void VallueSet(int m, int n)
{
    if (m < n) return;
     if (m % 2 == 0);
       VallueSet(m-1, n);
    Console.Write($" {m}");
    
    
}
int num= int.Parse(Console.ReadLine()!);
int num_1 = int.Parse(Console.ReadLine()!);
VallueSet(num, num_1);