using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class Planes
    {
        public static Planes instancia;

        public static Planes obtener_instancia()
        {
            if (instancia == null)
            {
                instancia = new Planes();
            }
            return instancia;
        }
        MODELO.ISP oISP;

        private Planes()
        {
            oISP = MODELO.ISP.Obtener_instancia();
        }
    }
}
