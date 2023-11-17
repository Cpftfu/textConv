using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace textConv
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*сын сказал, что когда вырастет у него будет несколько профессий: клоун, фокусник 
             и проограммист. он еще не вкурсе что в IT это всё одна профессия*/

            //int posposition = strelochka.strelka(4, 11);
            //нахуй блять, я ебала
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

            while (true)
            {
                ConsoleKeyInfo knopka = Console.ReadKey(true);
                switch (knopka.Key)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        Console.WriteLine("     введите формат файла через точку \n " +
                            "чтобы сохранить файл именно в этом формате\n        (.txt; .json; .xml) ");
                        string govno = Console.ReadLine();
                        if (govno == ".txt")
                        {
                            string text = File.ReadAllText("C:\\Users\\Вика\\Desktop\\myShit.txt");
                            File.WriteAllText(govno, text);
                            Console.WriteLine("файл успешно создан!!!");
                        }
                        else if (govno == ".json")
                        {
                            //тута работа с JSON
                            double[] Litrash = new double[] { 0.4, 0.5, 0.55 };

                            forSave beer1 = new forSave();
                            beer1.BeerTitle = "Светлый лагер";
                            beer1.BeerLitrash = new double[] { 0.4, 0.5, 0.55 };
                            beer1.BeerStrong = 3.2;

                            forSave beer2 = new forSave();
                            beer2.BeerTitle = "Майбок";
                            beer2.BeerLitrash = new double[] { 0.4, 0.5, 0.55 };
                            beer2.BeerStrong = 6.3;

                            forSave beer3 = new forSave();
                            beer3.BeerTitle = "Бьер-де-Гард";
                            beer3.BeerLitrash = new double[] { 0.4, 0.5, 0.55 };
                            beer3.BeerStrong = 6.8;

                            List<forSave> beer = new List<forSave>();
                            beer.Add(beer1);
                            beer.Add(beer2);
                            beer.Add(beer3);

                            string JSON = JsonConvert.SerializeObject(beer);
                            File.WriteAllText("C:\\Users\\Вика\\Desktop\\myShit.json", JSON);
                            string txt = File.ReadAllText("C:\\Users\\Вика\\Desktop\\myShit.json");
                            List<forSave> result = JsonConvert.DeserializeObject<List<forSave>>(txt);
                        }
                        else if (govno == ".xml")
                        {
                            //тута работа с XML (my ass)
                            forSave beer1 = new forSave();
                            XmlSerializer XML = new XmlSerializer(typeof(forSave));
                            using (FileStream sh = new FileStream("C:\\Users\\Вика\\Desktop\\myShit.xml", FileMode.OpenOrCreate))
                            {
                                XML.Serialize(sh, beer1);
                            }

                            forSave beerr;
                            XmlSerializer xml = new XmlSerializer(typeof(forSave));
                            using (FileStream sh = new FileStream("C:\\Users\\Вика\\Desktop\\myShit.xml", FileMode.Open))
                            {
                                beerr = (forSave)xml.Deserialize(sh);
                            }
                        }break;
                }
            }
        }
    }
}



