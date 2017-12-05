using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PangaAutomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            LogiSisse logisisse = new LogiSisse();
            UusKonto uuskonto = new UusKonto();

            Console.WriteLine("Tere tulemast Parimasse automaati™, kas tahate logida sisse või luua uus konto");
            Console.WriteLine("* logi sisse");
            Console.WriteLine("* uus konto");
            Console.WriteLine("* väljuda");
            string vastus = Console.ReadLine();

            if (vastus == "logi sisse")
            {
                Console.WriteLine("Mis on teie konto nimi?");
                string nimi = Console.ReadLine();
                bool KõikKorras = false;
                int pin = 0;
                while (KõikKorras == false)
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
                string konto = nimi + pin;
                logisisse.logimine(konto, nimi);
            }
            else if (vastus == "uus konto")
            {
                uuskonto.loomine();
            }
        }
    }
}
