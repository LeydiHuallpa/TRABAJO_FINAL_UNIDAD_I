using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio
{
    public class ClsColeccion
    {
        public int idcoleccion { get; private set; }

        public string nombre_coleccion { get; private set; }

        public int idsubcomunidad { get; private set; }

        public ClsSubComunidad subcomunidad { get; private set; }

        public ClsColeccion CrearColeccion(string asnombrecoleccion, int asidsubcomunidad)
        {

            return new ClsColeccion()
            {
                nombre_coleccion = asnombrecoleccion,
                idsubcomunidad = asidsubcomunidad
            };
        }
    }
}
