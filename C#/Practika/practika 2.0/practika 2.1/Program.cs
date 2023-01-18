/*

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/


 //   Console.WriteLine($"> {str[1]}");


int number = ReadInt($"Введите трехзначное число: ");
int str = number.ToString().Length;

if (str < 3 || str > 3)
{
    Console.WriteLine($"Случайное трех значное число:  {number}");
}
else
{
    Console.WriteLine(InCenter(number));
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    
    return result;
}