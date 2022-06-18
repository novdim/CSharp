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

            //Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


            Console.WriteLine("__________");
            Console.WriteLine("Задача 30");


            void randArray (int lenArray)
            {
                Random randomA = new Random();
                int[] array = new int[lenArray];
                for (int i = 0; i <= lenArray-1; i++) 
                {
                    array[i] = randomA.Next(0,2);
                    if (i == lenArray-1)
                    {
                        Console.Write($"{array[i]}");
                    }
                    else
                    {
                        Console.Write($"{array[i]}, ");
                    }
                }
            }
            randArray(8);
            


            

        }
    }
}
