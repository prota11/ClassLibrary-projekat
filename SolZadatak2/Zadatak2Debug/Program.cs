using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Zadatak2Klasa.clsMath clsMath = new Zadatak2Klasa.clsMath();
                long[] rezultat = clsMath.GenFibonacci(10);
                foreach (long deo in rezultat)
                {
                    Console.WriteLine(deo);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
 
            Console.ReadKey();
        }
    }
}
