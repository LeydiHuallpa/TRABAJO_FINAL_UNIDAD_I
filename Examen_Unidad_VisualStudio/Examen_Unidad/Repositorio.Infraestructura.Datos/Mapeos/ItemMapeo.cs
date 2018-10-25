using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class ItemMapeo : EntityTypeConfiguration<ClsItem>
    {
        public ItemMapeo()
        {
            ToTable("TBL_ITEM");
            HasKey(p => p.iditem);
            Property(p => p.iditem).HasColumnName("ID_ITEM");
            Property(p => p.titulo).HasColumnName("TITULO");
            Property(p => p.fechapublicacion).HasColumnName("FEC_PUBLICACION");
            Property(p => p.editorial).HasColumnName("EDITORIAL");
            Property(p => p.resumen).HasColumnName("RESUMEN");
            Property(p => p.uri).HasColumnName("URI");

            Property(p => p.idcoleccion).HasColumnName("ID_COLECCION");

            HasRequired(m => m.coleccion).WithMany().HasForeignKey(f => f.idcoleccion);

        }
    }
}
