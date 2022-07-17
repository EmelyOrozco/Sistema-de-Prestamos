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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //if (Form1.rol == "A0001")
            //{
            //    btnalmacen.Enabled = true;
            //    btnventas.Enabled = true;
            //    btncompras.Enabled = true;

            //    lblCargo.Text = "Administrador";
            //}
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FUsuarios usuarios = new FUsuarios();
            usuarios.ShowDialog();
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FPrestamos fPrestamos = new FPrestamos();
            fPrestamos.ShowDialog();
        }
    }
}
