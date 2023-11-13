using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textConv
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("===========================================================");
            Console.WriteLine("                ПРИВЕТСВУЮ В КОНВЕРТЕРЕ                    ");
            Console.WriteLine("===========================================================");
            Console.WriteLine("     введите путь до файла, который требуется открыть :   ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("=================================================");
            Console.WriteLine("    сохраненька файла в одном из форматов" +
                " \n    (на выбор .txt; .json; .xml)\n    по нажатию клавиши F1");
            Console.WriteLine("=================================================");
            Console.WriteLine("    чтобы свалить из проги нажмите ESC");
            Console.WriteLine("=================================================");
            string myShit = File.ReadAllText("C:\\Users\\Вика\\Desktop\\myShit.txt");
            Console.WriteLine(myShit);

            //int posposition = strelochka.strelka(4, 11);
            //нахуй блять я ебала

            while (true)
            {

                ConsoleKeyInfo knopka = Console.ReadKey(true);
                switch (knopka.Key)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        Console.WriteLine("     введите путь до файла, который требуется сохранить," +
                            " \n    и измените формат файла на желаемый для сохранения:" +
                            " \n                (.txt; .json; .xml) ");
                        string puti = "C:\\Users\\Вика\\Desktop\\myShit.txt";
                        string newFile = "C:\\Users\\Вика\\Desktop\\NEWShit.txt";
                        Console.ReadLine();
                        try
                        {
                            string read = File.ReadAllText(puti);
                            File.WriteAllText(newFile, read);
                            Console.WriteLine("файлик успешно создан!!!\n ура-ура-ура");
                        }
                        catch (Exception bbb)
                        {
                            {
                                Console.WriteLine("упси...вышла ошибочка: " + bbb.Message);
                            }
                        }break;
                        
                }break;
            }

        }
    }
}
