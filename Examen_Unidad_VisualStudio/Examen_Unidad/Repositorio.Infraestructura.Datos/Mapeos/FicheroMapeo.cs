using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class FicheroMapeo : EntityTypeConfiguration<ClsFichero>
    {
        public FicheroMapeo()
        {
            ToTable("TBL_FICHERO");
            HasKey(p => p.idfichero);
            Property(p => p.idfichero).HasColumnName("ID_FICHERO");
            Property(p => p.link).HasColumnName("LINK").HasMaxLength(100);
            Property(p => p.descripcion).HasColumnName("DESCRIPCION").HasMaxLength(100);
            Property(p => p.tamaño).HasColumnName("TAMAÑO").HasMaxLength(100);
            Property(p => p.formato).HasColumnName("FORMATO").HasMaxLength(100);

        }
    }
}
