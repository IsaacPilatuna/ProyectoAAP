using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosG4
{
    class EscribirArchivo
    {

        public EscribirArchivo() { }


        public void escribirPersona(HashSet<SolicitudDeViaje> viajes)
        {

            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Cristian Betancourt\source\repos\ProyectoAAP\ModulosG4\ModulosG4\Archivos\Persona.txt");
                foreach (SolicitudDeViaje viaje in viajes)
                {
                    sw.WriteLine(viajes.ToString());

                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
