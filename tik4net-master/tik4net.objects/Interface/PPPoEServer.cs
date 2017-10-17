using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tik4net.Objects.Interface
{ /// <summary>
  /// /ppp/secret: IP addresses serve for a general host identification purposes in IP networks. Typical (IPv4) address consists of four octets. For proper addressing the router also needs the network mask value, id est which bits of the complete IP address refer to the address of the host, and which - to the address of the network. The network address value is calculated by binary AND operation from network mask and IP address values. It's also possible to specify IP address followed by slash "/" and the amount of bits that form the network address. 
  /// </summary>
    [TikEntity("/ppp/secret", IncludeDetails = true)]
    public class PPPoEServer
    {

        /// <summary>
        /// Row .id property.
        /// </summary>
        [TikProperty(".id", IsReadOnly = true, IsMandatory = true)]
        public string Id { get; private set; }

        [TikProperty("service", IsReadOnly = true, IsMandatory = true)]
        public string Service { get; private set; }


        [TikProperty("name", IsReadOnly = true, IsMandatory = true)]
        public string Nombre { get; private set; }

        [TikProperty("profile", IsReadOnly = true, IsMandatory = true)]
        public string Perfil { get; private set; }







    }
}
