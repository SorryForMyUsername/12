using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Используя случайное число в диапазоне от 1 до 7, вывести на экран название дня недели.
            //Random rnd = new Random();
            //int number = rnd.Next(1, 7);
            //Console.WriteLine(number);
            //switch(number)
            //{
            //    case 1: 
            //        Console.WriteLine("Понедельник");
            //        break;
            //    case 2:
            //        Console.WriteLine("Вторник");
            //        break;
            //    case 3:
            //        Console.WriteLine("Среда");
            //        break;
            //    case 4:
            //        Console.WriteLine("Четверг");
            //        break;
            //    case 5:
            //        Console.WriteLine("Пятница");
            //        break;
            //    case 6:
            //        Console.WriteLine("Суббота");
            //        break;
            //    case 7:
            //        Console.WriteLine("Воскресенье");
            //        break;
            //    default: 
            //        Console.WriteLine("Eroor");
            //        break;
            //}

            //Задача 2. Даны два целых положительных числа. Если все они четные, каждое число уменьшить в 2 раза, если хотя бы одно из них четное, увеличить каждое число в 2 раза, если четных чисел нет, каждое число увеличить на 1.
            //Console.Write("Введите первое число: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Введите второе число: ");
            //int num2 = int.Parse(Console.ReadLine());
            //if(num1 % 2 == 0 & num2 % 2 == 0)
            //{
            //    num1 /= 2;
            //    num2 /= 2;
            //}
            //else if (num1 % 2 == 0 | num2 % 2 == 0)
            //{
            //    num1 *= 2;
            //    num2 *= 2;
            //}
            //else
            //{
            //    num1++;
            //    num2++;
            //}
            //Console.WriteLine($"Первое число теперь равно {num1}");
            //Console.WriteLine($"Второе число теперь равно {num2}");

            //Задача 3. Проведен тест, оцениваемый в целочисленных баллах от нуля до ста. Вывести на экран оценку тестируемого в зависимости от набранного количества баллов: от 90 до 100 – «отлично», от 70 до 89 – «хорошо», от 50 до 69 – «удовлетворительно», менее 50 – «неудовлетворительно».
            //Console.Write("Набранное количество баллов от 0 до 100: ");
            //int balls = int.Parse(Console.ReadLine());
            //if (90 <= balls)
            //{
            //    Console.WriteLine("Оценка: Отлично");
            //}
            //else if (70 <= balls && balls < 90)
            //{
            //    Console.WriteLine("Оценка: Хорошо");
            //}
            //else if(50 <= balls && balls < 70)
            //{
            //    Console.WriteLine("Оценка: Удовлетворительно");
            //}
            //else if(balls < 50)
            //{
            //    Console.WriteLine("Оценка: Неудовлетворительно");
            //}

            Console.ReadKey();
        }
    }
}
