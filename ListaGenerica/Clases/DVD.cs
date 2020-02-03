using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGenerica.Clases
{
    class DVD : Reproductores
    {
        public int idDVD;
        public String nombreDVD;

        public String NombreDVD { get; set; }
        public int IdDVD { get; set; }

        public DVD(int idDVD, string nombreDVD)
        {
            this.idDVD = idDVD;
            this.nombreDVD = nombreDVD;
        }
        public DVD()
        {

        }
        public String Pelicula()
        {
            return string.Format("La pelicula se inicio en:", idDVD, nombreDVD);
        }
    }
}
