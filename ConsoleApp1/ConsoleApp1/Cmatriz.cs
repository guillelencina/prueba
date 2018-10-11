using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cmatriz
    {

        public double a;
        public double b;
        public double r;

        public void Suma()
        {
            r = a + b;

        }
        public void muestra()
        {
            Console.WriteLine("r={0},a={1},b={2}", r, a, b);
            Console.WriteLine("Adiós");
        }
        


    }
}
