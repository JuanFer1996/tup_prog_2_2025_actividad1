using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Rectangulo
    {
        public double ancho { get; set; }
        public double largo { get; set; }

        public Rectangulo(double ancho, double largo)
        {
            this.ancho = ancho;
            this.largo = largo;
        }
        public double CalcularArea() 
        {
            double area = 0;
            area=ancho*largo;
            return area;

        }
        public string Describir() 
        {
            string json = $@"
            {{
                ""lado"":{this.largo},
               ""ancho"":{this.ancho}
            }}
            ";
            return json;
        }
    }
}
