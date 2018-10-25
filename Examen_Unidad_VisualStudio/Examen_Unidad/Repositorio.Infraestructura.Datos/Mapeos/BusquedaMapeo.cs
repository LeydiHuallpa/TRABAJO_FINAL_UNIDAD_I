
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;

namespace Repositorio.Infraestructura.Datos.Mapeos
{
    public class BusquedaMapeo : EntityTypeConfiguration<ClsBusqueda>
    {
        public BusquedaMapeo()
        {
            ToTable("TBL_BUSQUEDA");
            HasKey(p => p.idbusqueda);
            Property(p => p.idbusqueda).HasColumnName("ID_BUSQUEDA");
            
            Property(p => p.idusuario).HasColumnName("ID_USUARIO");
            Property(p => p.iditem).HasColumnName("ID_ITEM");

            HasRequired(m => m.usuario).WithMany().HasForeignKey(f => f.idusuario);
            HasRequired(m => m.item).WithMany().HasForeignKey(f => f.iditem);
        }
    }
}
