using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class SolicitudCredito
    {
        public string TipoDoc { get; set; }
        public string NroDoc { get; set; }
        public double IngresosTotales { get; set; }
        public double EgresosTotales { get; set; }
        public double MontoSolicitado { get; set; }
        public int PlazoSolicitado { get; set; }

        public SolicitudCredito() { }

        public SolicitudCredito(string tipoDoc, string nroDoc, double ingresos, double egresos, double monto, int plazo)
        {
            TipoDoc = tipoDoc;
            NroDoc = nroDoc;
            IngresosTotales = ingresos;
            EgresosTotales = egresos;
            MontoSolicitado = monto;
            PlazoSolicitado = plazo;
        }
    }
}
