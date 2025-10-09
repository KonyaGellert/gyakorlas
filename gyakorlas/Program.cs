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



        }
    }
}
