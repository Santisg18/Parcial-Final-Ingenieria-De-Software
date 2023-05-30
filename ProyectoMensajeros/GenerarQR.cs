using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMensajeros
{
    public partial class GenerarQR : Form
    {
        public GenerarQR()
        {
            InitializeComponent();
        }
        string WebAzure = ConfigurationManager.AppSettings["urlweb"];
        string datosmensajeroQR = string.Empty,IdMensajero=string.Empty;

        private void btnGenerarQR_Click(object sender, EventArgs e)
        {
            CrearQR(PanelResultado,datosmensajeroQR , IdMensajero);
            btnGuardarQR.Enabled = true;
        }

        private void btnGuardarQR_Click(object sender, EventArgs e)
        {
            GuardarImagen(PanelResultado);
        }

        private void GenerarQR_Load(object sender, EventArgs e)
        {
            dgvMensajero.DataSource = JsonConvert.DeserializeObject( MostrarMensajeros(WebAzure, "/api/Mensajero/Mensajeros"));
        }

        private void dgvMensajero_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdMensajero = dgvMensajero.CurrentRow.Cells["IdMensajero"].Value.ToString();
            datosmensajeroQR =DatosMensajero();
            btnGenerarQR.Enabled = true;
        }

        public string DatosMensajero()
        {
            string NombMensajero = $"Nombre: {dgvMensajero.CurrentRow.Cells["NombreMensajero"].Value.ToString()}";
            string UsuarioMensajero= $"Usuario: {dgvMensajero.CurrentRow.Cells["UsuarioMensajero"].Value.ToString()}";
            string ColorMoto= $"Color Moto: {dgvMensajero.CurrentRow.Cells["ColorMotoMensajero"].Value.ToString()}";
            string PlacaMoto= $"Placa Moto: {dgvMensajero.CurrentRow.Cells["PlacaMotoMensajero"].Value.ToString()}";
            string PerfilMensajero = $"{NombMensajero}\n{UsuarioMensajero}\n{ColorMoto}\n{PlacaMoto}";
            return PerfilMensajero;
        }

        public string MostrarMensajeros(string URL, string ControladorMetodo)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ControladorMetodo, Method.GET);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return content;
        }

        public void GuardarImagen(Panel PanelClon)
        {
            Image ImagenFinal = (Image)PanelClon.BackgroundImage.Clone();
            SaveFileDialog CajaDeDialoGuardar = new SaveFileDialog();
            CajaDeDialoGuardar.AddExtension = true;
            CajaDeDialoGuardar.Filter = "Image PNG(*.png)|*.png";
            CajaDeDialoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(CajaDeDialoGuardar.FileName))
            {
                ImagenFinal.Save(CajaDeDialoGuardar.FileName, ImageFormat.Png);
            }
            ImagenFinal.Dispose();
        }

        public void CrearQR(Panel PanelContenedor, string DatosMensajero, string IdMensajero)
        {
            QrEncoder QR = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            QR.TryEncode(DatosMensajero, out qrCode);
            GraphicsRenderer Render = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero)
                , Brushes.Black
                , Brushes.White);
            MemoryStream MemStr = new MemoryStream();
            Render.WriteToStream(qrCode.Matrix, ImageFormat.Png, MemStr);
            var ImagenTemporal = new Bitmap(MemStr);
            var Imagen = new Bitmap(ImagenTemporal, new Size(new Point(265, 265)));
            PanelContenedor.BackgroundImage = Imagen;
            Imagen.Save(IdMensajero + ".png", ImageFormat.Png);
        }
    }
}
