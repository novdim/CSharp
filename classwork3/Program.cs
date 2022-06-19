using System;
using System.Text.RegularExpressions; // подключаю "библиотеку" регулярных выражений

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


        /*
        Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
        */

        Console.Write("_________ \n");
        Console.Write("Задача 31: \n");

            int len = 12;
            int start = -9;
            int end = 10;
            int minusNumber = 0;
            int plusNumber = 0;

            int[] randArray (int lenArray, int startRange, int endRange)
            {
                Random randomA = new Random();
                int[] array = new int[lenArray];
                for (int i = 0; i <= lenArray-1; i++) 
                {
                    array[i] = randomA.Next(startRange,endRange);
                    Console.Write($"{array[i]} ");
                }
                return array;
            }


            int[] array = randArray(len, start, end);
                    
            for (int i = 0; i <= 12-1; i++) 
            {
                if (array[i] < 0)
                {
                    minusNumber = minusNumber + array[i];
                }
                else
                {
                    plusNumber = plusNumber + array[i];
                }
            }

            Console.Write($"\n Сумма отрицательных чисел: ({minusNumber}), сумма положительных чисел: {plusNumber}");
        }
    }
}