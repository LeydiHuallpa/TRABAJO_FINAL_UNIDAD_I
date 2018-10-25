using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio
{
    public class ClsItem_Metadato
    {
        public int iditem_metadato { get; private set; }

        public int idmetadato { get; private set; }
        public int iditem { get; private set; }

        public ClsMetaDato metadato { get; private set; }
        public ClsItem item { get; private set; }

        public ClsItem_Metadato ClsItem_Metadato1
        {
            get => default(ClsItem_Metadato);
            set
            {
            }
        }
    }
}
