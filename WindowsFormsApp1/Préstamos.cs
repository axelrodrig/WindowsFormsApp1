using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace WindowsFormsApp1
{
    public partial class Préstamos : Form
    {
        public Préstamos()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Conversión de lista de Signaturas a arreglo
            string[] SignaturasArray = Signaturas.ToArray();
             string signaturasArrayInOne = string.Join(",", SignaturasArray),
             idUsuario = txt_IDUsuario.Text,
             aprobadoPor = txt_aprobadoPor.Text;
            
            if (idUsuario == "" || idUsuario.Length < 8 || idUsuario.Length > 15 || aprobadoPor == "")
            {
                MessageBox.Show("La identificación el Usuario puede ser:\n1- Carnet de Estudiante\n1- Cédula de Identidad.\n\nPor favor, ingresa credenciales válidas.");
            }
            else
            {

                using (SqlConnection oconexion = new SqlConnection(ConexionDB.cadena))
                {
                    oconexion.Open();
                    string consulta1 = "select * from Usuario where identificacion = @idUsuario";
                    SqlCommand comando = new SqlCommand(consulta1, oconexion);
                    comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                    SqlDataReader query1 = comando.ExecuteReader();
                    if (query1.Read())
                    {
                        query1.Close();
                        string consulta2 = "select * from Prestamo where id_usuario = @idUsuario";
                        SqlCommand comando2 = new SqlCommand(consulta2, oconexion);
                        comando2.Parameters.AddWithValue("@idUsuario", idUsuario);
                        SqlDataReader query2 = comando2.ExecuteReader();
                        if (query2.Read())
                        {
                            string signaturasBase = query2["signaturas"].ToString()+","+signaturasArrayInOne;
                            Signaturas.Clear();
                            query2.Close();

                            //Actualizar el campo de signaturas
                            string actualizar = "update Prestamo set signaturas = @signaturas where id_usuario = @idUsuario";
                            using (SqlCommand comando4 = new SqlCommand(actualizar, oconexion))
                            {
                                comando4.Parameters.AddWithValue("@signaturas", signaturasBase);
                                comando4.Parameters.AddWithValue("@idUsuario", idUsuario);

                                comando4.ExecuteNonQuery();

                                MessageBox.Show("Registro guardado ", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txt_IDUsuario.Text = "";
                                dtGV_Signaturas.Rows.Clear();
                            }
                        }
                        else
                        {
                            query2.Close();

                            //Registrar un nuevo préstamo
                            try
                            {
                                string registrar = "insert into Prestamo (fecha_prestamo, id_usuario, estado_prestamo, aprobado_por, signaturas) values (@fecha_prestamo, @id_usuario, @estado_prestamo, @aprobado_por, @signaturas)";

                                using (SqlCommand comando3 = new SqlCommand(registrar, oconexion))
                                {
                                    comando3.Parameters.AddWithValue("@fecha_prestamo", timeToday.ToString());
                                    comando3.Parameters.AddWithValue("@id_usuario", idUsuario);
                                    comando3.Parameters.AddWithValue("@estado_prestamo", "Pendiente");
                                    comando3.Parameters.AddWithValue("@aprobado_por", aprobadoPor);
                                    comando3.Parameters.AddWithValue("@signaturas", signaturasArrayInOne);

                                    comando3.ExecuteNonQuery();

                                    MessageBox.Show("Registro guardado ", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    txt_IDUsuario.Text = "";
                                    txt_aprobadoPor.Text = "";
                                    dtGV_Signaturas.Rows.Clear();
                                    Signaturas.Clear();
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(" - Error " + ex.Message, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        query1.Close();
                        MessageBox.Show("");
                    }
                }
            }
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Prestamo_de_libro prestamo_De_Libro = new Prestamo_de_libro();
            prestamo_De_Libro.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Lista de signaturas
        List<string> Signaturas = new List<string>();
        DateTime timeToday = DateTime.Now;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string signatura = txt_AgregarSignaturaList.Text;

            if (signatura != "" && signatura != " ")
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDB.cadena))
                {
                    oconexion.Open();

                    string consulta = "select * from Libro where signatura=" + signatura;

                    //codeNew
                    SqlCommand comando = new SqlCommand(consulta, oconexion);
                    SqlDataReader query = comando.ExecuteReader();
                    if (query.Read())
                    {
                        Signaturas.Add(signatura);
                        int n = dtGV_Signaturas.Rows.Add();

                        //Insertar información el el Data Grid View
                        dtGV_Signaturas.Rows[n].Cells[0].Value = signatura;
                        txt_AgregarSignaturaList.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar la Signatura a la lista debido a que no se encuentra en la Base de Datos.");
                    }

                }
            }
            else
            {
                MessageBox.Show("No se puede agregar valores vacíos. por favor, ingresa credenciales correctas.");
            }

        }

        private void txtSignatura_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarSignatura_Click(object sender, EventArgs e)
        {
            string aggSignatura = txt_AgregarSignatura.Text;

            using (SqlConnection oconexion = new SqlConnection(ConexionDB.cadena))
            {
                oconexion.Open();

                string consulta = "select * from Libro where signatura=" + aggSignatura;

                
                SqlCommand comando = new SqlCommand(consulta, oconexion);
                SqlDataReader query = comando.ExecuteReader();
                
                if (query.Read())
                {
                    MessageBox.Show("La signatura que intenta registrar ya se encuentra existente en la Base de Datos.\nNo se puede duplicar el registro de las Signaturas.");
                }
                else
                {
                    query.Close();

                    try
                    {
                       //Registrar en SQL
                       string registro = "Insert Into Libro (signatura) Values (@signatura)";

                       using (SqlCommand comando2 = new SqlCommand(registro, oconexion))
                       {
                           comando2.Parameters.AddWithValue("@signatura", aggSignatura);

                           comando2.ExecuteNonQuery();

                           MessageBox.Show("Registro guardado ", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_AgregarSignatura.Text = "";
                       }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(" - Error " + ex.Message, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }   
        }

        private void dtGV_Signaturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
