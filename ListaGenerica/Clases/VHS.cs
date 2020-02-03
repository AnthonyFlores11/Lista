using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGenerica.Clases
{
    class VHS : Reproductores
    {
        public int idVHS;
        public String nombreVHS;

        public string NombreVHS { get; set; }
        public int IdVHS { get; set; }

        public VHS(int idVHS, string nombreVHS)
        {
            this.idVHS = idVHS;
            this.nombreVHS = nombreVHS;
        }
        public VHS()
        {

        }

        public String Pelicula()
        {
            return string.Format("La pelicula se inicio en:", idVHS, nombreVHS);
        }
    }
}
