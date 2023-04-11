using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Det øverste er efterspørgsler og derefter definere vi variablerne via ReadLines.
            Console.WriteLine("Hej hvad er dit navn? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej {name} hvor gammel er du?");
            string age = Console.ReadLine();
            Console.WriteLine("hvor høj er du? ");
            string height = Console.ReadLine();

            /* først konverterer vi til forskellige variabler. Først siger vi at vi vil definere en ny variabel,- 
             * var convertedAge som laver vi om til en interger. Det gør vi ved at bruge den brugerdefinerede variabel age inde i
             * ToInt32 parentesen
             */
            var convertedAge = Convert.ToInt32(age);
            double convertedHeight = Convert.ToDouble(height);
                //double.tryparse virker hvor int.tryparse ikke gør
            bool cancvHeight = double.TryParse(height, out double convertedHeight3);
            if (cancvHeight)
            {
                Console.WriteLine($"{convertedHeight} {convertedHeight3}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Fejl, skriv venligst højde som et heltal");
            }
        }
    }
}
