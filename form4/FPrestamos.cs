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
    public partial class FPrestamos : Form
    {
        public FPrestamos()
        {
            InitializeComponent();
        }

        private void FPrestamos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pRESTAMOSDataSet.Prestamos' table. You can move, or remove it, as needed.
            this.prestamosTableAdapter.Fill(this.pRESTAMOSDataSet.Prestamos);

        }
    }
}
