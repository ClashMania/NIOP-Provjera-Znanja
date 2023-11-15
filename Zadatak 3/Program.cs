using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_3
{
    internal class Program
    {            
        static void Main(string[] args)
        {
                Console.Write("Unesite N-ti broj Fibonaccijevog niza: ");
                int n = int.Parse(Console.ReadLine());

                
                n = n - 1;
                Console.Write(NtiBroj(n));
                Console.ReadKey();
        }

        private static int NtiBroj(int broj)
            {
                if ((broj == 0) || (broj == 1))
                {
                    return broj;
                }
                else
                {
                    return (NtiBroj(broj - 1) + NtiBroj(broj - 2));
                }
        }
        
    }
}


