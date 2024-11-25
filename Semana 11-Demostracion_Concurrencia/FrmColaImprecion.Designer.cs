namespace Semana_11_Demostracion_Concurrencia
{
    partial class FrmColaImprecion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            LblContador = new Label();
            BtnAgregarTrabajo = new Button();
            BtnProcesarCola = new Button();
            TxtResultadoImprecion = new TextBox();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(LblContador);
            splitContainer1.Panel1.Controls.Add(BtnAgregarTrabajo);
            splitContainer1.Panel1.Controls.Add(BtnProcesarCola);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultadoImprecion);
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(657, 336);
            splitContainer1.SplitterDistance = 219;
            splitContainer1.TabIndex = 4;
            // 
            // LblContador
            // 
            LblContador.AutoSize = true;
            LblContador.Location = new Point(83, 221);
            LblContador.Name = "LblContador";
            LblContador.Size = new Size(13, 15);
            LblContador.TabIndex = 2;
            LblContador.Text = "0";
            // 
            // BtnAgregarTrabajo
            // 
            BtnAgregarTrabajo.Location = new Point(35, 12);
            BtnAgregarTrabajo.Name = "BtnAgregarTrabajo";
            BtnAgregarTrabajo.Size = new Size(149, 75);
            BtnAgregarTrabajo.TabIndex = 1;
            BtnAgregarTrabajo.Text = "Agregar Trabajo";
            BtnAgregarTrabajo.UseVisualStyleBackColor = true;
            BtnAgregarTrabajo.Click += BtnAgregarTrabajo_Click_1;
            // 
            // BtnProcesarCola
            // 
            BtnProcesarCola.Location = new Point(35, 103);
            BtnProcesarCola.Name = "BtnProcesarCola";
            BtnProcesarCola.Size = new Size(149, 69);
            BtnProcesarCola.TabIndex = 0;
            BtnProcesarCola.Text = "Procesar Trabajo";
            BtnProcesarCola.UseVisualStyleBackColor = true;
            BtnProcesarCola.Click += BtnProcesarCola_Click_1;
            // 
            // TxtResultadoImprecion
            // 
            TxtResultadoImprecion.Dock = DockStyle.Fill;
            TxtResultadoImprecion.Location = new Point(0, 0);
            TxtResultadoImprecion.Multiline = true;
            TxtResultadoImprecion.Name = "TxtResultadoImprecion";
            TxtResultadoImprecion.Size = new Size(434, 336);
            TxtResultadoImprecion.TabIndex = 2;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(434, 336);
            TxtResultado.TabIndex = 1;
            // 
            // FrmColaImprecion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 336);
            Controls.Add(splitContainer1);
            Name = "FrmColaImprecion";
            Text = "FrmColaImprecion";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button BtnAgregarTrabajo;
        private Button BtnProcesarCola;
        private TextBox TxtResultado;
        private Label LblContador;
        private TextBox TxtResultadoImprecion;
    }
}