using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;
namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class ComunidadMapeo : EntityTypeConfiguration<ClsComunidad>
    {
        public ComunidadMapeo()
        {
            ToTable("TBL_COMUNIDAD");
            HasKey(p => p.idcomunidad);
            Property(p => p.idcomunidad).HasColumnName("ID_COMUNIDAD");
            Property(p => p.nombrecomunidad).HasColumnName("NOM_COMUNIDAD").HasMaxLength(100);
           

        }
    }
}
