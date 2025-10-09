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

        }
    }
}
