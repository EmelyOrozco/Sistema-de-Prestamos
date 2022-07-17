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
using biblioteca3;

namespace form4
{
    public partial class Form1 : Form
    {
        user2 objeuserr = new user2();
        user3 objeuser = new user3();
        Form2 fmr1 = new Form2();

        public static string usuario_nombre;


        void logueo_p()
        {
            DataTable dt = new DataTable();
            objeuserr.nombre = textusuario.Text;
            objeuserr.clave = textpass.Text;

            dt = objeuser.userz(objeuserr);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][0].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][0].ToString();

                fmr1.ShowDialog();

                Form1 log = new Form1();
                log.ShowDialog();

                if (log.DialogResult == DialogResult.OK)
                    Application.Run(new Form2());

                textusuario.Clear();
                textpass.Clear();

            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
logueo_p();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
