using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 41: Пользователь вводит с клавиатуры M чисел. 
            // Посчитайте, сколько чисел больше 0 ввёл пользователь.

            // Console.WriteLine($"__________");
            // Console.WriteLine($"Задача 41:");

            // Console.WriteLine("Введите число");
            // int quantity_number = 3;
            // CountingNumbersMoreZero(quantity_number);


            // Console.WriteLine($"(версия 2):");
            // Console.WriteLine("Введите несколько чисел. Чтобы остановить ввод чисел введите q");
            // CountingNumbersMoreZeroVersion2();
            
            // Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
            // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
            
            // Console.WriteLine($"__________");
            // Console.WriteLine($"Задача 43:");

            // SearchPointIntersectionLines();

            

            // Задача 1. Написать перевод десятичного числа в двоичное, используя рекурсию.
           
           
            // Console.WriteLine($"__________");
            // Console.WriteLine($"Доп. Задача 1:");
            // Console.WriteLine("Введите число:");
            // int input_number = Convert.ToInt32(Console.ReadLine());
            
            // Console.WriteLine($"Введенное число {input_number} в двоичной системе счисления {DecimalToBinaryNumber(input_number)} ");


            string proverb = "Без труда не выловишь и рыбку из пруда";
            Console.WriteLine($"В тексте \"{proverb}\" \n {CalculationVowelLetters(proverb,0)} - гласных.");
            Console.WriteLine($"Версия без рекурсии.");
            CalculationVowelLettersVersionWithoutRecursion(proverb);

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



            
        }
    }
}
