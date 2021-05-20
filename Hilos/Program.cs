using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {

            ImprimirY();
            ImprimirX();

        }

        static void ImprimirY()
        {
            while (true)
            {
                Console.Write("Y");
            }
        }

        static void ImprimirX()
        {
            while (true)
            {
                Console.Write("X");

            }

        }
    }
}
