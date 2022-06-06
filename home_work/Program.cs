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
        
        /*
        Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        2, 3, 7 -> 7
        44 5 78 -> 78
        22 3 9 -> 22
        */
        void maxNamberOfThree (int namberOne, int namberTwo, int namberThree)
        {
            if (namberOne > namberTwo)
            {
                if (namberOne > namberThree)
                {
                    Console.WriteLine($"max = {namberOne}");
                }
                else
                {
                    Console.WriteLine($"max = {namberThree}");
                }
            }
            else if (namberOne == namberTwo && namberOne == namberThree)
            {
                Console.WriteLine("Введенные числа равны. Max - нет.");
            }
            else
            {
                if (namberTwo > namberThree)
                {
                    Console.WriteLine($"max = {namberTwo}");
                }
                else
                {
                    Console.WriteLine($"max = {namberThree}");
                }
            }
        }
        Console.WriteLine("Введите первое число:");
        int namberA = correctNamber();
        Console.WriteLine("Введите второе число:");
        int namberB = correctNamber();
        Console.WriteLine("Введите третье число:");
        int namberC = correctNamber();
        maxNamberOfThree(namberA, namberB, namberC);

        /*
        Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        4 -> да
        -3 -> нет
        7 -> нет
        */
        void evenOrOdd (int namber)
        {

            if (namber%2 == 0)
            {
                Console.WriteLine($"Да. Введенное вами число {namber} - четное");
            }
            else
            {
                Console.WriteLine($"Нет. Введенное вами число {namber} - нечетное");
            }
        }
        Console.WriteLine("Введите число:");
        int youNamber = correctNamber();
        evenOrOdd(youNamber);
        /*
        Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
        5 -> 2, 4
        8 -> 2, 4, 6, 8
        Ссылка на дополнительные задачи (их решать не обязательно):  
        */
        void allEvenNumbersUpToN (int namber)
        {
            if (namber == 1)
            {
                Console.Write($"Введенное вами число {namber}. Целых четных чисел от 1 до {namber} нет.");
            }
            else if (namber < 0)
            {
                Console.Write($"Введенное вами число {namber} отрицательное.");
            }
            else
            {
                for (int i = 1; i <= namber; i++)
                {
                    if (i%2 == 0)
                    {
                        if (i == namber || i == namber-1 )
                        {
                            Console.Write($"{i} ");
                        }
                        else
                        {
                            Console.Write($"{i}, ");
                        }
                    }
                }
            }
        }
        Console.WriteLine("Введите целое положительное число:");
        int namberD = correctNamber();
        allEvenNumbersUpToN(namberD);
        }          
    }
}
