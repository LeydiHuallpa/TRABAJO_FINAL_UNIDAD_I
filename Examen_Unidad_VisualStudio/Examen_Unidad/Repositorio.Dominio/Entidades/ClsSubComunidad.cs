using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio
{
    public class ClsSubComunidad
    {
        public int idsubcomunidad { get; private set; }
        public string nombresubcomunidad { get; private set; }

        public int idcomunidad { get; private set; }
        public ClsComunidad comunidad { get; private set; }

        public ClsColeccion ClsColeccion
        {
            get => default(ClsColeccion);
            set
            {
            }
        }

        public ClsSubComunidad CrearSubcomunidad(string asnombresubcomunidad, int asidcomunidad) {

            return new ClsSubComunidad() {
                nombresubcomunidad = asnombresubcomunidad,
                idcomunidad = asidcomunidad
            };
        }
    }
}
