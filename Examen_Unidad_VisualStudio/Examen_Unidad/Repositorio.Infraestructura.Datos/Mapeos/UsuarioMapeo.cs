using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class UsuarioMapeo : EntityTypeConfiguration<ClsUsuario>
    {
        public UsuarioMapeo()
        {
            ToTable("TBL_USUARIO");
            HasKey(p => p.idusuario);
            Property(p => p.idusuario).HasColumnName("ID_USUARIO");
            Property(p => p.direccionip).HasColumnName("DIRECCION_IP").HasMaxLength(100);
            Property(p => p.pais).HasColumnName("PAIS").HasMaxLength(100);
        }
    }
}
