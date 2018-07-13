using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosG4
{
    class Persona
    {
        private string numeroDeCedula1;

        public string GetnumeroDeCedula()
        {
            return numeroDeCedula1;
        }

        public void SetnumeroDeCedula(string value)
        {
            numeroDeCedula1 = value;
        }

        private string nombres1;

        public string Getnombres()
        {
            return nombres1;
        }

        public void Setnombres(string value)
        {
            nombres1 = value;
        }

        private string apellidos1;

        public string Getapellidos()
        {
            return apellidos1;
        }

        public void Setapellidos(string value)
        {
            apellidos1 = value;
        }

        private String obtenerNombreCompleto()
        {
            return Getnombres() + " " + Getapellidos();
        }


    }
}
