/* напишите программу которая умножает число на число, делает его в квадрат 
например:
3*3 -> 9
5*5 -> 25
7*7 -> 49
*//*
Console.WriteLine ("Введите число:");
string numberStr = Console.ReadLine() ?? "";
int number = Convert.ToInt32(numberStr);
double Sqr = Math.Pow(number,9);
int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result} = {Sqr}"); 

*/

/*Нижняя хрень показывает как и что я встроил в код выше чтобы преобразовать в квадрат

using System; 
using System.Text; 
using System.Collections; 
namespace Cons 
{ 
    public class square 
    { 
        public static void Main() 
        { 
                Console.WriteLine("Enter a Number : "); 
                int Number = Convert.ToInt16(Console.ReadLine()); 
                double Sqr = Math.Pow(Number,2); - эта хрень выводит в квадрат, если поставить 3 то будет в куб, если в 4 и так далее будет возводить в эту степнь
                Console.WriteLine("Square of {0} is: {1}", Number, Sqr); 
                Console.ReadLine(); 
        } 
    } 
} 



*/

/*

Вводить номер недели и чтобы выходила неделя

*/
/*
Console.WriteLine("Введите число номера недели по понядку:");
string day = Console.ReadLine();
switch (day)
{
    case "1" :
    Console.WriteLine("Понедельник");
    break;
    case "2" :
    Console.WriteLine("Вторник");
    break;
    case "3" :
    Console.WriteLine("Среда");
    break;
    case "4" :
    Console.WriteLine("Четверг");
    break;
    case "5" :
    Console.WriteLine("Пятница");
        break;
    case "6" :
    Console.WriteLine("Суббота");
    break;
    case "7" :
    Console.WriteLine("Воскресенье");
    break;

    default:
    Console.WriteLine("Воскресенье");
    break;

}
*/
Console.WriteLine("Введите число: ");
string n1 = Console.ReadLine() ??"";
int n = Convert.ToInt32(n1);

for (int i = (-n); i < n; i++)
{
    Console.Write(i);
}