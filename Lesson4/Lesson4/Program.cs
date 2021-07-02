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
        class StaticClass
        {

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
                            return arr;
                        }
                        else
                        {
                            arr[i] = -999999999;
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
                    for (int n = 0; n <= 1; n++)
                    {
                        if (c + n > arr.Length) break;
                        if (Math.Abs(arr[n]) % 3 == 0) countNum++;
                    }
                    if (countNum == 1) countDiv++;
                    c += 2;
                    countNum = 0;
                }
                Console.WriteLine($"Количество пар с двумя подряд идущими элементами в массиве, в которых только одно число делится на 2 = {countDiv}");
            }

            public bool CheckFileExist(string file)
            {
                bool fileExist;
                StringReader sf = new StringReader(file);
                if (File.Exists(file)) return fileExist = true;
                else
                {
                    Console.WriteLine($"Файл {file} отсутствует");
                    return fileExist = false;
                }
            }
            public string[] ReadFromFile(string readFile)
            {
                string[] file = File.ReadAllLines(readFile);

                return file;
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
                    for (int n = 0; n <= 1; n++)
                    {
                        if (c + n > arrInt.Length) break;
                        if (Math.Abs(arrInt[n]) % 3 == 0) countNum++;
                    }
                    if (countNum == 1) countDiv++;
                    c += 2;
                    countNum = 0;
                }

                Console.WriteLine($"Количество пар с двумя подряд идущими элементами в массиве, в которых только одно число делится на 2 = {countDiv}");
                Console.ReadKey();
                #endregion

                Console.Clear();

                #region 2. Реализуйте задачу 1 в виде статического класса StaticClass;
                // а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
                // б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
                // в)*Добавьте обработку ситуации отсутствия файла на диске.
                Console.WriteLine("*** Решение первого задания через класс ***");
                StaticClass stat = new StaticClass();
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

            }

        }
    }
}

