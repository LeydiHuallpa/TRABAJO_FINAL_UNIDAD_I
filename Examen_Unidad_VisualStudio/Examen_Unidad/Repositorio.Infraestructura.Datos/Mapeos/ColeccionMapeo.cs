using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;
namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class ColeccionMapeo : EntityTypeConfiguration<ClsColeccion>
    {
        
        public ColeccionMapeo()
        {
            ToTable("TBL_COLECCION");
            HasKey(p => p.idcoleccion);
            Property(p => p.idcoleccion).HasColumnName("ID_COLECCION");
            Property(p => p.nombre_coleccion).HasColumnName("NOM_COLECCION").HasMaxLength(100);
            Property(p => p.idsubcomunidad).HasColumnName("ID_SUBCOMUNIDAD");

            HasRequired(m => m.subcomunidad).WithMany().HasForeignKey(f => f.idsubcomunidad);
        }
    }
}
