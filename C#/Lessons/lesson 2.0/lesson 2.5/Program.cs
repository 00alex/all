/*

Напишите программу, которая принимает на вход 2 чмсла и проверяет, является ли одно число квадратом другого

*/

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (((num1 * num1) == num2) || ((num2 * num2) == num1))
{
    Console.WriteLine("ok");
}
else
    Console.WriteLine("not ok");
