using System;
using System.Text.RegularExpressions; // подключаю "библиотеку" регулярных выражений

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


        /*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        14212 -> нет
        23432 -> да
        12821 -> да
        */
            bool IsAlphaNumeric(string input) // метод проверки введенных данных 
            {
                return Regex.IsMatch(input, "^[a-zA-Z0-9]+$"); // возврат результата в формате (true, false) проверки наличия (букв и цифр) регулярным выражением
            }

            Console.Write("Введите слово (число) из 5 и более букв или цифр.\n");
            string inputText = Console.ReadLine();  
            bool lettersOrNumbers = IsAlphaNumeric(inputText);

            void PalindromeCheck(string text) // метод проверки палиндромома на введенные 5 и более букв или цифр
            {
                text = text.ToLower(); // делаем все символы маленькими (для случая если часть букв введены верхним регистром )
                char[] chars = text.ToCharArray(); // извлекаем символы из строки в массив
                while(true)
                {
                    if (chars.Length < 5 || lettersOrNumbers == false)  // проверяем на количество букв(цифр) и на то чтобы не было других символов 
                    {
                        Console.Write("Введите слово (число) из 5 и более букв или цифр.\n");
                        text = Console.ReadLine();
                        text = text.ToLower();
                        chars = text.ToCharArray();
                        lettersOrNumbers = IsAlphaNumeric(text);
                    }
                    else
                    {
                        char[] charText = new char[text.Length];
                        int ctr = chars.Length-1; // в ctr склаываем длинну массива - 1, чтобы начать с последнего элемента 
                        
                        for (int j = 0; j < chars.Length; j++) // по символьно складываем значения из конца массива chars в начало массива charText
                        {
                            charText[j] = chars[ctr];
                            ctr--;
                        }

                        string oldText = new string(chars); // изначально введенная строка
                        string newText = new string(charText); // полученная строка
                        

                        if (newText == oldText) // сравниваем строки
                        {
                            Console.Write($"Да. {newText} - палиндромом \n");
                        }
                        else
                        {
                            Console.Write($"Нет. {newText} - не палиндромом \n");
                        }
                    break;
                    }
                }                
            }

            PalindromeCheck(inputText);

            Console.Write("Проверим 2 версию определителя палиндромома. \n");
            Console.Write("Введите слово (число) из 5 и более букв или цифр.\n");
            string inputText_V2 = Console.ReadLine();  
            bool lettersOrNumbers_V2 = IsAlphaNumeric(inputText);

            void PalindromeCheck_V2 (string text) // метод проверки палиндромома на введенные 5 и более букв или цифр (версия 2) 
            {
                text = text.ToLower(); // делаем все символы маленькими (для случая если часть букв введены верхним регистром )
                char[] chars = text.ToCharArray(); // извлекаем символы из строки в массив

                while(true)
                {
                    if (chars.Length < 5 || lettersOrNumbers_V2 == false)  // проверяем на количество букв(цифр) и на то чтобы не было других символов 
                    {
                        Console.Write("Введите слово (число) из 5 и более букв или цифр.\n");
                        text = Console.ReadLine();
                        text = text.ToLower();
                        chars = text.ToCharArray();
                        lettersOrNumbers = IsAlphaNumeric(text);
                    }
                    else
                    {
                        Array.Reverse(chars); // переворачиваем массив используя встроенный метод Reverse
                        string newText = new string(chars); // присваиваем newText перевернутый массив
                        
                        if (newText == text) // сравниваем строки
                        {
                            Console.Write($"Да. {newText} - палиндромом \n");
                        }
                        else
                        {
                            Console.Write($"Нет. {newText} - не палиндромом \n");
                        }
                    break;
                    }
                }                
            }

            PalindromeCheck_V2(inputText_V2);

        /*
        Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        A (3,6,8); B (2,1,-7), -> 15.84
        A (7,-5, 0); B (1,-1,9) -> 11.53
        */

        double CorrectNamber() // Метод (функция) проверки вводимого числа 
        {
            double namber; // обьявляем переменную namber типа double
            while (!double.TryParse(Console.ReadLine(), out namber)) // Вводим символы. Проверяем если введенно не число выполняем цикл. Если введено число передаем его в переменную namber
            {
                Console.WriteLine("Ошибка ввода! Введите число!");
            }
            return Convert.ToDouble(namber); // После выполнения метода(функции) возвращаем namber с типом double
        }


        void DistancePoints3dSpace (double[] pointOne, double[] pointTwo) //метод определения расстояния меду точками в 3D пространстве
        {
            double sumDifferences = 0;  
            for (int i = 0; i <= 2;  i++) // циклом проходимя по массивам pointOne, pointTwo чтобы получить сумму разностей точек в квадрате 
            {
                sumDifferences = sumDifferences + Convert.ToDouble(Math.Pow((pointOne[i] - pointTwo[i]), 2)); // методом Pow возводим во 2 степень полученные разницы
            }
            Console.WriteLine($"{Math.Sqrt(sumDifferences)} "); // выводим корень уже полученной суммы
            
        }
        Console.WriteLine("Введите кординату X точки A");
        double cordinateAx = CorrectNamber();
        Console.WriteLine("Введите кординату Y точки A");
        double cordinateAy = CorrectNamber();
        Console.WriteLine("Введите кординату Z точки A");
        double cordinateAz = CorrectNamber();
        Console.WriteLine("Введите кординату X точки B");
        double cordinateBx = CorrectNamber();
        Console.WriteLine("Введите кординату Y точки B");
        double cordinateBy = CorrectNamber();
        Console.WriteLine("Введите кординату Z точки B");
        double cordinateBz = CorrectNamber();

        double[] pointA = {cordinateAx, cordinateAy, cordinateAz};
        double[] pointB = {cordinateBx, cordinateBy, cordinateBz};
    
        DistancePoints3dSpace(pointA, pointB);


        /*
        Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        3 -> 1, 8, 27.
        5 -> 1, 8, 27, 64, 125
        */

        void СubeTableForGivenNumbers (int number) //метод вывода кубов чисел от 1 до N.
        {
            int sumDifferences = 0;  
            for (int i = 1; i <= number;  i++) // циклом проходимя по массивам pointOne, pointTwo чтобы получить сумму разностей точек в квадрате 
            {
                if (i != number) // чтобы последнее число выводилось без запятой проверяем дошел ли цикл до последнего элемента
                {
                    Console.Write($"{Convert.ToInt32(Math.Pow(i, 3))}, "); // методом Pow возводим во 3 степень
                }
                else
                {
                    Console.Write($"{Convert.ToInt32(Math.Pow(i, 3))}"); // методом Pow возводим во 3 степень
                }
            }
            
        }
        Console.WriteLine("Введите число:");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        СubeTableForGivenNumbers(inputNumber);
        }
    }
}