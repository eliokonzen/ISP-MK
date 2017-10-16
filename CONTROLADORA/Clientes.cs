using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Clientes
    {
        public static Clientes instancia;

        public static Clientes obtener_instancia()
        {
            if (instancia == null)
            {
                instancia = new Clientes();
            }
            return instancia;
        }
        MODELO.ISP oISP;

        private Clientes()
        {
            oISP = MODELO.ISP.Obtener_instancia();
        }
    }
}
