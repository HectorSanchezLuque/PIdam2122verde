using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace ProyectoIntegradoVerde
{
    
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniSesion_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            
            conexion.CerrarConexion();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
