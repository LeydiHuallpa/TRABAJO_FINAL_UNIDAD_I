using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    class PalabrasClave_ItemMapeo : EntityTypeConfiguration<ClsPalabrasClave_Item>
    {
        public PalabrasClave_ItemMapeo()
        {
            ToTable("TBL_PALABRA_CLAVE_ITEM");
            HasKey(p => p.idpalabrasclave_item);
            Property(p => p.idpalabrasclave_item).HasColumnName("ID_PALABRA_CLAVE_ITEM");

            Property(p => p.idpalabraclave).HasColumnName("FEC_PALABRA_CLAVE");
            Property(p => p.iditem).HasColumnName("ID_LIBRO");

            HasRequired(m => m.palabraclave).WithMany().HasForeignKey(f => f.idpalabraclave);
            HasRequired(m => m.item).WithMany().HasForeignKey(f => f.iditem);
        }
    }
}
