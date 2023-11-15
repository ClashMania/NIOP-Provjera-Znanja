using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string recenica;

            Console.WriteLine("*****Unesite Rečenicu*****");
            recenica = Console.ReadLine();

            Console.WriteLine("\n*****Uređena rečenica*****");
            Console.WriteLine(recenica.Replace(' ', '_'));


            Console.ReadKey();
        }
    }
}
