using System;
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
        private static void CreateOrUpdateAddressList(ITikConnection connection)
        {
            var existingAddressList = connection.LoadList<FirewallAddressList>(
                    connection.CreateParameter("list", "TEST-LIST"),
                    connection.CreateParameter("address", "192.168.1.20"))
                .SingleOrDefault();

            if (existingAddressList == null)
            {
                //Create
                var newAddressList = new FirewallAddressList()
                {
                    Address = "192.168.88.1",
                    List = "TEST-LIST",
                };
                connection.Save(newAddressList);
            }
            else
            {
                //Update
                existingAddressList.Comment = "Comment update: " + DateTime.Now.ToShortTimeString();

                connection.Save(existingAddressList);
            }
        }


    }
}
