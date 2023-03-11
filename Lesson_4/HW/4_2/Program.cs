// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine( "Enter a number:  ");

int SumNum(int num)
{
    int sum = 0;
    for(int i = num; num != 0; num/=10){
      
      sum += num % 10;
    }
    return sum;      
}
 
 int num = int.Parse(Console.ReadLine()!);
 
 Console.WriteLine(SumNum(num));

