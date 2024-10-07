using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4_Program
{
    public class Vehiculo
    {
        public String Modelo { get; set; }

        public double Precio { get; set; }


        public Vehiculo(String modelo, double precio)
        {
            Modelo = modelo;
            Precio = precio;
        }
    }
}
