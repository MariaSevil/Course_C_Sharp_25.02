// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.


Console.WriteLine();

void VallueSet(int N)
{
    if (N == 0) return;
    VallueSet(N -1);
    Console.Write($" {N}" );
}
int num = int.Parse(Console.ReadLine()!);
VallueSet(num);