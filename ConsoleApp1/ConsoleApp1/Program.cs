using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Cmatriz matriz1 = new Cmatriz();
            matriz1.a = 3;
            matriz1.b = 2;

            matriz1.muestra();

            matriz1.Suma();

            matriz1.muestra();
            matriz1.muestra();
        }
    }
}
