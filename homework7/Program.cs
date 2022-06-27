using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

        // Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
        // m = 3, n = 4.
        // 0,5 7 -2 -0,2
        // 1 -3,3 8 -9,9
        // 8 7,8 -7,1 9
        int size_rows = 3;
        int size_column = 4;
        
        double[,] new_Array = RandArray(size_rows, size_column, 11, 10);
        PrintArray(new_Array);

        

        // Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
        // и возвращает значение этого элемента или же указание, что такого элемента нет.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4

        // [1, 3] -> 3

        // Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 5 3
        // 8 4 6 4

        // Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.

        // Методы

        double[,] RandArray(int rows, int columns, int start, int end)
        {
            Random random = new Random();
            double namber = 0;
            double[,] array = new double[rows, columns];

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    namber = random.NextDouble() * end - random.Next(1,start);
                    array[i, j] = Math.Round(namber, 1);
                }                    
            }
            return array;
        }

        void PrintArray(double[,] currentArray)
        {
            for (int i = 0; i < currentArray.GetLength(0); i++)
            {
                for (int j = 0; j < currentArray.GetLength(1); j++)
                {
                    Console.Write(currentArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        }
    }
}
