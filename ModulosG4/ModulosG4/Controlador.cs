using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ModulosG4
{
    [Serializable]
    class Controlador
    {
        ListaSolicitudes listaSol = new ListaSolicitudes();
        public Controlador() {
            ListaSolicitudes listaActual = Deserialize();
        }

        public void guardarInfo(String cedula, String nombre, String destino, String conductor, DateTime tiempoSalida, DateTime tiempoRetorno, String motivoViaje) {
            
        }
        public void escribriSe()
        {

            FileStream fs = new FileStream("solicitudes.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs,listaSol);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public ListaSolicitudes Deserialize()
        {
            ListaSolicitudes solicitudes = null;
            FileStream fs = new FileStream("solicitudes.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                solicitudes = (ListaSolicitudes)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
            //foreach (solicitudDeViaje sol in solicitudes)
            //{
            //    Console.WriteLine(sol.nombreSolicitante);
            //}
            return listaSol; 
        }

    }
    
}
