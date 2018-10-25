using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio
{
    public class ClsItem
    {
        public int iditem { get; private set; }
        public string titulo { get; private set; }
        public DateTime fechapublicacion { get; private set; }
        public string editorial { get; private set; }
        public string resumen { get; private set; }
        public string uri { get; private set; }

        public int idcoleccion { get; private set; }
        public ClsColeccion coleccion { get; private set; }
    }
}
