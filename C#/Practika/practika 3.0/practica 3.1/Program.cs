﻿Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}