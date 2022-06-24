using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

        // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
        // Напишите программу, которая покажет количество чётных чисел в массиве.

            Console.Write($"\n__________\n");
            Console.Write($"Задача 34: \n");

            int lenArray = 10;
            int startRange  = 100;
            int endRange = 1000;

            int[] newArray = RandArray(lenArray, startRange, endRange);
            PrintArray(newArray);
            СountEvenNumbersInArray(newArray);


            int[] RandArray (int len, int start, int end) // метод генирации массива, заданной длинны len на заданном отрезке start, end
            {
                Random randomA = new Random();
                int[] array = new int[len];
                for (int i = 0; i < len; i++) 
                {
                    array[i] = randomA.Next(start,end);
                }
                return array;
            }

            void СountEvenNumbersInArray (int[] array) //метод подсчета четных чисел в массиве
            {
                int cout = 0;
                for (int i = 0; i < array.Length; i++) 
                {
                    if (array[i]%2 == 0) cout += 1;
                }
                Console.Write($"\n Четных чисел в массиве - {cout}.");
            }

            void PrintArray(int[] array) // метод печати массива
            {
                for (int i = 0; i < array.Length; i++) 
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.Write("\b \b\b \b"); // удаляем последнюю запятую и пробел массива 
            }
        
        
        // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
        // Найдите сумму элементов, стоящих на нечётных позициях.
        
        Console.Write($"\n__________\n");
        Console.Write($"Задача 36: \n");

        int lenArray2 = 7;
        int startRange2  = 1;
        int endRange2 = 100;

        int[] arrayTwo = RandArray(lenArray2, startRange2, endRange2); // метод RandArray ранее использовался в задаче 34 с другими входными параметрами
        PrintArray(arrayTwo);
        SumNonEvenNumbers(arrayTwo);
        SumNumbersForNonEvenPositionInArray(arrayTwo);

        void SumNonEvenNumbers (int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i]%2 != 0) sum += array[i];
            }
            Console.Write($"\n Сумма не четных чисел в массиве - {sum}. \n");

        }

        void SumNumbersForNonEvenPositionInArray (int[] array) // метод расчета суммы чисел массива находящихся на не четных позициях (с учетом того что позиции массива начинаются с 0)
        {
            int sum = 0;
            int i = 1;
            while (i < array.Length) 
            {
                sum += array[i];
                i += 2;
            }
            Console.Write($"\n Сумма чисел на нечетных позициях в массиве - {sum}. \n");
        }
    
        // Задача 38: Задайте массив вещественных чисел. 
        // Найдите разницу между максимальным и минимальным элементов массива.

        Console.Write($"\n__________\n");
        Console.Write($"Задача 38: \n");

        
        double[] arrayThree = {3, 7, -2.2, 2, 78};

        PrintArray_double(arrayThree);
        DifferenceMaxMinNumberInArray(arrayThree);    

        void PrintArray_double(double[] array) // метод печати массива
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.Write($"{array[i]}, ");
            }
            Console.Write("\b \b\b \b"); // удаляем последнюю запятую и пробел массива 
        }

        void DifferenceMaxMinNumberInArray(double[] array)
        {
            double min, max;

            if (array[0] > array[1])
            {
                max = array[0];
                min = array[1];
            }
            else
            {
                max = array[1];
                min = array[0];
            }

            for(int i = 2; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.Write($"\n Разница максимального и минимального элемента: {max} - ({min}) = {max-min}");
        }


        
        // Семинар 5.
        // Дополнительные задачи.

        // Задача 1. Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число. 
        // Напишите программу, которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.
        // {0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
        // {4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> нет
        
            Console.Write($"\n__________\n");
            Console.Write($"Доп. Задача 1: \n");        

            int lenArray1 = 15;
            int startRange1  = 1;
            int endRange1 = 10;

            int[] newArray1 = RandArray(lenArray1, startRange1, endRange1);
            PrintArray(newArray1);

            Console.Write("\n Введите натуральное число состоящее из 3 и более цифр: \n");

            string input =  Console.ReadLine();
            SearchSequence(newArray1, input);

            void SearchSequence (int[] array, string number)
            {
                while(true)
                {
                    int inputLength = number.Length;
                    if (inputLength < 3) 
                    {
                        Console.Write("\n Введите натуральное число состоящее из 3 и более цифр: \n");
                        number = Console.ReadLine();
                    }
                    else
                    {
                        int naturalNumber = Convert.ToInt32(number);
                        int[] numberArray = new int[inputLength];
                        int i = numberArray.Length - 1;
                        while (naturalNumber > 0) // пока введеное число > 0 
                        {
                            numberArray[i] = naturalNumber % 10; // берем остаток деления на 10 и складываем в массив с конца
                            naturalNumber /= 10; // делим число на 10 до тех пор пока делится на 10 (с каждой итерацией будет убираться последний символ) naturalNumber = naturalNumber / 10
                            i--;
                        }

                        int j = 0;

                        for (int b = 0; b < array.Length; b++)
                        {
                            if (array[b] == numberArray[0]) //найдено первое совпадение
                            {
                                j = 0;
                                while (b + j < array.Length && array[b+j] == numberArray[j])
                                {
                                    j++;
                                    if (j == numberArray.Length)
                                    {
                                        Console.Write($"{number} - Да. В этом массиве есть такая последовательность. \n"); 
                                        return;
                                    }
                                }
                            }
                            if (b == array.Length-1) Console.Write($"{number} - Нет. В этом массиве нет такой последовательности. \n");
                        }
                        break;
                    }
                }
                
            }
            
        // Задача 2. На вход подаются два числа случайной длины. Найдите произведение каждого разряда первого числа на каждый разряд второго. Ответ запишите в массив.
        // 24, 132 -> {2, 6, 4, 4, 12, 8}

        Console.Write($"\n__________\n");
        Console.Write($"Доп. Задача 2: \n");

        Console.Write("\n Введите натуральное число: \n");
        int[] numberArray1 = NumberInArray(Console.ReadLine());
        Console.Write("\n Введите натуральное число: \n");
        int[] numberArray2 = NumberInArray(Console.ReadLine());

        
        PrintArray(ProductEachDigitFirstSecondNumbers (numberArray1, numberArray2));

        int[] NumberInArray (string number) // метод перевода числа в массив
        {
            int naturalNumber = Convert.ToInt32(number);
            int sizeArray = number.Length; 
            int[] numberArray = new int[sizeArray];
            int i = numberArray.Length - 1;
            while (naturalNumber > 0) // пока введеное число > 0 
            {
                numberArray[i] = naturalNumber % 10; // берем остаток деления на 10 и складываем в массив с конца
                naturalNumber /= 10; // делим число на 10 до тех пор пока делится на 10 (с каждой итерацией будет убираться последний символ) naturalNumber = naturalNumber / 10
                i--;
            }
            return numberArray;
        }

        int[] ProductEachDigitFirstSecondNumbers(int[] numberArray1, int[] numberArray2)
        {
            int[] lastArray = new int[numberArray1.Length*numberArray2.Length];
            int k = 0;
            while (k < lastArray.Length)
            {
                for (int i = 0; i < numberArray1.Length; i++)
                {
                    for (int j = 0; j < numberArray2.Length; j++)
                    {
                        lastArray[k] = numberArray1[i]*numberArray2[j];
                        k++;
                    }
                }
            }
            return lastArray;
        }

        // Задача 3. Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений. Подсчитайте их количество.
        
        Console.Write($"\n__________\n");
        Console.Write($"Доп. Задача 3: \n");


        string lastNumber = Console.ReadLine();

        CountSumMultiplicationDigitsNumber(lastNumber);

        // Метод расчета суммы и умножения цифр чисел от 1 до введенного значения. 
        // И определения количества числел сумма цифр которых в три раза меньше их произведений.

        void CountSumMultiplicationDigitsNumber(string number) 
        {
            int numberInt = Convert.ToInt32(number);
            int j = 0;
            int sum = 0;                                    // аккумулятор суммирования цифр числа
            double multiplicate = 1;                        // аккумулятор умножения цифр числа (берем тип double, так как в дальнейшем будем делить на 3) 
            int digit = 0;                                  // переменная в которую будем складывать цифру числа
            int count = 0;                                  // аккумулятор в котором будет храниться количетво чисел которые будут удволетворять требованиям
            for (int i = 1; i < numberInt; i++)
            {
                j += i;                                     // переходим от одного числа до другого
                sum = 0;                                    // обнуляем аккумулятор
                multiplicate = 1;                           // обнуляем аккумулятор
                while (j > 0)
                {
                    digit = j%10;
                    sum += digit;                            // берем остаток деления на 10 и складываем в аккумулятор sum = sum + digit % 10
                    multiplicate *= digit;                   // берем остаток деления на 10 и складываем в аккумулятор multiplicate = multiplicate * multiplicate % 10
                    j /= 10;                                 // делим число на 10 до тех пор пока делится на 10 (с каждой итерацией будет убираться последний символ)
                }
                if (sum < multiplicate/3)                    // условия рачета
                {
                    count++;
                }
            }
            Console.Write(count);

        }

        // Задача 1*. Дан массив массивов, состоящих из натуральных чисел, размер которого 5. 
        // Для каждого элемента-массива определить найти сумму его элементов и вывести массив с наибольшей суммой. 
        // Если таких массивов несколько, вывести массив с наименьшим индексом.

        }
    }
}