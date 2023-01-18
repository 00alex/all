/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


*/



 Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
//           Console.WriteLine((a > b) ? "{0} {1}" : "{1} {0}", a, b); //выводит порядок введенных чисел
if (a > b)                                          //
    {                                                   //   это 
        Console.WriteLine("Наибольшее число: " + a);    //     все
    }                                                   //      выводит
else                                                    //      максимальное
    {                                                   //      число
        Console.WriteLine("Наибольшее число: " + b);    //      из двух
    }                                                   //
    return;                                             //      вводимых  чисел

