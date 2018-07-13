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


        public void escribirViaje(SolicitudDeViaje viaje)
        {

            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Cristian Betancourt\source\repos\ProyectoAAP\ModulosG4\ModulosG4\Archivos\Viaje.txt");
                sw.WriteLine(viaje.ToString());
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
