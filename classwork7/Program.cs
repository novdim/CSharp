using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array_1 = RandArray(5, 5, -9, 10);
            int[,] array_2 = RandArray(5, 5, -9, 10);
            Console.WriteLine($"____1____");
            PrintArray(array_1);
            Console.WriteLine($"____2____");
            PrintArray(array_2);
            Console.WriteLine($"____Итог_____");
            MatrixMultiplication(array_1, array_2);
            
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


        }
    }
}
