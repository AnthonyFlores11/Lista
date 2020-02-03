using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGenerica.Clases
{
    class Netflix : Reproductores

       
    {
        public int idNetflix;
        public String nombreNetflix;

        public String NombreNetflix { get; set; }
        public int IdNEtflix { get; set; }

        public Netflix(int idNetflix, string nombreNetflix)
        {
            this.idNetflix = idNetflix;
            this.nombreNetflix = nombreNetflix;
        }
        public Netflix()
        {

        }
        public String Pelicula()
        {
            return string.Format("La pelicula se inicio en:", idNetflix, nombreNetflix);
        }
    }
}
