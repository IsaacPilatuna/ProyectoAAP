using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosG4
{
    class SolicitudDeViaje
    {
        private String ciSolicitante, nombreSolicitante, destino, conductor;
        private DateTime fechaSalida, fechaLlegada;

        public SolicitudDeViaje(String ciSolicitante, String nombreSolicitante, String destino, String conductor, DateTime fechaSalida, DateTime fechaLlegada) {
            this.ciSolicitante = ciSolicitante;
            this.nombreSolicitante = nombreSolicitante;
            this.destino = destino;
            this.conductor = conductor;
            this.fechaSalida = fechaSalida;
        }
        public override String ToString() {
            return ciSolicitante+","+nombreSolicitante + "," +destino + "," +conductor + ",";
        }
        
    }

   

    
}
