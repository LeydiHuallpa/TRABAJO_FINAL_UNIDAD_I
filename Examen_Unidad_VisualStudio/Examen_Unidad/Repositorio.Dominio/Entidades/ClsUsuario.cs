using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Net;
using System.Net.NetworkInformation;

namespace Repositorio.Dominio
{
    public class ClsUsuario
    {
      

        public int idusuario { get; private set; }

        public string nombreusuario { get; private set; }
        public string direccionip { get; private set; }
        public string pais { get; private set; }

        public ClsBusqueda ClsBusqueda
        {
            get => default(ClsBusqueda);
            set
            {
            }
        }

        public ClsUsuario()
        {

        }

        public string ObtenerIP(string direccionip)
        {
            string strIP = "";
            string strHostName = string.Empty;

            strHostName = Dns.GetHostName();

            IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);

            for (int i=0; i<hostIPs.Length;i++)
            {
                strIP = hostIPs[i].ToString();
            }
            return strIP;
            
        }
        public  ClsUsuario RegistrarUsuario (int asidusuario, string asnombreusuario,string asdireccionip, string aspais)
        {
            return new ClsUsuario()
            {
                idusuario = asidusuario,
                nombreusuario = asnombreusuario,
                direccionip = asdireccionip,
                pais = aspais
            };
        }




      
    }
}
