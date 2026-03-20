using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDatosPrueba;
using CapaNegocio;

namespace PruebasUnitarias
{
    [TestClass]
    public sealed class LogicaTest
    {
        Logica logica = new Logica(new DatosMemoria());

        [TestMethod]
        public void probarPlazoFueraDeRango()
        {
            var solicitud = new SolicitudCredito("CC", "1234568700", 1000, 200, 5000, 0); // plazo 0
            var resultado = logica.PreaprobarCredito(solicitud);
            Assert.IsFalse(resultado.aprobado);
        }

        [TestMethod]
        public void probarBalanzaNegativa()
        {
            var solicitud = new SolicitudCredito("CC", "1234568700", 1000, 2000, 10000, 12);
            var resultado = logica.PreaprobarCredito(solicitud);
            Assert.IsFalse(resultado.aprobado);
        }

        [TestMethod]
        public void probarRelacionAlta_Requiere800_Aprobado()
        {
            // Usamos documento con puntaje 800 (ver DatosMemoria)
            // Construimos una solicitud con relacion alta
            var solicitud = new SolicitudCredito("CC", "15345116", 1000, 100, 50000, 12);
            var resultado = logica.PreaprobarCredito(solicitud);
            Assert.IsTrue(resultado.aprobado);
        }

        [TestMethod]
        public void probarRelacionAlta_Requiere800_Rechazado()
        {
            // Documento con puntaje 700
            var solicitud = new SolicitudCredito("CC", "1017927400", 1000, 100, 50000, 12);
            var resultado = logica.PreaprobarCredito(solicitud);
            Assert.IsFalse(resultado.aprobado);
        }

        [TestMethod]
        public void probarRelacionBaja_AprobadoSinConsulta()
        {
            // relacion baja => aprobar sin consultar
            var solicitud = new SolicitudCredito("CC", "1234568700", 10000, 100, 1000, 12);
            var resultado = logica.PreaprobarCredito(solicitud);
            Assert.IsTrue(resultado.aprobado);
        }
    }
}
