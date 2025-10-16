using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int ido = DateTime.Now.Hour;
            if (ido < 12)
            {
                Console.WriteLine("Jó reggelt!");
            }
            else if (ido < 18)
            {
                Console.WriteLine("Jó napot!");
            }
            else
            {
                Console.WriteLine("Jó estét!");
            }
            Console.WriteLine("--------------------------------------------------------------");
            //2
            Console.Write("Kérem a lekötés összegét: ");
            double osszeg = double.Parse(Console.ReadLine());

            Console.Write("Hány évre szeretné lekötni?: ");
            int ev = int.Parse(Console.ReadLine());

            Console.Write("Milyen kamatra?:(%) ");
            double kamat = double.Parse(Console.ReadLine());
            
            double kamat2 = kamat / 100 + 1;

            for (int i = 0; i < ev; i++)
            {
                osszeg *= kamat2;
            }

            Console.WriteLine($"A lekötés végén az összeg: {osszeg} Ft");

            Console.WriteLine("--------------------------------------------------------------");
            //3
            //nem értem :(
            
            double vKezdo;
            do
            {
                Console.Write("Add meg a kezdő sebességet (3.00–5.00 m/s): ");
                vKezdo = double.Parse(Console.ReadLine());
            }
            while (vKezdo < 3.0 || vKezdo > 5.00);
            const double tav = 100.0; 
            double fele = tav / 2.0;
            double lassuloTav = 10;

            double vMax = vKezdo + 4.0;

            double a1 = (vMax - vKezdo) * (vMax + vKezdo) / (2*fele);
            Console.WriteLine("tizmeterenkenti sebbesseg");
            for (int i =10; i<=tav;i=i+10)
            {
                double v;
                if (i <= fele)
                {
                    v = vKezdo + (vMax - vKezdo) * (i / fele);
                }
                else if (i > tav - lassuloTav)
                {
                    double vVeg = vMax / 2;
                    v = vMax - (vMax - vVeg) * ((i - (tav - lassuloTav)) / lassuloTav);
                }
                else 
                {
                    v = vMax; 
                }
                double vKmH = v * 3.6;
                Console.WriteLine($"{i,3} m: {vKmH,6:F2} km/h");
            }

        }
    }
}
