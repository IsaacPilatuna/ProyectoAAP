using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosG4
{
    class Persona
    {
        private String numeroDeCedula { get; set; }
        private String nombres { get; set; }
        private String apellidos { get; set; }

        private String obtenerNombreCompleto()
        {
            return nombres + " " + apellidos;
        }

        public override String ToString() {
            return numeroDeCedula + "," + nombres + "," + apellidos;
        }

    }
}
