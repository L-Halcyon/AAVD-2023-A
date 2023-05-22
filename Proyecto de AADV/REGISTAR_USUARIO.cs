using System;
using System.Collections;
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
    public partial class REGISTRAR_USUARIO : Form
    {
        public REGISTRAR_USUARIO()
        {
            InitializeComponent();
        }              

        private void REGISTRAR_USUARIO_Load(object sender, EventArgs e)
        {

        }

        private void RU_BTN_REGISTRAR_Click(object sender, EventArgs e)
        {

            string nombre = RU_TBX_NOMBRE.Text;
            string ap = RU_TBX_AP.Text;
            string am = RU_TBX_AM.Text;
            string correo = RU_TBX_CORREO.Text;
            string contrasena = RU_TBX_CONTRASENA.Text;
            string nomina = RU_TBX_NOMINA.Text;
            //DateTime fechanacim = RU_DTP_FECHANACIM.Value;
            string domicilio = RU_TBX_DOMICILIO.Text;
            string telefono = RU_TBX_TELEFONO.Text;
            string rol = RU_TBX_ROL.Text;

            EnlaceCassandra instancia = new EnlaceCassandra();
            EnlaceCassandra.InsertarUsuario(nombre, ap, am, correo, contrasena, nomina, domicilio, telefono, rol);
        }
    }
}
