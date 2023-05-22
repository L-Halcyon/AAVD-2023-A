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
    public partial class MENU_USUARIO : Form
    {
        public MENU_USUARIO()
        {
            InitializeComponent();
        }

        private void MENU_USUARIO_Load(object sender, EventArgs e)
        {

        }

        private void MU_CLIENTES_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            LISTA_CLIENTES ListaClientes = new LISTA_CLIENTES();

            // Mostrar el formulario
            ListaClientes.ShowDialog();
        }

        private void MU_RESERVACIONES_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            LISTA_RESERVACIONES ListaReservaciones = new LISTA_RESERVACIONES();

            // Mostrar el formulario
            ListaReservaciones.ShowDialog();
        }
    }
}
