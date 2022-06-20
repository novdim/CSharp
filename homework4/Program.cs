using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

        // Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
        // 3, 5 -> 243
        // 2, 4 -> 16

        Console.Write($" \n __________ \n");
        Console.Write($"Задача 25: \n");

        void Exponentiation(int numberA, int numberB)
        {
            int result = 1; // объявлем переменную (аккумулятор) в которую(ый) будем складывать результат возведения в степень, так как операция умножение значение делаем 1
            for(int i = 1; i <= numberB; i++) 
            {
                result *= numberA; // ленивый вариант result = result * numberA
            }
            Console.Write($"Число {numberA} в степени {numberB} = {result}");
            Console.Write($"\n Так же можно получить число {numberA} в степени {numberB} используя метод Math.Pow результат будет = {Convert.ToInt32(Math.Pow(numberA, numberB))}");
        }
        Console.Write($"Введите число А:");
        int inputNumberA = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите число B (степень в которую будем возводить число {inputNumberA}:");
        int inputNumberB = Convert.ToInt32(Console.ReadLine());
        
        Exponentiation(inputNumberA, inputNumberB);


        // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        // 452 -> 11
        // 82 -> 10
        // 9012 -> 12
        
        Console.Write($" \n __________ \n");
        Console.Write($"Задача 27: \n");

        Console.Write($"Введите число:");
        string inputNumber_V1 = Console.ReadLine();
        SumDigitsNumber(inputNumber_V1);


        Console.Write($"\n Версия 2 \n");
        Console.Write($"Введите число:");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        SumDigitsNumber_V2(inputNumber);
        
    
        
        void SumDigitsNumber(string number) // метод который принимает на вход строку(число) и выдаёт сумму цифр в числе
        { 
            int sum = 0; // аккумулятор складываемых цифр
 
            for (int i = 0; i < number.Length; i++) 
            {
                sum += Convert.ToInt32(number.Substring(i, 1)); // извлекаем 1 элемент строки методом Substring, преобразуем его в число и прибавляем к аккумулятору 
            }
            Console.WriteLine(sum);
        }


        void SumDigitsNumber_V2(int number)
        {
            int sum = 0; // аккумулятор складываемых цифр
            while (number > 0) // пока введеное число > 0 
            {
                sum += number % 10; // берем остаток деления на 10 и складываем в аккумулятор
                number /= 10; // делим число на 10 до тех пор пока делится на 10 (с каждой итерацией будет убираться последний символ)
            }
            Console.WriteLine(sum);

        }


        // Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
        // -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
        // 6, 1, -33 -> [1, 6, -33]
 
        }
    }
}