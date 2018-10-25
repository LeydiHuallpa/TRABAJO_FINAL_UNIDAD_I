using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Repositorio.Dominio;
using Repositorio.Infraestructura.Datos.Mapeos;

namespace Repositorio.Infraestructura.Datos.Contexto
{
    public class RepositorioContexto : DbContext 
    {
        public RepositorioContexto(): base("bdRepositorioUPT")
        {

        }
        public DbSet<ClsAutor> Autores { get; set; }
        public DbSet<ClsBusqueda> Busquedas { get; set; }
        public DbSet<ClsColeccion> Colecciones { get; set; }
        public DbSet<ClsComunidad> Comunidades { get; set; }
        public DbSet<ClsFichero> Ficheros { get; set; }
        public DbSet<ClsFichero_Item> Ficheros_Items { get; set; }
        public DbSet<ClsItem> Items { get; set; }
        public DbSet<ClsItem_Autor> Items_Autores { get; set; }
        public DbSet<ClsItem_Metadato> Items_Metadatos { get; set; }
        public DbSet<ClsMetaDato> Metadatos { get; set; }
        public DbSet<ClsPalabrasClave> PalabrasClaves { get; set; }
        public DbSet<ClsPalabrasClave_Item> PalabrasClaves_Items { get; set; }
        public DbSet<ClsSubComunidad> SubComunidades { get; set; }
        public DbSet<ClsUsuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AutorMapeo());
            modelBuilder.Configurations.Add(new BusquedaMapeo());
            modelBuilder.Configurations.Add(new ColeccionMapeo());
            modelBuilder.Configurations.Add(new ComunidadMapeo());
            modelBuilder.Configurations.Add(new Fichero_ItemMapeo());
            modelBuilder.Configurations.Add(new FicheroMapeo());
            modelBuilder.Configurations.Add(new Item_AutorMapeo());
            modelBuilder.Configurations.Add(new Item_MetadatoMapeo());
            modelBuilder.Configurations.Add(new ItemMapeo());
            modelBuilder.Configurations.Add(new MetadatoMapeo());
            modelBuilder.Configurations.Add(new PalabrasClave_ItemMapeo());
            modelBuilder.Configurations.Add(new PalabrasClaveMapeo());
            modelBuilder.Configurations.Add(new SubComunidadMapeo());
            modelBuilder.Configurations.Add(new UsuarioMapeo());
        }


    }
}
