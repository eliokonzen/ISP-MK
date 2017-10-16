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
    public class conexionTIK4NET
    {
       public ITikConnection connection = ConnectionFactory.OpenConnection(TikConnectionType.Api, ConfigurationManager.AppSettings["host"], ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["pass"]);
        public static conexionTIK4NET instancia;
        public static conexionTIK4NET tik4netINSTANCIA()
        {
            

            if (instancia== null)
            {

                instancia = new conexionTIK4NET();
               // connection.Open(ConfigurationManager.AppSettings["host"], ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["pass"]);
            }
            return instancia;

        }

          
        
        public List<IpAddress> listar()
        {
            var ss = connection.LoadList<IpAddress>();
            return ss.ToList<IpAddress>();
        }
        


    }
}
