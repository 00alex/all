/*

Напишите программу, которая выводит случайное число из отрезка [10б 99]
и показывает наибольшу цифру числа

*/

int GetRandomNumber(int left, int right)
{
    Random rnd = new Random();
    int number = rnd.Next(left, right +1);
    return number;
}

int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = GetRandomNumber(10, 99);
Console.WriteLine($"Сгенирированное число: {number}");
int maxDigit = GetMaxDigitOfNumber(number);
Console.WriteLine ($"Наибольшая цифра числа: {maxDigit}");
