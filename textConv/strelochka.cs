using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textConv
{
    internal class strelochka
    {
        public static int strelka(int minStrelka, int maxsStrelka)
        {
            int porn = 10;
            ConsoleKeyInfo klavishka;

            do
            {
                Console.SetCursorPosition(0, porn);
                Console.WriteLine(">>");

                klavishka = Console.ReadKey();

                Console.SetCursorPosition(0, porn);
                Console.WriteLine("  ");

                if (klavishka.Key == ConsoleKey.UpArrow && porn != minStrelka)
                {
                    porn = porn - 1;
                }
                if (klavishka.Key == ConsoleKey.DownArrow && porn != maxsStrelka)
                {
                    porn = porn + 1;
                }
                if (klavishka.Key == ConsoleKey.RightArrow) ;
                {
                    porn = porn + 1;
                }


            } while (klavishka.Key != ConsoleKey.Enter);
            return porn;
        }
    }
}
