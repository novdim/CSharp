using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int size_rows = 2;
            int size_colum = 22;
            int start = 1;
            int end = 10;
            int[,] new_Array = RandFillArray(size_rows, size_colum, start, end);
            PrintArray(new_Array);


            // Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n.
            // Выведите полученный массив на экран.

            Console.WriteLine("____________");
            Console.WriteLine("Задача 48: ");
            FillArray48(new_Array);

            // Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

            Console.WriteLine("____________");
            Console.WriteLine("Задача 49: ");

            FillArray49(new_Array);

            //Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

            Console.WriteLine("____________");
            Console.WriteLine("Задача 51: ");

            FillArray51(new_Array);

            // Дан двумерный массив из двух строк и двадцати двух столбцов. 
            // В его первой строке записано количество мячей, забитых футбольной командой в той или иной игре, во второй — количество пропущенных мячей в этой же игре.
            а) Для  каждой  проведенной  игры  напечатать  словесный  результат:  "выигрыш", "ничья" или "проигрыш". 
            б) Определить количество выигрышей данной команды. 
            в) Определить  количество  выигрышей  и  количество  проигрышей  данной   команды. 
            г) Определить количество выигрышей, количество ничьих и количество проигрышей данной команды. 
            д) Определить,  в  скольких  играх  разность  забитых  и  пропущенных  мячей  была большей или равной трем. 
            е) Определить общее число очков, набранных командой (за выигрыш даются 3 очка, за ничью — 1, за проигрыш — 0).





            // методы
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
            
            void FillArray48 (int [,] array)
            {
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i ,j] = i + j;
                    }                    
                }
                PrintArray(array);
            }

            void FillArray49 (int [,] array)
            {
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (i%2 == 0 && j%2 == 0) array[i,j] = array[i,j]*array[i,j];
                    }                    
                }
                PrintArray(array);

            }

            void FillArray51 (int [,] array)
            {
                int sum = 0;
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (i == j) sum = sum + array[i,j];
                    }                    
                }
                Console.WriteLine($"Сумма элементов, находящихся на главной диагонали {sum}");
            }


            
        }
    }
}
