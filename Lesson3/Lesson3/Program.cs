using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3 // ЕРОХИН АЛЕКСАНДР АНДРЕЕВИЧ. Факультет Разработки VR&AR
{
    public struct Complex
    {
        // Действительная часть комплексного числа
        public double re;
        // Мнимая часть комплексного числа
        public double im;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im; 

            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;

            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y;
            y.re = re * x.re;
            y.im = im * x.im;

            return y;
        }
        public Complex Div(Complex x)
        {
            Complex y;
            y.re = re / x.re;
            y.im = im / x.im;

            return y;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
            //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.
            bool work = false;
            int menu = 0;
            int wh = Console.WindowHeight;
            int ww = Console.WindowWidth;
            do
            {
                Console.WriteLine("*** Вас приветсвует программа работы с комплексными числами ***");
                Console.WriteLine("1) Настройки экрана");
                Console.WriteLine("2) Работа с комплексными числами");
                while (menu != 1 && menu != 2)
                {
                    Console.Write("Введите 1 или 2: "); menu = int.Parse(Console.ReadLine());
                }

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Установить размер экрана в 2 раза меньше? (1 - Да / 2 - Нет) "); int s1 = int.Parse(Console.ReadLine());
                        if (s1 == 1)
                        {
                            Console.WindowHeight = Console.WindowHeight / 2;
                            Console.WindowWidth  = Console.WindowWidth  / 2;
                        }
                        Console.Write("Установить синий цвет фона для текста? (1 - Да / 2 - Нет) ");    int s2 = int.Parse(Console.ReadLine());
                        if (s2 == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        Console.Write("Сбросить настройки по умолчанию? (1 - Да / 2 - Нет) "); int s3 = int.Parse(Console.ReadLine());
                        if (s3 == 1)
                        {
                            Console.WindowHeight = wh;
                            Console.WindowWidth  = ww;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.Clear();
                        work = true;
                        menu = 0;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Работа с комплексными числами");
                        Complex complex01 = new Complex();
                        Complex complex02 = new Complex();
                        Console.Write("Введите действительную: "); complex01.re = double.Parse(Console.ReadLine());
                        Console.Write("Введите мнимую часть: "); complex02.im = double.Parse(Console.ReadLine());
                        Console.WriteLine("Что выхотите сделать с числами?");
                        Console.WriteLine("Plus  - сложение");
                        Console.WriteLine("Minus - вычетание");
                        Console.WriteLine("Multi - умножение");
                        Console.WriteLine("Div   - деление");
                        Console.Write("Введите команду: "); string ComplexAction = Console.ReadLine();
                        ComplexAction.ToLower();
                        switch (ComplexAction)
                        {
                            case "plus":
                                Console.WriteLine($"{complex01} + {complex02} = {complex01.Plus(complex02)}");
                                break;
                            case "minus":
                                Console.WriteLine($"{complex01} - {complex02} = {complex01.Minus(complex02)}");
                                break;
                            case "multi":
                                Console.WriteLine($"{complex01} * {complex02} = {complex01.Multi(complex02)}");
                                break;
                            case "div":
                                Console.WriteLine($"{complex01} / {complex02} = {complex01.Div(complex02)}");
                                break;
                            default:
                                break;
                        }
                        work = false;
                        break;

                    default:
                        break;
                }
            } 
            while (work == true);

            Console.ReadKey();

            #endregion

            Console.Clear();

            #region 2. а) С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
            Console.WriteLine("*** Вас приветсвует программа подсчета суммы нечетных положительных чисел ***");
            bool tryInt;
            int n;
            int summ = 0;
            do
            {
                Console.Write("Введите число: "); string s = Console.ReadLine();
                tryInt = Int32.TryParse(s, out n);
                if (tryInt == false) n = -1;
                if (n % 2 != 0 & n > 0)
                {
                    summ += n;
                }
            } while (n != 0);
            
            Console.WriteLine($"Сумма нечетных положительных чисел = {summ}");
            Console.ReadKey();

            #endregion

        }
    }
}
