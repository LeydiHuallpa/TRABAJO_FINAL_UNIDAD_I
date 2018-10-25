using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class PalabrasClaveMapeo : EntityTypeConfiguration <ClsPalabrasClave>
    {
        public PalabrasClaveMapeo()
        {
            ToTable("TBL_PALABRA_CLAVE");
            HasKey(p => p.idpalabraclave);
            Property(p => p.idpalabraclave).HasColumnName("ID_PALABRA_CLAVE");

            Property(p => p.nombrepalabraclave).HasColumnName("NOMBRE_PALABRA").HasMaxLength(100);            
        }

    }
}
