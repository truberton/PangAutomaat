using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PangaAutomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sellega näeb unicode'i nagu tm sümbol ja õ
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            LogiSisse logisisse = new LogiSisse();
            UusKonto uuskonto = new UusKonto();

            string path = Directory.GetCurrentDirectory() + "kontod.txt";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
            }

            while (true)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Tere tulemast Parimasse automaati™, kas tahate logida sisse või luua uus konto");
                Console.WriteLine("* Logi sisse");
                Console.WriteLine("* Uus konto");
                Console.WriteLine("* Lõpetada");
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine();
                string vastus = Console.ReadLine();

                if (vastus == "logi sisse" || vastus == "Logi sisse" || vastus == "login")
                {
                    Console.WriteLine("Mis on teie konto nimi?");
                    string nimi = Console.ReadLine();
                    bool KõikKorras = false;
                    int pin = 0;

                    while (!KõikKorras)
                    {
                        Console.WriteLine("Mis on teie konto PIN?");
                        pin = Convert.ToInt32(Console.ReadLine());

                        if (pin < 1000 || pin > 9999)
                        {
                            Console.WriteLine("PIN peab olema 4 kohaline arv");
                        }
                        else
                        {
                            break;
                        }
                    }
                    string konto = nimi + pin;
                    if (!File.Exists(Directory.GetCurrentDirectory() + nimi))
                    {
                        Console.WriteLine("Teie raha kadus kuskile ära, olete tagasi nullis");
                        File.WriteAllText(Directory.GetCurrentDirectory() + nimi, "0");
                    }
                    logisisse.logimine(konto, nimi);
                    vastus = "abc";
                }

                else if (vastus == "uus konto" || vastus == "Uus konto")
                {
                    uuskonto.loomine();
                    vastus = "abc";
                }

                else if (vastus == "Lõpetada" || vastus == "lõpetada" || vastus == "Lopetada")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Palun sisestage midagi valikutest");
                }
            }
        }
    }
}
