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
    public partial class MENU_ADMIN : Form
    {
        public MENU_ADMIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MA_USUARIOS_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            LISTA_DE_USUARIOS ListaDeUsuarios = new LISTA_DE_USUARIOS();

            // Mostrar el formulario
            ListaDeUsuarios.ShowDialog();
        }

        private void MA_UBICACIONES_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            REGISTRAR_C_P_E RegistrarCPE = new REGISTRAR_C_P_E();

            // Mostrar el formulario
            RegistrarCPE.ShowDialog();
        }

        private void MA_HOTELES_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            LISTA_HOTELES ListaHoteles = new LISTA_HOTELES();

            // Mostrar el formulario
            ListaHoteles.ShowDialog();
        }

        private void ME_CANCELACIONES_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            CANCELACIONES Cancelaciones = new CANCELACIONES();

            // Mostrar el formulario
            Cancelaciones.ShowDialog();
        }

        private void MA_OCUPACION_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            REPORTE_OCUPACION_HOTEL ReporteOcupacion = new REPORTE_OCUPACION_HOTEL();

            // Mostrar el formulario
            ReporteOcupacion.ShowDialog();
        }

        private void MA_VENTAS_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            REPORTE_VENTAS ReporteVentas = new REPORTE_VENTAS();

            // Mostrar el formulario
            ReporteVentas.ShowDialog();
        }
    }
}
