using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class One
    {
        private int n;
        private bool f = false;

        public One(int cnt, bool t)
        {
            n = cnt;
            f = t;
            Fill();
            mid_value();
            more_hundred();
            no_repeat_elements();
        }
        private int[] a;

        private void FillByUser(int m)
        {
            Console.WriteLine("Введите элементы массива:");
            a = new int[m];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        private void RndmFill(int m)
        {
            a = new int[m];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(100000);
            }
        }

        private void Fill()
        {
            if (!f)
            {
                RndmFill(n);
            }
            else
            {
                FillByUser(n);
            }
        }

        private void array_output(int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
        }

        private void mid_value()
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Среднее значение в массиве: " + sum / a.Length);
        }

        private void more_hundred()
        {
            int cnt = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (Math.Abs(a[i]) <= 100)
                {
                    cnt++;
                }
            }
            int[] b = new int[cnt];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (Math.Abs(a[i]) <= 100)
                {
                    b[j] = a[i];
                    j++;
                }
            }
            array_output(b);
        }

        private void no_repeat_elements()
        {
            int cnt = 1;
            for (int i = 1; i < a.Length; i++)
            {
                bool have = false;
                for (int j = 0; j < i; j++)
                {
                    if (a[j] == a[i])
                    {
                        have = true;
                    }
                }
                if (!have)
                {
                    cnt++;
                }
            }
            int[] b = new int[cnt];
            int k = 1;
            b[0] = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                bool have = false;
                for (int j = 0; j < i; j++)
                {
                    if (a[j] == a[i])
                    {
                        have = true;
                    }
                }
                if (!have)
                {
                    b[k] = a[i];
                    k++;
                }
            }
            array_output(b);
        }


    }
}