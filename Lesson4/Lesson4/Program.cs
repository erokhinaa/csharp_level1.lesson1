using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson4 // ЕРОХИН АЛЕКСАНДР АНДРЕЕВИЧ. Факультет Разработки VR&AR
{
    class Program
    {
        public class StaticClass
        {
            public int[] arr;
            public StaticClass(int arrLength, int Start, int Step)
            {
                arr = new int[arrLength];
                for (int i = 0; i < arrLength; i++)
                {
                    if (i == 0) arr[i] = Start;
                    else arr[i] = arr[i - 1] + Step;
                }
            }
            
            public int Sum
            {
                get
                {
                    int sum = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        sum += arr[i];                            
                    }
                    return sum;
                }
            }

            public int[] Inverse(int[] arr)
            {
                int[] newArr = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] < 0)
                    {
                        newArr[i] = Math.Abs(arr[i]);
                        Console.Write($"{newArr[i]} ");
                    }
                    else
                    {
                        newArr[i] = -arr[i];
                        Console.Write($"{newArr[i]} ");
                    }
                return newArr;
            }
            public int[] Multi(int num)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i] * num;
                    Console.Write($"{arr[i]} ");
                }
                    return arr;
            }
            public int MaxCount
            {
                get
                {
                    int max = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] >= max)
                            max = arr[i];
                    }
                    return max;
                }
            }
            
            public int[] ArrayRandomGenerator(bool withFile, string file, int arrSize, int rndFrom, int rndTo)
            {
                Random rand = new Random();
                if (withFile)
                {
                    int strCount = 0;
                    foreach (string str in File.ReadLines(file))
                    {
                        strCount++;
                    }
                    int[] arr = new int[strCount];
                    int i = 0;
                    int n = 0;
                    foreach (string str in File.ReadLines(file))
                    {
                        if (int.TryParse(str, out n)) 
                        { 
                            arr[i] = n; 
                            i++; 
                        }
                        else 
                        { 
                            arr[i] = -1; 
                            i++; 
                        }
                    }
                    return arr;
                }
                else
                {
                    int[] arr2 = new int[arrSize];
                    for (int c = 0; c < arr2.Length; c++) arr2[c] = rand.Next(rndFrom, rndTo);
                    return arr2;
                }
            }
            public void ArrayPrinter(int[] arr)
            {
                int countDiv = 0;
                int countNum = 0;
                for (int c = 0; c < arr.Length; c++)
                {
                    for (int n = 1; n <= 2; n++)
                    {
                        if (c+n >= arr.Length) break;
                        if ((Math.Abs(arr[c+n]) % 3) != 0) countNum++;
                    }
                    if (countNum == 1) countDiv++;
                    {
                        countNum = 0;
                    }
                }
                Console.WriteLine($"Количество пар с двумя подряд идущими элементами в массиве, в которых только одно число делится на 3 = {countDiv}");
            }

            public struct Account
            {
                public string Login;
                public string Password;

                public bool CheckAccess(string[] auth)
                {
                    Account login;
                    Account pass;
                    login.Login = "root";
                    pass.Password = "GeekBrains";
                    bool access = false;
                    
                    if ((auth[0] == login.Login) && (auth[1] == pass.Password))
                        access = true;
                    else access = false; ;
                    
                    return access;

                }

            }

            static void Main(string[] args)
            {

                #region 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
                // Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
                // В данной задаче под парой подразумевается два подряд идущих элемента массива.
                // Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
                int countDiv = 0;
                int countNum = 0;
                int[] arrInt = new int[20];
                Random rand = new Random();
                Console.WriteLine("*** Запускаем генератор случайных чилел ***");
                for (int i = 0; i < arrInt.Length; i++) arrInt[i] = rand.Next(-10000, 10000);

                for (int c = 0; c < arrInt.Length; c++)
                {
                    for (int n = 1; n <= 2; n++)
                    {
                        if (c + n > arrInt.Length) break;
                        if ((Math.Abs(arrInt[n]) % 3) != 0) countNum++;
                    }
                    if (countNum == 1) countDiv++;
                    countNum = 0;
                }

                Console.WriteLine($"Количество пар с двумя подряд идущими элементами в массиве, в которых только одно число делится на 3 = {countDiv}");
                Console.ReadKey();
                #endregion

                Console.Clear();
                
                #region 2. Реализуйте задачу 1 в виде статического класса StaticClass;
                // а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
                // б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
                // в)*Добавьте обработку ситуации отсутствия файла на диске.
                Console.WriteLine("*** Решение задачи с помощью класса ***");
                StaticClass stat = new StaticClass(20, -10000, 10000);
                Console.Write($"Введите название файла в каталоге {Directory.GetCurrentDirectory()}\\");
                string file = Directory.GetCurrentDirectory() + "\\" + Console.ReadLine();
                FileNotFoundException errMes = new FileNotFoundException();
                
                if (File.Exists(file))
                {
                    stat.ArrayPrinter(stat.ArrayRandomGenerator(true, file, 20, -10000, 10000));
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(errMes.Message + " Тогда запустим без входного файла");
                    stat.ArrayPrinter(stat.ArrayRandomGenerator(false, file, 20, -10000, 10000));
                }
                Console.ReadKey();

                #endregion

                Console.Clear();

                #region 3. а) Дописать класс для работы с одномерным массивом.
                //Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
                //Создать свойство Sum, которое возвращает сумму элементов массива,
                //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),
                //метод Multi, умножающий каждый элемент массива на определённое число,
                //свойство MaxCount, возвращающее количество максимальных элементов.
                Console.WriteLine("*** Программа для работы с классом одномерных массивов ***");
                int[] arr = new int[] { 2,3,4 } ;
                StaticClass stat2 = new StaticClass(2,10,2);
                Console.WriteLine($"Результат свойства Sum: {stat2.Sum}");

                // Inverse
                Console.Write("Массив до обработки методом Inverse: ");
                for (int i = 0; i < arr.Length; i++)
                    Console.Write($"{arr[i]} ");
                Console.WriteLine();
                
                Console.Write($"Результат метода Inverse: ");
                stat2.Inverse(arr);
                Console.WriteLine();
                Console.Write("Массив после работы метода Inverse: ");
                for (int i = 0; i < arr.Length; i++)
                    Console.Write($"{arr[i]} ");

                // Multi
                Console.WriteLine();
                Console.Write($"Результат метода Multi: ");
                stat2.Multi(2);

                Console.WriteLine();
                Console.WriteLine($"Результат свойства MaxCout: {stat2.MaxCount}");

                Console.ReadKey();

                #endregion

                Console.Clear();

                #region 4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
                Console.WriteLine("*** Вас приветсвует программа проверки логина и пароля ***");
                Console.Write($"Проверка на наличие файла auth.txt в каталоге {Directory.GetCurrentDirectory()}\\");
                string fAuth = Directory.GetCurrentDirectory() + "\\auth.txt";
                FileNotFoundException errMes2 = new FileNotFoundException();
                if (File.Exists(fAuth))
                {
                    Console.WriteLine("Файл найден. Продолжаем работу.");
                    string[] auth = new string[2];
                    int i = 0;
                    foreach (string str in File.ReadLines(fAuth))
                    {
                        auth[i] = str; i++;
                    }
                    Account check = new Account();

                    Console.WriteLine();
                    if (check.CheckAccess(auth)) Console.WriteLine("Вы успешно вошли в систему.");
                    else Console.WriteLine("В доступе отказано.");
                }
                else
                {
                    Console.WriteLine(errMes2.Message);
                }
                
                Console.ReadKey();

                #endregion
            }

        }
    }
}

