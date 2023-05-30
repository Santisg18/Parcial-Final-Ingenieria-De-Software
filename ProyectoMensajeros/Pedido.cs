using RestSharp;
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
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }
        private void dgvPedido_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        public string InformacionMensajeros(string URL, string ControladorMetodo)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ControladorMetodo, Method.GET);
            request.AddParameter("NombreMensajero", txtIdMensajero.Text);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return content;
        }

        private void btnMostrarPedido_Click(object sender, EventArgs e)
        {
            if (txtIdMensajero.Text == string.Empty)
            {
                MensajeError("Digite su ID");
                txtIdMensajero.Focus();
                return;
            }

        }
        public void MensajeError(string mensaje)
        {
            lblErrorMensaje.Text = $"       {mensaje}";
            //lblCreacionexitosa.Visible = false;
            lblErrorMensaje.Visible = true;
        }
    }
}
