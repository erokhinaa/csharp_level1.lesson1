using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5
{
    public static class Message
    {
        public static string GetWordsFromMessage(string str, int num)
        {
            str = str + " ";
            string words = "";
            int calc = 0;
            int len = 1;
            int i = 0;
            foreach (char c in str)
            {
                if (c == ' ') len++;
            }

            string[] strOut = new string[len];

            foreach (char c in str)
            {
                if (c == ' ')
                {
                    if (calc <= num)
                    {
                        words = words + strOut[i] + " ";
                    }
                    i++;
                    calc = 0;
                }
                else { strOut[i] = strOut[i] + c; calc++; }
            }

            return words;
        }
        
        public static StringBuilder DeleteWordsFromMessage(StringBuilder str, char sym)
        {
            string _str = str.ToString();
            string[] strOut;
            char s = ' ';
            int len = 1;
            int i = 0;

            foreach (char c in _str)
            {
                if (c == ' ') len++;
            }

            strOut = new string[len];
            StringBuilder sb = new StringBuilder();
            foreach (char c in _str)
            {
                if (c == ' ')
                {
                    strOut[i] = strOut[i] + " ";
                    i++;                    
                }
                else 
                    strOut[i] = strOut[i] + c;
            }
            i = 0;
            _str = _str + " ";
            foreach (char c in _str)
            {
                if (c == ' ')
                {
                    if (s == sym)
                    {
                        sb.Append(strOut[i]); i++;
                    }
                    else i++;
                }
                s = c;
            }
            return sb;
        }

        public static string GetMaxWordFromString(string str)
        {
            string[] strOut;
            string max = "";
            int len = 1;
            int i = 0;
            
            foreach (char c in str)
            {
                if (c == ' ') len++;
            }

            strOut = new string[len];

            foreach (char c in str)
            {
                if (c == ' ')
                {
                    strOut[i] = strOut[i] + " ";
                    i++;
                }
                else
                    strOut[i] = strOut[i] + c;
            }

            max = strOut[0];

            for (int c = 0; c < strOut.Length; c++)
            {
                if (max.Length <= strOut[c].Length) max = strOut[c] ;
            }

            return max;
        }
    }    
        class Program
    {
        public static bool LoginCheck(StringBuilder login)
        {
            string strNum = "0123456789";
            string strNumSym = "0123456789qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            bool check = false;
            int count = 0;

            if (login.Length == 1) { check = false; return false; }
            else
            {
                foreach (char c in strNum)
                    if (c == login[0]) { check = false; return check; }

                for (int i = 1; i < login.Length; i++)
                {
                    foreach (char c in strNumSym)
                        if (c == login[i])
                        {
                            check = true;
                            count++;
                            break;
                        }
                        else check = false;
                }
            }
            if (count == login.Length-1) check = true; 
            else check = false;
            return check;
        }

        public static bool LoginCheckRegex(string login)
        {
            bool check = false;
            Regex reg = new Regex("^[a-zA-z]{1,1}[a-zA-Z0-9]{2,10}$");
            if (reg.IsMatch(login)) check = true;
            else check = false;
            return check;
        }

        public static bool CheckStrings(string str1, string str2)
        {
            bool check = false;
            int s = 0;
            str1 = str1.ToLower();
            str2 = str2.ToLower();

            if (str1.Length != str2.Length) check = false;
            else
            {
                foreach (char str in str1)
                {
                    for (int i = 0; i < str2.Length; i++)
                    {
                        if (str == str2[i]) s++;
                    }
                }
        
                if (s == str2.Length) check = true;
                else check = false;
            }

            return check;
        }

        static void Main(string[] args)
        {

            #region 1.Создать программу, которая будет проверять корректность ввода логина. 
            //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            //а) без использования регулярных выражений;
            //б) **с использованием регулярных выражений.
            bool check = false;
            Console.WriteLine("*** Программа проверки корректности логина ***");
            Console.Write("Придумайте логин "); StringBuilder login = new StringBuilder(Console.ReadLine());
            check = LoginCheck(login);
            if (check) Console.WriteLine("Вы можете использовать данный логин");
            else Console.WriteLine("Логин не соответствует требованиям политики безопасности");
            
            bool check2 = false;
            Console.Write("Придумайте логин "); string loginR = Console.ReadLine();
            check2 = LoginCheckRegex(loginR);
            if (check2) Console.WriteLine("Вы можете использовать данный логин");
            else Console.WriteLine("Логин не соответствует требованиям политики безопасности");
            Console.ReadKey();

            #endregion

            Console.Clear();

            #region 2.Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            //а) Вывести только те слова сообщения, которые содержат не более n букв.
            //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            //в) Найти самое длинное слово сообщения.
            //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            //д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
            Console.WriteLine("*** Вас приветсвтует программа обработки текста***");
            Console.WriteLine("Выводим слова, в которых не более n букв");
            Console.WriteLine(Message.GetWordsFromMessage("привет как твои дела",4));
            Console.ReadKey();

            StringBuilder str = new StringBuilder("привет как твои дела привет");
            Console.WriteLine("Выводим слова, которые заканчиваются на заданный символ");
            Console.WriteLine(Message.DeleteWordsFromMessage(str, 'т'));
            Console.ReadKey();

            Console.WriteLine("Выводим самое длинное слово");
            Console.WriteLine(Message.GetMaxWordFromString("привет как дела"));
            Console.ReadKey();

            #endregion

            Console.Clear();

            #region 3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            Console.WriteLine("*** Программа определения строки как перестановку другой ***");
            Console.Write("Введите строку 1 "); string s1 = Console.ReadLine();
            Console.Write("Введите строку 2 "); string s2 = Console.ReadLine();
            bool checkString = CheckStrings(s1,s2);
            if (checkString) Console.WriteLine("Перестановка строк = true");
            else Console.WriteLine("Перестановка строк = false");
            
            #endregion

            Console.ReadKey();

        }
    }
}
