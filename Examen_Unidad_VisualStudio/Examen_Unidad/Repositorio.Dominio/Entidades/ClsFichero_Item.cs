using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio
{
    public class ClsFichero_Item
    {
        public int idfichero_item { get; private set; }
        public int iditem { get; private set; }
        public int idfichero { get; private set; }

        public ClsItem item { get; private set; }

        public ClsFichero fichero { get; private set; }

    }
}
