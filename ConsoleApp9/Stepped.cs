using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Stepped
    {
        private int n;
        private int[][] a;
        private bool f = false;
        public Stepped(int k, bool t)
        {
            n = k;
            f = t;
            Fill();
            all_mid_value();
            inside_mid_value();
            change_odd();
        }

        private void Fill()
        {
            if (f)
            {
                FillByUser();
            }
            else
            {
                RndmFill();
            }
        }

        private void RndmFill()
        {
            a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите количество элементов в строке массива");
                int m = int.Parse(Console.ReadLine());
                a[i] = new int[m];
                Random rnd = new Random();
                for (int j = 0; j < m; j++)
                {
                    a[i][j] = rnd.Next(10000);
                }
            }
        }

        private void FillByUser()
        {
            a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите количество элементов в строке массива");
                int m = int.Parse(Console.ReadLine());
                a[i] = new int[m];
                Console.WriteLine("Введите элементы строки массива:");
                for (int j = 0; j < m; j++)
                {
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        private void all_mid_value()
        {
            double sum = 0;
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    sum += a[i][j];
                    cnt++;
                }
            }
            Console.WriteLine("Среднее значение во всём массиве: " + sum / cnt);
        }

        private void inside_mid_value()
        {
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < a[i].Length; j++)
                {
                    sum += a[i][j];
                }
                Console.WriteLine("Среднее значение в строке массива: " + sum / a[i].Length);
            }
        }

        private void step_array_output(int[][] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private void change_odd()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] % 2 == 0)
                    {
                        a[i][j] = i * j;
                    }
                }
            }
            Console.WriteLine("Массив после изменения:");
            step_array_output(a);
        }

    }
}
