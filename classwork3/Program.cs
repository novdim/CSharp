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
                    arrayNumber[i] = arrayNumber[i] * (-1);
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
            int number = Convert.ToInt32(Console.ReadLine());
            int[] newArrayNumber = RandArray(len, start, end);

            findArray(newArrayNumber, number); 

            void findArray (int[] array, int inputNumber)
            {
                for (int i = 0; i < len; i++) 
                {
                    if (inputNumber == arrayNumber[i]) 
                    {
                        find = $"\n {inputNumber} да есть в массиве";
                        break;
                    }
                    else
                    {
                        find = $"\n {inputNumber} нет в массиве";
                    }
                }
                Console.Write(find);
            }

            /*
            Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
            Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
            [5, 18, 123, 6, 2] -> 1
            [1, 2, 3, 6, 2] -> 0
            [10, 11, 12, 13, 14] -> 5
            */

            /*
            Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
            [1 2 3 4 5] -> 5 8 3
            [6 7 3 6] -> 12 10
            */

        }
    }
}