//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.

Console.WriteLine("Hello, World!");

int VallueSet( int N)
{
    if (N == 0) return 0;
    return VallueSet (N / 10) + N % 10;
   
}
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine(VallueSet(num));