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
            Console.WriteLine($"Вы ввели {count} числа(-ел) больше 0.");
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
            Console.WriteLine($"Вы ввели {count} чисел(а) больше 0.");
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
                    Console.WriteLine($"При таких показателях линии не будут переcекаться. Они сопадают. Повторите ввод!"); 
                    continue;
                }
                else
                {
                    coordinate_x = (b2-b1)/(k1-k2);
                    coordinate_y = k1 * coordinate_x + b1;
                    Console.WriteLine($"Координаты точки пересечения(x,y) = ({coordinate_x},{coordinate_y})");
                    break;
                }
            }

        }
        }
    }
}
