using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6._5_advanced_looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Num1();
            Console.WriteLine();
            Console.WriteLine();
            Num2();
            Console.WriteLine();
            Console.WriteLine();
            Num3();
            Console.WriteLine();
            Console.WriteLine();
            Num4();
            Console.WriteLine();
            Console.WriteLine();
            Num5();
            Console.WriteLine();
            Console.WriteLine();
            Num6();
            Console.WriteLine();
            Console.WriteLine();
            Num7();
            Console.WriteLine();
            Console.WriteLine();
            Num8();
            Console.WriteLine();
            Console.WriteLine();
            Num9();
            Console.WriteLine();
            Console.WriteLine();
            Num10();
            Console.WriteLine();
            Console.WriteLine();
            Num11();
            Console.WriteLine();
            Console.WriteLine();
            Num12();
            Console.WriteLine();
            Console.WriteLine();
            Num13();
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void Num1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("*");
            }
        }
        public static void Num2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int j = 1; j <= 5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int k = 1; k <= 20; k++)
            {
                Console.Write("*");
            }
        }
        public static void Num3()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Num4()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Num5()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void Num6()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Num7()
        {
            for (int i = 1; i <= 1; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Console.Write($"{j} {j} {j} {j} {j} {j} {j} {j} {j} {j}");
                    Console.WriteLine();
                }
            }
        }
        public static void Num8()
        {
            for (int i = 1; i <= 10; i++)
            {

            }
        }
        public static void Num9()
        {

        }
        public static void Num10()
        {

        }
        public static void Num11()
        {

        }
        public static void Num12()
        {

        }
        public static void Num13()
        {

        }
    }
}
