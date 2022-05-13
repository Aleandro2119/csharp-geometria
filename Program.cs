using csharp_geometria;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double baseRect, altezzaRect;
            csharp_geometria.LeggiNumeri.ReadNum("Inserisci base di un rettangolo : ", out baseRect);
            csharp_geometria.LeggiNumeri.ReadNum("Inserisci altezza del rettangolo: ", out altezzaRect);

            csharp_geometria.Rettangolo r1 = new(baseRect, altezzaRect);

            Console.WriteLine("Area: {0}", r1.CalcolaArea());
            Console.WriteLine("Perimetro: {0}", r1.CalcolaPerimetro());


            Rettangolo r2 = new Rettangolo(10, 20, "Rett 1");
            Rettangolo r3 = new Rettangolo(110, 320, "Rett 2");
            Rettangolo r4 = new Rettangolo(210, 540, "Rett 3");

            r2.StampaRettangolo();
            r3.StampaRettangolo();
            r4.StampaRettangolo();


            r2.Disegna();
        }
    }
}
