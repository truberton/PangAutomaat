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
            int sisse = Convert.ToInt32(Console.ReadLine());
            int sees = Convert.ToInt32(File.ReadAllText(rahapath));
            int summa = sees + sisse;
            File.WriteAllText(rahapath, Convert.ToString(summa));
        }
    }
}
