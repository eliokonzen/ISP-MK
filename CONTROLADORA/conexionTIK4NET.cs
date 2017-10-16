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
          public ITikConnection connection = ConnectionFactory.CreateConnection(TikConnectionType.Api);

        public List<IpAddress> listar()
        {
            connection.Open(ConfigurationManager.AppSettings["host"], ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["pass"]);
            var ss = connection.LoadList<IpAddress>();
            return ss.ToList<IpAddress>();
        }
        


    }
}
