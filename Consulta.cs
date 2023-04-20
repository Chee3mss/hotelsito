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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }


        public Label Label1
        {
            get { return labelVIP; }
            set { labelVIP = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form check_in = new Check_in();
            check_in.Show();

            this.Close();

            this.Close();
        }

        private void lblSencilla_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
