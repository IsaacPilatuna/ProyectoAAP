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


        public void escribirPersona(HashSet<Persona> personas)
        {

            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Cristian Betancourt\source\repos\ProyectoAAP\ModulosG4\ModulosG4\Archivos\Persona.txt");
                foreach (Persona persona in personas)
                {
                    sw.WriteLine(persona.ToString());

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
