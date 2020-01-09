using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Recursion_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            while (menu.IsRun)
            {
                menu.RunSelectedMenu(menu.SelectMenu(Menu.MenuArray()));   
            }
        }
    }
}
