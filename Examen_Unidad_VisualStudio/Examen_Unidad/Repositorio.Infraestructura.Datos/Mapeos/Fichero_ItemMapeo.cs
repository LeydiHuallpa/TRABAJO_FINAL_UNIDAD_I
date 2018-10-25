using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class Fichero_ItemMapeo : EntityTypeConfiguration<ClsFichero_Item>
    {
        public Fichero_ItemMapeo()
        {
            ToTable("TBL_FICHERO_ITEM");
            HasKey(p => p.idfichero_item);

            Property(p => p.iditem).HasColumnName("ID_ITEM");
            Property(p => p.idfichero).HasColumnName("ID_FICHERO");

            HasRequired(m => m.item).WithMany().HasForeignKey(f => f.iditem);
            HasRequired(m => m.fichero).WithMany().HasForeignKey(f => f.idfichero);
        }
    }
}
