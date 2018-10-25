using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class MetadatoMapeo : EntityTypeConfiguration<ClsMetaDato>
    {
        public MetadatoMapeo()
        {
            ToTable("TBL_METADATO");
            HasKey(p => p.idmetadato);
            Property(p => p.idmetadato).HasColumnName("ID_METADATO");
            Property(p => p.campodc).HasColumnName("CAMPODC").HasMaxLength(100);
            Property(p => p.valor).HasColumnName("VALOR").HasMaxLength(1000);
            Property(p => p.lenguaje).HasColumnName("LENGUAJE").HasMaxLength(100);
        }
    }
}
