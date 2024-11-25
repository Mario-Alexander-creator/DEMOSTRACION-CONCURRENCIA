namespace Semana_11_Demostracion_Concurrencia
{
    partial class FrmGestionBloqueos
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
            BtnIncrementar = new Button();
            LblContador = new Label();
            BtnDisminuir = new Button();
            splitContainer1 = new SplitContainer();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnIncrementar
            // 
            BtnIncrementar.Location = new Point(22, 21);
            BtnIncrementar.Name = "BtnIncrementar";
            BtnIncrementar.Size = new Size(133, 47);
            BtnIncrementar.TabIndex = 0;
            BtnIncrementar.Text = "Incrementar";
            BtnIncrementar.UseVisualStyleBackColor = true;
            BtnIncrementar.Click += BtnIncrementar_Click;
            // 
            // LblContador
            // 
            LblContador.AutoSize = true;
            LblContador.Location = new Point(81, 176);
            LblContador.Name = "LblContador";
            LblContador.Size = new Size(13, 15);
            LblContador.TabIndex = 1;
            LblContador.Text = "0";
            // 
            // BtnDisminuir
            // 
            BtnDisminuir.Location = new Point(22, 102);
            BtnDisminuir.Name = "BtnDisminuir";
            BtnDisminuir.Size = new Size(138, 47);
            BtnDisminuir.TabIndex = 2;
            BtnDisminuir.Text = "Disminuir";
            BtnDisminuir.UseVisualStyleBackColor = true;
            BtnDisminuir.Click += BtnDisminuir_Click;
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
            splitContainer1.Panel1.Controls.Add(BtnDisminuir);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(622, 314);
            splitContainer1.SplitterDistance = 207;
            splitContainer1.TabIndex = 3;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(411, 314);
            TxtResultado.TabIndex = 1;
           
            // 
            // FrmGestionBloqueos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 314);
            Controls.Add(BtnIncrementar);
            Controls.Add(splitContainer1);
            Name = "FrmGestionBloqueos";
            Text = "Gestion de Bloqueos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BtnIncrementar;
        private Label LblContador;
        private Button BtnDisminuir;
        private SplitContainer splitContainer1;
        private TextBox TxtResultado;
    }
}