using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eksamen201opg22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var talliste = System.IO.File.ReadAllLines("Inddata.txt");

            var textoutput = "";

            List<double> tal = new List<double>();

            foreach (var item in talliste)
            {
                tal.Add(double.Parse(item));
            }

            var antalNegativeTal = tal.Where(x => x < 0).ToList();

            foreach (var item in antalNegativeTal) 
            { 
                textoutput +=  item + Environment.NewLine;
            }

            textoutput += "Antal negative tal på filen inddata: " + antalNegativeTal.Count;

            System.IO.File.WriteAllText("Uddata.txt", textoutput);
        }
    }
}
