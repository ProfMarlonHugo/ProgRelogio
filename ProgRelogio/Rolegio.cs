using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgRelogio
{
    class Relogio
    {
        private double segundos;

        /*Construtor*/
        public Relogio(double seg)
        {
            segundos = seg;
        }

        public double Segundos
        {
            get { return segundos; }
            set
            {
                if (value == 0)
                    System.Console.WriteLine("Segundos não pode ser zero.");
                segundos = value;
            }
        }

        public double Minuto
        {
            get;
            set;
        }

        public double Hora
        {
            get { return segundos / 3600; }
            set
            {
                if (value <= 1 && value >= 24)
                    System.Console.WriteLine("Valor deve ser entre 1 e 24");
                segundos = value * 3600;
            }
        }
    }
}



