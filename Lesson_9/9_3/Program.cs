// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии


Console.WriteLine("Hello, World!");

int VallueSet( int A, int B)
{
    if (B == 0) return 1;
    return VallueSet(A, B - 1) * A;
   
}
int num_A = int.Parse(Console.ReadLine()!);
int num_B = int.Parse(Console.ReadLine()!);

Console.WriteLine( VallueSet(num_A, num_B));