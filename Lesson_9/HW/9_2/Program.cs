// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

Console.WriteLine("Hello, World!");

int RecSumma(int m, int n)
{
   
    if (m == n) return n ;
   else return m + RecSumma(m + 1, n);
}
    Console.Write($"");
int sum = int.Parse(Console.ReadLine()!);

RecSumma(m,n);