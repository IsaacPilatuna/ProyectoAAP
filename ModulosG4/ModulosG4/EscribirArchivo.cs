﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosG4
{
    class EscribirArchivo
    {
        private LeerArchivo lec_archivo;

        public EscribirArchivo() {
            lec_archivo = new LeerArchivo();
        }


        public void escribirViaje(SolicitudDeViaje viaje)
        {
            String viajes = lec_archivo.leerViaje(); 
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Cristian Betancourt\source\repos\ProyectoAAP\ModulosG4\ModulosG4\Archivos\Viaje.txt");
                sw.WriteLine(viajes);
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
