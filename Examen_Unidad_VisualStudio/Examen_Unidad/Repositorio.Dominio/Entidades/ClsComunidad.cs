using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio
{
    public class ClsComunidad
    {
        public int idcomunidad { get;  set; }
        public string nombrecomunidad { get;  set; }

        public ClsSubComunidad ClsSubComunidad
        {
            get => default(ClsSubComunidad);
            set
            {
            }
        }

        public ClsComunidad RegistrarComunidad (int asidcomunidad,string asnombrecomunidad)
        {
            return new ClsComunidad()
            {
                idcomunidad = asidcomunidad,
                nombrecomunidad = asnombrecomunidad
            };
        }

        public ClsComunidad CambiarComunidad(string asNuevonombrecomunidad)
        {
            return new ClsComunidad()
            {
                nombrecomunidad = asNuevonombrecomunidad
            };
        }
        
    }
}
