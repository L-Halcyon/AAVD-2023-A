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
    public partial class LISTA_DE_USUARIOS : Form
    {
        public LISTA_DE_USUARIOS()
        {
            InitializeComponent();
        }

        private void USUARIOS_Load(object sender, EventArgs e)
        {

        }

        private void LU_REGISTRAR_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario que deseas abrir
            REGISTRAR_USUARIO RegistrarUsuario = new REGISTRAR_USUARIO();

            // Mostrar el formulario
            RegistrarUsuario.ShowDialog();
        }

        private void LU_ELIMINAR_Click(object sender, EventArgs e)
        {

        }
    }
}
