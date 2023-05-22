using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
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
                string correo = IS_TBX_CORREO.Text;
                string contraseña = IS_TBX_CONTRASEÑA.Text;
                string rol = "1";

                EnlaceCassandra instancia = new EnlaceCassandra();
                EnlaceCassandra.InicioSesionAdmin(correo, contraseña, rol);



                /*// Conectarse a la base de datos
                using (var cluster = Cluster.Builder().AddContactPoint("localhost").Build())
                {
                    using (var session = cluster.Connect("keyspace1"))
                    {
                        // Consulta CQL para obtener la contraseña del usuario
                        string query = "SELECT contrasena FROM usuarios WHERE correo = ?";

                        // Preparar la consulta
                        var preparedStatement = session.Prepare(query);
                        var boundStatement = preparedStatement.Bind(correo);

                        // Ejecutar la consulta
                        var row = session.Execute(boundStatement).FirstOrDefault();

                        if (row != null)
                        {
                            string storedPassword = row.GetValue<string>("contrasena");

                            if (contraseña == storedPassword)
                            {
                                // Inicio de sesión exitoso
                                MessageBox.Show("Inicio de sesión exitoso");
                                // Si el CheckBox está marcado, crea una instancia del formulario A y muéstralo
                                // Crear una instancia del formulario que deseas abrir
                                MENU_ADMIN MenuAdmin = new MENU_ADMIN();
                                // Mostrar el formulario
                                MenuAdmin.ShowDialog();
                            }
                            else
                            {
                                // Contraseña incorrecta
                                MessageBox.Show("Contraseña incorrecta");
                            }
                        }
                        else
                        {
                            // Usuario no encontrado
                            MessageBox.Show("Usuario no encontrado");
                        }
                    }
                }    */
            }
            else
            {
                string correo = IS_TBX_CORREO.Text;
                string contraseña = IS_TBX_CONTRASEÑA.Text;
                string rol = "0";

                EnlaceCassandra instancia = new EnlaceCassandra();
                EnlaceCassandra.InicioSesionUsuario(correo, contraseña, rol);
                         
            }
            //this.Close();
        }
      
    }
}
