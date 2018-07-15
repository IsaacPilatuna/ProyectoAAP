using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosG4
{
    class ReporteConductor
    {
        private String cedula, nombreCompleto, descripcion, dineroCombustible, comportamientoPasajeros;
        private bool inconveniente;

        public ReporteConductor(String cedula, String nombreCompleto, String descripcion, bool inconveniente, String dineroCombustible, String comportamientoPasajeros) {
            this.cedula = cedula;
            this.nombreCompleto = nombreCompleto;
            this.descripcion = descripcion;
            this.dineroCombustible = dineroCombustible;
            this.comportamientoPasajeros = comportamientoPasajeros;
        }

        public override string ToString()
        {
            return cedula+","+nombreCompleto + "," +descripcion + "," +inconveniente + "," +dineroCombustible+","+comportamientoPasajeros;
        }

    }
}
