using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int size_rows = 4;
            int size_colum = 3;
            int start = 1;
            int end = 10;

            int[,] new_Array = RandFillArray(size_rows, size_colum, start, end);
            PrintArray(new_Array);

            int[,] RandFillArray (int rows, int columns, int start, int end)
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
            
            void PrintArray(int[,] currentArray)
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
            
            // Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n.
            // Выведите полученный массив на экран.


            Console.WriteLine();
            Console.WriteLine("____________");
            Console.WriteLine("Задача 48: ");
            int[,] new_array_1 = FillArray(size_rows, size_colum, start, end);
            PrintArray(new_array_1);


            int[,] FillArray (int rows, int columns, int start, int end)
            {
                Random random = new Random();
                int[,] array = new int[rows,columns];
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i ,j] = i + j;
                    }                    
                }
                return array;
            }

            // Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

        }
    }
}
