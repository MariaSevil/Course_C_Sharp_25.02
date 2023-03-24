// Напишите программу, которая будет преобразовывать десятичное число в двоичное.


string Binary(int num)
{
    string rezult = "";
    while (num > 0)
    {
        res = num % 2 + res;
        num /= 2;
    }
    return res;
}
// 45 -> 101101  // 3 -> 11  // 2 -> 10
Console.WriteLine(Binary(12));

// int n =int.Parse(Console.ReadLine()!);
// string result = Binary(n);
//Consolt.WriteLine(result);