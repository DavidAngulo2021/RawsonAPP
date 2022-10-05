using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawsonApp
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("server=LAPTOP-AMP5OCIH;Initial Catalog=Rawson;User ID=sa;Password=123456");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

          


      

            int Ident = int.Parse(textBox1.Text);
            string Nombre = textBox2.Text;
            string Apellido = textBox3.Text;
            string telefono = textBox4.Text;
            string telefono2 = textBox7.Text;
            string correo = textBox6.Text;
            string correo2 = textBox8.Text;
            string Dirreccion = textBox5.Text;
            DateTime fecha = dateTimePicker1.Value;
            string cadena = "insert into Cliente(identificacion,Nombre,Apellido,telefono,telefono2,correo,correo2,Direccion,Fecha_Nacimiento) values (" + Ident + ",'" + Nombre + "','" + Apellido + "','" + telefono + "','" + telefono2 + "','" + correo + "','" + correo2 + "','" + Dirreccion + "','" + fecha + "')";
            string con = "SELECT * FROM CLIENTE WHERE identificacion = " + Ident + "";
            


            SqlCommand cmd = new SqlCommand(con, conexion);
          
              try
                {
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos Guardado");
                    MessageBox.Show("Los datos se guardaron correctamente");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("La identificacion ya esta registrada " + Ident);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
                finally
                {
                    conexion.Close();
                }
            

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
    
}



