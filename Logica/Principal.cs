using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        public List<Envio> Envios { get; set; }
        public List<Destinatario> Destinatarios { get; set; }
        public List<Repartidor> Repartidores { get; set; }

        public bool AltaEnvio(string dniDestinatario, DateTime fechaEstimadaEntrega, string descripcion)
        {
            Destinatario destinatario = Destinatarios.Find(x => x.DNI == dniDestinatario);
            if (destinatario != null)
            {
                if (destinatario.Telefono != null)
                {
                    Envio envio = new Envio()
                    {
                        ID = Envios.Count + 1,
                        Destinatario = destinatario,
                        EstadoPaquete = Envio.Estado.PENDIENTE,
                        FechaEstimadaEntrega = fechaEstimadaEntrega,
                        Descripcion = descripcion
                    };

                }
            }
            return false;
        }

        public bool ActualizarEnvio(int codigoSeguimiento, string estadoActual)
        {
            Envio envio = Envios.Find(x => x.ID == codigoSeguimiento);
            if (envio != null)
            {
                if (Enum.IsDefined(typeof(Envio.Estado), estadoActual))
                {
                    Envio.Estado estado = (Envio.Estado)Enum.Parse(typeof(Envio.Estado), estadoActual);
                    if (estado == Envio.Estado.ENTREGADO)
                    {
                        envio.EstadoPaquete = estado;
                        envio.FechaEntrega = DateTime.Now;

                    }
                }
            }
            return false;
        }

        public Repartidor AsignarRepartidor(Envio envio)
        {

        }


    }
}
