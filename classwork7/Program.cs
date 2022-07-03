using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"__________");
            Console.WriteLine($"Задача :");

            int[,] array_1 = RandArray(5, 5, -9, 10);
            int[,] array_2 = RandArray(5, 5, -9, 10);
            Console.WriteLine($"____1____");
            PrintArray(array_1);
            Console.WriteLine($"____2____");
            PrintArray(array_2);
            Console.WriteLine($"____Итог_____");
            MatrixMultiplication(array_1, array_2);

            //Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

            Console.WriteLine($"__________");
            Console.WriteLine($"Задача 63:");

            Console.WriteLine($"Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            PrintNumbersRecursion(number);


            // Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


            Console.WriteLine($"\n__________");
            Console.WriteLine($"Задача 65:");

            Console.WriteLine($"Введите число M");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите число N");
            int numberN = Convert.ToInt32(Console.ReadLine());

            Recursion(numberM, numberN);
            

            // Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
            // 453 -> 12
            // 45 -> 9

            Console.WriteLine($"__________");
            Console.WriteLine($"Задача 67:");


            Console.WriteLine($"Введите число");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма цифр числа {number1} - {Recursion67(number1)}");

            // Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

            // методы    

            
            void PrintNumbersRecursion(int current_number, int count = 1)
           {
               if (count > current_number) return;
               Console.Write(count);
               PrintNumbersRecursion(current_number, count+1);
               
           }
           
           void Recursion(int current_numberM, int current_numberN)
           {
               if (current_numberM > current_numberN) return;
               Console.Write(current_numberM);
               Recursion(current_numberM, current_numberM+1);
           }  
           
           int Recursion67(int current_number, int sum = 0)
           {
               if (current_number  == 0) 
               {
                   return sum;
               }
               sum += current_number%10;
               return Recursion67(current_number/10, sum);
               
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
