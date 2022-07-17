using biblioteca1;
using biblioteca2;
using System;
using System.Windows.Forms;

namespace form4
{
    public partial class Form1 : Form
    {
        Logim objeuserr = new Logim();
        user user = new user();
        Form2 fmr1 = new Form2();

        public static string usuario_nombre;
        public static string rol;


        void logueo_p()
        {
            objeuserr.usuario = textusuario.Text;
            objeuserr.contraseña = textpass.Text;
            objeuserr.rol = txtRol.Text;

            var dt = user.users(objeuserr);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();

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
