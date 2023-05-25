using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class registrar : Form
    {
        public registrar()
        {
            InitializeComponent();
        }

        //CONEXION 
        string CONEXION = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=EMPADRONAR;Integrated Security=True";
        
        //MOVER EL FORMULARIO

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        //   BOTON REGISTRAR 
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection())
            {

                SqlCommand cmd = new SqlCommand("  INSERT INTO REGISTRO (CUI, Nombre1, Nombre2) VALUES ( '" + txtDPI.Text +"', '" + txtNombre1.Text +"', '" + txtNombre2.Text +"')    ", cn);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteNonQuery();

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Form consult = new consulta();
            consult.Show();

            this.Hide();

        }


        private void txtSNombre_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtDPI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
