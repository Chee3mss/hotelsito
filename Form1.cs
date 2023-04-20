using Microsoft.VisualBasic;
using Mysqlx;
using System.Drawing.Imaging;


namespace HOTEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string usuario, contraseña;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Usuariotxt.Clear();
            Contraseñatxt.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs E)
        {

            usuario = Convert.ToString(Usuariotxt.Text);
            contraseña = Convert.ToString(Contraseñatxt.Text);

            if (usuario == "2069392" && contraseña == "123")
            {
                Form nuevo = new Menu();
                nuevo.Show();
                this.Hide();
            }
            else if(usuario == "2069247" && contraseña == "456")
            {
                Form nuevo = new Menu();
                nuevo.Show();
                this.Hide();
            }
            else if (usuario == "2069565" && contraseña == "789")
            {
                Form nuevo = new Menu();
                nuevo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al entrar");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}


