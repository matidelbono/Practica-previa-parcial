using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Envio
    {
        public Random NumeroAleatorioEnvio { get; set; }
        public Destinatario Destinatario { get; set; }
        public Repartidor Repartidor { get; set; }
        public int Estado { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEstimadaEntrega { get; set; }
        public DateTime FechaEntrega { get; set; }

    }
}
