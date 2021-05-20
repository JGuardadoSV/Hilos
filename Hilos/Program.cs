using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread hilo1 = new Thread(ImprimirY);
            hilo1.Start();

            Thread hilo2 = new Thread(ImprimirX);
            hilo2.Start();

            //ImprimirX();
          //  ImprimirY();

        }

        static void ImprimirY()
        {
            int contador = 1;
            while (contador<100000)
            {
                Console.Write("Y");
                contador++;
            }
        }

        static void ImprimirX()
        {
            int contador = 1;
            while (contador < 100000)
            {
                Console.Write("X");
                contador++;
            }

        }
    }
}
