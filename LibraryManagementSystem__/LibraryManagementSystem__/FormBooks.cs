using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem__
{
    public partial class FormBooks : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=MONSTER-ARDA;Initial Catalog=DbYtLibrary;Integrated Security=True;");


        public FormBooks()
        {
            InitializeComponent();
        }

        private void buttonNewBookAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableBooks (BookName,WriterName, WriterSurname,ISBN,Situation,BookTypeCode) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
                sqlCommand.Parameters.AddWithValue("@p1", textBoxBookName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", textBoxWriterName.Text);
                sqlCommand.Parameters.AddWithValue("@p3", textBoxWriterSurname.Text);
                sqlCommand.Parameters.AddWithValue("@p4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@p5", "true");
                sqlCommand.Parameters.AddWithValue("@p6", textBoxBookTypeCode.Text);


                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the book !" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            DataShow();

        }

        private void DataShow()
        {
            try
            {
                string q = "SELECT  * FROM TableBooks";
                SqlDataAdapter da = new SqlDataAdapter(q, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            DataShow();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelReturnLateFee.Text = "0";
            int SelectedRow = dataGridView1.SelectedCells[0].RowIndex;
            labelID.Text = dataGridView1.Rows[SelectedRow].Cells[0].Value.ToString();
            textBoxBookName.Text = dataGridView1.Rows[SelectedRow].Cells[1].Value.ToString();
            textBoxWriterName.Text = dataGridView1.Rows[SelectedRow].Cells[2].Value.ToString();
            textBoxWriterSurname.Text = dataGridView1.Rows[SelectedRow].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridView1.Rows[SelectedRow].Cells[4].Value.ToString();
            textBoxBookTypeCode.Text = dataGridView1.Rows[SelectedRow].Cells[8].Value.ToString();


            textBoxBorrower.Text = dataGridView1.Rows[SelectedRow].Cells[6].Value.ToString();

            if (dataGridView1.Rows[SelectedRow].Cells[7].Value != System.DBNull.Value)
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[SelectedRow].Cells[7].Value;



        }

        private void buttonUpdateBookİnformation_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableBooks SET BookName = @p1,WriterName = @p2, WriterSurname = @p3,ISBN = @p4, BookTypeCode = @p5 WHERE ID = @p6", connection);
                sqlCommand.Parameters.AddWithValue("@p1", textBoxBookName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", textBoxWriterName.Text);
                sqlCommand.Parameters.AddWithValue("@p3", textBoxWriterSurname.Text);
                sqlCommand.Parameters.AddWithValue("@p4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@p5", textBoxBookTypeCode.Text);
                sqlCommand.Parameters.AddWithValue("@p6", labelID.Text);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the book !" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            DataShow();
        }

        private void buttonLendTheBook_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableBooks SET Borrower = @p1,BorrowerDate = @p2, Situation = @p3  WHERE ID = @p4", connection);
                    sqlCommand.Parameters.AddWithValue("@p1", textBoxBorrower.Text);
                    sqlCommand.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@p3", "False");
                    sqlCommand.Parameters.AddWithValue("@p4", labelID.Text);
                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while borrowing a book !" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please choose a book from the list !");
            }
            DataShow();
        }

        private void buttonCalculateReturnLateFee_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                DateTime TodayDate = DateTime.Now;
                int TodayDifference = (int)(TodayDate - dateTimePicker1.Value.Date).TotalDays;
                if (TodayDifference > 10)
                {
                    int ReturnLateFee = (TodayDifference - 10) * 2;
                    labelReturnLateFee.Text = ReturnLateFee.ToString();
                }

            }
            DataShow();
        }

        private void buttonBookReturn_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableBooks SET Borrower = @p1, @p2, Situation = @p3  WHERE ID = @p4", connection);
                    sqlCommand.Parameters.AddWithValue("@p1", " ");
                    sqlCommand.Parameters.Add("@p2", SqlDbType.Date).Value = DBNull.Value;
                    sqlCommand.Parameters.AddWithValue("@p3", "False");
                    sqlCommand.Parameters.AddWithValue("@p4", labelID.Text);
                    sqlCommand.ExecuteNonQuery();
                    textBoxBorrower.Text = " ";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem with the book return process !" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                DataShow();

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        public void clearTextBox()
        {
            labelID.Text = "-";
            textBoxBookName.Text = " ";
            textBoxWriterName.Text = " ";
            textBoxWriterSurname.Text = " ";
            textBoxISBN.Text = " ";
            textBoxBookTypeCode.Text = " ";
            textBoxBorrower.Text = " ";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchShow();
        }
        private void SearchShow()
        {
            try
            {
                string q = "SELECT * FROM TableBooks WHERE BookName LIKE '" + textBoxBookName.Text
                                                                          + "%' AND WriterName LIKE '" + textBoxWriterName.Text + "%'"
                                                                          + " AND WriterSurname LIKE '" + textBoxWriterSurname.Text + "%'"
                                                                          + " AND ISBN LIKE '" + textBoxISBN.Text + "%'"
                                                                          + " AND BookTypeCode LIKE '" + textBoxBookTypeCode.Text + "%'"
                                                                          + " AND Borrower LIKE '" + textBoxBorrower.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(q, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDataShow_Click(object sender, EventArgs e)
        {
            DataShow();
        }

        private void buttonBookDelete_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "-" || labelID.Text == "")
            {
                MessageBox.Show("Please select the book to be listed");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableBooks WHERE ID = @p1", connection);
                    sqlCommand.Parameters.AddWithValue("@p1", labelID.Text);

                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the book !" + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                DataShow();
                clearTextBox();
            }
        }

        private void FormBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
