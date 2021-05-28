using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_prakt
{
    class Program
    {
        static bool IsPrime(int n)
        {
            for (int i = 2; i < Math.Floor(Math.Sqrt(n)); i++)
                if (n % i == 0) return false;
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число b");
            int b = int.Parse(Console.ReadLine());
               int c = 0, s = 0;
            Console.WriteLine("Простые числа на отрезке [a, b]:");
            for (int i = a; i <= b; i++)
                if (IsPrime(i))
                {
                    Console.Write(i + "  ");
                    c++;
                }
                else s += i;
            Console.WriteLine("\nКоличество всех простых чисел на отрезке [a, b]:  " + c);
            Console.WriteLine("Сумма всех составных чисел на отрезке [a, b]:  " + s);
            Console.WriteLine("Введите число A:");
            int A = int.Parse(Console.ReadLine()) - 1;
            for (; ; A--)
                if (IsPrime(A))
                {
                    Console.WriteLine("Ближайшее предшествующее по отношению к A простое число:  " + A);
                    break;
                }
        }
    }
}