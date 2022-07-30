using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
            // Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
            // При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

            string[] array = new string[] {"1234", "1567", "-2", "computer science"};
            
            
            PrintArray(SortingArray(array));

            void PrintArray(string[] currentArray)                                            
            {
                for (int i = 0; i < currentArray.Length; i++)
                {
                    Console.Write($"{currentArray[i]} ");
                }
            }

            string[] SortingArray (string[] array)            
            {
                int count = 0;
                int length_array = array.Length;
                
                for (int i = 0; i < length_array; i++)
                {
                    if (array[i].Length <= 3)
                    {
                        count++;
                    }
                }

                int[] id_elements = new int[count];
                int id = 0;

                for (int i = 0; i < length_array; i++)
                {

                    if (array[i].Length <= 3)
                    {
                        id_elements[id] = i;
                        id++;
                    }
                }

                string[] new_array = new string[count];

                for (int i = 0; i < count; i++)
                {
                        new_array[i] = array[id_elements[i]];
                }

                return new_array;

                
            }


        }
    }
}