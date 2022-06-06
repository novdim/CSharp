using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
        Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
        a = 5; b = 7 -> max = 7, min = 5
        a = 2 b = 10 -> max = 10, min = 2
        a = -9 b = -3 -> max = -3, min = -9
        */  
        
            int correctNamber()
            {
                int namber;
                while (!int.TryParse(Console.ReadLine(), out namber))
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
                return Convert.ToInt32(namber);
            }
           
            void minOrMax (int namberOne, int namberTwo)
            {
                if (namberOne > namberTwo)
                {
                    Console.WriteLine($"max = {namberOne}");
                    Console.WriteLine($"min = {namberTwo}");               
                }
                else if (namberOne == namberTwo)
                {
                    Console.WriteLine("Введенные числа равны. min, max - нет.");
                }
                else
                {
                    Console.WriteLine($"max = {namberTwo}");
                    Console.WriteLine($"min = {namberOne}");
                }
            }

            Console.WriteLine("Введите первое число:");
            int namberOne = correctNamber();
            Console.WriteLine("Введите второе число:");
            int namberTwo = correctNamber();
            
            minOrMax(namberOne, namberTwo);
        
        
        }          
    }
}
