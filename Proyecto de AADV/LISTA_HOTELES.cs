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
    public partial class LISTA_HOTELES : Form
    {
        public LISTA_HOTELES()
        {
            InitializeComponent();
        }

        private void LH_REGISTRAR_HOTEL_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            REGISTRAR_HOTEL RegistrarHotel = new REGISTRAR_HOTEL();

            // Mostrar el formulario
            RegistrarHotel.ShowDialog();
        }

        private void LH_REGISTRAR_HABITACION_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            REGISTRAR_HABITACION RegistrarHabitacion = new REGISTRAR_HABITACION();

            // Mostrar el formulario
            RegistrarHabitacion.ShowDialog();
        }
    }
}
