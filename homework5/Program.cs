using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

        // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
        // Напишите программу, которая покажет количество чётных чисел в массиве.

            Console.Write($"\n__________\n");
            Console.Write($"Задача 34: \n");

            int lenArray = 10;
            int startRange  = 100;
            int endRange = 1000;

            int[] newArray = RandArray(lenArray, startRange, endRange);
            PrintArray(newArray);
            СountEvenNumbersInArray(newArray);


            int[] RandArray (int len, int start, int end) // метод генирации массива, заданной длинны len на заданном отрезке start, end
            {
                Random randomA = new Random();
                int[] array = new int[len];
                for (int i = 0; i < len; i++) 
                {
                    array[i] = randomA.Next(start,end);
                }
                return array;
            }

            void СountEvenNumbersInArray (int[] array) //метод подсчета четных чисел в массиве
            {
                int cout = 0;
                for (int i = 0; i < array.Length; i++) 
                {
                    if (array[i]%2 == 0) cout += 1;
                }
                Console.Write($"\n Четных чисел в массиве - {cout}.");
            }

            void PrintArray(int[] array) // метод печати массива
            {
                for (int i = 0; i < array.Length; i++) 
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.Write("\b \b\b \b"); // удаляем последнюю запятую и пробел массива 
            }
        
        
        // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
        // Найдите сумму элементов, стоящих на нечётных позициях.
        
        Console.Write($"\n__________\n");
        Console.Write($"Задача 36: \n");

        int lenArray2 = 5;
        int startRange2  = 1;
        int endRange2 = 100;

        int[] arrayTwo = RandArray(lenArray2, startRange2, endRange2); // метод RandArray ранее использовался в задаче 34 с другими входными параметрами
        PrintArray(arrayTwo);
        SumNonEvenNumbers(arrayTwo);

        void SumNonEvenNumbers (int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i]%2 != 0) sum += array[i];
            }
            Console.Write($"\n Сумма не четных чисел в массиве - {sum}. \n");
        }
    
        // Задача 38: Задайте массив вещественных чисел. 
        // Найдите разницу между максимальным и минимальным элементов массива.

        Console.Write($"\n__________\n");
        Console.Write($"Задача 38: \n");

        
        double[] arrayThree = {3, 7, -2.2, 2, 78};

        PrintArray_double(arrayThree);
        DifferenceMaxMinNumberInArray(arrayThree);    

        void PrintArray_double(double[] array) // метод печати массива
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write($"{array[i]}, ");
            }
            Console.Write("\b \b\b \b"); // удаляем последнюю запятую и пробел массива 
        }

        void DifferenceMaxMinNumberInArray(double[] array)
        {
            double min, max;

            if (array[0] > array[1])
            {
                max = array[0];
                min = array[1];
            }
            else
            {
                max = array[1];
                min = array[0];
            }

            for(int i = 2; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.Write($"\n Разница максимального и минимального элемента: {max} - ({min}) = {max-min}");

        }

        }
    }
}