using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4_Program
{
    public static class CalcularReserva
    {
        //Metodo para calcular el costo total de reserva

        public static double CalcularCostoTotal(Vehiculo vehiculo, int dias)
        {
            if (dias <= 0)
                throw new ArgumentException("El numero de dias debe ser mayor que 0 ");

            return vehiculo.Precio * dias;

        }


    }
}
