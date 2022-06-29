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

            // Задача 1. Даны две матрицы, количество строк и столбцов которых может быть 3 или 4, 
            // заполнены числами от -9 до 9. Выполните умножение матриц.


            Console.WriteLine($" \n__________");
            Console.WriteLine($"Доп. Задача 1:");

            // можно снять с коммента цикл for для того чтобы умножить сразу несколько матриц, 
            // так как столбцы и строки задаются рандомом от 3 до 4, 
            // не всегда возможно перемножение матриц(массивов).
             

            // for(int i = 0; i < 10; i++)  
            // {
                int[,] array_1 = RandArray(5, 5, -9, 10);
                int[,] array_2 = RandArray(5, 5, -9, 10);
                Console.WriteLine($"____1____");
                PrintArray(array_1);
                Console.WriteLine($"____2____");
                PrintArray(array_2);
                Console.WriteLine($"____Итог_____");
                MatrixMultiplication(array_1, array_2);
            // }
            
            Console.WriteLine($" \n__________");
            Console.WriteLine($"Доп. Задача 2:");

            int[,] array_3 = SeparateRandArray(3, 4, 100, 10000);
            PrintArray(array_3);

            SelectionNumbersInArray(array_3);

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

            int[,] RandArray(int max_rows, int max_columns, int start, int end)             // метод генерации массива целых чисел от 3 и более строк и от 3 и более столбцов     
            {
                Random random = new Random();
                int rows = random.Next(3,max_rows);
                int columns = random.Next(3,max_columns);

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

            
            void PrintArrayOnedimensional(int[] currentArray)                                            
            {
                for (int i = 0; i < currentArray.Length; i++)
                {
                    Console.Write($"{currentArray[i]} ");
                }
            }

            void OutputElementByPosition (double[,] currentArray, int row_id, int column_id) // метод вывода элента по позиции (номер строки и столбца)
            {
                int quantity_row = currentArray.GetLength(0);
                int quantity_column = currentArray.GetLength(1);
                
                if (row_id > quantity_row || column_id > quantity_column || row_id < 0 || column_id < 0) 
                    Console.WriteLine("Элемента с такой позицией нет");
                else Console.WriteLine($"Элемент с позицией ({row_id}, {column_id}): {currentArray[row_id, column_id]}");
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
            

            //___________________ методы для доп. задач___________________



            void MatrixMultiplication(int [,] matrix_1, int [,] matrix_2)                                 // метод среднего арифметического элементов столбца
            {
              
                int[,] result_matrix = new int[matrix_1.GetLength(0), matrix_2.GetLength(1)];

                if (matrix_1.GetLength(1) != matrix_2.GetLength(0))
                {
                    Console.WriteLine("Нельзя перемножить матрицы");
                }
                else
                {
                    for (int i = 0; i < matrix_1.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix_2.GetLength(1); j++)
                        {
                            for (int k = 0; k < matrix_2.GetLength(0); k++)
                            {
                                result_matrix[i, j] += matrix_1[i, k] * matrix_2[k, j];
                            }
                        }
                    }
                    PrintArray(result_matrix);
                }      
            }


            int[,] SeparateRandArray(int rows, int columns, int start, int end)             
            {
                Random random = new Random();
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

            void SelectionNumbersInArray (int[,] array)             
            {
                int[] new_array = new int[array.Length];
                int k = 0;

                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        //Console.WriteLine(SumDigitsNumberMoreMultiplications(array[i, j]));
                        if (SumDigitsNumberMoreMultiplications(array[i, j]) != 0) 
                        {
                            new_array[k] = array[i, j];
                            k++;
                        }
                    }                    
                }
                Array.Resize(ref new_array, k); // изменяем длину массива
                if (k > 0) PrintArrayOnedimensional(new_array);
                else Console.WriteLine("В полученном массиве нет чисел сумма которых больше их произведений");

                
            }

            int SumDigitsNumberMoreMultiplications (int number) 
            {
                int digit = 0;               
                int sum = 0;      
                int multiplicate = 1;
                int last_number = number;
                while (number > 0)
                {
                    digit = number%10;
                    sum += digit;         
                    multiplicate *= digit;
                    number /= 10;              
                }
                //Console.WriteLine(sum);
                //Console.WriteLine(multiplicate);
                if (sum > multiplicate) return last_number;
                else return 0;
            }
            
        }
    }
}
