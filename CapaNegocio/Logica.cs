using System;

namespace CapaNegocio
{
    public class Logica
    {
        private readonly IFuenteDeDatos fuenteDatos;

        public Logica(IFuenteDeDatos fuenteDatos)
        {
            this.fuenteDatos = fuenteDatos;
        }

        // Devuelve tupla con resultado y mensaje explicativo
        public (bool aprobado, string mensaje) PreaprobarCredito(SolicitudCredito solicitud)
        {
            // Regla: plazo entre 1 y 72 meses
            if (solicitud.PlazoSolicitado < 1 || solicitud.PlazoSolicitado > 72)
            {
                return (false, "Plazo solicitado fuera de rango (1-72)");
            }

            double balanza = solicitud.IngresosTotales - solicitud.EgresosTotales; // diferencia ingresos - egresos

            // Si la balanza es cero o negativa, negar
            if (balanza <= 0)
            {
                return (false, "Balanza insuficiente (ingresos - egresos <= 0)");
            }

            // relacionCreditoBalanza = (MontoSolicitado/PlazoSolicitado)/Balanza
            double relacion = (solicitud.MontoSolicitado / solicitud.PlazoSolicitado) / balanza;

            // Según umbrales consultamos la central de riesgo y validamos el puntaje
            if (relacion >= 0.95)
            {
                int puntaje = fuenteDatos.consultarPuntaje(solicitud.TipoDoc, solicitud.NroDoc);
                if (puntaje >= 800) return (true, $"Aprobado (puntaje {puntaje})");
                else return (false, $"Rechazado por puntaje ({puntaje})");
            }
            else if (relacion >= 0.7)
            {
                int puntaje = fuenteDatos.consultarPuntaje(solicitud.TipoDoc, solicitud.NroDoc);
                if (puntaje >= 600) return (true, $"Aprobado (puntaje {puntaje})");
                else return (false, $"Rechazado por puntaje ({puntaje})");
            }
            else if (relacion >= 0.4)
            {
                int puntaje = fuenteDatos.consultarPuntaje(solicitud.TipoDoc, solicitud.NroDoc);
                if (puntaje >= 400) return (true, $"Aprobado (puntaje {puntaje})");
                else return (false, $"Rechazado por puntaje ({puntaje})");
            }
            else
            {
                // relacion < 0.4 => riesgo bajo, aprobar sin consultar
                return (true, "Aprobado sin consultar (relacion < 0.4)");
            }
        }
    }
}
