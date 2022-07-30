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

            // **Примеры**:

            // ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

            // ["1234", "1567", "-2", "computer science"] -> ["-2"]

            // ["Russia", "Denmark", "Kazan"] -> []

            string[] array = new string[] {"hello", "2", "world", ":-)"};
            
            
            PrintArray(SortingArray(array));

            void PrintArray(string[] currentArray)                                            
            {
                for (int i = 0; i < currentArray.Length; i++)
                {
                    Console.Write($"{currentArray[i]}, ");
                }
            }

            string[] SortingArray (string[] array)            
            {
                int count = 0;
                int id = 0;
                int length_array = array.Length;
                
                for (int i = 0; i < length_array; i++)
                {
                    if (array[i].Length <= 3)
                    {
                        count++;
                    }
                }

                string[] new_array = new string[count];

                for (int i = 0; i < length_array; i++)
                {
                    if (array[i].Length <= 3) 
                    {
                        new_array[id] = array[i];
                        if (id < count-1) id++;
                    }
                }

                return new_array;
            }


        }
    }
}