using MySql.Data.MySqlClient;
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
    public partial class Check_Out : Form
    {
        public Check_Out()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Database=hotel;data source = localhost;user id=root; pass =; SSL Mode = None;";

            MySqlConnection conexionDb;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDb = new MySqlConnection(cadenaConexion);

                MySqlCommand comando = new MySqlCommand("SELECT * FROM hotel where Vigencia=true", conexionDb);
                comando.CommandType = CommandType.Text;

                conexionDb.Open();

                resultado = comando.ExecuteReader();
                datatable.Load(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView2.DataSource = datatable;
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Database=hotel;data source = localhost;user id=root; pass =; SSL Mode = None;";

            MySqlConnection conexionDb;
            DataTable datatable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDb = new MySqlConnection(cadenaConexion);

                MySqlCommand comando = new MySqlCommand("UPDATE hotel SET Vigencia = false where id = " + textBox1.Text, conexionDb);
                comando.CommandType = CommandType.Text;

                conexionDb.Open();

                resultado = comando.ExecuteReader();
                datatable.Load(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Clear();
        }
    }
}
