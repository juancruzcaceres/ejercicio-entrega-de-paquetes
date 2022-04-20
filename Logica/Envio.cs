using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Envio
    {
        public int ID { get; set; }
        public Destinatario Destinatario { get; set; }
        public Repartidor Repartidor { get; set; }
        public Estado EstadoPaquete { get; set; }
        public DateTime FechaEstimadaEntrega { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEntrega { get; set; }

        public enum Estado
        {
            PENDIENTE,
            ASIGNADO_REPARTIDOR,
            EN_CAMINO,
            ENTREGADO
        }
    }
}
