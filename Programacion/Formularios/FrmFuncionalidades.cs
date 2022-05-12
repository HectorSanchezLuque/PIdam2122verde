using ProyectoIntegradoVerde.Clases;
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
    public partial class FrmFuncionalidades : Form
    {
        public void RellenarDataGrid()
        {
            List<Tarea> list = new List<Tarea>();
            list = Tarea.ListadoTareas();
            for (int i = 0; i < list.Count; i++)
            {
                dgvTareasSinAsignar.Rows.Add(list[i].Titulo, list[i].FPublicacion.ToString("dd-MM-yyyy"), list[i].FLimite.ToString("dd-MM-yyyy"), list[i].Puntos);
            }
        }
        private int numPag;
        private string nif;
        public FrmFuncionalidades(int num,string niff)
        {
            nif = niff;
            numPag = num;
            InitializeComponent();
        }

        private void FrmFuncionalidades_Load(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(numPag);
            RellenarDataGrid();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
