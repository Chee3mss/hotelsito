using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            Form xd = new Form1();
            xd.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form cerrar = new Menu();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form check_in = new Check_in();
            check_in.Show();

            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Check_Out = new Check_Out();
            Check_Out.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form UwU = new Consulta();
            UwU.Show();

            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrar);
        }

        private void cerrar(object sender, EventArgs e)
        {
            Form1 Sesion = new Form1();
            Sesion.Show();
        }
    }
}
