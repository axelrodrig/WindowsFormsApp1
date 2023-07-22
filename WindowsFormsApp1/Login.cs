using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        //public void logear(string usuario, string identificacion) {
        //    try 
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("SELECT nombre, Tipo_usuario from usuarios where usuario = @usuario and identificacion = @identificacion , con);
        //        //cmd.Parameters.AddWithValue("usuario", usuario);
        //        //cmd.Parameters.AddWithValue("pas", identificacion);
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);
        //        if (dt.Rows.Count == 1)
        //        {
        //            this.Hide();
        //            if (dt.Rows[0][1].ToString() == usuario){
        //                new Menu().Show();


        //            }
        //            else if (dt.Rows[0][1].ToString() == identificacion )
        //                {
        //                new Prestamo_de_libro(dt.Rows[0][0].ToString()).Show(); 
        //                }

        //        }else {
        //            MessageBox.Show("usuario y/o contraseña incorreta");

        //        }
        //    } catch(Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    } 
        //    finally
        //    {
        //        con.Close();
        //    }
        //}


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            string nombre = cbusuario.SelectedItem.ToString();
            string clave = txtidentificacion.Text;

            CD_Usuario oCD_Usuario = new CD_Usuario();
            DataTable dtUsuariosistema = new DataTable();
            dtUsuariosistema = oCD_Usuario.leerUsuarioSistema(nombre);
            
            if (clave == dtUsuariosistema.Rows[0]["clave"].ToString())
            {
                    MessageBox.Show("¡Haz iniciado sesión correctamente, bienvenido!");
                if(nombre == "DOCENTE" || nombre == "ESTUDIANTES" || nombre == "EXTERNOS")
                {
                    Prestamo_de_libro prestamo_de_libro = new Prestamo_de_libro();
                    prestamo_de_libro.Show();
                    this.Hide();
                }
                else if(nombre == "ADMINISTRADOR")
                {
                    Menu Menu = new Menu();
                    Menu.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK);
            }
            





        //    if (usuario != null)
        //    {
        //        if ((usuario.id_tipoUsuario == 1) || (usuario.id_tipoUsuario == 2) || (usuario.id_tipoUsuario == 4))
        //        {
        //            Prestamo_de_libro prestamo_De_Libro = new Prestamo_de_libro();
        //            prestamo_De_Libro.Show();
        //            this.Hide();

        //        }

        //        else if (usuario.id_tipoUsuario == 3)
        //        {
        //            Menú menu = new Menú();
        //            menu.Show();
        //            this.Hide();
        //        }

        //    }
        //    else
        //    {
        //        MessageBox.Show("usuario no encontrado", "accesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //    }
        //
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            resultado = MessageBox.Show("Desea salir de la app?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).ToString();
            if (resultado == "Yes")
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Registro_usuario registro = new Registro_usuario();
            registro.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Muestra.Checked)
            {
                txtidentificacion.PasswordChar = '\0'; // Mostrar contraseña
            }
            else
            {
                txtidentificacion.PasswordChar = '*'; // Ocultar contraseña

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
          
    }

        private void cbusuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



