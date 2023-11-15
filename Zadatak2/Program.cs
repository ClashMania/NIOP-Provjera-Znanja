using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1, string2;
            Console.WriteLine("Upišite riječ: ");
            string1 = Console.ReadLine();
            Console.WriteLine("Upišite drugi riječ: ");
            string2 = Console.ReadLine();
            int x;

            if (string1.Length > string2.Length)
            {
                x = string2.Length;
            }
            else
            {
                x = string1.Length;
            }

            for (int i = 0; i < x; i++)
            {
                if (string1[i] < string2[i])
                {
                    Console.WriteLine(string1 + " " + string2);
                    break;
                }
                else
                {
                    Console.WriteLine(string2 + " " + string1);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
