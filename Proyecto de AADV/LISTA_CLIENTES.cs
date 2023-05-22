using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_AADV
{
    public partial class LISTA_CLIENTES : Form
    {
        public LISTA_CLIENTES()
        {
            InitializeComponent();
        }        



        private void LISTA_CLIENTES_Load(object sender, EventArgs e)
        {

        }

        private void LC_VER_HISTORIAL_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            HISTORIAL_CLIENTE HistorialCliente = new HISTORIAL_CLIENTE();

            // Mostrar el formulario
            HistorialCliente.ShowDialog();
        }

        private void LC_BUSCAR_APELLIDO_Click(object sender, EventArgs e)
        {

        }

        private void LC_BUSCAR_RFC_Click(object sender, EventArgs e)
        {

        }

        private void LC_BUSCAR_CORREO_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
