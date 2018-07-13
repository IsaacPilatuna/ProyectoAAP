using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosG4  
{
    [Serializable]
    class ListaSolicitudes : List<solicitudDeViaje>
    {
        public ListaSolicitudes() { }

    }
    class solicitudDeViaje
    {
        public String cedula, nombreSolicitante, destino, conductor, motivo;
        DateTime tiempoSalida, tiempoRetorno;
        public solicitudDeViaje(String cedula, String nombre, String destino, String conductor, DateTime tiempoSalida, DateTime tiempoRetorno, String motivoViaje)
        {
            this.cedula = cedula;
            this.nombreSolicitante = nombre;
            this.destino = destino;
            this.conductor = conductor;
            this.tiempoRetorno = tiempoRetorno;
            this.tiempoSalida = tiempoSalida;
        }

        public override String ToString() {
            return ""+cedula + " " + nombreSolicitante + " " + destino + " " + conductor + " " + tiempoRetorno + " " + tiempoSalida;
        }
    }
}
