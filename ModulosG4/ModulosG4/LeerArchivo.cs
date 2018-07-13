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
        public String leerViaje()
        {
            string viajes = "";
            string linea = "";
            StreamReader objReader = new StreamReader(@"C:\Users\Cristian Betancourt\source\repos\ProyectoAAP\ModulosG4\ModulosG4\Archivos\Viaje.txt");

            while (linea != null)
            {
                linea = objReader.ReadLine();
                try
                {
                    if (linea != null)
                    {
                        viajes += linea;
                    }
                }
                catch (Exception e)
                {
                    return "";
                }
            }
            objReader.Close();
            return viajes;

        }
    }
}
