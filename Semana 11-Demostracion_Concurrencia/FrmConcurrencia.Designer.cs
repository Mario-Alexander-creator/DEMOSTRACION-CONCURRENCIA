namespace Semana_11_Demostracion_Concurrencia
{
    partial class FrmConcurrencia
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
            splitContainer1 = new SplitContainer();
            BtnCancelarHilo = new Button();
            BtnIniciarTarea = new Button();
            BtnIniciarHilo = new Button();
            btnSecuencial = new Button();
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
            splitContainer1.Panel1.Controls.Add(BtnCancelarHilo);
            splitContainer1.Panel1.Controls.Add(BtnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(BtnIniciarHilo);
            splitContainer1.Panel1.Controls.Add(btnSecuencial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(545, 409);
            splitContainer1.SplitterDistance = 181;
            splitContainer1.TabIndex = 0;
            // 
            // BtnCancelarHilo
            // 
            BtnCancelarHilo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnCancelarHilo.Location = new Point(13, 239);
            BtnCancelarHilo.Name = "BtnCancelarHilo";
            BtnCancelarHilo.Size = new Size(147, 55);
            BtnCancelarHilo.TabIndex = 3;
            BtnCancelarHilo.Text = "Cancelar proceso";
            BtnCancelarHilo.UseVisualStyleBackColor = true;
            BtnCancelarHilo.Click += BtnCancelarHilo_Click;
            // 
            // BtnIniciarTarea
            // 
            BtnIniciarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarTarea.Location = new Point(13, 164);
            BtnIniciarTarea.Name = "BtnIniciarTarea";
            BtnIniciarTarea.Size = new Size(147, 55);
            BtnIniciarTarea.TabIndex = 2;
            BtnIniciarTarea.Text = "Iniciar Tarea";
            BtnIniciarTarea.UseVisualStyleBackColor = true;
            BtnIniciarTarea.Click += BtnIniciarTarea_Click;
            // 
            // BtnIniciarHilo
            // 
            BtnIniciarHilo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnIniciarHilo.Location = new Point(13, 93);
            BtnIniciarHilo.Name = "BtnIniciarHilo";
            BtnIniciarHilo.Size = new Size(147, 55);
            BtnIniciarHilo.TabIndex = 1;
            BtnIniciarHilo.Text = "Iniciar Hilo";
            BtnIniciarHilo.UseVisualStyleBackColor = true;
            BtnIniciarHilo.Click += BtnIniciarHilo_Click;
            // 
            // btnSecuencial
            // 
            btnSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSecuencial.Location = new Point(13, 16);
            btnSecuencial.Name = "btnSecuencial";
            btnSecuencial.Size = new Size(147, 55);
            btnSecuencial.TabIndex = 0;
            btnSecuencial.Text = "Iniciar Secuencial";
            btnSecuencial.UseVisualStyleBackColor = true;
            btnSecuencial.Click += btnSecuencial_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(360, 409);
            TxtResultado.TabIndex = 0;
            // 
            // FrmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 409);
            Controls.Add(splitContainer1);
            Name = "FrmConcurrencia";
            Text = "Demostracion de concurrencia";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnSecuencial;
        private Button BtnIniciarTarea;
        private Button BtnIniciarHilo;
        private TextBox TxtResultado;
        private Button BtnCancelarHilo;
    }
}
