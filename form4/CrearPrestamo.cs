using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using biblioteca1;
using biblioteca2;

namespace form4
{
    public partial class CrearPrestamo : Form
    {
        user ObjNegocio = new user();
        Prestamos prestamos = new Prestamos();
        public CrearPrestamo()
        {
            InitializeComponent();
        }

        private void CrearPrestamo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRESTAMOSDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.pRESTAMOSDataSet.Clientes);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                prestamos.ClienteId =(int)comboBox1.SelectedValue;
                prestamos.CantidadSOlicitada = Convert.ToDecimal(textcant.Text);
                prestamos.Tasa = Convert.ToDecimal(textasa.Text);
                prestamos.CantidadMeses = Convert.ToInt32(textMeses.Text);
                prestamos.Estado = comboBox2.Text;
                ObjNegocio.Insertarprestamos(prestamos);
                MessageBox.Show("Se ha Guardado el registro");
                CrearPrestamo user = new CrearPrestamo();
                user.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el registro" + ex);
            }
        }
    }
}
