// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:  ");
string number = (Console.ReadLine()!);

if (number.Length == 5)
{

    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром ");
    }
    else
    {
        Console.WriteLine($"{number} - Не палиндром "); 
}
}
    else
    {
        Console.WriteLine($"error: {number} - Не палиндром ");

    }
    return 0;

