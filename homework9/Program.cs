using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

 
            //  Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
            // M = 1; N = 9. -> "3, 6, 9 M = 13; N = 20. -> "15, 18"

            Console.WriteLine($"\n__________");
            Console.WriteLine($"Задача 64:");

            Console.WriteLine($"Введите число M:");
            int numberM_ex64 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите число N:");
            int numberN_ex64 = Convert.ToInt32(Console.ReadLine());
            
            NumbersMultiplesThree(numberM_ex64,numberN_ex64);
            Console.WriteLine("\b \b\b \b");

             
            // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            // M = 1; N = 15 -> 120
            // M = 4; N = 8. -> 30

            Console.WriteLine($"\n__________");
            Console.WriteLine($"Задача 66:");

            Console.WriteLine($"Введите число M:");
            int numberM_ex66 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите число N больше чем {numberM_ex66}:");
            int numberN_ex66 = Convert.ToInt32(Console.ReadLine());

            Console.Write(SumNaturaleNumbers(numberM_ex66, numberN_ex66));

           
            // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            // m = 3, n = 2 -> A(m,n) = 29   

            Console.WriteLine($"\n__________");
            Console.WriteLine($"Задача 68:");        

            Console.WriteLine($"Введите число M:");
            double numberM_ex68 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"Введите число N:");
            double numberN_ex68 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"A({numberM_ex68},{numberN_ex68}) - {Akkerman(numberM_ex68,numberN_ex68)}");



            // ____________МЕТОДЫ _____________

            void NumbersMultiplesThree (int number_one, int number_two, int multiplicity_number = 3)
            {
                if (number_one > number_two) 
                    {
                        return;
                    }
                if (number_one%multiplicity_number == 0) 
                {
                    Console.Write($"{number_one}, ");
                }
                
                NumbersMultiplesThree(number_one+1, number_two);
            }

            int SumNaturaleNumbers (int number_one, int number_two, int sum = 0)
            {
                if (number_one > number_two) return sum;
                // else if (number_one > number_two) return 0;
                sum += number_one;
                
                return SumNaturaleNumbers(number_one+1, number_two, sum);
            }

            double Akkerman (double m, double n)
            {
                if (m == 0) return n+1;
                if (m > 0 && n == 0) return Akkerman(m-1, 1);
                if (m > 0 && n > 0) return Akkerman(m-1, Akkerman(m,n-1));
                return Akkerman(m,n);
            }

        }
    }
}