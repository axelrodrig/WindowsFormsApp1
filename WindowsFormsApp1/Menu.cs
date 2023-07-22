using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu (string nombre)
        {
            InitializeComponent();

        }

        public Menu()
        {
            InitializeComponent();
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro_usuario registro_Usuarios = new Registro_usuario();
            registro_Usuarios.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes_de_estadisticas reportes_De_Estadisticas = new Reportes_de_estadisticas();
            reportes_De_Estadisticas.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Mostrar MessageBox y confirmar si desea salir
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario no desea salir, cancelar el cierre del formulario
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Reportes_de_estadisticas reportes_De_Estadisticas = new Reportes_de_estadisticas();
            reportes_De_Estadisticas.Show();
            this.Hide();


        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            resultado = MessageBox.Show("Desea salir de la app?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).ToString();
            if (resultado == "Yes")
            {
                Application.Exit();
            }

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {

            Prestamo_de_libro prestamo_De_Libro = new Prestamo_de_libro();
            prestamo_De_Libro.Show();
            this.Hide();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Devolución devolución = new Devolución();
            devolución.Show();
            this.Hide();
        }

        private void iconToolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            usuario_sistemaLG usuario_SistemaLG = new usuario_sistemaLG();
            usuario_SistemaLG.Show();
            this.Hide();
            
        }

        private void toolStripLabel3_Click_1(object sender, EventArgs e)
        {
            usuario_sistemaLG usuario_SistemaLG = new usuario_sistemaLG();
            usuario_SistemaLG.Show();
            this.Hide();
        }
    }
}
