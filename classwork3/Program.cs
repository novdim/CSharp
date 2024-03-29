﻿using System;

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
                for (int i = 0; i < lenArray; i++) 
                {
                    array[i] = randomA.Next(startRange,endRange);
                    Console.Write($"{array[i]} ");
                }
                return array;
            }


            int[] arrayNumber = RandArray(len, start, end);
                    
            for (int i = 0; i < len; i++) 
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
                for (int i = 0; i < len; i++) 
                {
                    arrayNumber[i] = arrayNumber[i] * (-1);
                }

                for (int i = 0; i < len; i++) 
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


            int[] newArrayNumber = RandArray(len, start, end);
            Console.WriteLine();
            int number = Convert.ToInt32(Console.ReadLine());
            string find = $"\n {number} нет в массиве \n";

            findArray(newArrayNumber, number); 

            void findArray (int[] array, int inputNumber)
            {
                for (int i = 0; i < len; i++) 
                {
                    if (inputNumber == array[i]) 
                    {
                        find = $"\n {inputNumber} да есть в массиве \n";
                        break;
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
            
            Console.Write("\n _________ \n");
            Console.Write("Задача 35: \n");

            int lenTwo = 123;
            int startTwo = 1;
            int endTwo = 124;
            int countElements = 0;
            int[] arrayTwo = RandArray(lenTwo, startTwo, endTwo);
            findElementsArray(arrayTwo);

            void findElementsArray (int[] array)
            {
                for (int i = 0; i < lenTwo; i++) 
                {
                    if (array[i] >=10 && array[i] < 100) 
                    {
                        countElements = 1 + countElements;
                    }
                }
                Console.Write($"\n {countElements} элементов лежат в отрезке [10,99] \n");
            }

            /*
            Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
            [1 2 3 4 5] -> 5 8 3
            [6 7 3 6] -> 12 10
            */
            
            Console.Write("\n _________ \n");
            Console.Write("Задача 37: \n");

            int lenThree = 9;
            int halfLen = lenThree/2;
            int lastIndex = lenThree - 1;
            int startThree = 1;
            int endThree = 10;
            int[] arrayThree = RandArray(lenThree, startThree, endThree);
            
            multiplicationArray (arrayThree);

            void multiplicationArray (int[] array)
            {
                Console.WriteLine();
                for (int i = 0; i < halfLen; i++) 
                {
                    Console.Write($"{array[i] * array[lastIndex- i]} ");
                }
                if (lenThree%2 != 0) Console.Write($"{array[halfLen]} ");

            }
            
        }
    }
}

