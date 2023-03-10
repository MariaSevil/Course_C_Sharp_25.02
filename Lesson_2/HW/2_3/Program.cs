// 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры


Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());
int ThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}
if (ThirdDigit(number1) == -1)
    Console.WriteLine("Третьей цифры нет");

else
    Console.WriteLine($"Третья цифра заданного числа:  {ThirdDigit(number1)}");