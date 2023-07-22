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
    public partial class Reportes_de_estadisticas : Form
    {
        public Reportes_de_estadisticas()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=AxelRodriguez\\SQLEXPRESS;Initial Catalog=EstadisticaBiblioteca;Integrated Security=True");


        private void Reportes_de_estadisticas_Load(object sender, EventArgs e)
        {
            //Consulta 
            using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
            {
                conexion.Open();

                string consulta = "select * from Usuario inner join Prestamo on Usuario.identificacion = Prestamo.id_usuario;";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader query = comando.ExecuteReader();
                if (query.Read())
                {
                    query.Close();

                    //Insertar información el el Data Grid View
                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                     DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtGV_SignaturasReport.DataSource = table;
                }
                else
                {
                    MessageBox.Show("No existe ningún registro de préstamo actualmente.");
                }

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
