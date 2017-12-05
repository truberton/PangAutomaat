using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PangaAutomaat
{
    class Sisse
    {
        public void sisse(string nimi)
        {
            string rahapath = Directory.GetCurrentDirectory() + nimi + ".txt";
            Console.WriteLine("Palju soovite sisse panna?");
            double sisse = Convert.ToDouble(Console.ReadLine());
            double sees = Convert.ToDouble(File.ReadAllText(rahapath));
            double summa = sees + sisse;
            File.WriteAllText(rahapath, Convert.ToString(summa));
        }
    }
}
