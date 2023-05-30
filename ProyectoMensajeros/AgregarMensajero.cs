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
    public partial class AgregarMensajero : Form
    {
        public AgregarMensajero()
        {
            InitializeComponent();
        }
        string WebAzure = ConfigurationManager.AppSettings["urlweb"];
        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            if (txtNombreM.Text == string.Empty)
            {
                MensajeError("Debes ingresar un nombre ");
                txtNombreM.Focus();
                return;
            }
            if (txtUsuarioM.Text == string.Empty)
            {
                MensajeError("Debes ingresar un usuario");
                txtUsuarioM.Focus();
                return;
            }
            if (txtContraseñaM.Text == string.Empty)
            {
                MensajeError("Debes ingresar una contraseña");
                txtContraseñaM.Focus();
                return;
            }
            if (txtColorMotoM.Text == string.Empty)
            {
                MensajeError("Debes ingresar un color de la moto");
                txtColorMotoM.Focus();
                return;
            }
            if (txtPlacaMotoM.Text == string.Empty)
            {
                MensajeError("Debes ingresar una placa de la moto");
                txtPlacaMotoM.Focus();
                return;
            }

            string Validar= ValidarUsuario(WebAzure, "/api/Mensajero/BuscarMensajero");

            if (Validar != "[]")
            {
                MensajeError("Usuario ya existente");
                txtUsuarioM.Text = string.Empty;
                txtUsuarioM.Focus();
            }
            else
            {
                CrearMensajero(WebAzure, "/api/Mensajero/CrearMensajero");
                MensajeSatisfactorio("Mensajero creado exitosamente");
                Vaciar();
            }
        }
        public void CrearMensajero(string URL, string ControladorMetodo)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ControladorMetodo, Method.POST);

            request.RequestFormat = DataFormat.Json;
            var obj = new { NombreMensajero = txtNombreM.Text,
                            UsuarioMensajero = txtUsuarioM.Text ,
                            ContraseñaMensajero = txtContraseñaM.Text,
                            ColorMotoMensajero = txtColorMotoM.Text,
                            PlacaMotoMensajero = txtPlacaMotoM.Text};
            request.AddJsonBody(obj);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
        }
        public string ValidarUsuario(string URL, string ControladorMetodo)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ControladorMetodo, Method.GET);
            request.AddParameter("UsuarioMensajero", txtUsuarioM.Text);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return content;
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
        public void Vaciar()
        {
            txtNombreM.Text = string.Empty;
            txtUsuarioM.Text = string.Empty;
            txtContraseñaM.Text = string.Empty;
            txtColorMotoM.Text = string.Empty;
            txtPlacaMotoM.Text = string.Empty;
        }
    }
}
