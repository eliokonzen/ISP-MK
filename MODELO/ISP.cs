namespace MODELO
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    public class ISP : DbContext
    {
        public static ISP instancia;
        public static ISP Obtener_instancia()
        {
            if (instancia == null)
            {
                instancia = new ISP();
            }
            return instancia;
        }

        public ISP()

            : base("name=Empresa")
        {
        }

    }
}
