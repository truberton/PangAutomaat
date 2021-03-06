﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PangaAutomaat
{
    class LogiSisse
    {
        public string tegu;

        public void logimine(string konto, string nimi)
        {
            Sisse sisse = new Sisse();
            Välja välja = new Välja();

            string path = Directory.GetCurrentDirectory() + "kontod.txt";
            string rahapath = Directory.GetCurrentDirectory() + nimi;
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
                        else if (tegu == "Lõpetada" || tegu == "Lopetada" || tegu == "lõpetada" || tegu == "lopetada")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Palun valige midagi valikust");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Konto ei eksisteeri või sisestasite vale nime/PIN");
                        break;
                    }
                }
            }
        }
    }
}
