using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio
{
    public class ClsPalabrasClave_Item
    {
        public int idpalabrasclave_item { get; private set; }

        public int idpalabraclave { get; private set; }
        public int iditem { get; private set; }
        public ClsPalabrasClave palabraclave { get; private set; }
        public ClsItem item { get; private set; }

        public ClsPalabrasClave_Item ClsPalabrasClave_Item1
        {
            get => default(ClsPalabrasClave_Item);
            set
            {
            }
        }
    }
}
