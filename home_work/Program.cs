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
            
            int CorrectNamber() // Метод (функция) проверки вводимого числа 
            {
                int namber; // обьявляем переменную namber типа integer
                while (!int.TryParse(Console.ReadLine(), out namber)) // Вводим символы. Проверяем если введенно не число выполняем цикл. Если введено число передаем его в переменную namber
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число!");
                }
                return Convert.ToInt32(namber); // После выполнения метода(функции) возвращаем namber с типом integer
            }
            
            void MinOrMax (int namberOne, int namberTwo) // Метод(функция) определения минимального и максимального числа из двух введенных чисел 
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
            int namberOne = CorrectNamber(); // Объявляем переменную namberOne и присваиваем ей значение полученное из функии CorrectNamber
            Console.WriteLine("Введите второе число:");
            int namberTwo = CorrectNamber(); // Объявляем переменную namberTwo и присваиваем ей значение полученное из функии CorrectNamber
            
            MinOrMax(namberOne, namberTwo); // Выполняем метод(функцию) MinOrMax с атрибутами namberOne и namberTwo
        
            /*
            Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            2, 3, 7 -> 7
            44 5 78 -> 78
            22 3 9 -> 22
            */
            void MaxNamberOfThree (int namberOne, int namberTwo, int namberThree) // Метод (функция) который(ая) принимает на вход три числа и выдаёт максимальное из этих чисел.
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
            int namberA = CorrectNamber(); // Объявляем переменную namberOne и присваиваем ей значение полученное из функии CorrectNamber
            Console.WriteLine("Введите второе число:");
            int namberB = CorrectNamber(); // Объявляем переменную namberB и присваиваем ей значение полученное из функии CorrectNamber
            Console.WriteLine("Введите третье число:");
            int namberC = CorrectNamber(); // Объявляем переменную namberC и присваиваем ей значение полученное из функии CorrectNamber
            MaxNamberOfThree(namberA, namberB, namberC); // Выполняем метод (функцию) MaxNamberOfThree с атрибутами namberA, namberB, namberC
            
            /*
            Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            4 -> да
            -3 -> нет
            7 -> нет
            */
            void EvenOrOdd (int namber) // Метод (функция) которая на вход принимает число и выдаёт четное оно или нет.
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
            int youNamber = CorrectNamber();
            EvenOrOdd(youNamber);

            /*
            Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
            5 -> 2, 4
            8 -> 2, 4, 6, 8
            Ссылка на дополнительные задачи (их решать не обязательно):  
            */
            void AllEvenNumbersUpToN (int namber) // Метод (функция) который(ая) на вход принимает число, а на выходе показывает все чётные числа от 1 до полученного числа.
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
                                Console.Write($"{i} \n"); // выводим последнее четное число без запятой
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
            int namberD = CorrectNamber();
            AllEvenNumbersUpToN(namberD);

            //Семинар 1. Дополнительные задачи.

            /*
            Задача 1. Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран.
            N = 4 -> 1, 1, 1, 1
            N = 2 -> 1, 1
            */
            void PrintNamberUnits (int namber) // Метод (функция) вывода N единиц на экран
            {
                if (namber < 0)
                {
                    Console.WriteLine($"Введенное вами число {namber} отрицательное. \n");
                }
                else
                {
                    for (int i = 0; i < namber; i++)
                    {
                        if (i == namber-1) // Если значение счетчика i равно введенному числу - 1. (-1 потому что отсчет цикла начинается с 0) 
                        {
                            Console.Write("1 \n"); // выводим последнее четное число без запятой
                        }
                        else
                        {
                            Console.Write("1, "); // выводим все четные числа кроме последнего
                        }
                    }    
                }
            }
            Console.WriteLine("Введите целое положительное число:");
            int namberF = CorrectNamber();
            PrintNamberUnits(namberF);
            
            /*
            Задача 2. Даны два числа a, b, такие что a < b. Вывести на экран сколько раз число a поместиться в числе b.
            */
            void HowMuchNamberAInNamberB (int a, int b) // Метод (функция) определения сколько раз число a поместиться в числе b.
            {
                while(true) // объявляем бесконечный цикл который будет выполняться пока не будут введены корректные числа для а,b
                {
                    if (a < b && a > 0) // кроме проверки a меньше b проверяем с условием (И) чтобы а было полоительным, так как отрицательные числа не могут повторятся в положительных
                    { 
                        int result = b / a; // обьявляем переменную namber типа integer, чтобы при выводе было целое число без остатка
                        Console.WriteLine($"Число a поместится в число b {result} раз(а).");
                        break; // завершаем цикл 
                    }
                    else
                    {
                        Console.WriteLine("Введенные вами числа не соответствуют условиям задачи. Число а должно быть меньше b и должно быть положительным. Повторите ввод!");
                        Console.WriteLine("Введите число a:");
                        a = CorrectNamber();
                        Console.WriteLine("Введите число b:");
                        b = CorrectNamber();
                    }
                }
            }
            Console.WriteLine("Введите число a:");
            int namberG = CorrectNamber();
            Console.WriteLine("Введите число b:");
            int namberH = CorrectNamber();
            HowMuchNamberAInNamberB(namberG, namberH);
            
            //Задача 3. На ввод подаётся рост трёх спортсменов. Расположить их от большего к меньшему.
            void GrowthOfAthletes (int athletOne, int athletTwo, int athletThree)
            {
                int[] arrayAthletes = {athletOne, athletTwo, athletThree};
                int temp;
                while (true)
                {
                    if (arrayAthletes[0] > 0 && arrayAthletes[1] > 0 && arrayAthletes[2] > 0)
                    {
                        for (int i = 0; i < arrayAthletes.Length-1; i++)
                        {
                            for (int j = i + 1; j < arrayAthletes.Length; j++)
                            {
                                if (arrayAthletes[i] < arrayAthletes[j])
                                {
                                    temp = arrayAthletes[i];
                                    arrayAthletes[i] = arrayAthletes[j];
                                    arrayAthletes[j] = temp;
                                }
                            }
                        }
                        
                        for (int i = 0; i < arrayAthletes.Length; i++)
                        {
                            if (i == arrayAthletes.Length-1)
                            {
                                Console.Write($"{arrayAthletes[i]} \n");
                            }
                            else
                            {
                                Console.Write($"{arrayAthletes[i]}, ");
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введенные вами числа не соответствуют условиям задачи. Рост спортсмена не может быть отрицательным. Повторите ввод!");
                        Console.WriteLine("Введите рост первого спортсмена:");
                        arrayAthletes[0] = CorrectNamber();
                        Console.WriteLine("Введите рост второго спортсмена:");
                        arrayAthletes[1] = CorrectNamber();
                        Console.WriteLine("Введите рост третьего спортсмена:");
                        arrayAthletes[2] = CorrectNamber();                        
                    }
                }
            }
            Console.WriteLine("Введите рост первого спортсмена:");
            int growthAthletOne = CorrectNamber();
            Console.WriteLine("Введите рост второго спортсмена:");
            int growthAthletTwo = CorrectNamber();
            Console.WriteLine("Введите рост третьего спортсмена:");
            int growthAthletThree = CorrectNamber();
            GrowthOfAthletes (growthAthletOne, growthAthletTwo, growthAthletThree);
            /*
            Задача 4. Дано N секунд. Вывести время в формате часы:минуты:секунды. N = 72334 -> 20:5:34
            */
            void SecondsСalculator (int seconds)
            {
                int watch = seconds/3600;
                int restOfSeconds = seconds - watch*3600;
                int minutes = restOfSeconds/60;
                restOfSeconds = restOfSeconds - minutes*60;
                if (watch > 10)
                {
                    Console.Write($"{watch}:");
                }
                else
                {
                    Console.Write($"0{watch}:");
                }
                if (minutes > 10)
                {
                    Console.Write($"{minutes}:");
                }
                else
                {
                    Console.Write($"0{minutes}:");
                }
                
                if (restOfSeconds > 10)
                {
                    Console.Write($"{restOfSeconds}");
                }
                else
                {
                    Console.Write($"0{restOfSeconds}");
                }
            }
            Console.WriteLine("Введите количество секунд:");
            int numberOfSeconds = CorrectNamber();
            SecondsСalculator(numberOfSeconds);
        }
    }
}