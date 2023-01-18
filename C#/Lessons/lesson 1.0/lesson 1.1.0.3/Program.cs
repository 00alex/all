/* Задача 7 Программа, которая принимает на вход трехзначное число и на выходе
показывает последнюю цмфру этого числа
432 -> 2
456 -> 6
599 -> 9
*/

Console.WriteLine("Введите число: ");
string nstring = Console.ReadLine() ?? "";
int n = Convert.ToInt32(nstring);


if((n>=100) && (n<=999))
    Console.WriteLine(n % 100);
else
{
    Console.WriteLine("Неверно введенное значение: ");
}
/*
string nstring = Console.ReadLine();
Console.WriteLine(nstring[2]);
*/