using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public interface IFuenteDeDatos
    {
        // Consulta el puntaje en la central de riesgo para un documento
        public int consultarPuntaje(string tipoDoc, string nroDoc);

    }
}
