using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Ejercicio_1.Models
{
    internal class Ortoedro
    {
        private Rectangulo[] Laterales = new Rectangulo[4];
        private Rectangulo[] Bases = new Rectangulo[2];
        public Ortoedro(double anchoBase, double ladoComun, double largoLateral)
        {
            Bases[0] = new Rectangulo(ladoComun, anchoBase);
            Bases[1] = new Rectangulo(ladoComun, anchoBase);
            Laterales[0] = new Rectangulo(ladoComun, largoLateral);
            Laterales[1] = new Rectangulo(ladoComun, largoLateral);
            Laterales[2] = new Rectangulo(ladoComun, largoLateral);
            Laterales[3] = new Rectangulo(ladoComun, largoLateral);

        }


        public double CalcularArea()
        {
            double area = Bases[0].CalcularArea() * 2 + Laterales[0].CalcularArea() * 4;
            return area;

        }
        public double CalcularVolumen()
        {
            double volumen = Bases[0].CalcularArea() * Laterales[0].largo;
            return volumen;
        }
        public string Describir()
        {                  
            return $@"tipo: ortoedro 
            voluen:{CalcularVolumen()}  
            area:{CalcularArea()}";
        }
    }
}
