using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgRelogio
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada = System.Convert.ToDouble(Console.ReadLine());
            Relogio R = new Relogio(entrada);

            double xx = R.Hora;
            System.Console.WriteLine(xx);

            System.Console.ReadKey();
        }
    }
}
