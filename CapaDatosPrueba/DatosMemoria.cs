using CapaNegocio;
using System.Collections.Generic;
using System.Linq;

namespace CapaDatosPrueba
{
    public class DatosMemoria : IFuenteDeDatos
    {
        record Registro(string TipoDoc, string NroDoc, int Puntaje);

        List<Registro> datos;

        public DatosMemoria()
        {
            datos = new List<Registro>();

            // Datos de ejemplo en memoria (tipoDoc, nroDoc, puntaje)
            datos.Add(new Registro("CC", "1234568700", 563));
            datos.Add(new Registro("CC", "15345116", 800));
            datos.Add(new Registro("CC", "1017927400", 700));
            datos.Add(new Registro("TI", "1017927300", 350));
        }

        public int consultarPuntaje(string tipoDoc, string nroDoc)
        {
            var encontrado = datos.FirstOrDefault(d => d.TipoDoc == tipoDoc && d.NroDoc == nroDoc);
            return encontrado == null ? 0 : encontrado.Puntaje;
        }
    }
}
