using System;
using System.Reflection;

namespace Recursion_5
{
    class Menu
    {
        public int Index { get; set; } = 0;
        public bool IsRun { get; set; } = true;

        public Menu()
        {
        }

        public static string[] MenuArray()
        {
            string[] str = {
                "1.Разработать рекурсивный метод, который по заданному натуральному числу N\n" +
                "выведет на экран все натуральные числа не больше N в порядке возрастания.",
                "2.Разработать рекурсивный метод, который по заданному натуральному числу N\n" +
                 "выведет на экран все натуральные числа не больше N в порядке убывания.",
                "3.Разработать рекурсивный метод для вывода на экран стихотворения.",
                "4.Дано натуральное число N. Вывести треугольник из чисел по возрастанию",
                "5.Дано натуральное число N. Вывести треугольник из чисел по убыванию",
                "6.Дано число N. Распечатать число по цифрам в прямом порядке",
                "7.Дано число. Перевести его в бинарную систему исчисления",
                "8.Дано бинарное число N. Перевести в десятичную",
                "9. Вывести все делители заданного натурального числа N",
                "10. Вывести до числа N 0-n звездочек по убыванию",
                "11. Вывести N пробелов между звездочками ",
                "12. Вывести число по возрастанию и сразу по убыванию до N",
                "13. Распечатать алфавит от a-z и z-a с повторениями ",
                "14. Exit"
            };

            return str;
        }

        private static string GetMethodName(int menuNum)
        {
            string methodName;
            if (menuNum == Menu.MenuArray().Length)
            {
                methodName = "Exit";
            }
            else
            {
                methodName = "Task" + menuNum;
            }
            return methodName;
        }
        public void RunSelectedMenu(int MenuNum)
        {
            Type TaskType = typeof(Tasks);
            string MethodName = GetMethodName(MenuNum);
            if (MethodName == "Exit")
            {
                IsRun = false;
            }
            else
            {
                MethodInfo method = TaskType.GetMethod(MethodName);
                object task = method.Invoke(null, new object[] { });
            }
        }

        public int SelectMenu(string[] MenuItem)
        {
            bool flag = true;

            while (flag)
            {

                PrintMenu(Index);
                ConsoleKeyInfo ckey = Console.ReadKey(); // waiting for the managing keys 

                if (ckey.Key == ConsoleKey.DownArrow)
                {
                    if (Index == MenuItem.Length - 1)
                    {
                        Index = 0;
                    }
                    else
                        Index++;
                }

                else if (ckey.Key == ConsoleKey.UpArrow)
                {
                    if (Index <= 0)
                    {
                        Index = MenuItem.Length - 1;
                    }
                    else
                        Index--;
                }

                else if (Char.IsDigit(ckey.KeyChar))
                {
                    Index = Int32.Parse($"{ckey.KeyChar}") - 1;
                }

                else if (ckey.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    WriteFullLine($"****{MenuItem[Index]}*****", ConsoleColor.Yellow, ConsoleColor.Magenta);
                    Console.ResetColor();
                    break;
                }
                Console.SetCursorPosition(0, 0);

            }
            Index++;
            return Index;
        }

        public static void PrintMenu(int Index)
        {
            string[] MenuItem = MenuArray();

            for (int i = 0; i < MenuItem.Length; i++)
            {
                if (i == Index)
                {
                    WriteFullLine($"****{MenuItem[i]}*****", ConsoleColor.Yellow, ConsoleColor.Magenta);
                }
                else
                {
                    WriteFullLine($"{MenuItem[i]}", ConsoleColor.White, ConsoleColor.Blue);
                }
                Console.ResetColor();
            }

        }
        public static void WriteFullLine(string str, ConsoleColor backgroundColor = ConsoleColor.Green, ConsoleColor foregroundColor = ConsoleColor.DarkGreen)
        {
            //
            // This method writes an entire line to the console with the string.
            //
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(str.PadRight(Console.WindowWidth - 1)); 
            Console.ResetColor();
        }
    }
}
