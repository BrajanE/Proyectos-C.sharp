using Entidades;
using System;
using System.Windows.Forms;

namespace FormsUI
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            cmb_SO.DataSource = Enum.GetValues(typeof(ESistemaOperativo));
            txt_contrania.Enabled = false;
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {

            ESistemaOperativo so;
            Enum.TryParse<ESistemaOperativo>(cmb_SO.SelectedValue.ToString(), out so);
            Usuario usuarioIngresado = new Usuario(so,txt_usuario.Text);
            FrmTiendaApps tiendaApps = new FrmTiendaApps(usuarioIngresado);
            tiendaApps.Show();
            this.Hide();
        }
    }
}
