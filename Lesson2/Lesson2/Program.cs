using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2 // ЕРОХИН АЛЕКСАНДР АНДРЕЕВИЧ. Факультет Разработки VR&AR
{
    class Program
    {
        static int GetMinNum(int a, int b, int c)
        {
            int num = 0;

            if (a < b && a < c) num = a;
            if (b < a && b < c) num = b;
            if (c < a && c < b) num = c;
            
            return num;
        }
        
        static void Main(string[] args)
        {
            #region 1. Написать метод, возвращающий минимальное из трёх чисел.
            Console.WriteLine("Вас приветсвует программа возврата минимального числа их трех");
            Console.Write("Введите первое число: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: "); int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: "); int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMinNum(a, b, c));
            Console.ReadKey();
            #endregion

            Console.Clear();

            #region 2. Написать метод подсчета количества цифр числа.
            Console.WriteLine("Вас приветсвует программа подсчета количества цифр числа");
            Console.Write("Введите число: "); string num = Console.ReadLine();
            int i = 0;
                foreach (char s in num) i++;
            Console.WriteLine($"Количество цифр в числе {num} = {i}");
            Console.ReadKey();
            #endregion

            Console.Clear();

            #region 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            Console.WriteLine("Вас приветсвует программа подсчета суммы нечетных положительных чисел");
            int n = -1;
            int summ = 0;
            while (n != 0)
            {
                Console.Write("Введите число: "); n = int.Parse(Console.ReadLine());
                if (n % 2 != 0 & n > 0)
                {
                    summ += n;
                }
            }
            Console.WriteLine($"Сумма нечетных положительных чисел = {summ}");
            Console.ReadKey();
            #endregion
            
            Console.Clear();
            
            #region 4.Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль.На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.
            Console.WriteLine("Вас приветсвует программа проверки логина и пароля");
            int attempts = 3;
            string user = "root";
            string pass = "GeekBrains";
            do
            {
                Console.WriteLine($"У вас осталось {attempts} попыток");
                Console.Write("Введите логин: ");  string in_user = Console.ReadLine();
                Console.Write("Введите пароль: "); string in_pass = Console.ReadLine();

                if ((in_user == user) && (in_pass == pass))
                {
                    Console.WriteLine("Вы успешно вошли в систему");
                    break;
                }   
                else attempts--;
            }
            while (attempts != 0);
            
            Console.ReadKey();
            #endregion

            Console.Clear();
            
            #region 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            double imt = 0;
            double good_imt = 20;
            double need_imt = 0;
            Console.WriteLine("Вас приветствует программа расчета ИМТ");
            Console.WriteLine();
            Console.Write("Введите свой вес (кг): ");  double w = double.Parse(Console.ReadLine());
            Console.Write("Введите свой рост (см): "); double h = double.Parse(Console.ReadLine()) / 100;
            Console.WriteLine();
            imt = w / (h * h);

            Console.WriteLine($"Индекс массы тела = {imt:f2}");

            if (imt < 16)
            {
                need_imt = good_imt - imt; 
                Console.WriteLine($"Вам нужно набрать {need_imt*(h*h):f2} кг");
            }
            else if (imt >= 16 && imt < 24.99)
            {
                Console.WriteLine("Ваш вес в норме");
            }
            else
            {
                need_imt = imt - good_imt;
                Console.WriteLine($"Вам нужно похудеть на {need_imt*(h*h):f2} кг");
            }
            Console.ReadKey();
            #endregion

            Console.Clear();
            
            #region 6. * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр.
            //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            int good_count = 0;
            int num_in_number = 0;            
            Console.WriteLine("Вас приветствует программа подсчета хороших чисел");
            Console.WriteLine();
            Console.Write("Введите число: "); string good = Console.ReadLine();

            DateTime start_time = DateTime.Now;
            int good_int = int.Parse(good);
            while (good_int >= 1 && good_int <= 1000000000)
            {                
                foreach (char d in good) num_in_number++;
                if (int.Parse(good) % num_in_number == 0) good_count ++;
                Console.Write("Введите число: "); good = Console.ReadLine();
                good_int = int.Parse(good);
            }
            DateTime end_time = DateTime.Now;
            Console.WriteLine($"Количество хороших чисел = {good_count}. Время выполнения подсчета {end_time - start_time}");
            Console.ReadKey();
            #endregion
        }
    }
}
