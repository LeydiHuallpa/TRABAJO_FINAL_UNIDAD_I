using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio
{
    public class ClsPalabrasClave
    {
        public List<string> Errores { get; set; }

        public int idpalabraclave { get; private set; }

        public string nombrepalabraclave { get; private set; }

        public ClsPalabrasClave_Item ClsPalabrasClave_Item
        {
            get => default(ClsPalabrasClave_Item);
            set
            {
            }
        }

        public ClsPalabrasClave DarPalabraClave(string asnombrepalabraclave) {

            return new ClsPalabrasClave() {
                nombrepalabraclave = asnombrepalabraclave
            };
        }

       

      
    }
}
