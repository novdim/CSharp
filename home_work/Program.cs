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
            
            int correctNamber() //Функция проверки вводимого числа 
            {
                int namber; // обьявляем переменную namber типа integer
                while (!int.TryParse(Console.ReadLine(), out namber)) // Вводим символы. Проверяем если введенно не число выполняем цикл. Если введено число передаем его в переменную namber
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
                return Convert.ToInt32(namber); // После выполнения функции возвращаем namber с типом integer
            }
            
            void minOrMax (int namberOne, int namberTwo) //Функция определения минимального и максимального числа из двух введенных чисел 
            {
                if (namberOne > namberTwo) // Если первое число больше второго
                {
                    Console.WriteLine($"max = {namberOne}"); 
                    Console.WriteLine($"min = {namberTwo}");               
                }
                else if (namberOne == namberTwo) // Если первое число равно второму
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
            int namberOne = correctNamber(); // Объявляем переменную namberOne и присваиваем ей значение полученное из функии correctNamber
            Console.WriteLine("Введите второе число:");
            int namberTwo = correctNamber(); // Объявляем переменную namberTwo и присваиваем ей значение полученное из функии correctNamber
            
            minOrMax(namberOne, namberTwo); // Выполняем функцию minOrMax с атрибутами namberOne и namberTwo
        
            /*
            Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            2, 3, 7 -> 7
            44 5 78 -> 78
            22 3 9 -> 22
            */
            void maxNamberOfThree (int namberOne, int namberTwo, int namberThree) // Функция которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            {
                if (namberOne > namberTwo) // Если первое число больше второго
                {
                    if (namberOne > namberThree) //Если первое число больше третьего
                    {
                        Console.WriteLine($"max = {namberOne}");
                    }
                    else //Если первое число меньше или равно третьему. 
                    {
                        Console.WriteLine($"max = {namberThree}"); // В случае если 1 и 3 числа равны будем брать за максимум значение числа 3, так как они оба будут по отношению ко 2 числу максимальными. При условии что 3 число больше выводим его на экран. 
                    }
                }
                else if (namberOne == namberTwo && namberOne == namberThree) // Если все числа равны
                {
                    Console.WriteLine("Введенные числа равны. Max - нет.");
                }
                else //Если первое число меньше или равно второму. 
                {
                    if (namberTwo > namberThree) // Если второе число больше третьего
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
            int namberA = correctNamber(); // Объявляем переменную namberOne и присваиваем ей значение полученное из функии correctNamber
            Console.WriteLine("Введите второе число:");
            int namberB = correctNamber(); // Объявляем переменную namberB и присваиваем ей значение полученное из функии correctNamber
            Console.WriteLine("Введите третье число:");
            int namberC = correctNamber(); // Объявляем переменную namberC и присваиваем ей значение полученное из функии correctNamber
            maxNamberOfThree(namberA, namberB, namberC); // Выполняем функцию maxNamberOfThree с атрибутами namberA, namberB, namberC
            
            /*
            Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            4 -> да
            -3 -> нет
            7 -> нет
            */
            void evenOrOdd (int namber) // Функция которая на вход принимает число и выдаёт четное оно или нет.
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
            void allEvenNumbersUpToN (int namber) // Функция которая на вход принимает число, а на выходе показывает все чётные числа от 1 до полученного числа.
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
                            if (i == namber || i == namber-1 ) // Если значение счетчика i равно введенному числу (для четного введенного числа) или равно введенному числу - 1 (для нечетного введенного числа)
                            {
                                Console.Write($"{i} "); // выводим последнее четное число без запятой
                            }
                            else
                            {
                                Console.Write($"{i}, "); // выводим все четные числа кроме последнего
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