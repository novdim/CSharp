using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 41: Пользователь вводит с клавиатуры M чисел. 
            // Посчитайте, сколько чисел больше 0 ввёл пользователь.

            Console.WriteLine($"__________");
            Console.WriteLine($"Задача 41:");

            Console.WriteLine("Введите число");
            int quantity_number = 3;
            CountingNumbersMoreZero(quantity_number);


            Console.WriteLine($"(версия 2):");
            Console.WriteLine("Введите несколько чисел. Чтобы остановить ввод чисел введите q");
            CountingNumbersMoreZeroVersion2();
            
            // Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
            // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
            
            Console.WriteLine($"__________");
            Console.WriteLine($"Задача 43:");

            SearchPointIntersectionLines();

            

            // Задача 1. Написать перевод десятичного числа в двоичное, используя рекурсию.
           
           
            Console.WriteLine($"__________");
            Console.WriteLine($"Доп. Задача 1:");
            Console.WriteLine("Введите число:");
            int input_number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Введенное число {input_number} в двоичной системе счисления {DecimalToBinaryNumber(input_number)} ");

            // Задача 2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. 
            // Используя рекурсию, подсчитайте, сколько в поговорке гласных букв.

            Console.WriteLine($"__________");
            Console.WriteLine($"Доп. Задача 2:");

            string proverb = "Без труда не выловишь и рыбку из пруда";
            Console.WriteLine($"В тексте \"{proverb}\" \n {CalculationVowelLetters(proverb,0)} - гласных.");
            Console.WriteLine($"Версия без рекурсии.");
            CalculationVowelLettersVersionWithoutRecursion(proverb);


            // Задача 3. Дано число N. Используя только операцию деления и рекурсию, 
            // определите, что оно является степенью числа 3.

           Console.WriteLine($"__________");
           Console.WriteLine($"Доп. Задача 3:");

            Console.WriteLine("Введите число:");
             double number_ex3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DegreeNumber(number_ex3,3)); // вместо 3 можно выбрать любое другое число возводимое в степень

            Console.WriteLine($"__________");
            Console.WriteLine($"Доп. Задача 1*:");
            Console.WriteLine();
            PrintArray(NowTime());

            // Методы
            

            void CountingNumbersMoreZero (int quantity)
            {
                int count = 0;
                int number = 0;
                for(int i = 0; i < quantity; i++)
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if(number > 0) count++;
                }
                Console.WriteLine($"Вы ввели {count} числа(-ел, -о) больше 0.");
            }

            void CountingNumbersMoreZeroVersion2 ()
            {
                int count = 0;
                string number = string.Empty;
                int last_number = 0;

                while(true)
                {
                    number = Console.ReadLine();
                    if(number == "q") break;
                    else last_number = Convert.ToInt32(number);
                    if(last_number > 0) count++;
                }
                Console.WriteLine($"Вы ввели {count} числа(-ел, -о) больше 0.");
            }

            void SearchPointIntersectionLines ()
            {
                double coordinate_x = 0, coordinate_y = 0, k1 = 0, k2 = 0, b1 = 0, b2 = 0;

                while(true)
                {
                    Console.WriteLine($" Введите k1 для уровнения y = k1 * x + b1");
                    k1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($" Введите b1 для уровнения y = k1 * x + b1");
                    b1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($" Введите k2 для уровнения y = k2 * x + b2;");
                    k2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($" Введите b2 для уровнения y = k2 * x + b2;");
                    b2 = Convert.ToInt32(Console.ReadLine());

                    if (k1 == k2 && b1 != b2)
                    {
                        Console.WriteLine($"При таких показателях линии не будут переcекаться. Они будут параллельными. Повторите ввод!"); 
                        continue;
                    }
                    else if (k1 == k2 && b1 == b2)
                    {
                        Console.WriteLine($"При таких показателях линии не будут переcекаться. Они совпадают. Повторите ввод!"); 
                        continue;
                    }
                    else
                    {
                        coordinate_x = (b2-b1)/(k1-k2);
                        coordinate_y = k1 * coordinate_x + b1;
                        Console.WriteLine($"Координаты точки пересечения(x,y) = ({coordinate_x}, {coordinate_y})");
                        break;
                    }
                }

            }

            // ________________ Методы для доп. задач ______________

            string DecimalToBinaryNumber(int number)
            {
                if(number == 0) return "";
                else return DecimalToBinaryNumber(number / 2) + (number % 2).ToString();
            }

            
            int CalculationVowelLetters(string text, int count)
            {
                string str = "аоэеиыуёюяАОЭЕИЫУЁЮЯ";
                int index = str.IndexOf(text[count]);
                if (index < 0) 
                {
                    if (count < text.Length - 1) return CalculationVowelLetters(text, count+1);
                    else return 0;
                }
                else
                {
                    if (count < text.Length - 1) return CalculationVowelLetters(text, count+1) + 1;
                    else return 1; 
                }
                // краткий вариант вывода
                // return (index < 0 ? 0 : 1) + (count < text.Length - 1 ? CalculationVowelLetters(text, count + 1) : 0);
            }


            void CalculationVowelLettersVersionWithoutRecursion(string text)
            {
                char[] vowels = new char[20] { 'а', 'о', 'и', 'е','ё','э','ы','у','ю','я','А','О','И','Е','Ё','Э','Ы','У','Ю','Я'};
                int count_vowels = 0;
                for(int i = 0; i < text.Length; i++)
                {
                    for(int j = 0; j < vowels.Length; j++)
                    {
                        if (text[i] == vowels[j]) count_vowels++;
                    }
                }
                Console.WriteLine($"В тексте: \"{text}\" \n {count_vowels} - гласных.");
            }

            string DegreeNumber (double number, int raise_number)
            {
                if (number == 1) return $"Да. Введенное число является степенью {raise_number}";
                else if (number > 1 && number < raise_number) return $"Нет. Введенное число не является степенью {raise_number}";
                else return DegreeNumber(number/raise_number, raise_number);
            }

            int[,] NowTime()
            {
                DateTime date1 = DateTime.Now;
                string time = date1.ToShortTimeString();
                int ten_сlock = Convert.ToInt32(time[0])-48;
                int сlock = Convert.ToInt32(time[1])-48;
                int ten_minutes = Convert.ToInt32(time[3])-48;
                int minutes = Convert.ToInt32(time[4])-48;
                
                int[,] number_0 = {{0,1,1,1,0},{1,0,0,0,1},{1,0,0,0,1},{1,0,0,0,1},{1,0,0,0,1},{1,0,0,0,1},{0,1,1,1,0}};
                int[,] number_1 = {{0,0,1,0,0},{0,1,1,0,0},{1,0,1,0,0},{0,0,1,0,0},{0,0,1,0,0},{0,0,1,0,0},{1,1,1,1,1}};
                int[,] number_2 = {{0,1,1,1,0},{1,0,0,0,1},{1,0,0,1,0},{0,0,1,0,0},{0,1,0,0,0},{1,0,0,0,0},{1,1,1,1,1}};
                int[,] number_3 = {{0,1,1,1,0},{1,0,0,0,1},{1,0,0,0,1},{0,0,1,1,0},{0,0,0,0,1},{1,0,0,0,1},{0,1,1,1,0}};
                int[,] number_4 = {{1,0,0,0,1},{1,0,0,0,1},{1,0,0,0,1},{1,1,1,1,1},{0,0,0,0,1},{0,0,0,0,1},{0,0,0,0,1}};
                int[,] number_5 = {{1,1,1,1,1},{1,0,0,0,0},{1,0,0,0,0},{0,1,1,1,0},{0,0,0,0,1},{1,0,0,0,1},{0,1,1,1,0}};
                int[,] number_6 = {{0,1,1,1,0},{1,0,0,0,1},{1,0,0,0,0},{1,1,1,1,0},{1,0,0,0,1},{1,0,0,0,1},{0,1,1,1,0}};
                int[,] number_7 = {{1,1,1,1,1},{0,0,0,0,1},{0,0,0,0,1},{0,0,0,1,0},{0,0,1,0,0},{0,1,0,0,0},{1,0,0,0,0}};
                int[,] number_8 = {{0,1,1,1,0},{1,0,0,0,1},{1,0,0,0,1},{0,1,1,1,0},{1,0,0,0,1},{1,0,0,0,1},{0,1,1,1,0}};
                int[,] number_9 = {{0,1,1,1,0},{1,0,0,0,1},{1,0,0,0,1},{0,1,1,1,1},{0,0,0,0,1},{1,0,0,0,1},{0,1,1,1,0}};

                int[][,] all_number = {number_0, number_1, number_2, number_3, number_4, number_5, number_6, number_7, number_8, number_9};

                int[,] time_array ={{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},{0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}};
                
                for (int i = 0; i < time_array.GetLength(0); i++)
                {
                    for (int j = 0; j < time_array.GetLength(1); j++)
                    {
                        if(j < 5) 
                        {
                            time_array[i, j] = all_number[ten_сlock][i, j];
                            time_array[i, j+6] = all_number[сlock][i, j];
                            time_array[i, j+16] = all_number[ten_minutes][i, j];
                            time_array[i, j+22] = all_number[minutes][i, j];
                        }
                    }
                }

                return time_array;
            }

            void PrintArray(int[,] currentArray)                                            // метод печати массива целых чисел
            {
                for (int i = 0; i < currentArray.GetLength(0); i++)
                {
                    for (int j = 0; j < currentArray.GetLength(1); j++)
                    {
                        if (currentArray[i, j] == 0) Console.Write(" ");
                        if (currentArray[i, j] == 1) Console.Write("@");
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}
