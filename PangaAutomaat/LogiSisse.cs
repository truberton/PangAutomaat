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
        public virtual void logimine(string konto, string nimi)
        {
            string path = Directory.GetCurrentDirectory() + "kontod.txt";
            string rahapath = Directory.GetCurrentDirectory() + nimi + ".txt";
            bool olemas;
            if (File.Exists(path))
            {
                olemas = File.ReadAllText(path).Contains(konto);
                if (olemas == true)
                {
                    Console.WriteLine("Teie kontol on: " + File.ReadAllText(rahapath) + " eurot");
                }
            }
        }
    }
}
