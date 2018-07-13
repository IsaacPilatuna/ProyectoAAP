using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosG4
{
    class LeerArchivo
    {
        Persona persona;
        public HashSet<Persona> leerPersona() {
            string[] datos;
            HashSet<Persona> personas = new HashSet<Persona>();
            persona =  = new Persona();
            string linea = "";

            StreamReader objReader = new StreamReader(@"C:\Users\Cristian Betancourt\source\repos\ProyectoAAP\ModulosG4\ModulosG4\Archivos\Persona.txt");

            while (linea != null)
            {
                datos = new String[3];
                linea = objReader.ReadLine();
                try
                {
                    if (linea != null)
                    {
                        persona = new Persona();
                        datos = linea.Split(',');
                        persona.nombreDeCedula(datos[0]);
                        persona.nombres(datos[1]);
                        persona.apellidos(datos[2]);
                        personas.Add(persona);
                    }
                }
                catch (Exception e) {
                    return new HashSet<Persona>();
                }
            }
            objReader.Close();
            return personas;

        }
    }
}
