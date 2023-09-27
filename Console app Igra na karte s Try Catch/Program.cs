using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Console_app_Igra_na_karte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karte = 0;
            int cardCounter = 0;


            while (cardCounter < 31)
            {
                Console.WriteLine("Unesite broj karte od 1 - 13:  ");

                try { 
                karte = Convert.ToInt32(Console.ReadLine());
                }
                 catch (Exception greska) { Console.WriteLine("Pogrešan unos!"); 
                Console.WriteLine(greska.Message);
                }


                if (karte <= 13 && karte >= 1)
                {
                    cardCounter += karte;
                }

                else Console.WriteLine("Unesi ispravnu kartu od 1 do 13.");
            }


            if (cardCounter == 31) 
            {
                Console.WriteLine("Pobjeda!");
            }
            else { Console.WriteLine("Gubitak!"); }





            Console.ReadKey(); 
        }
    }
}
