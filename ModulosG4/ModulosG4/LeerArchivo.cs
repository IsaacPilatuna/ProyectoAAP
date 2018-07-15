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
        public String leerViaje(String archivo)
        {
            string datos = "\n";
            string linea = "";
            StreamReader objReader = new StreamReader(@"C:\Users\Cristian Betancourt\source\repos\ProyectoAAP\ModulosG4\ModulosG4\Archivos\"+archivo+".txt");

            while (linea != null)
            {
                linea = objReader.ReadLine();
                try
                {
                    if (linea != null)
                    {
                        datos += (linea+"\n");
                    }
                }
                catch (Exception e)
                {
                    return "";
                }
            }
            objReader.Close();
            return datos;

        }
    }
}
