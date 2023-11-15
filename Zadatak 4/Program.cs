using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
      
            Console.WriteLine("Upišite stranicu x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Upišite stranicu y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Upišite stranicu z: ");
            z = Convert.ToInt32(Console.ReadLine());


            if ((z * z) == (x * x) + (y * y))
            {
                Console.WriteLine("Da!");
            }

             else 
            {
                Console.WriteLine("Ne!");
            }





            Console.ReadKey();


        }

    }
}


