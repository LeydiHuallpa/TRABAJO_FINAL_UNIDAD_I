using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class AutorMapeo : EntityTypeConfiguration <ClsAutor>
    {
        public AutorMapeo()
        {
            ToTable("TBL_AUTOR");
            HasKey(p => p.idautor);
          
            
            Property(p => p.idautor).HasColumnName("ID_AUTOR");
            Property(p => p.nombreautor).HasColumnName("NOMBRE_AUTOR").HasMaxLength(100);
        }
    }
}
