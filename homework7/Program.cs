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

            Console.WriteLine($"__________");
            Console.WriteLine($"Задача 47:");
            int size_rows = 3;
            int size_column = 4;
            int start = 11;
            int end = 10;
            
            double[,] new_Array = RandDoubleArray(size_rows, size_column, start, end);
            PrintDoubleArray(new_Array);

            

            // Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
            // и возвращает значение этого элемента или же указание, что такого элемента нет.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // [1, 3] -> 3

            Console.WriteLine($"__________");
            Console.WriteLine($"Задача 50:");

            Console.WriteLine($"Введите номер строки (расчет строк начинается с 0)");
            int number_row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите номер столбца(расчет столбцов начинается с 0)");
            int number_column = Convert.ToInt32(Console.ReadLine());

            OutputElementByPosition(new_Array, number_row, number_column); // массив new_Array беру из задачи 47

            
            // Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 5 3
            // 8 4 6 4

            // Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.

            Console.WriteLine($"__________");
            Console.WriteLine($"Задача 52:");

            int max_quantity_rows = 10;
            int max_quantity_columns = 10;
            int range_start = 1;
            int range_end = 10;

            int[,] last_array = RandArray(max_quantity_rows, max_quantity_columns, range_start, range_end);
            PrintArray(last_array);
            Console.WriteLine($"Среднее арифметическое каждого столбца:");
            
            ArithmeticMeanColumn(last_array);

            // Методы

            double[,] RandDoubleArray(int rows, int columns, int start, int end)            // метод генерации массива вещественных     
            {
                Random random = new Random();
                double namber = 0;
                double[,] array = new double[rows, columns];

                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        namber = random.NextDouble() * end - random.Next(1,start);          // random использую 2 раза чтобы было больше положительных чисел =)
                        array[i, j] = Math.Round(namber, 1);
                    }                    
                }
                return array;
            }

            int[,] RandArray(int max_rows, int max_columns, int start, int end)             // метод генерации массива целых чисел от 3 и более строк и от 4 и более столбцов     
            {
                Random random = new Random();
                int rows = random.Next(3,max_rows);
                int columns = random.Next(4,max_columns);

                int[,] array = new int[rows, columns];

                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = random.Next(start, end);
                    }                    
                }
                return array;
            }

            void PrintDoubleArray(double[,] currentArray)                                   // метод печати массива вещественных чисел
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

            void PrintArray(int[,] currentArray)                                            // метод печати массива целых чисел
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

            void OutputElementByPosition (double[,] currentArray, int row_id, int column_id) // метод вывода элента по позиции (номер строки и столбца)
            {
                int quantity_row = currentArray.GetLength(0);
                int quantity_column = currentArray.GetLength(1);
                
                if (row_id > quantity_row || column_id > quantity_column || row_id < 0 || column_id < 0) 
                    Console.WriteLine("Элемента с такой позицией нет");
                else Console.WriteLine(currentArray[row_id, column_id]);
            }

            void ArithmeticMeanColumn(int [,] currentArray)                                 // метод среднего арифметического элементов столбца
            {
                double arithmetic_mean = 0;
                double length_column = currentArray.GetLength(0);
                double sum = 0;
                for (int j = 0; j < currentArray.GetLength(1); j++)
                {
                    sum = 0;
                    arithmetic_mean = 0;
                    for (int i = 0; i < currentArray.GetLength(0); i++)
                    {
                        sum += currentArray[i, j];   
                    }
                    arithmetic_mean = sum / length_column;
                    Console.Write($"{Math.Round(arithmetic_mean, 1)} \t");
                }
            }

        }
    }
}
