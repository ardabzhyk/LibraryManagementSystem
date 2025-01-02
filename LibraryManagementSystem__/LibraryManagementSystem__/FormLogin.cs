using System.Data.SqlClient;

namespace LibraryManagementSystem__
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        FormBooks formBooks;

        SqlConnection connection = new SqlConnection(@"Data Source=MONSTER-ARDA;Initial Catalog=DbYtLibrary;Integrated Security=True;");


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string password = "";
            try
            {
                connection.Open();
                SqlCommand sqlkomut = new SqlCommand("SELECT Password FROM TableLibraryAdminastor WHERE Username = @p1", connection);

                sqlkomut.Parameters.AddWithValue("@p1", textBoxUsername.Text);

                SqlDataReader sqlDataReader = sqlkomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    password = sqlDataReader[0].ToString();
                }

                if (password == textBoxPassword.Text)
                {
                    MessageBox.Show("Login succesful.");

                    formBooks = new FormBooks();
                    this.Hide();
                    formBooks.Show();


                }
                else
                {
                    MessageBox.Show("Username or Password is wrong !");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
