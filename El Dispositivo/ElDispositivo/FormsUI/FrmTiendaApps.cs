using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUI
{
    public partial class FrmTiendaApps : Form
    {
        Usuario miUsuario;
        List<Aplicacion> aplicaciones;
        public FrmTiendaApps(Usuario usuarioIngresado)
        {
            InitializeComponent();
            miUsuario = usuarioIngresado;
            aplicaciones = HardCode.CargarAppsHD();
        }

        private void FrmTiendaApps_Load(object sender, EventArgs e)
        {
            this.Text = $"Tienda : Bienvenido {miUsuario.NomUsuario}";
            dgv_aplicaciones.DataSource = aplicaciones;
        }

        private void FrmTiendaApps_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
