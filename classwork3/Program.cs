using System;

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

            int[] RandArray (int lenArray, int startRange, int endRange)
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


            int[] arrayNumber = RandArray(len, start, end);
                    
            for (int i = 0; i <= len-1; i++) 
            {
                if (arrayNumber[i] < 0)
                {
                    minusNumber = minusNumber + arrayNumber[i];
                }
                else
                {
                    plusNumber = plusNumber + arrayNumber[i];
                }
            }

            Console.Write($"\n Сумма отрицательных чисел: ({minusNumber}), сумма положительных чисел: {plusNumber} \n");

            /* Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
            [-4, -8, 8, 2] -> [4, 8, -8, -2]
            */

            Console.Write("_________ \n");
            Console.Write("Задача 32: \n");

            void changeArray (int[] array)
            {
                for (int i = 0; i <= len-1; i++) 
                {
                    if (arrayNumber[i] < 0) // не влияет на сумму
                    {
                        arrayNumber[i] = Math.Abs(arrayNumber[i]);
                    }
                    else
                    {
                        arrayNumber[i] = arrayNumber[i] * (-1);
                    }
                }

                for (int i = 0; i <= len-1; i++) 
                {
                    Console.Write($"{arrayNumber[i]} ");   
                }
            }
            changeArray(arrayNumber); 


            /*
            Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
            4; массив [6, 7, 19, 345, 3] -> нет
            3; массив [6, 7, 19, 345, 3] -> да
            */
            Console.Write("\n _________ \n");
            Console.Write("Задача 33: \n");

            string find = String.Empty;
            
            void findArray (int[] array, int inputNumber)
            {
                for (int i = 0; i <= len-1; i++) 
                {
                    if (arrayNumber[i] == inputNumber) 
                    {
                        find = $"{inputNumber} да есть в массиве";
                    }
                    else
                    {
                        find = $"{inputNumber} нет в массиве";
                    }
                }
                Console.Write(find);

            }
            int number = Convert.ToInt32(Console.ReadLine());
            findArray(arrayNumber, number); 
        }
    }
}