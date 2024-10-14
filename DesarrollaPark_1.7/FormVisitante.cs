using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DesarrollaPark_1._7
{
    public partial class FormVisitante : Form

    {
        public FormVisitante()
        {
            InitializeComponent();
            //llamar al inicio del programa
            MostrarDatosEnGrilla();


        }

        public class Visitante
        {
            public string Nombre;
            public string Apellido;
            public int Edad;
            public string DNI;
            public string Email;
            public string Telefono;
            public string Id_visitante;

            // Constructor
           

            public Visitante(string nombre, string apellido, int edad, string dni, string email, string telefono, string id_visitante)
            {
                Nombre = nombre;
                Apellido = apellido;
                Edad = edad;
                DNI = dni;
                Email = email;
                Telefono = telefono;
                Id_visitante = id_visitante;  // 
            }
            public Visitante()
            {
                Nombre = "";
                Apellido = "";
                Edad = 0;
                DNI = "";
                Email = "";
                Telefono = "";
                Id_visitante = "";
                
            }
        }
        //aca estaba load

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos de los campos de texto
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int edad = int.Parse(txtEdad.Text); // Convertir a entero
                string dni = txtDni.Text;
                string email = txtEmail.Text;
                string telefono = txtTelefono.Text;
                string id_visitante = txt_id_visitante.Text;


                // Crear un nuevo objeto Visitante
                Visitante nuevoVisitante = new Visitante(nombre, apellido, edad, dni, email, telefono, id_visitante);
           



                // Agrega un nuevo visitante al DataGridView dgvVisitante


                // Limpia los cuadros de texto después de agregar la Persona

                txtNombre.Clear();
                txtApellido.Clear();
                txtEdad.Clear();
                txtDni.Clear();
                txtEmail.Clear();
                txtTelefono.Clear();
                txt_id_visitante.Clear();


                // Conectar a la base de datos MySQL
                string connectionString = "Server=localhost;database=parquediversiones;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO visitante(Nombre, Apellido, Edad, DNI, Email, Telefono, Id_visitante) VALUES (@Nombre, @Apellido, @Edad, @DNI, @Email, @Telefono, @id_visitante)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {


                        // Agregar parámetros
                        command.Parameters.AddWithValue("@Nombre", nuevoVisitante.Nombre);
                        command.Parameters.AddWithValue("@Apellido", nuevoVisitante.Apellido);
                        command.Parameters.AddWithValue("@Edad", nuevoVisitante.Edad);
                        command.Parameters.AddWithValue("@DNI", nuevoVisitante.DNI);
                        command.Parameters.AddWithValue("@Email", nuevoVisitante.Email);
                        command.Parameters.AddWithValue("@Telefono", nuevoVisitante.Telefono);
                        command.Parameters.AddWithValue("@Id_visitante", nuevoVisitante.Id_visitante);

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)

                        {
                            // Obtener el ID generado automáticamente
                            long idGenerado = (long)command.LastInsertedId;

                            // Mostrar mensaje y agregar datos al DataGridView incluyendo el ID generado
                           
                            MessageBox.Show("Datos guardados correctamente.");
                            dgvVisitante.Rows.Add( nuevoVisitante.Nombre, nuevoVisitante.Apellido, nuevoVisitante.Edad, nuevoVisitante.DNI, nuevoVisitante.Email, nuevoVisitante.Telefono, idGenerado);

                        }


                        else
                        {
                            MessageBox.Show("No se pudo guardar los datos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }




        }        
            

        //////////////////////////////////////////////paso mostrar en grilla

        private void MostrarDatosEnGrilla()
        {
            try
            {
                // Cadena de conexión a la base de datos MySQL
                string connectionString = "Server=localhost;database=parquediversiones;Uid=root;Pwd=";//nombre de base de datos

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Id_visitante, Nombre, Apellido, Edad, DNI, Email, Telefono FROM visitante"; //cambie los datos de los campos y agregue la tabla visitante
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Asignar el DataTable al DataGridView
                            dgvVisitante.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        /////////////////////////////////////////////paso 3 btnEvento
        private void btnEvento_Click(object sender, EventArgs e)
        {
            
            FormVisitante frmVisitante = new FormVisitante();
            frmVisitante.Show();
        }

        ///////////////////////////////////////////// paso 4
        private void dgvVisitante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Eliminar()
        {
            try
            {
                // Verificar si se hizo clic en una celda y no en la cabecera
                if (dgvVisitante.SelectedCells.Count > 0)
                {
                    // Obtener el ID de la fila seleccionada (suponiendo que el nombre de la columna es "id_visitante")
                  
                    string idToString = dgvVisitante.SelectedCells[0].OwningRow.Cells["id_visitante"].Value.ToString();
                    int idToDelete = Convert.ToInt32(idToString);

                    // Cadena de conexión a la base de datos MySQL
                    string connectionString = "Server=localhost;Database=parquediversiones;Uid=root;Pwd=";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Consulta SQL para eliminar la fila con el ID seleccionado
                        string deleteQuery = $"DELETE FROM visitante WHERE id_visitante = {idToDelete}";
                        using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                        {
                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Fila eliminada correctamente.");
                                MostrarDatosEnGrilla();
                                // Actualizar el DataGridView después de eliminar
                                // Asegúrate de que tengas un adapter y una dataTable configurados correctamente
                                // adapter.Fill(dataTable);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar la fila.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la fila: " + ex.Message);
            }
        }

        // // //////////////////////////////////////////////////////paso 5 btnEliminar

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        // // //////////////////////////////////////////////////////////Paso 6 
        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVisitante frmVisitante = new FormVisitante();
            frmVisitante.Show();

        }
        
        // // ///////////////////////////////////////////////paso 7 btnModificar

        private void btnModificar_Click(object sender, EventArgs e)////////////me quede aca, hay algo raro con id visitante
        {
            try
            {
                // Obtén los valores de los cuadros de texto
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string id_visitante = txt_id_visitante.Text;
                int edad = int.Parse(txtEdad.Text);
                string dni = txtDni.Text;
                string email = txtEmail.Text;
                string telefono = txtTelefono.Text;

                // Verifica que el ID no esté vacío, ya que es necesario para realizar la actualización
                if (string.IsNullOrWhiteSpace(txt_id_visitante.Text))
                {
                    MessageBox.Show("El ID es necesario para actualizar los datos.");
                    return;
                }

                // Crea una instancia de la clase Persona con los valores
                Visitante visitanteActualizado = new Visitante(nombre, apellido, edad, dni, email, telefono, id_visitante);


                // Cadena de conexión a la base de datos MySQL
                string connectionString = "Server=localhost;Database=parquediversiones;Uid=root;Pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta de actualización
                    string query = "UPDATE visitante SET Nombre = @Nombre, Apellido = @Apellido, Edad = @Edad, DNI = @DNI, Email = @Email, Telefono = @Telefono WHERE Id_visitante = @Id_visitante";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Agregar parámetros
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@Edad", edad);
                        command.Parameters.AddWithValue("@DNI", dni);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Id_visitante", id_visitante);



                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos actualizados correctamente.");

                            // Limpia los cuadros de texto después de actualizar los datos
                            txtNombre.Clear();
                            txtApellido.Clear();
                            txt_id_visitante.Clear();
                            txtDni.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            txtEdad.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar los datos. Asegúrate de que el ID sea correcto.");
                        }
                    }
                }

                // Mostrar los datos actualizados en el DataGridView
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    
    }
}
