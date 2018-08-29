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

namespace Database_Proyect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*SqlConnection conexion;
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ESCUELA;Trusted_Connection=True";
            conexion = new SqlConnection(connectionString);

            string query = "SELECT * FROM Alumnos";
            conexion.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();*/

            Update_Datagrid();
        }

        public void enable()
        {
            txt_nombre.Enabled = true;
            txt_amaterno.Enabled = true;
            txt_apaterno.Enabled = true;

            btn_insert.Visible = true;
            btn_cancel.Visible = true;
            btn_new.Enabled = false;
            btn_delete.Enabled = false;
            btn_select.Enabled = false;
            btn_update.Enabled = false;
        }

        public void saved()
        {
            txt_nombre.Enabled = false;
            txt_amaterno.Enabled = false;
            txt_apaterno.Enabled = false;

            btn_insert.Visible = false;
            btn_cancel.Visible = false;
            btn_new.Enabled = true;
            btn_delete.Enabled = true;
            btn_select.Enabled = true;
            btn_update.Enabled = true;
        }

        public void Update_Datagrid()
        {
            string conexionString = "Server=localhost\\SQLEXPRESS;Database=Escuela;Trusted_Connection=True";

            SqlConnection conexion;

            conexion = new SqlConnection(conexionString);

            SqlCommand comando;

            string query;

            query = "SELECT * FROM Alumnos";

            try
            {
                conexion.Open();

                comando = new SqlCommand(query, conexion);

                SqlDataAdapter da = new SqlDataAdapter(comando);

                DataTable datatable = new DataTable();

                da.Fill(datatable);

                dataGridView1.DataSource = datatable;

                datatable.Columns[0].ColumnName = "No_Control";
                datatable.Columns[1].ColumnName = "Nombre";
                datatable.Columns[2].ColumnName = "aPaterno";
                datatable.Columns[3].ColumnName = "aMaterno";

                comando.Dispose();

                conexion.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void reset()
        {

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        { 
            enable();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            SqlConnection conexion;

            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ESCUELA;Trusted_Connection=True";

            conexion = new SqlConnection(connectionString);

            SqlCommand comando;

            string query = "UPDATE Alumnos SET nombre ='" + txt_nombre.Text + "' , aPaterno ='" + txt_apaterno.Text + "', aMaterno='" + txt_amaterno.Text + "' where no_control= " + txt_nocontrol.Text;

            if (string.IsNullOrEmpty(txt_nocontrol.Text) || string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_apaterno.Text) || string.IsNullOrEmpty(txt_amaterno.Text))
            {
                MessageBox.Show("No se admiten campos vacios");
            }
            else
            {

                try
                {
                    conexion.Open();

                    comando = new SqlCommand(query, conexion);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Registro Actualizado");

                    comando.Dispose();

                    conexion.Close();

                    Update_Datagrid();
                }

                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }

                saved();

                Update_Datagrid();

                reset();
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            string conexionString = "Server=localhost\\SQLEXPRESS;Database=Escuela;Trusted_Connection=True";

            SqlConnection conexion;

            conexion = new SqlConnection(conexionString);

            SqlCommand comando;

            SqlDataReader dataReader;

            string query = "SELECT * FROM Alumnos WHERE no_control=" + txt_nocontrol.Text;

            conexion.Open();

            comando = new SqlCommand(query, conexion);

            if (string.IsNullOrEmpty(txt_nocontrol.Text))
            {
                MessageBox.Show("Necesita introducir el numero de control");
            }

            else
            {
                try
                {
                    dataReader = comando.ExecuteReader();
                    if (dataReader.Read())
                    {
                        enable();
                        btn_update.Enabled = true;

                        txt_nocontrol.Text = dataReader[0].ToString();
                        txt_nombre.Text = dataReader[1].ToString();
                        txt_apaterno.Text = dataReader[2].ToString();
                        txt_amaterno.Text = dataReader[3].ToString();
                    }
                    else
                        MessageBox.Show("El registro no existe");

                    comando.Dispose();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conexion.Close();
                }

                btn_cancel.Visible = true;
            }
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
                string conexionString = "Server=localhost\\SQLEXPRESS;Database=Escuela;Trusted_Connection=True";

                SqlConnection conexion;

                conexion = new SqlConnection(conexionString);

                SqlCommand comando;

                string query = "INSERT INTO Alumnos VALUES (" + txt_nocontrol.Text + ",'" + txt_nombre.Text + "' , '" + txt_apaterno.Text + "', '" + txt_amaterno.Text + "')";

                if (string.IsNullOrEmpty(txt_nocontrol.Text) || string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_apaterno.Text) || string.IsNullOrEmpty(txt_amaterno.Text))
                {
                    MessageBox.Show("No se admiten campos vacios");
                }
                else
                {
                    try
                    {
                        conexion.Open();

                        comando = new SqlCommand(query, conexion);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Registro Guardado");

                        comando.Dispose();

                        conexion.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    saved();

                    Update_Datagrid();

                    reset();
                }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            reset();
            saved();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection conexion;

            string connectionString = "Server=localhost\\SQLEXPRESS;Database=ESCUELA;Trusted_Connection=True";

            conexion = new SqlConnection(connectionString);

            SqlCommand comando;

            string query = "DELETE FROM Alumnos WHERE no_control = " + txt_nocontrol.Text;

            if (string.IsNullOrEmpty(txt_nocontrol.Text))
            {
                MessageBox.Show("Necesita introducir el numero de control");
            }
            else
            {

                try
                {
                    conexion.Open();

                    comando = new SqlCommand(query, conexion);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Registro Eliminado");

                    comando.Dispose();

                    conexion.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }

                Update_Datagrid();
                reset();
            }
        }
    }
}
