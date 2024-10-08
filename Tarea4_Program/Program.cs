using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4_Program
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // Crear una instancia de Vehiculo

            Vehiculo vehiculo = new Vehiculo("Chevrolet Camaro", 100);

            // Aplicar descuento de 20%

            double PrecioConDesc = Vehiculo.descuento.AplicarDescuento(vehiculo.Precio, 20);
            vehiculo.Precio = PrecioConDesc;

            // Mostrar informacion formateada del vehiculo

            Console.WriteLine(vehiculo.MostrarInformacion());

            // Calcular el costo total de la reserva por 7 dias

            double costoTotal = CalcularReserva.CalcularCostoTotal(vehiculo, 7);

            Console.WriteLine($"Costo total por 7 dias: {costoTotal:C}");

        }

    }
}        
   
  