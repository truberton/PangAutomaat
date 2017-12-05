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
                    KõikKorras = true;
                }
            }
            string info = nimi + pin + Environment.NewLine;
            File.AppendAllText(path, info);
            string rahapath = Directory.GetCurrentDirectory() + nimi + ".txt";
            Console.WriteLine("Palju teil raha on?");
            double raha = Convert.ToDouble(Console.ReadLine());
            File.WriteAllText(rahapath, Convert.ToString(raha));
        }
    }
}
