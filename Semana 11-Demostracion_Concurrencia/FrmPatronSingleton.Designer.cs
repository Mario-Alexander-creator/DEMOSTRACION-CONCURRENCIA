namespace Semana_11_Demostracion_Concurrencia
{
    partial class FrmPatronSingleton
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
            BtnAsignarCadenaConexion = new Button();
            BtnObtenerCadenaConexion = new Button();
            TxtCadenaConexion = new TextBox();
            label1 = new Label();
            LblCadenaConexionRecuperar = new Label();
            SuspendLayout();
            // 
            // BtnAsignarCadenaConexion
            // 
            BtnAsignarCadenaConexion.Location = new Point(30, 95);
            BtnAsignarCadenaConexion.Name = "BtnAsignarCadenaConexion";
            BtnAsignarCadenaConexion.Size = new Size(122, 65);
            BtnAsignarCadenaConexion.TabIndex = 0;
            BtnAsignarCadenaConexion.Text = "Asignar cadena de conexion ";
            BtnAsignarCadenaConexion.UseVisualStyleBackColor = true;
            BtnAsignarCadenaConexion.Click += BtnAsignarCadenaConexion_Click;
            // 
            // BtnObtenerCadenaConexion
            // 
            BtnObtenerCadenaConexion.Location = new Point(30, 189);
            BtnObtenerCadenaConexion.Name = "BtnObtenerCadenaConexion";
            BtnObtenerCadenaConexion.Size = new Size(122, 67);
            BtnObtenerCadenaConexion.TabIndex = 1;
            BtnObtenerCadenaConexion.Text = "Obtener cadena de conexion";
            BtnObtenerCadenaConexion.UseVisualStyleBackColor = true;
            BtnObtenerCadenaConexion.Click += BtnObtenerCadenaConexion_Click;
            // 
            // TxtCadenaConexion
            // 
            TxtCadenaConexion.Location = new Point(30, 43);
            TxtCadenaConexion.Name = "TxtCadenaConexion";
            TxtCadenaConexion.Size = new Size(314, 23);
            TxtCadenaConexion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 13);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 3;
            label1.Text = "Cadena de conexion";
            // 
            // LblCadenaConexionRecuperar
            // 
            LblCadenaConexionRecuperar.AutoSize = true;
            LblCadenaConexionRecuperar.Location = new Point(196, 215);
            LblCadenaConexionRecuperar.Name = "LblCadenaConexionRecuperar";
            LblCadenaConexionRecuperar.Size = new Size(0, 15);
            LblCadenaConexionRecuperar.TabIndex = 4;
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 299);
            Controls.Add(LblCadenaConexionRecuperar);
            Controls.Add(label1);
            Controls.Add(TxtCadenaConexion);
            Controls.Add(BtnObtenerCadenaConexion);
            Controls.Add(BtnAsignarCadenaConexion);
            Name = "FrmPatronSingleton";
            Text = "Demostración del Patron Singleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAsignarCadenaConexion;
        private Button BtnObtenerCadenaConexion;
        private TextBox TxtCadenaConexion;
        private Label label1;
        private Label LblCadenaConexionRecuperar;
    }
}