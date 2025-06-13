using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void CargarDatos()
        {
            try
            {
                string conexion = "Data Source=LAB-INF-15\\SQLEXPRESS;Initial Catalog=Usuario;Integrated Security=True;";
                SqlConnection connection = new SqlConnection(conexion);
                connection.Open();
                string query = " select nombre,apellido from paolita";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);



                DataSet ds = new DataSet();
                Adapter.Fill(ds, "paolita");
                dataGridView1.DataSource = ds.Tables["paolita"];
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void Crear()
        {
            try
            {
                string conexion = "Data Source=LAB-INF-15\\SQLEXPRESS;Initial Catalog=Usuario;Integrated Security=True;";
                SqlConnection connection = new SqlConnection(conexion);
                connection.Open();
                string query = "insert into paolita(nombre,apellido)values(@nombre,@apellido)";
                SqlCommand cdm = new SqlCommand(query, connection);
                cdm.Parameters.AddWithValue("@nombre", txtnombre.Text);
                cdm.Parameters.AddWithValue("@apellido", txtapellido.Text);

                cdm.ExecuteNonQuery();

                MessageBox.Show("se guardo exitosamente");

                CargarDatos();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void Actualizar()
        {
            try
            {
                string conexion = "Data Source=LAB-INF-15\\SQLEXPRESS;Initial Catalog=Usuario;Integrated Security=True;";
                SqlConnection connection = new SqlConnection(conexion);
                connection.Open();
                string query = "update paolita set nombre=@nombre,apellido=@apellido where id= @id;";
                SqlCommand cdm = new SqlCommand(query, connection);
                cdm.Parameters.AddWithValue("@nombre", txtnombre.Text);
                cdm.Parameters.AddWithValue("@apellido", txtapellido.Text);

                cdm.ExecuteNonQuery();

                MessageBox.Show("Los cambios se realizaron exitosamente");

                CargarDatos();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Crear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LBLID.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }
    }
}