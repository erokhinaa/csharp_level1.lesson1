using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1 // ЕРОХИН АЛЕКСАНДР АНДРЕЕВИЧ. Факультет Разработки VR&AR

{
    class Program
    {
        static double GetMPow(int x1, int y1, int x2, int y2)
        {
            double mpow = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));                          
            return mpow;
        }
        static void PrintDataInConsole(string data, int x, int y)
        {
            Console.WindowWidth = x;
            Console.WindowHeight = y;
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine(data);
        }
        static void Main(string[] args)
        {
            
        #region 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
                //   а) используя склеивание;
                //   б) используя форматированный вывод;
                //   в) используя вывод со знаком $.

            Console.WriteLine("Вас приветствует программа \'Анкета\'");
            Console.WriteLine();
            Console.Write("Введите свое имя: "); string name = Console.ReadLine();
            Console.Write("Введите свою фамилию: "); string surname = Console.ReadLine();
            Console.Write("Введите свой возраст: "); string age = Console.ReadLine();
            Console.Write("Введите свой рост: "); string height = Console.ReadLine();
            Console.Write("Введите свой вес: "); string weight = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Привет, " + name + " " + surname + ". Твой возраст:" + age + ", рост:" + height + ", вес:" + weight);
            Console.WriteLine("Привет, {0} {1}. Твой возраст:{2}, рост:{3}, вес:{4}", name, surname, age, height, weight);
            Console.WriteLine($"Привет, {name} {surname}. Твой возраст:{age}, рост:{height}, вес:{weight}");
            Console.ReadKey();
        #endregion

            Console.Clear();

        #region 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
            Console.WriteLine("Вас приветствует программа расчета ИМТ");
            Console.WriteLine();
            Console.Write("Введите свой вес (кг): "); int w = int.Parse(Console.ReadLine());
            Console.Write("Введите свой рост (см): "); double h = double.Parse(Console.ReadLine()) / 100;
            Console.WriteLine();
            Console.WriteLine($"Индекс массы тела = {w / (h * h):f2}");
            Console.ReadKey();
        #endregion

            Console.Clear();

        #region а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
                //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            Console.WriteLine("Вас приветствует программа подсчета расстояния между точками");
            Console.WriteLine();
            Console.Write("Введите x1: "); int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите y1: "); int y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите x2: "); int x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите y2: "); int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"MPOW = {GetMPow(x1, y1, x2, y2):f2}");
            Console.ReadKey();

        #endregion

            Console.Clear();

        #region 4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
                //а) с использованием третьей переменной;
                //б) *без использования третьей переменной.
            Console.WriteLine("Вас приветствует программа обмена значений переменных");
            Console.WriteLine();
            Console.Write("Введите значение 1: "); string var1 = Console.ReadLine();
            Console.Write("Введите значение 2: "); string var2 = Console.ReadLine();
            string var3 = var1;
            var1 = var2;
            var2 = var3;
            Console.WriteLine($"Значение 1 = {var1}, Значение 2 = {var2}");
            Console.Write("Введите значение 1: "); int ivar1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение 2: "); int ivar2 = int.Parse(Console.ReadLine());
            ivar1 += ivar2;
            ivar2 = ivar1 - ivar2;
            ivar1 -= ivar2; 
            Console.WriteLine($"Значение 1 = {ivar1}, Значение 2 = {ivar2}");
            Console.ReadKey();

        #endregion
            
            Console.Clear();

        #region а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
                //б) Сделать задание, только вывод организовать в центре экрана.
                //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

            Console.WriteLine("Ваши данные будут выведены в центре экрана");
            Console.WriteLine();
            Console.Write("Введите свое имя: "); string sname = Console.ReadLine();
            Console.Write("Введите свою фамилию: "); string ssurname = Console.ReadLine();
            Console.Write("Введите ваш родной город: "); string stown = Console.ReadLine();
            string data = $"{sname} {ssurname} из города {stown}";
            PrintDataInConsole(data, 100, 60);            
            Console.ReadKey();

        #endregion

        }
    }
}
