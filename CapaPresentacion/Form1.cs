using System;
using System.Windows.Forms;
using CapaAccesoDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {

        Logica logica = new Logica(new ConexionSQLServer());

        public Form1()
        {
            InitializeComponent();
            // Inicialización mínima. Los controles añadidos en Designer se usan para la solicitud de crédito.
        }
        

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Leer y validar inputs
            string tipoDoc = tbTipoDoc.Text.Trim();
            string nroDoc = tbNroDoc.Text.Trim();
            if (tipoDoc == "" || nroDoc == "")
            {
                MessageBox.Show(this, "Tipo y número de documento son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(tbIngresos.Text.Trim(), out double ingresos))
            {
                MessageBox.Show(this, "Ingrese un valor numérico válido para Ingresos Totales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(tbEgresos.Text.Trim(), out double egresos))
            {
                MessageBox.Show(this, "Ingrese un valor numérico válido para Egresos Totales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(tbMonto.Text.Trim(), out double monto))
            {
                MessageBox.Show(this, "Ingrese un valor numérico válido para Monto Solicitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbPlazo.Text.Trim(), out int plazo))
            {
                MessageBox.Show(this, "Ingrese un valor entero válido para Plazo (meses)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var solicitud = new SolicitudCredito(tipoDoc, nroDoc, ingresos, egresos, monto, plazo);

            var resultado = logica.PreaprobarCredito(solicitud);

            if (resultado.aprobado)
            {
                MessageBox.Show(this, "CRÉDITO APROBADO: " + resultado.mensaje, "Aprobación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "CRÉDITO RECHAZADO: " + resultado.mensaje, "Rechazo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
