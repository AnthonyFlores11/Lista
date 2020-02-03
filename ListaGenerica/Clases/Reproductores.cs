using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGenerica.Clases
{
    class Reproductores
    {
        //public String Marca;
        //public String 
        public void Play()
        {
            Console.WriteLine("Play ---------> Inicia la pelicula");

        }
        public void Stop()
        {
            Console.WriteLine("Stop ---------> Se detiene la pelicula");

        }
        public void FW()
        {
            Console.WriteLine("FW -----------> Se adelanta la pelicula");
        }

        public void RW()
        {
            Console.WriteLine("RW -----------> Se devuelve la pelicula");
        }
    }
}
