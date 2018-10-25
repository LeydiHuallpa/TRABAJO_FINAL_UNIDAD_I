﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Dominio
{
    public class ClsBusqueda
    {
        public int idbusqueda { get; private set; }

        public int idusuario { get; private set; }
        public int iditem { get; private set; }
        public ClsUsuario usuario { get; private set; }
        public ClsItem item { get; private set; }
    }
}
