using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

        // Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
        // 3, 5 -> 243
        // 2, 4 -> 16

        void exponentiation(int numberA, int numberB)
        {
            int result = 1; // объявлем переменную (аккумулятор) в которую(ый) будем складывать результат возведения в степень, так как операция умножение значение делаем 1
            for(int i = 1; i <= numberB; i++) 
            {
                result = result*numberA;
            }
            Console.Write($"Число {numberA} в степени {numberB} = {result}");
            Console.Write($"\n Так же можно получить число {numberA} в степени {numberB} используя метод Math.Pow результат будет = {Convert.ToInt32(Math.Pow(numberA, numberB))}");
        }
        Console.Write($"Введите число А:");
        int inputNumberA = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите число B (степень в которую будем возводить число {inputNumberA}:");
        int inputNumberB = Convert.ToInt32(Console.ReadLine());
        
        exponentiation(inputNumberA, inputNumberB);


        // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        // 452 -> 11
        // 82 -> 10
        // 9012 -> 12


        // Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
        // -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
        // 6, 1, -33 -> [1, 6, -33]
 
        }
    }
}