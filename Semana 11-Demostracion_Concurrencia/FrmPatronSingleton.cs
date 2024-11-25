using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_11_Demostracion_Concurrencia
{
    public partial class FrmPatronSingleton : Form
    {
        public FrmPatronSingleton()
        {
            InitializeComponent();
        }

        private void BtnAsignarCadenaConexion_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexion = Singleton.Instance;
            cadenaConexion.cadenaConexion = TxtCadenaConexion.Text;
        }

        private void BtnObtenerCadenaConexion_Click(object sender, EventArgs e)
        {
            Singleton cadenaConexion = Singleton.Instance;
            LblCadenaConexionRecuperar.Text = cadenaConexion.cadenaConexion;
        }
    }
}
