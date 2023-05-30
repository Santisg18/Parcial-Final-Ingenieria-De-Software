using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMensajeros
{
    public partial class InformacionMensajero : Form
    {
        public InformacionMensajero()
        {
            InitializeComponent();
        }
        string WebAzure = ConfigurationManager.AppSettings["urlweb"];
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdMensajero.Text == string.Empty)
            {
                MensajeError("Debe digitar un valor para buscar");
                return;
            }
            string Validacion = InformacionMensajeros(WebAzure, "/api/Mensajero/BuscarMensajeros");
            
            if (Validacion !="[]")
            {
                lblErrorMensaje.Visible = false;
                dgvMensajero.DataSource = JsonConvert.DeserializeObject(InformacionMensajeros(WebAzure, "/api/Mensajero/BuscarMensajeros"));
                string Criptografia = dgvMensajero.CurrentRow.Cells["ContraseñaMensajero"].Value.ToString();
                dgvMensajero.CurrentRow.Cells["ContraseñaMensajero"].Value = CriptografiaSHA512(Criptografia);
                dgvMensajero.Update();
                txtIdMensajero.Text = string.Empty;
            }
            else
            {
                MensajeError("No se encontró ese mensajero");
            } 
        }
        public string InformacionMensajeros(string URL, string ControladorMetodo)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ControladorMetodo, Method.GET);
            request.AddParameter("UsuarioMensajero", txtIdMensajero.Text);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return content;
        }
        public void MensajeError(string mensaje)
        {
            lblErrorMensaje.Text = $"       {mensaje}";
            lblErrorMensaje.Visible = true;
        }
        private String CriptografiaSHA512(string valor)
        {
            var stringHash = "";
            try
            {
                UnicodeEncoding encode = new UnicodeEncoding();
                byte[] hashBytes, messageBytes = encode.GetBytes(valor);

                SHA512Managed sha512Managed = new SHA512Managed();

                hashBytes = sha512Managed.ComputeHash(messageBytes);

                foreach (byte b in hashBytes)
                {
                    stringHash += String.Format("{0:x2}", b);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return stringHash;
        }
    }
}
