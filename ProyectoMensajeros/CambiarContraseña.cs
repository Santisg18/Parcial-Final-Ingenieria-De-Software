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
    public partial class CambiarContraseña : Form
    {
        public CambiarContraseña()
        {
            InitializeComponent();
        }
        string WebAzure = ConfigurationManager.AppSettings["urlweb"];
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                MensajeError("Debes ingresar un usuario ");
                txtUsuario.Focus();
                return;
            }
            if (txtContraseñaM.Text == string.Empty)
            {
                MensajeError("Debes ingresar la Contraseña");
                txtContraseñaM.Focus();
                return;
            }
            if (txtContraseñaNueva.Text == string.Empty)
            {
                MensajeError("Debes ingresar una contraseña nueva");
                txtContraseñaNueva.Focus();
                return;
            }
            ActualizarContraseña(WebAzure, "/api/Mensajero/CambiarContraseña");
            MensajeSatisfactorio("Actualizacion satisfactoria");
        }
        public void ActualizarContraseña(string URL, string ControladorMetodo)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ControladorMetodo, Method.PUT);

            request.RequestFormat = DataFormat.Json;
            var obj = new
            {
                UsuarioMensajero = txtUsuario.Text,
                ContraseñaMensajero = txtContraseñaM.Text,
                NuevaContraseñaMensajero = txtContraseñaNueva.Text
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
