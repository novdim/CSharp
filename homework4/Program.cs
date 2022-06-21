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

            Console.Write($"\n__________\n");
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
            
            Console.Write($"\n__________\n");
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


            void SumDigitsNumber_V2(int number) // метод который принимает на вход число и выдаёт сумму цифр в числе (математическим способом)
            {
                int sum = 0; // аккумулятор складываемых цифр
                while (number > 0) // пока введеное число > 0 
                {
                    sum += number % 10; // берем остаток деления на 10 и складываем в аккумулятор sum = sum + number % 10
                    number /= 10; // делим число на 10 до тех пор пока делится на 10 (с каждой итерацией будет убираться последний символ) number = number / 10
                }
                Console.WriteLine(sum);
            }


            // Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
            // -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
            // 6, 1, -33 -> [1, 6, -33]
    
            Console.Write($"\n__________\n");
            Console.Write($"Задача 29: \n");

            int lenArray = 8;
            int startRange  = -100;
            int endRange = 100;
            

            int[] oldArray = RandArray(lenArray, startRange, endRange); // генерируем массив и складываем его в oldArray
            PrintArray(oldArray); // печатаем сгенерированный массив

            Console.WriteLine();
        
            PrintArray(BubbleSortArrayModule(oldArray)); // печатаем массив полученный в результате сортировки(BubbleSortArrayModule) массива oldArray

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

            int[] BubbleSortArrayModule (int[] array) // метод сортировки массива пузырьком по модулю 
            {
                int max;
                for (int i = 0; i < array.Length; i++) 
                {
                    for(int j = i + 1; j < array.Length; j++)
                    {
                        if(Math.Abs(array[i]) > Math.Abs(array[j])) // сравниваем значения по модулю, а ниже меняем их реальные значения
                        {
                            max = array[i];
                            array[i] = array[j];
                            array[j] = max;
                        }
                    }
                }
                return array;
            }

            void PrintArray(int[] array) // метод печати массива
            {
                int lastSymbol = array.Length - 1;
                for (int i = 0; i < array.Length; i++) 
                {
                    Console.Write($"{array[i]}, ");
                }
                Console.Write("\b \b\b \b"); // удаляем последнюю запятую и пробел массива 
            }

            // Семинар 4. Дополнительные задачи.

            // Задача 1. На вход подаётся натуральное десятичное число. 
            // Проверьте, является ли оно палиндромом в двоичной записи.

            Console.Write($"\n__________\n");
            Console.Write($"Доп. Задача 1: \n");
            
            Console.Write($"Введите число:");
            int originalNamber = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Введенное число {originalNamber} в двоичной системе: {DecimalToBinary(originalNamber)} {PalindromeCheck(DecimalToBinary(originalNamber))}");

            string DecimalToBinary(int number) // метод перевода из 10 в 2 с выводом результата в виде строки
            {
                return Convert.ToString(number, 2);
            }

            
            string PalindromeCheck (string number) // метод проверки палиндромома
            {
                char[] chars = number.ToCharArray(); // извлекаем символы из строки в массив

                Array.Reverse(chars); // переворачиваем массив используя встроенный метод Reverse
                string newText = new string(chars); // присваиваем newText перевернутый массив
                
                if (newText == number) // сравниваем строки
                {
                    return $"палиндромом \n";
                }
                else
                {
                    return $"не палиндромом \n";
                }          
            }

            // Задача 2. Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц. 
            // Размер массива должен совпадать с квадратом количества единиц в нём.

            Console.Write($"\n__________\n");
            Console.Write($"Доп. Задача 2: \n");

            for(int i = 0; i < 10; i++) // так как длина массива сильно зависит от первого элемента выполняем 10 вызов метода
            {
                PrintArray(RandArrayWithoutLength());
                Console.WriteLine();
            }
            
            int[] RandArrayWithoutLength () // метод генирации массива на отрезке [0,2)
            {
                Random randomA = new Random();
                int[] array = new int[100]; // создем массив с максимальным кол-вом элеметов 100
                int sum = 0; // аккумулятор для суммы полученных 1
                int countElements = 0; // аккумулятор для подсчета количества элементов массива
                for (int i = 0; i < 100; i++) 
                {
                    array[i] = randomA.Next(0,2);
                    sum += array[i];
                    countElements++;
                    if (sum*sum == countElements) // если квадрат сложенных 1 равен полученной длинне в аккумуляторе countElements останавливаем наполнение массива
                    {
                        break;
                    }
                    if (sum > 10) // если сумма единиц больше 10, то оставшуся часть массива заполняем 0, так как квадрат от 11 больше 100 
                    {
                        array[i] = 0;
                    }
                }

                Array.Resize(ref array, countElements); // изменяем длину массива с 100 на полученну в аккумуляторе countElements
                Console.Write($"Длина массива - {array.Length} \n"); // выводим длину полученного массива
                return array;
            }

  

            // Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99. 
            // Определите самый часто встречающийся элемент в массиве. Если таких элементов несколько, вывести их все.


        }
    }
}