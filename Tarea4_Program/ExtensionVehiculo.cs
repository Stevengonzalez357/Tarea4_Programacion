using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4_Program
{
    public static class ExtensionVehiculo
    {
        // Metodo de extension para formatear la informacion

        public static string MostrarInformacion(this Vehiculo vehiculo)
        {
            return
            $"Modelo: {vehiculo.Modelo}, Precio por dia: {vehiculo.Precio:C}";
        }
    }
}
