using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_5
{
    static class Tasks
    {

        public static void Task1()
        {
            Random random = new Random();
            int n = random.Next(1, 1001);
            Console.WriteLine($"Generated n = {n} ");
            PrintAscNumbers(n);
            TaskExit();
        }

        private static void PrintAscNumbers(int n)
        {
            if (n <= 0)
            {
                Console.Write(n + " ");
            }
            else
            {
                PrintAscNumbers(n - 1);
                Console.Write(n + " ");
            }
        }

        private static void PrintDescNumbers(int n)
        {
            if (n <= 0)
            {
                Console.Write(n);
            }
            else
            {
                Console.Write(n + " ");
                PrintDescNumbers(n - 1);
            }

        }
        public static void TaskExit()
        {
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task2()
        {

            Random random = new Random();
            int n = random.Next(1, 1001);
            Console.WriteLine($"Generated n = {n} ");
            PrintDescNumbers(n);
            TaskExit();
        }

        private static void Sleepwalker(int n)
        {

            if (n > 0)
            {
                Console.WriteLine("{0} лунатиков жило на Лунe", n);
                Console.WriteLine("{0} лунатиков ворочались во сне", n);
                Console.WriteLine("Один из лунатиков упал с Луны во сне");
                if (n - 1 == 0)
                {
                    Console.WriteLine("И больше не осталось лунатиков на Луне");
                }
                else
                {
                    Console.WriteLine("{0} лунатиков осталось на Луне", n - 1);
                }
                Sleepwalker(n - 1);
            }

        }
        public static void Task3()
        {
            Sleepwalker(10);
            TaskExit();
        }

        private static void PrintReverseTriangle(int n)
        {
            if (n > 0)
            {

                for (int i = 0; i < n; i++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
                PrintReverseTriangle(n - 1);
            }
        }

        private static void PrintTriangle(int n)
        {
            if (n > 0)
            {
                PrintTriangle(n - 1);
                for (int i = 0; i < n; i++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Task4()
        {
            Random random = new Random();
            int n = random.Next(1, 15);
            Console.WriteLine($"Generated n = {n} ");
            PrintTriangle(n);
            TaskExit();
        }

        public static void Task5()
        {
            Random random = new Random();
            int n = random.Next(1, 15);
            Console.WriteLine($"Generated n = {n} ");
            PrintReverseTriangle(n);
            TaskExit();
        }

        public static void Task6()
        {
            Random random = new Random();
            int n = random.Next(1, 99999);
            Console.WriteLine($"Generated n = {n} ");
            PrintNumber(n);
            TaskExit();
        }

        private static void PrintBinaryValue(int n)
        {
            if (n / 2 != 0)
            {
                PrintBinaryValue(n / 2);
                Console.Write(n % 2);
            }
            else
            {
                Console.Write(n % 2);
            }
        }

        private static void PrintNumber(int n)
        {

            if (n / 10 != 0)
            {
                PrintNumber(n / 10);
                Console.Write(n % 10);

            }
            else
            {
                Console.Write(n % 10);
            }
        }
        public static void Task7()
        {
            Random random = new Random();
            int n = random.Next(1, 99);
            Console.WriteLine($"Generated n = {n} ");
            PrintBinaryValue(n);
            TaskExit();
        }

        public static void Task8()
        {

            Random random = new Random();
            int n = random.Next(1, 99);
            Console.WriteLine($"Generated {n}");
            string binaryNum = Convert.ToString(n, 2);
            Console.WriteLine("turn to decimal value {0}", binaryNum);
            double res = GetDecimalValue(binaryNum);

            Console.WriteLine($"Final res = {GetDecimalValue(binaryNum)}");
            TaskExit();
        }

        private static double GetDecimalValue(string binaryNum)
        {

            if (binaryNum.Length != 1)
            {
                Console.WriteLine($"{Double.Parse($"{binaryNum[0]}") * Math.Pow(2, binaryNum.Length-1)}");
                return Double.Parse($"{binaryNum[0]}") * Math.Pow(2, binaryNum.Length - 1) + GetDecimalValue(binaryNum.Substring(1, binaryNum.Length-1));
            }
            else
            {
                Console.WriteLine($"Last {Double.Parse($"{binaryNum[0]}")}");
                return Double.Parse($"{binaryNum[0]}");
            }

        }

        public static void Task9()
        {

            Random random = new Random();
            int n = random.Next(1, 99);
            Console.WriteLine($"Generated n = {n} ");
            PrintAllDividers(n, n);
            TaskExit();
        }

        private static void PrintAllDividers(int startNumber, int divider)
        {
            if (divider > 0)
            {
                if (startNumber % divider == 0 )
                {
                    Console.WriteLine($"For {startNumber} divider is {divider}");
                }
                PrintAllDividers(startNumber, divider - 1);
            }
            else
            {
                Console.WriteLine("End, n = 1");
            }

        }

        public static void Task10()
        {

            Random random = new Random();
            int n = random.Next(5, 10);
            Console.WriteLine($"Generated n = {n} ");
            PrintAsterisks(n);
            TaskExit();
        }
        static void Stroka(int a, int j)
        {
            for (int i = 0; i < j; i++)
            {
                Console.Write(a);
            }
        }
        static void NumberR(int i, int j, int n)
        {
            if (i < n)
            {
                Stroka(i, j);
                Console.WriteLine();
                NumberR(i + 1, j += 2, n);
            }
            if (i == n)
            {
                Stroka(i, j);
                Console.WriteLine();
            }
            else
            {
                Stroka(i, j -= 2);
                Console.WriteLine(); 
            }
        }

        public static void Task11()
        {

            Random random = new Random();
            int n = random.Next(5, 50);
            Console.WriteLine($"Generated n = {n} ");
            PrintAsterisksBoth(n);
            TaskExit();
        }

        public static void PrintAsterisks(int n)
        {

            if (n > 1)
            {
                if (n % 2 == 0)
                    Console.WriteLine(new string('*', n));

                PrintAsterisks(n - 1);
            }
        }

        public static void PrintAsterisksBoth(int n)
        {

            if (n > 1)
            {
                if (n % 2 == 0)
                    Console.WriteLine(new string('*', n));

                PrintAsterisksBoth(n - 1);

                if (n % 2 == 0)
                    Console.WriteLine(new string('*', n));
            }
        }
        public static void Task12()
        {

            Random random = new Random();
            int n = random.Next(1, 99);
            Console.WriteLine($"Generated n = {n} ");
            NumberR(1, 1, n);
            TaskExit();
        }
        public static void Task13()
        {
            PrintAlphabet(80, 65);
            TaskExit();
        }
        static void PrintCharacter(int n, char a)
        {
            for (int i = n; i > 0; i--)
            {
                Console.Write(a);
            }
        }

        static void PrintAlphabet(int i, int j)
        {
            if (i > 30)
            {
                PrintCharacter(i, (char)j);
                Console.WriteLine();
                PrintAlphabet(i - 2, j + 1);
            }
            PrintCharacter(i, (char)j);
            Console.WriteLine();
        }

    }
}
