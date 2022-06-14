using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int CorrectNamber() // Метод (функция) проверки вводимого числа 
            {
                int namber; // обьявляем переменную namber типа integer
                while (!int.TryParse(Console.ReadLine(), out namber)) // Вводим символы. Проверяем если введенно не число выполняем цикл. Если введено число передаем его в переменную namber
                {
                    Console.WriteLine("Ошибка ввода! Введите число!");
                }
                return Convert.ToInt32(namber); // После выполнения метода(функции) возвращаем namber с типом integer
            }

            /*
                Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
                645 -> 5
                78 -> третьей цифры нет
                32679 -> 6
            */

            void OutputThirdDigitNumber (int number) // Метод вывода третьей цифры введенного числа
            {
                int numberModulo = Math.Abs(number); // для того чтобы вывод работал для отрицательных чисел присваиваем numberModulo его значение по модулю
                if (numberModulo < 100)
                {
                    Console.WriteLine($"В введенном числе {number} третьей цифры нет.");
                }
                else
                {
                    Console.WriteLine($"Третья цифра введенного числа: {numberModulo.ToString()[2]}"); // Преобразуем numberModulo в строку и выведем 3 элемент 
                }
            }
            
            Console.WriteLine("Введите число");
            int thirdDigit = CorrectNamber(); // Объявляем переменную thirdDigit и присваиваем ей значение полученное из функии CorrectNamber
            OutputThirdDigitNumber(thirdDigit);

            /*
                Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
                6 -> да
                7 -> да
                1 -> нет
            */

            void WeekdaysOrWeekends (int number) // Метод который принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
            {
                int dayWeek = number - 7*(number/7);
                /* добавляем возможность определния дня недели если введено число больше 7.
                    Присваеваем dayWeek разницу между введенным числом и количетсвом дней для полных недель.
                 */
                while(true) // создаем бескоечный цикл, который завершится когда пользователь введет число больше 0
                {
                    if (number > 0) // проверяем чтобы введенное число было больше 0
                    {
                        if (dayWeek == 6 || dayWeek == 7 || dayWeek == 0) 
                        /*
                         Проверяем если полученное значение разницы равно 6 или 7 значит введенная цифра выходной. Проверка на 0 нужна для случая, если пользователь введет цифру кратную 7. 
                        */
                        {
                            Console.WriteLine("Да. Введенная цифра выходной день");
                        }
                        else
                        {
                            Console.WriteLine("Нет. Введенная цифра будний день");
                        }
                    break;
                    }
                    else
                    {
                        Console.WriteLine("Введенное число меньше или равно 0. ");
                    }
                    Console.WriteLine("Введите число");
                    number = CorrectNamber();
                }
            }
            
            Console.WriteLine("Введите число");
            int numberDayWeek = CorrectNamber(); // Объявляем переменную numberB и присваиваем ей значение полученное из функии CorrectNamber
            WeekdaysOrWeekends(numberDayWeek);


            /*
                Семинар 2.
                Дополнительные задачи.
            */

            /*
                Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.
            */
            void DefinitionIsoscelesTriangle (int sideA, int sideB, int sideC)
            {
                while(true)
                {
                    if (sideA > 0 && sideB > 0 && sideC > 0)
                    {
                        if (sideA < sideB+sideC && sideB < sideA+sideC && sideC < sideA+sideB)
                            {
                                if(sideA == sideB || sideA == sideC || sideB == sideC)
                            {
                                Console.WriteLine($"Треугольник со сторонами A:{sideA}, B:{sideB}, C:{sideC}. Равнобедренный.");   
                            }
                            else
                            {
                                Console.WriteLine($"Треугольник со сторонами A:{sideA}, B:{sideB}, C:{sideC}. Не равнобедренный.");
                            }
                        break;
                        }
                        else
                        {
                            Console.WriteLine($"Треугольника со сторонами A:{sideA}, B:{sideB}, C:{sideC} не существует. Треугольник существует только тогда, когда сумма любых двух его сторон больше третьей. Повторите ввод!!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Введенные значения сторон a,b,c меньше или равны 0. Повторите ввод!!!");
                    }
                    Console.WriteLine("Введите длину стороны AB");
                    sideA = CorrectNamber();
                    Console.WriteLine("Введите длину стороны BC");
                    sideB = CorrectNamber();
                    Console.WriteLine("Введите длину стороны CA");
                    sideC = CorrectNamber();
                }
            }
          
            Console.WriteLine("Введите длину стороны AB");
            int sideAB = CorrectNamber();
            Console.WriteLine("Введите длину стороны BC");
            int sideBC = CorrectNamber();
            Console.WriteLine("Введите длину стороны CA");
            int sideCA = CorrectNamber();
            DefinitionIsoscelesTriangle(sideAB, sideBC, sideCA);

            /*
                Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.
            */

            /*
                Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. 
                Определить размер депозита через n месяцев.
            */

            /*
                Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная
            */








        }
    }
}