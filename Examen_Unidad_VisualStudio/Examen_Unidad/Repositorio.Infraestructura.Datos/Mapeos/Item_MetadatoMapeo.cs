using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class Item_MetadatoMapeo : EntityTypeConfiguration<ClsItem_Metadato>
    {
        public Item_MetadatoMapeo()
        {
            ToTable("TBL_ITEM_METADATO");
            HasKey(p => p.iditem_metadato);
            Property(p => p.iditem_metadato).HasColumnName("ID_ITEM_METADATO");
            Property(p => p.idmetadato).HasColumnName("ID_METADATO");
            Property(p => p.iditem).HasColumnName("ID_ITEM");

            HasRequired(m => m.metadato).WithMany().HasForeignKey(f => f.idmetadato);
            HasRequired(m => m.item).WithMany().HasForeignKey(f => f.iditem);
        }
    }
}
