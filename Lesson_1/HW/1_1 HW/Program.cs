// 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число
// большее, а какое меньшее. a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

string num_a = Console.ReadLine()!;
string num_b = Console.ReadLine()!;
int a = int.Parse(num_a);
int b = int.Parse(num_b);

if (a > b ) Console.WriteLine("первое число больше второго числа");
else Console.WriteLine("второе число больше первого числа");
