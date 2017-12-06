using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PangaAutomaat
{
    class UusKonto
    {
        public void loomine()
        {
            string path = Directory.GetCurrentDirectory() + "kontod.txt";
            string nimi;
            while (true)
            {
                Console.WriteLine("Mis on teie konto nimi?");
                nimi = Console.ReadLine();
                if (File.ReadAllText(path).Contains(nimi))
                {
                    Console.WriteLine("See konto juba eksisteerib, palun valige teine nimi");
                }
                else
                {
                    break;
                }
            }
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
                    KõikKorras = true;
                }
            }
            string info = nimi + pin + Environment.NewLine;
            File.AppendAllText(path, info);
            string rahapath = Directory.GetCurrentDirectory() + nimi;
            File.WriteAllText(rahapath, "0");
        }
    }
}
