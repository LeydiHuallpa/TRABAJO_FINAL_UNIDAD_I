using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio
{
    public class ClsItem_Autor
    {
        public int iditem_autor { get; private set; }

        public int idautor { get; private set; }
        public int iditem { get; private set; }
        public ClsAutor autor { get; private set; }
        public ClsItem item { get; private set; }
    }
}
