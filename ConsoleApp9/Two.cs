using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Two
    {
        private int n, m;
        private int[,] a;
        private bool f = false;

        public Two(int k, int l, bool t)
        {
            n = k;
            m = l;
            f = t;
            Fill();
            mid_value();
            array_output_normal(a);
            array_output_reversed(a);
        }

        private void FillByUser(int k, int l)
        {
            Console.WriteLine("Введите элементы массива:");
            a = new int[k, l];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        private void RndmFill(int k, int l)
        {
            a = new int[k, l];
            Random rnd = new Random();
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    a[i, j] = rnd.Next(100000);
                }

            }
        }

        private void Fill()
        {
            if (!f)
            {
                RndmFill(n, m);
            }
            else
            {
                FillByUser(n, m);
            }
        }

        private void mid_value()
        {
            double sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
            Console.WriteLine("Среднее значение в массиве: " + sum / (n * m));
        }

        private void array_output_normal(int[,] b)
        {
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private void array_output_reversed(int[,] b)
        {
            for (int i = 0; i < b.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = b.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
                else
                {
                    for (int j = 0; j < b.GetLength(1); j++)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
