using K4os.Compression.LZ4.Encoders;
using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HOTEL
{
    public partial class Check_in : Form
    {
        public Check_in()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Check_in_Load(object sender, EventArgs e)
        {

        }

        public void btnadd_Click(object sender, EventArgs e)
        {

            string nombre, telefono, edad, noches, Habitacion, total, entrada;

            nombre = txtNombre.Text;
            telefono = txtTelefono.Text;
            edad = n_edad.Value.ToString();
            noches = n_noches.Value.ToString();
            Habitacion = n_hab.Text;
            total = txtTotal.Text;
            entrada = dataEntrada.Text;
            MySqlConnection conexion = new MySqlConnection("Database=hotel;data source = localhost;user id=root; pass =; SSL Mode = None;");

            conexion.Open();

            string consulta = "INSERT INTO hotel values(null,'" + nombre + "','" + telefono + "','" + edad + "','" + noches + "','" + Habitacion + "','" + total + "','" + entrada + "');";

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();


            conexion.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime fechita = DateTime.Today;
            dataEntrada.MinDate = fechita;
            DateTime femax = DateTime.Today.AddDays(3);
            dataEntrada.MaxDate = femax;
        }

        private void dataEntrada_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++) //La variable i es para recorrer por cada numero de habitacion
            {
                string dias = n_noches.Value.ToString();
                int dias2 = int.Parse(dias);
                for (int v = 0; v < dias2; v++) //La variable v es para verificar cada noche del hospedaje
                {
                    DateTime fecha_prog = dataEntrada.Value.AddDays(v);

                    string cadenaConexion = "Database=hotel;data source=localhost;user id=root;pass=;SSL Mode=None;";
                    MySqlConnection conexionDb;
                    try
                    {
                        conexionDb = new MySqlConnection(cadenaConexion);
                        Int64 hospe;
                        MySqlCommand comando = new MySqlCommand("SELECT COUNT(id) FROM hotel where id_hab=" + i, conexionDb);
                        comando.CommandType = CommandType.Text;

                        conexionDb.Open();

                        object resultado1 = comando.ExecuteScalar();
                        hospe = Convert.ToInt64(resultado1);
                        Int32[] arreglito = new Int32[hospe];
                        for (int x = 1; x <= hospe; x++)
                        {

                            try
                            {
                                MySqlCommand instru = new MySqlCommand("SELECT id FROM hotel where id_hab=" + i, conexionDb);
                                instru.CommandType = CommandType.Text;
                                object resultado2 = instru.ExecuteScalar();
                                arreglito[x - 1] = Convert.ToInt32(resultado2);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }

                        for (int y = 0; y < hospe; y++)
                        {
                            try
                            {
                                Int32 dias_hospedados = 0;
                                MySqlCommand instru = new MySqlCommand("SELECT dias FROM hotel where id = " + arreglito[y], conexionDb);
                                instru.CommandType = CommandType.Text;

                                object resultado2 = instru.ExecuteScalar();
                                dias_hospedados = Convert.ToInt32(resultado2);
                                for (int z = 0; z < dias_hospedados; z++)
                                {
                                    try
                                    {
                                        MySqlCommand orden = new MySqlCommand("SELECT entrada FROM hotel where id=" + arreglito[y], conexionDb);
                                        orden.CommandType = CommandType.Text;

                                        object resultado3 = orden.ExecuteScalar();
                                        DateTime fecha_sql = Convert.ToDateTime(resultado3);
                                        DateTime fecha_sql2 = fecha_sql.AddDays(z);
                                        if (fecha_prog.Day == fecha_sql2.Day)
                                        {
                                            n_hab.Items.Remove(i);
                                        }

                                        if (fecha_prog.Day != fecha_sql2.Day)
                                        {

                                            label23.Text = fecha_prog.ToString();
                                            label24.Text = fecha_sql2.ToString() + i.ToString();
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}

