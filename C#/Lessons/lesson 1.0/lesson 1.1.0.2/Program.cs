/*Программа которая принимает число N а на выходе показывает все числа в промежутке от -N до N
*/

Console.WriteLine("Введите число: ");
string n1 = Console.ReadLine() ??"";
int n = Convert.ToInt32(n1);
n = Math.Abs(n); //добавляет если указано отрицательное число
for (int i = (-n); i <= n; i++)
{
    Console.Write(i+" ");
}