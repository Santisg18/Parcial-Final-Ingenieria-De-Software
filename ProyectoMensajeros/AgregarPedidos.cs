using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMensajeros
{
    public partial class AgregarPedidos : Form
    {
        public AgregarPedidos()
        {
            InitializeComponent();
        }
        string WebAzure = ConfigurationManager.AppSettings["urlweb"];
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (txtIdAdm.Text == string.Empty)
            {
                MensajeError("Debes ingresar un ID de Administrador ");
                txtIdAdm.Focus();
                return;
            }
            if (txtIdmen.Text == string.Empty)
            {
                MensajeError("Debes ingresar un ID de Mensajero");
                txtIdmen.Focus();
                return;
            }
            if (txtNom.Text == string.Empty)
            {
                MensajeError("Debes ingresar un nombre de pedido");
                txtNom.Focus();
                return;
            }
            if (txtDesc.Text == string.Empty)
            {
                MensajeError("Debes ingresar una descripcion de pedido");
                txtDesc.Focus();
                return;
            }
            if (txtValor.Text == string.Empty)
            {
                MensajeError("Debes ingresar un valor");
                txtValor.Focus();
                return;
            }
            int Valor = 0;
            if(!int.TryParse(txtValor.Text,out Valor))
            {
                MensajeError("Debe ser un valor numerico");
                txtValor.Focus();
                return;
            }
            if (txtDireccion.Text == string.Empty)
            {
                MensajeError("Debes ingresar una direccion de pedido");
                txtDireccion.Focus();
                return;
            }
            AgregarPedido(WebAzure, "/api/Pedido/AsignarPedido");
            MensajeSatisfactorio("PedidoAgregado exitosamente");
        }
        public void AgregarPedido(string URL, string ControladorMetodo)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ControladorMetodo, Method.POST);

            request.RequestFormat = DataFormat.Json;
            var obj = new
            {
                IdAdministrador = txtIdAdm.Text,
                IdMensajero = txtIdmen.Text,
                NombrePedido = txtNom.Text,
                DescripcionPedido = txtDesc.Text,
                ValorPedido = txtValor.Text,
                DireccionPedido = txtDireccion.Text
            };
            request.AddJsonBody(obj);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
        }
        public void MensajeError(string mensaje)
        {
            lblErrorMensaje.Text = $"       {mensaje}";
            lblCreacionexitosa.Visible = false;
            lblErrorMensaje.Visible = true;
        }
        public void MensajeSatisfactorio(string Mensaje)
        {
            lblCreacionexitosa.Text = $"     {Mensaje}";
            lblCreacionexitosa.Visible = true;
            lblErrorMensaje.Visible = false;
        }
    }
}
