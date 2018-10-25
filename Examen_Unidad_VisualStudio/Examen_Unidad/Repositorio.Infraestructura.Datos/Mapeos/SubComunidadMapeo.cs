using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class SubComunidadMapeo :EntityTypeConfiguration<ClsSubComunidad>
    {
        public SubComunidadMapeo()
        {
            ToTable("TBL_SUBCOMUNIDAD");
            HasKey(p => p.idsubcomunidad);
            Property(p => p.idsubcomunidad).HasColumnName("ID_SUBCOMUNIDAD");
            Property(p => p.nombresubcomunidad).HasColumnName("NOM_SUBCOMUNIDAD");

            Property(p => p.idcomunidad).HasColumnName("ID_COMUNIDAD");

            HasRequired(m => m.subcomunidad).WithMany().HasForeignKey(f => f.idcomunidad);
        }
    }
}
