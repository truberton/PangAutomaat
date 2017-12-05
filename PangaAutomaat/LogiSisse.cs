using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PangaAutomaat
{
    class LogiSisse
    {
        Sisse sisse = new Sisse();
        Välja välja = new Välja();

        public string tegu;
        public virtual void logimine(string konto, string nimi)
        {
            string path = Directory.GetCurrentDirectory() + "kontod.txt";
            string rahapath = Directory.GetCurrentDirectory() + nimi + ".txt";
            bool olemas;
            if (File.Exists(path))
            {
                olemas = File.ReadAllText(path).Contains(konto);
                while (true)
                {
                    if (olemas)
                    {
                        Console.WriteLine("Teie kontol on: " + File.ReadAllText(rahapath) + " eurot");
                        Console.WriteLine("Kas soovite raha sisse panna või välja võtta?");
                        Console.WriteLine("* Sisse");
                        Console.WriteLine("* Välja");
                        Console.WriteLine("* Lõpetada");
                        tegu = Console.ReadLine();

                        if (tegu == "sisse" || tegu == "Sisse")
                        {
                            sisse.sisse(nimi);
                        }
                        else if (tegu == "välja" || tegu == "Välja")
                        {
                            välja.välja(nimi);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
