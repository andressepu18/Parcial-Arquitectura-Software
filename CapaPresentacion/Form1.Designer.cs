using System;
using System.Windows.Forms;
using System.Drawing;

namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Controles para la solicitud de crédito
            labelTipoDoc = new Label();
            tbTipoDoc = new TextBox();
            labelNroDoc = new Label();
            tbNroDoc = new TextBox();
            labelIngresos = new Label();
            tbIngresos = new TextBox();
            labelEgresos = new Label();
            tbEgresos = new TextBox();
            labelMonto = new Label();
            tbMonto = new TextBox();
            labelPlazo = new Label();
            tbPlazo = new TextBox();
            btnConsultar = new Button();

            SuspendLayout();

            // labelTipoDoc
            labelTipoDoc.AutoSize = true;
            labelTipoDoc.Location = new Point(24, 20);
            labelTipoDoc.Name = "labelTipoDoc";
            labelTipoDoc.Size = new Size(60, 20);
            labelTipoDoc.TabIndex = 0;
            labelTipoDoc.Text = "Tipo Doc";

            // tbTipoDoc
            tbTipoDoc.Location = new Point(110, 17);
            tbTipoDoc.Name = "tbTipoDoc";
            tbTipoDoc.Size = new Size(100, 27);
            tbTipoDoc.TabIndex = 1;

            // labelNroDoc
            labelNroDoc.AutoSize = true;
            labelNroDoc.Location = new Point(220, 20);
            labelNroDoc.Name = "labelNroDoc";
            labelNroDoc.Size = new Size(60, 20);
            labelNroDoc.TabIndex = 2;
            labelNroDoc.Text = "Nro Doc";

            // tbNroDoc
            tbNroDoc.Location = new Point(300, 17);
            tbNroDoc.Name = "tbNroDoc";
            tbNroDoc.Size = new Size(130, 27);
            tbNroDoc.TabIndex = 3;

            // labelIngresos
            labelIngresos.AutoSize = true;
            labelIngresos.Location = new Point(24, 60);
            labelIngresos.Name = "labelIngresos";
            labelIngresos.Size = new Size(110, 20);
            labelIngresos.TabIndex = 4;
            labelIngresos.Text = "Ingresos Totales";

            // tbIngresos
            tbIngresos.Location = new Point(150, 57);
            tbIngresos.Name = "tbIngresos";
            tbIngresos.Size = new Size(130, 27);
            tbIngresos.TabIndex = 5;

            // labelEgresos
            labelEgresos.AutoSize = true;
            labelEgresos.Location = new Point(24, 100);
            labelEgresos.Name = "labelEgresos";
            labelEgresos.Size = new Size(110, 20);
            labelEgresos.TabIndex = 6;
            labelEgresos.Text = "Egresos Totales";

            // tbEgresos
            tbEgresos.Location = new Point(150, 97);
            tbEgresos.Name = "tbEgresos";
            tbEgresos.Size = new Size(130, 27);
            tbEgresos.TabIndex = 7;

            // labelMonto
            labelMonto.AutoSize = true;
            labelMonto.Location = new Point(24, 140);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(120, 20);
            labelMonto.TabIndex = 8;
            labelMonto.Text = "Monto Solicitado";

            // tbMonto
            tbMonto.Location = new Point(150, 137);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(130, 27);
            tbMonto.TabIndex = 9;

            // labelPlazo
            labelPlazo.AutoSize = true;
            labelPlazo.Location = new Point(24, 180);
            labelPlazo.Name = "labelPlazo";
            labelPlazo.Size = new Size(98, 20);
            labelPlazo.TabIndex = 10;
            labelPlazo.Text = "Plazo (meses)";

            // tbPlazo
            tbPlazo.Location = new Point(150, 177);
            tbPlazo.Name = "tbPlazo";
            tbPlazo.Size = new Size(100, 27);
            tbPlazo.TabIndex = 11;

            // btnConsultar
            btnConsultar.Location = new Point(270, 175);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(160, 29);
            btnConsultar.TabIndex = 12;
            btnConsultar.Text = "Consultar Preaprobacion";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 220);
            Controls.Add(labelTipoDoc);
            Controls.Add(tbTipoDoc);
            Controls.Add(labelNroDoc);
            Controls.Add(tbNroDoc);
            Controls.Add(labelIngresos);
            Controls.Add(tbIngresos);
            Controls.Add(labelEgresos);
            Controls.Add(tbEgresos);
            Controls.Add(labelMonto);
            Controls.Add(tbMonto);
            Controls.Add(labelPlazo);
            Controls.Add(tbPlazo);
            Controls.Add(btnConsultar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Preaprobacion Credito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTipoDoc;
        private TextBox tbTipoDoc;
        private Label labelNroDoc;
        private TextBox tbNroDoc;
        private Label labelIngresos;
        private TextBox tbIngresos;
        private Label labelEgresos;
        private TextBox tbEgresos;
        private Label labelMonto;
        private TextBox tbMonto;
        private Label labelPlazo;
        private TextBox tbPlazo;
        private Button btnConsultar;
    }
}
