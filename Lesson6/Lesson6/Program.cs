using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6 // ЕРОХИН АЛЕКСАНДР АНДРЕЕВИЧ. Факультет Разработки VR&AR
{

    delegate double DoDelegate(double a, double x);
    delegate double FDelegate(double x);

    class Program
    {

        public static double GetMultiPow(double a, double x) 
        {
            Console.Write($"{a} * {x}^2 = ");
            return a * Math.Pow(x,2);
        }

        public static double GetMultiSin(double a, double x)
        {
            Console.Write($"{a} * Sin({x}) = ");
            return a * Math.Sin(x);
        }

        public static void Process(DoDelegate dodelegate, double a, double x)
        {
            double result = dodelegate(a, x);
            Console.Write($"{result}");
            Console.WriteLine();
        }

        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static void SaveFunc(FDelegate fdelegate, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(fdelegate(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        static void Main(string[] args)
        {

            #region 1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
            // Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
            Console.WriteLine("*** Программа по работе с делегатом ***");
            DoDelegate dodelegate01 = GetMultiPow;
            Process(dodelegate01, 5, 10);
            
            Process(GetMultiSin, 5, 10);
            
            Console.ReadKey();
            #endregion

            Console.Clear();

            #region 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
            // а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.
            // б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр(с использованием модификатора out).
            Console.WriteLine("*** Программа нахождения минимума функции ***");
            FDelegate f = F;
            SaveFunc(f, "data.txt", -100, 100, 0.5);
            Console.WriteLine(Load("data.txt"));
            Console.ReadKey();
            #endregion


        }
    }
}
