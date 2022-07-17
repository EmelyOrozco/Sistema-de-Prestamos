
using biblioteca1;
using biblioteca2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form4
{
    public partial class CrearUser : Form
    {
        user ObjNegocio = new user();
        Usuarios usuarios = new Usuarios();
        public CrearUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                usuarios.Id = textID.Text;
                usuarios.Nombre_Completo = textNombre.Text;
                usuarios.Rol = textRol.Text;
                usuarios.Clave = textContra.Text;
                usuarios.Usuario = textUsuario.Text;
                ObjNegocio.InsertarUsuarios(usuarios);
                MessageBox.Show("Se ha Guardado el registro");
                CrearUser user = new CrearUser();
                user.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el registro" + ex);
            }
        }
    }
}
