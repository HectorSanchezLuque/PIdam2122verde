using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegradoVerde.Formularios
{
    public partial class FrmDatos : Form
    {
        private Usuario user;
        public FrmDatos(Usuario us)
        {
            InitializeComponent();
            user = us;
        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {
            lblNomUser.Text = user.Nombre;
            lblCodigo.Text = user.Id.ToString("D4");
            /*ptbFoto.Image = user.Foto;*/
            
        }
    }
}
