using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace masRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите количество элементов в массиве");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Элементы массива");
            int[] mas = Mascreate(n);
            Console.WriteLine(mas);
            int maxValue = Masmax(mas);
            Console.WriteLine("Максимальное число в массиве = " + maxValue);
            int minValue = Masmin(mas);
            Console.WriteLine("Минимальное число в массиве = " + minValue);
            double srValue = SrValue(mas);
            Console.WriteLine("Среднее арифметическое = " + srValue);
        }
        public static int[] Mascreate(int n)
        {
            int randomValue;
            Random r = new Random();
            int[] mas = new int[n];

            for (int i = 0; i < n; i++)
            {
                randomValue = r.Next(1, 100);
                if (randomValue % 2 == 1)
                {
                    mas[i] = randomValue;
                    Console.WriteLine(mas[i] + " ");
                }
                else
                {
                    mas[i] = ++randomValue;
                    Console.WriteLine(mas[i] + " ");
                }
            }
            
            return mas;
        }
        public static int Masmax(int[] mas)
        {
            int max = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];
                }
            }

            return max;
        }
        public static int Masmin(int[] mas)
        {
            int min = 100;

            for (int i = 0; i < mas.Length; i++)
            {
                if (min > mas[i])
                {
                    min = mas[i];
                }
            }

            return min;
        }
        public static double SrValue(int[] mas)
        {
            int sum=0;
            double sr;

            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            sr = sum / mas.Length;

            return sr;
        }
    }
}
