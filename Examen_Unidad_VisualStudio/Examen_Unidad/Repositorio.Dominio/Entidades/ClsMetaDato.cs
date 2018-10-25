using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio
{
    public class ClsMetaDato
    {
        public int idmetadato { get; private set; }

        public string campodc { get; private set; }

        public string valor { get; private set; }

        public string lenguaje { get; private set; }

        public ClsItem_Metadato ClsItem_Metadato
        {
            get => default(ClsItem_Metadato);
            set
            {
            }
        }

        public ClsMetaDato AgregarMedatados(string ascampodc , string asvalor, string aslenguaje) {

            return new ClsMetaDato {
                campodc=ascampodc,
                valor=asvalor,
                lenguaje= aslenguaje
            };
        }
    }
}
