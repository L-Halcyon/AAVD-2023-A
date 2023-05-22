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
    public partial class INICIO_SESION : Form
    {
        public INICIO_SESION()
        {
            InitializeComponent();
        }

        private void INICIO_SESION_Load(object sender, EventArgs e)
        {

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Si el CheckBox está marcado, crea una instancia del formulario A y muéstralo
                // Crear una instancia del formulario que deseas abrir
                MENU_ADMIN MenuAdmin = new MENU_ADMIN();

                // Mostrar el formulario
                MenuAdmin.ShowDialog();
            }
            else
            {
                // Si el CheckBox no está marcado, crea una instancia del formulario B y muéstralo
                // Crear una instancia del formulario que deseas abrir
                MENU_USUARIO MenuUsuario = new MENU_USUARIO();

                // Mostrar el formulario
                MenuUsuario.ShowDialog();            
            }
            //this.Close();
        }
    }
}
