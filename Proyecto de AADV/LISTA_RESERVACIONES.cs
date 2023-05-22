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
    public partial class LISTA_RESERVACIONES : Form
    {
        public LISTA_RESERVACIONES()
        {
            InitializeComponent();
        }

        private void LISTA_RESERVACIONES_Load(object sender, EventArgs e)
        {

        }

        private void MLR_CREAR_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            RESERVACIÓN Reservacion = new RESERVACIÓN();

            // Mostrar el formulario
            Reservacion.ShowDialog();
        }

        private void LR_CHECKIN_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            CHECK_IN CheckIn = new CHECK_IN();

            // Mostrar el formulario
            CheckIn.ShowDialog();
        }

        private void MLR_CHECKOUT_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            CHECK_OUT CheckOut = new CHECK_OUT();

            // Mostrar el formulario
            CheckOut.ShowDialog();
        }
    }
}
