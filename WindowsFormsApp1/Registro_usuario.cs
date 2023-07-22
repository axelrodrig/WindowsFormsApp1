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

namespace WindowsFormsApp1
{
    public partial class Registro_usuario : Form
    {
        public Registro_usuario()
        {
            InitializeComponent();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            txtidentificacion.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtaño.Clear();
            txtTurno.Clear();
            txtCarrera.Clear();
        }

       

        private void iconButton3_Click(object sender, EventArgs e)
        {

            using (SqlConnection oconexion = new SqlConnection(ConexionDB.cadena))
            {
                oconexion.Open();

                string consulta = "UPDATE Usuario SET " +
                                  "nombres = '" + txtNombre.Text + "', " +
                                  "apellidos = '" + txtApellido.Text + "', " +
                                  "telefono = '" + txtCorreo.Text + "', " +
                                  "carrera = '" + txtaño.Text + "', " +
                                  "correo = '" + txtTelefono.Text + "', " +
                                  "direccion = '" + txtDireccion.Text + "', " +
                                  "año = '" + txtTurno.Text + "', " +
                                  "turno = '" + txtCarrera.Text + "' " +
                                  "WHERE id_usuario = " + txtidentificacion.Text;

                SqlCommand comando = new SqlCommand(consulta, oconexion);
                int cant = comando.ExecuteNonQuery();

                if (cant > 0)
                {
                    MessageBox.Show("Registro modificado");
                }

                oconexion.Close();
            }
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

        private void Registro_usuario_Load(object sender, EventArgs e)
        {
            SqlConnection oconexion = new SqlConnection(ConexionDB.cadena);
            oconexion.Open();
            string query = "select * from Usuario;";
            SqlCommand comando = new SqlCommand(query, oconexion);
            SqlDataReader reader = comando.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgvcrud.DataSource = table;


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtidentificacion.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtaño.Clear();
            txtTurno.Clear();
            txtCarrera.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //    using (SqlConnection oconexion = new SqlConnection(ConexionDB.cadena))
            //    {
            //        oconexion.Open();

            //        string consulta = "UPDATE Usuario SET " +
            //                          "nombres = '" + txtNombre.Text + "', " +
            //                          "apellidos = '" + txtApellido.Text + "', " +
            //                          "telefono = '" + txtCorreo.Text + "', " +
            //                          "carrera = '" + txtaño.Text + "', " +
            //                          "correo = '" + txtTelefono.Text + "', " +
            //                          "direccion = '" + txtDireccion.Text + "', " +
            //                          "año = '" + txtTurno.Text + "', " +
            //                          "turno = '" + txtCarrera.Text + "' " +
            //                          "WHERE id_usuario = " + txtidentificacion.Text;

            //        SqlCommand comando = new SqlCommand(consulta, oconexion);
            //        int cant = comando.ExecuteNonQuery();

            //        if (cant > 0)
            //        {
            //            MessageBox.Show("Registro modificado");
            //        }

            //        oconexion.Close();
            //    }


            if (dgvcrud.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para modificar", "registro no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int IDusuario = Convert.ToInt32(dgvcrud.SelectedRows[0].Cells["id_usuario"].Value);


            string identificacion = txtidentificacion.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string carrera = txtCarrera.Text;
            string correo = txtCorreo.Text;
            string direccion = txtDireccion.Text;
            string año = txtaño.Text;
            string turno = txtTurno.Text;
            string tipoE = cmbTipoUsuarioo.Text;
            int tipoID = 0;

            if (tipoE == "ESTUDIANTES")
            {
                tipoID = 1;
            }
            else if (tipoE == "DOCENTES")
            {
                tipoID = 2;
            }
            else if (tipoE == "EXTERNO")
            {
                tipoID = 3;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    conexion.Open();

                    string Actualizar = "UPDATE Usuario SET nombres = @nombres, apellidos = @apellidos, identificacion = @identificacion, direccion = @direccion, telefono = @telefono, correo = @correo, id_tipoUsuario = @IDuser, carrera = @carrera, turno= @turno, año = @año WHERE id_usuario = @IDusuario";

                    using (SqlCommand comando = new SqlCommand(Actualizar, conexion))
                    {

                        comando.Parameters.AddWithValue("@nombres", nombre);
                        comando.Parameters.AddWithValue("@apellidos", apellidos);
                        comando.Parameters.AddWithValue("@identificacion", identificacion);
                        comando.Parameters.AddWithValue("@telefono", telefono);
                        comando.Parameters.AddWithValue("@carrera", carrera);
                        comando.Parameters.AddWithValue("@correo", correo);
                        comando.Parameters.AddWithValue("@direccion", direccion);
                        comando.Parameters.AddWithValue("@año", año);
                        comando.Parameters.AddWithValue("@turno", turno);
                        comando.Parameters.AddWithValue("@IDuser", tipoID);
                        comando.Parameters.AddWithValue("@IDusuario", IDusuario);


                        comando.ExecuteNonQuery();

                        MessageBox.Show("Registro Modificado correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex )
            {

                MessageBox.Show("No se puedo moficar"+ ex.Message, "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string identificacion = txtidentificacion.Text;
            string nombres = txtNombre.Text;
            string apellidos = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string carrera = txtCarrera.Text;
            string correo = txtCorreo.Text;
            string direccion = txtDireccion.Text;
            string año = txtaño.Text;
            string turno = txtTurno.Text;
            string tipoE = cmbTipoUsuarioo.Text;
            int tipoID = 0;

            if (tipoE == "ESTUDIANTES")
            {
                tipoID = 1;
            }
            else if (tipoE == "DOCENTES")
            {
                tipoID = 2;
            }
            else if (tipoE == "EXTERNO")
            {
                tipoID = 3;
            }

            try
            {
                using (SqlConnection oconexion = new SqlConnection(ConexionDB.cadena))
                {
                    oconexion.Open();

                    //Registrar en SQL
                    string consulta = "Insert Into Usuario (nombres, apellidos, identificacion, direccion, telefono, correo, id_tipoUsuario, carrera, turno, año) Values (@nombres, @apellidos, @identificacion, @direccion, @telefono, @correo, @id_tipoUsuario, @carrera, @turno, @año)";

                    using (SqlCommand comando = new SqlCommand(consulta, oconexion))
                    {
                        comando.Parameters.AddWithValue("@nombres", nombres);
                        comando.Parameters.AddWithValue("@apellidos", apellidos);
                        comando.Parameters.AddWithValue("@identificacion", identificacion);
                        comando.Parameters.AddWithValue("@direccion", direccion);
                        comando.Parameters.AddWithValue("@telefono", telefono);
                        comando.Parameters.AddWithValue("@correo", correo);
                        comando.Parameters.AddWithValue("@id_tipoUsuario", tipoID);
                        comando.Parameters.AddWithValue("@carrera", carrera);
                        comando.Parameters.AddWithValue("@turno", turno);
                        comando.Parameters.AddWithValue("@año", año);


                        comando.ExecuteNonQuery();

                        MessageBox.Show("Registro guardado ", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" - Error " + ex.Message, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Prestamo_de_libro prestamo_De_Libro = new Prestamo_de_libro();
            prestamo_De_Libro.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvregistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            resultado = MessageBox.Show("Desea salir de la app?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2).ToString();
            if (resultado == "Yes")
            {
                Application.Exit();
            }

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void dgvcrud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvcrud.Rows[e.RowIndex];

            txtidentificacion.Text = row.Cells["identificacion"].Value.ToString();
            txtNombre.Text = row.Cells["nombres"].Value.ToString();
            txtApellido.Text = row.Cells["apellidos"].Value.ToString();
            txtTelefono.Text = row.Cells["telefono"].Value.ToString();
            txtCarrera.Text = row.Cells["carrera"].Value.ToString();
            txtCorreo.Text = row.Cells["correo"].Value.ToString();
            txtDireccion.Text = row.Cells["direccion"].Value.ToString();
            txtaño.Text = row.Cells["año"].Value.ToString();
            txtTurno.Text = row.Cells["turno"].Value.ToString();
            cmbTipoUsuarioo.SelectedValue = row.Cells["id_tipoUsuario"].Value.ToString();
            
        }

        public void Actualizar()
        {
            
            string query = "select * from Usuario;";

            DataTable dataTable = new DataTable();

            using(SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
            {
                using(SqlCommand comando = new SqlCommand(query, conexion))
                {
                    conexion.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    adapter.Fill(dataTable);
                }
            }

            dgvcrud.DataSource = dataTable;
            


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvcrud.SelectedRows.Count > 0)
            {

                int IDusuario = Convert.ToInt32(dgvcrud.SelectedRows[0].Cells["id_usuario"].Value);

                string Eliminar = "DELETE FROM Usuario WHERE id_usuario = @IDusuario";

                using(SqlConnection conexion = new SqlConnection(ConexionDB.cadena))
                {
                    conexion.Open();
                    using(SqlCommand comando = new SqlCommand(Eliminar, conexion))
                    {
                        comando.Parameters.AddWithValue("@IDusuario", IDusuario);
                        comando.ExecuteNonQuery();
                    }
                }

            }
            else
            {
                MessageBox.Show("Seleccione un registro para eliminar");
            }

            Actualizar();

        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
             
        }
    }
    }
  

