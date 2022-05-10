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
                dgvTareasSinAsignar.Rows.Add(list[i].Titulo, list[i].Puntos);
            }
        }
        private int numPag;
        public FrmFuncionalidades(int num)
        {
            numPag = num;
            InitializeComponent();
        }

        private void FrmFuncionalidades_Load(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(numPag);
            RellenarDataGrid();
        }

    }
}
