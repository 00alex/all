/*

Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

*/



int GetRandomNumder()
{
    return new Random().Next(100, 1000); // 100 ... 999
}


void ShowNumber(int number)
{
    Console.WriteLine($"Случайное трех значное число:  {number}");
    string str = number.ToString();
    Console.WriteLine($"> {str[0]}{str[2]}");
}
ShowNumber(GetNumder());


void ShowRandomNumberSecond(int number)
{
    Console.WriteLine($"Случайное трех значное число:  {number}");
    int result = (((number / 100) * 10) + (number % 10));
    Console.WriteLine($"> {result}");
}
ShowRandomNumberSecond(GetRandomNumder());
