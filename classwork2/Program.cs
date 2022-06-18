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
                for (int i = 1; i <= number;  i++) // циклом проходимя по массивам pointOne, pointTwo чтобы получить сумму разностей точек в квадрате 
                {
                    sum = sum + i;
                }
                Console.Write($"{sum}");
                
            }
            Console.WriteLine("Введите число:");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            SumNumbers(inputNumber);

            
        }
    }
}
