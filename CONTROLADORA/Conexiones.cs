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
using CONTROLADORA;

namespace CONTROLADORA
{    
   public class Conexiones
    {
        //Referencia a instancia para buscar la conexion 
        CONTROLADORA.Mikorotik_conexion oCONEXION;



        public List<IpDhcpServer> listDHCP()
        {
            oCONEXION = Mikorotik_conexion.OBTENER_INSTANCIA();
           var lista =  oCONEXION.connection.LoadList<IpDhcpServer>();
            
            return lista.ToList<IpDhcpServer>();
        }

    }
}
