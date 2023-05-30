using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMensajeros
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.WindowState = FormWindowState.Minimized;
            login.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }
        public void AbrirForm(object form)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnGenerarQR_Click_1(object sender, EventArgs e) => AbrirForm(new GenerarQR());

        private void btnAgregarMensajero_Click(object sender, EventArgs e) => AbrirForm(new AgregarMensajero());

        private void btnLiquidacion_Click(object sender, EventArgs e) => AbrirForm(new Liquidacion());

        private void btnBuscarMensajero_Click(object sender, EventArgs e) => AbrirForm(new InformacionMensajero());

        private void btnCambiarContraseña_Click(object sender, EventArgs e) => AbrirForm(new CambiarContraseña());

        private void btnEstadistica_Click(object sender, EventArgs e) => AbrirForm(new Graficas());

        private void btnAgregarPedidos_Click(object sender, EventArgs e) => AbrirForm(new AgregarPedidos());
    }
}
