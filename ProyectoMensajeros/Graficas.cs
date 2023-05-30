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
    public partial class Graficas : Form
    {
        public Graficas()
        {
            InitializeComponent();
        }
        string WebAzure = ConfigurationManager.AppSettings["urlweb"];
        private void Graficas_Load(object sender, EventArgs e)
        {

           dgvEstadistica.DataSource= JsonConvert.DeserializeObject(InformacionMensajeros(WebAzure, "/api/Datos/Estadistica"));
        }
        public string InformacionMensajeros(string URL, string ControladorMetodo)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ControladorMetodo, Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return content;
        }
    }
}
