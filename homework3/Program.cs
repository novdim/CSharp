using System;
using System.Text.RegularExpressions;

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
            bool IsAlphaNumeric(string input)
            {
                return Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
            }
            
            string inputText = Console.ReadLine();
            bool lettersOrNumbers = IsAlphaNumeric(inputText);
            Console.Write(lettersOrNumbers);
            void PalindromeCheck(string text)
            {
                text = text.ToLower();
                char[] chars = text.ToCharArray();
                while(true)
                {
                    if (chars.Length < 5 || lettersOrNumbers == false)
                    {
                        Console.Write("Введите слово (число) из 5 и более символов.");
                        text = Console.ReadLine();
                        text = text.ToLower();
                        chars = text.ToCharArray();
                        lettersOrNumbers = IsAlphaNumeric(text);
                    }
                    else
                    {
                        char[] charText = new char[text.Length];
                        int ctr = chars.Length-1;
                        
                        for (int j = 0; j < chars.Length; j++)
                        {
                            charText[j] = chars[ctr];
                            ctr--;
                        }
                        string a = new string(charText); 
                        string b = new string(chars);

                        if (a == b)
                        {
                            Console.Write("Да");
                        }
                        else
                        {
                            Console.Write("Нет");
                        }
                    break;
                    }
                }



                
            }
            
            PalindromeCheck(inputText);

        /*
        Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        A (3,6,8); B (2,1,-7), -> 15.84
        A (7,-5, 0); B (1,-1,9) -> 11.53
        */
        /*
        Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        3 -> 1, 8, 27.
        5 -> 1, 8, 27, 64, 125
        */


        }
    }
}