﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoIntegradoVerde;
using ProyectoIntegradoVerde.Formularios;

namespace Programacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniSesion_Click(object sender, EventArgs e)
        {
            if (Usuario.compNif(txtNif.Text))
            {
                try
                {
                    if (conexion.Conexion != null)
                    {
                        conexion.AbrirConexion();
                        Usuario user = Usuario.BuscarUsuario(txtNif.Text);

                        if (user.Nif == txtNif.Text && user.Password == txtPassword.Text)
                        {
                            
                            
                            FrmPrincipal princ = new FrmPrincipal(txtNif.Text);
                            princ.Show();
                            




                        }
                        else
                        {
                            MessageBox.Show("No se ha podido iniciar sesión");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("El NIF no es válido");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtNif_TextChanged(object sender, EventArgs e)
        {
        }
    }
}