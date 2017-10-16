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
    class Conexiones
    {
        public ITikConnection connection = ConnectionFactory.CreateConnection(TikConnectionType.Api);


        public void iniciar()
        {
            connection.Open(ConfigurationManager.AppSettings["host"], ConfigurationManager.AppSettings["user"], ConfigurationManager.AppSettings["pass"]);

            var interfaces = connection.LoadAll<Interface>();
        }




    }
}
