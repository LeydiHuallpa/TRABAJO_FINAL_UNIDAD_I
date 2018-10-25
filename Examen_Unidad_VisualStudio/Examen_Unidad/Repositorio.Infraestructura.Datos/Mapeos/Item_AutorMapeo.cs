using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class Item_AutorMapeo : EntityTypeConfiguration<ClsItem_Autor>
    {
        public Item_AutorMapeo()
        {
            ToTable("TBL_ITEMA_UTOR");
            HasKey(p => p.iditem_autor);
            Property(p => p.iditem_autor).HasColumnName("ID_ITEM_AUTOR");

            Property(p => p.idautor).HasColumnName("ID_AUTOR");
            Property(p => p.iditem).HasColumnName("ID_ITEM");

            HasRequired(m => m.autor).WithMany().HasForeignKey(f => f.idautor);
            HasRequired(m => m.item).WithMany().HasForeignKey(f => f.iditem);
        }
    }
}
