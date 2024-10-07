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

        public class descuento
        {
            public static double AplicarDescuento(double precio, double porcentajeDescuento)
            {
                if (porcentajeDescuento < 0 || porcentajeDescuento > 100)
                    throw new ArgumentException("El porcentaje de descuento debe estar entre 0 y 100");

                return precio - (precio * (porcentajeDescuento / 100));

            }

        }
    }
}
