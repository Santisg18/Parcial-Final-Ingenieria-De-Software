using Newtonsoft.Json;
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
    public partial class Liquidacion : Form
    {
        public Liquidacion()
        {
            InitializeComponent();
        }
        string WebAzure = ConfigurationManager.AppSettings["urlweb"];
        private void btnLiquidar_Click(object sender, EventArgs e)
        {
            LiquidarMensajero(WebAzure, "/api/Nomina/RealizarLiquidacion");
            dgvLiquidacion.DataSource = JsonConvert.DeserializeObject(MostrarMensajerosXPagar(WebAzure, "/api/Pendientes/MensajerosXPagar"));
            btnLiquidar.Enabled = false;
            txtIdMensajero.Text = string.Empty;
        }

        private void dgvLiquidacion_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MensajeroLiquidar();
            btnLiquidar.Enabled = true;
        }

        private void Liquidacion_Load(object sender, EventArgs e)
        {
            dgvLiquidacion.DataSource = JsonConvert.DeserializeObject(MostrarMensajerosXPagar(WebAzure, "/api/Pendientes/MensajerosXPagar"));
        }

        public void MensajeroLiquidar()
        {
            txtIdMensajero.Text = dgvLiquidacion.CurrentRow.Cells["IdMensajero"].Value.ToString();
        }

        public void LiquidarMensajero(string URL, string ControladorMetodo)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ControladorMetodo, Method.POST);

            request.RequestFormat = DataFormat.Json;
            var obj = new
            {
                IdMensajero = txtIdMensajero.Text,
            };
            request.AddJsonBody(obj);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
        }

        public string MostrarMensajerosXPagar(string URL, string ControladorMetodo)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ControladorMetodo, Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return content;
        }

    }
}
