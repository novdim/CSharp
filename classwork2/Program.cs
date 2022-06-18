using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
            void SumNumbers (int number) //метод вывода кубов чисел от 1 до N.
            {
                int sum = 0;
                for (int i = 1; i <= number;  i++)
                {
                    sum = sum + i;
                }
                Console.Write($"{sum} \n");
                
            }

            Console.WriteLine("__________");
            Console.WriteLine("Задача 24");

            Console.WriteLine("Введите число:");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            SumNumbers(inputNumber);

            // Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

            void CountNumbers (string number) //метод вывода кубов чисел от 1 до N.
            {
                Console.Write($"{number.Length} \n");
            }


            Console.WriteLine("__________");
            Console.WriteLine("Задача 26");

            Console.WriteLine("Введите число:");
            string inputNumberA = Console.ReadLine();

            CountNumbers(inputNumberA);

            
            // Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

            void multiplicationNumbers (int number) 
            {
                int multiplication = 1;
                for (int i = 1; i <= number;  i++) 
                {
                    multiplication = multiplication * i;
                }
                Console.Write($"{multiplication} \n");
            }

            Console.WriteLine("__________");
            Console.WriteLine("Задача 28");

            Console.WriteLine("Введите число:");
            int inputNumberB = Convert.ToInt32(Console.ReadLine());
            multiplicationNumbers(inputNumberB);




        }
    }
}
