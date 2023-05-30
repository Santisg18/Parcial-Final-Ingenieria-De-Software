using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RestSharp;
using System.Configuration;

namespace ProyectoMensajeros
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        string WebAzure = ConfigurationManager.AppSettings["urlweb"];
        
        Menu menu = new Menu();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.WhiteSmoke;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtContraseña.Text != "CONTRASEÑA")
                {
                    string Validacion = consumirLogin(WebAzure, "/api/Mensajero/Login");
                    if (Validacion == "\"1\"")
                    {
                        menu.Show();
                        menu.btnAgregarMensajero.Visible = false;
                        menu.btnBuscarMensajero.Visible = false;
                        menu.btnEstadistica.Visible = false;
                        menu.btnGenerarQR.Visible = false;
                        menu.btnLiquidacion.Visible = false;
                        menu.btnUbicacion.Visible = false;
                        menu.panel1.Visible = false;
                        menu.panel2.Visible = false;
                        menu.panel3.Visible = false;
                        menu.panel4.Visible = false;
                        menu.panel5.Visible = false;
                        menu.panel7.Visible = false;
                        menu.panel8.Visible = false;
                        menu.btnAgregarPedidos.Visible = false;
                        this.Hide();
                    }else if (Validacion == "\"2\"")
                    {
                        menu.Show();
                        menu.btnPedidosAsignados.Visible = false;
                        menu.panel9.Visible = false;
                        this.Hide();
                    }
                    else
                    {
                        MensajeError("Usuario o Contraseña incorrecta");
                    }
                }
                else MensajeError("Ingrese una contraseña");
            }
            else MensajeError("Ingrese un usuario");
        }
        public void MensajeError(string mensaje)
        {
            lblErrorMensaje.Text = "       " + mensaje;
            lblErrorMensaje.Visible = true;
        }
        public string consumirLogin(string URL ,string ControladorMetodo)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ControladorMetodo, Method.GET);
            request.AddParameter("usuario", txtUsuario.Text);
            request.AddParameter("contraseña", txtContraseña.Text);
            //request.AddUrlSegment("usuario", txtUsuario.Text);
            //request.AddUrlSegment("contraseña", txtContraseña.Text);

            //request.RequestFormat = DataFormat.Json;
            //var obj = new { usuario = txtUsuario.Text, contraseña = txtContraseña.Text };
            //request.AddJsonBody(obj);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            return content;
        }
    }
}
