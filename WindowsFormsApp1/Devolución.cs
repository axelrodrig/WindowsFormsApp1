using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Devolución : Form
    {
        public Devolución()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            resultado = MessageBox.Show("Desea salir de la app?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).ToString();
            if (resultado == "Yes")
            {
                Application.Exit();
            }
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string idU;
        private void btn_consultarUPrestamo_Click(object sender, EventArgs e)
        {
            string idUsuario = txt_consultarUPrestamo.Text;
            idU = idUsuario;
            List<string> signaturasArray = new List<string>();

            if (idUsuario != "" && idUsuario != " ")
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDB.cadena))
            {
                oconexion.Open();

                string consulta = "select * from Usuario where identificacion = " + idUsuario;

                //codeNew
                SqlCommand comando = new SqlCommand(consulta, oconexion);
                SqlDataReader query = comando.ExecuteReader();
                if (query.Read())
                {
                    query.Close();

                        //Insertar información el el Data Grid View de Usuario
                    SqlDataAdapter dt = new SqlDataAdapter(consulta, oconexion);
                    DataTable table = new DataTable();
                    dt.Fill(table);
                    dtGV_Usuario.DataSource = table;


                    string consulta2 = "select signaturas from Prestamo where id_usuario=" + idUsuario;
                    //codeNew
                    SqlCommand comando2 = new SqlCommand(consulta2, oconexion);
                    SqlDataReader query2 = comando2.ExecuteReader();
                    if (query2.Read())
                    {
                         string signaturas = query2["signaturas"].ToString();
                         signaturasArray.Add(signaturas);
                         string[] arr = signaturasArray.ToArray();
                         string[] Signatura = arr[0].Split(',');
                         signaturasArray.Clear();
                         dtGV_SignaturasU.Rows.Clear();
                         
                            //Mostrar información en las celdas
                         foreach (string item in Signatura)
                         {
                             dtGV_SignaturasU.Rows.Add(item);
                         }
                         query2.Close();
                    }
                    else
                    {
                        MessageBox.Show("Revise las credenciales he ingreselas nuevamente, por favor.");
                    }
                        
                }
                else
                {
                    MessageBox.Show("Revise las credenciales e ingreselas nuevamente.");
                }
            }
            }
            else
            {
                MessageBox.Show("Es posible que esté dejando espacios en blanco.\nRevise las credenciales e ingreselas nuevamente.");
            }


        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

            string fechaDevolucion = fecha_DevolucionSignatura.Text,
                recibidoPor = select_Recibido.Text;

            if (idU != "" && fechaDevolucion != "" && recibidoPor != "")
            {
                try
                {
                    using (SqlConnection oconexion = new SqlConnection(ConexionDB.cadena))
                    {
                        oconexion.Open();

                        string consulta = "update Prestamo set fecha_devolucion = @fechaDevolucion, estado_prestamo =@estadoPrestamo, recibido_por =@recibidoPor where id_usuario = " + idU;

                        SqlCommand comando = new SqlCommand(consulta, oconexion);

                        comando.Parameters.AddWithValue("@fechaDevolucion", fechaDevolucion);
                        comando.Parameters.AddWithValue("@estadoPrestamo", "Entregado");
                        comando.Parameters.AddWithValue("@recibidoPor", recibidoPor);
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Registro guardado ", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    select_Recibido.Text = "";
                    txt_consultarUPrestamo.Text = "";
                    dtGV_Usuario.DataSource = "";
                    dtGV_SignaturasU.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" - Error " + ex.Message, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, ingresa las credenciales.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
