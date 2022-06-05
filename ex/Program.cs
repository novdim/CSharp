using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.
            //Напишите программу, которая на вход принимает два числа и проверяет,
            //является ли первое число квадратом второго

            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            
            if (b == a * a)
            {
                Console.WriteLine("да, число является квадратом");
            }
            else
            {
                Console.WriteLine("нет, число не является квадратом");
            }     

            //Задача 2
            //Напишите программу, которая на вход принимает два числа и проверяет,
            //является ли первое число квадратом второго

            Console.WriteLine("Введите число:");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day == 1)
            {
                Console.WriteLine("Понедельник");
            }
            else if (day == 2)
            {
                Console.WriteLine("Вторник");
            }
            else if (day == 3)
            {
                Console.WriteLine("Среда");
            }
            else if (day == 4)
            {
                Console.WriteLine("Четверг");
            }
            else if (day == 5)
            {
                Console.WriteLine("Пятница");
            }
            else if (day == 6)
            {
                Console.WriteLine("Суббота");
            }
            else if (day == 7)
            {
                Console.WriteLine("Воскресение");
            }
            else
            {
                Console.WriteLine("День недели введён неверно");
            }

            /*Задача 3 Напишите программу, которая на вход принимает одно число
            (N), а на выходе показывает все целые числа в промежутке от -N
            до N.
            */

            Console.WriteLine("Введите число:");
            int namber = Convert.ToInt32(Console.ReadLine());
            int start = -Math.Abs(namber);
            int finish = Math.Abs(namber);
            while (start <= finish)
            {
                Console.WriteLine(start);
                start++;
            }

            /*Задача 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	        456 -> 6
	        782 -> 2
        	918 -> 8
            */
            
            
            bool numberСheck = false;
            while (numberСheck != true)
            {
                Console.WriteLine("Введите трех значное число:");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 99 && n < 1000)
                {
                    Console.WriteLine("Последняя цифра введенного трехзначного числа:");
                    Console.Write(n%10);
                    numberСheck = true;       
                }
                else
                {
                    Console.WriteLine("Вы ввели не трех значное число. Попробуйте еще раз!");
                }
            }
            
        }
    }
}
