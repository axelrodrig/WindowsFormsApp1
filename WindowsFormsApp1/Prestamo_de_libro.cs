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
    public partial class Prestamo_de_libro : Form
    {

        public Prestamo_de_libro()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Préstamos prestamo_En_Sala = new Préstamos();
            prestamo_En_Sala.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btndevolucion_Click(object sender, EventArgs e)
        {
            Devolución  devolucion= new  Devolución();
            devolucion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Préstamos prestamo_En_Sala = new Préstamos();
            prestamo_En_Sala.Show();
            this.Hide();
          
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

        private void Prestamo_de_libro_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Prestamo_de_libro_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Préstamos prestamo_En_Sala = new Préstamos();
            prestamo_En_Sala.Show();
            this.Hide();

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Préstamos prestamo_En_Sala = new Préstamos();
            prestamo_En_Sala.Show();
            this.Hide();
        }
    } 
}
