using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tik4net.Api;
using tik4net.Objects;
using tik4net.Objects.Ip;
using tik4net.Objects.Ip.Dns;
using tik4net.Objects.Ip.Firewall;
using tik4net.Objects.Queue;
using tik4net.Objects.System;
using tik4net;

namespace CONTROLADORA
{
    public class Mikorotik_conexion
    {
       public ITikConnection connection = ConnectionFactory.OpenConnection(TikConnectionType.Api, ConfigurationManager.AppSettings["host"], ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["pass"]);
        public static Mikorotik_conexion instancia;
        public static Mikorotik_conexion OBTENER_INSTANCIA()
        {
            

            if (instancia== null)
            {

                instancia = new Mikorotik_conexion();
              
            }
            return instancia;

        }

    }
}
