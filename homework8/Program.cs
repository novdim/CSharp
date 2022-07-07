using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 54: Задайте двумерный массив. 
            // Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

            Console.WriteLine($"\n__________");
            Console.WriteLine($"Задача 54:");

            int[,] array_ex54 = RandArray(3, 3, 5, 5, -9, 10);
            
            PrintArray(array_ex54);
            Console.WriteLine($"__________");
            PrintArray(SortingLines(array_ex54));


            // Задача 56: Задайте прямоугольный двумерный массив. 
            // Напишите программу, которая будет находить строку с наименьшей суммой элементов.

            Console.WriteLine($"\n__________");
            Console.WriteLine($"Задача 56:");


            int[,] array_ex56 = RandArray(4, 3, 4, 3, -9, 10);
            PrintArray(array_ex56);
            SearchRowMaxSumElement(array_ex56);

            
            // Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.

            Console.WriteLine($"\n__________");
            Console.WriteLine($"Задача 58:");
            
            // PrintArray(SpiralArray(2,2));
            // PrintArray(SpiralArray(3,3));
            PrintArray(SpiralArray(4,4));
            // PrintArray(SpiralArray(5,5));




            // Семинар 8.
            // Дополнительные задачи.

            // Задача 1. Дан двумерный массив. Заменить в нём элементы первой строки элементами главной диагонали. А элементы последней строки, элементами побочной диагонали.

            //  1   2   3   4                1   6  11 15
            //  5   6   7   8     =>       5   6   7  8 
            // 9  10 11 12                9  10 11 12
            // 12 13 14 15              12 10  7  4

            // Задача 2. Дан двумерный массив, заполненный случайными числами от -9 до 9. Подсчитать частоту вхождения каждого числа в массив, используя словарь.
            // Справка:
            // https://docs.microsoft.com/ru-ru/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0

            // Задача 3. Найти минимальный по модулю элемент. Все столбцы и строки, содержащие элементы, равные по модулю минимальному.

            // Задача 4. Заполните двумерный массив 3х3 числами от 1 до 9 змейкой.

            // 1  6  7
            // 2  5  8
            // 3  4  9


            // __________МЕТОДЫ____________

            int[,] RandArray(int min_rows, int min_columns, int max_rows, int max_columns, int start, int end)             // метод генерации массива целых чисел от 3 и более строк и от 3 и более столбцов     
            {
                Random random = new Random();
                int rows = random.Next(min_rows,max_rows);
                int columns = random.Next(min_columns,max_columns);

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

            int[,] SortingLines (int[,] array)             // метод сортировки строк     
            {
                int max = array[0,0];

                
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = j + 1; k < array.GetLength(1); k++)
                        {
                            if(array[i,j] < array[i,k])
                            {
                                max = array[i,j];
                                array[i,j] = array[i,k];
                                array[i,k] = max;
                            }
                            else continue;
                        }
                    }                    
                }
                return array;
            }

            void SearchRowMaxSumElement (int[,] array) // метод поиска строки с максимальной суммой элементов
            {
                int[] sum = new int [array.GetLength(0)];
                int min = sum[0];
                int min_row_id = 0;

                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum[i] += array[i,j];
                    }                  
                }

                for(int i = 1; i < sum.Length; i++)
                {
                    if (sum[i] < min)
                    {
                        min = sum[i];
                        min_row_id = i;
                    }
                }
                Console.WriteLine($"Строка с id - {min_row_id} имеет наименьшую сумму {min}");
                Console.WriteLine($"Счет строк начинается с 0");
            }

            
            // метод генерации массива [4,4] с цифрами от 1 до 16 в виде спирали (так же работает работает (с параметрами [2,2], [3,3], [5,5]))         
            int[,] SpiralArray (int row = 4, int column = 4)            
            {
                int[,] array = new int[row,column];
                int sum = 0;                                            // накопитель                                    
                int top = 0;                                            // строка старта (верх)
                int right = array.GetLength(1)-1;                       // правая сторона
                int bottom = array.GetLength(0)-1;                      // строка с низу
                int left = 0;                                           // левая сторона
                int start = 1;                                          // переменная с 1 чтобы счет начался не с 0
                
                int shift = 0;                                          // переменная сдвига начинаем с 0 по проходу круга убавляем на 1
                
                while(sum < (row*column)+1)                             
                {
                    for (int j = shift; j <= right-shift; j++)          // право 
                    {
                        array[top, j] = sum+start;                      // для 1 ячейки задаем 1 через start
                        sum++;
                    }
                    
                    for (int i = shift; i <= right; i++)                //  низ
                    {
                        array[i, right] = sum;
                        sum++;
                    }

                    for (int j = right-1; j > shift-1; j--)             // лево 
                    {
                        array[bottom, j] = sum;
                        sum++;
                    }
                    for (int i = bottom-1; i > left; i--)               //  верх
                    {
                        array[i, left] = sum;
                        sum++;
                    }
                    start = 0;                                          // обнуляем старт больше он не понадобится
                    shift++;                                            // увеличиваем сдвиг

                    top++;
                    left++;

                    right--;                                            
                    bottom--;                                           

                }
                return array;
            }
            


        }
    }
}