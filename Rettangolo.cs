using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_geometria
{
    internal class Rettangolo
    {
        private double baseRettangolo;
        private double altezzaRettangolo;

        private string nomeRettangolo; 

        //Costruttore con tre parametri, per creare rettangolo con base e altezza dati
        public Rettangolo(double baseR, double altezzaR, string nomeR)
        {
            baseRettangolo = baseR;
            altezzaRettangolo = altezzaR;
            nomeRettangolo = nomeR;
        }

        public Rettangolo(double baseRect, double altezzaRect)
        {
        }

        public double CalcolaArea()
        {
            
            return baseRettangolo * altezzaRettangolo;
        }

        public double CalcolaPerimetro()
        {
            
            return baseRettangolo * 2 + altezzaRettangolo * 2;
        }

        public void StampaRettangolo()
        {
            Console.WriteLine("—— {0} ——", nomeRettangolo);
            Console.WriteLine("base: {0} cm", baseRettangolo);
            Console.WriteLine("altezza: {0} cm", altezzaRettangolo);
            Console.WriteLine("Perimetro: {0} cm", CalcolaPerimetro());
            Console.WriteLine("Area: {0} cm", CalcolaArea());
            Console.WriteLine();
        }

        public void Disegna()
        {
            
            for (int i = 1; i < (baseRettangolo - 1); ++i)
                Console.Write("-");
            
            for (int i = 1; i < (altezzaRettangolo - 1); ++i)
                Console.WriteLine("|{0}|", new String(' ', (int)(baseRettangolo - 2)));
            
            for (int i = 1; i < (baseRettangolo - 1); ++i)
                Console.Write("-");
            
        }
    }
}
