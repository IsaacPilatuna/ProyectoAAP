using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosG4
{
    class SolicitudDeViaje
    {
        private String ciSolicitante, nombreSolicitante, destino, conductor,fechaSalida, horaSalida, fechaLlegada, horaLlegada, motivo;
    
        public SolicitudDeViaje(String ciSolicitante, String nombreSolicitante, String destino, String conductor, String fechaSalida, String horaSalida, String fechaLlegada, String horaLlegada, String motivo) {
            this.ciSolicitante = ciSolicitante;
            this.nombreSolicitante = nombreSolicitante;
            this.destino = destino;
            this.conductor = conductor;
            this.fechaSalida = fechaSalida;
            this.horaSalida = horaSalida;
            this.fechaLlegada = fechaLlegada;
            this.horaLlegada = horaLlegada;
            this.motivo = motivo;
         }
        public override String ToString() {
            return (ciSolicitante+","+nombreSolicitante + "," +destino + "," +conductor + "," + fechaSalida + "," +horaSalida + ","+fechaLlegada+","+horaLlegada+","+motivo);
        }
        
    }

   

    
}
