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
    public partial class usuario_sistemaLG : Form
    {
        public usuario_sistemaLG()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
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
    }
}
