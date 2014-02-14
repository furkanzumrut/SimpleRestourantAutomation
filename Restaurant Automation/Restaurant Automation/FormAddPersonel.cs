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

namespace Restaurant_Automation
{
    public partial class FormAddPersonel : Form
    {
        SqlConnection connection = new SqlConnection("server=localhost;user id=sa;password=1");
        public FormAddPersonel()
        {
            InitializeComponent();
        }
        private void RefreshDatabase()
        {
            connection.Open();

            try
            {



               

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM restourant.dbo.personals", connection);
                //adapter.InsertCommand.Parameters.Add("",);
                DataSet ds = new DataSet();


                adapter.Fill(ds);//Tables[0]

                dataGridView1.DataSource = ds.Tables[0];

            }

            catch (SqlException s)
            {

                Console.WriteLine(s);

            }

            connection.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO restourant.dbo.personals VALUES(@username,@password,@IsAdmin)", connection);
            command.Parameters.AddWithValue("@username", textBox2.Text);
            command.Parameters.AddWithValue("@password", textBox1.Text);
            command.Parameters.AddWithValue("@IsAdmin", comboBox1.SelectedIndex);
            command.ExecuteNonQuery();
            connection.Close();
            RefreshDatabase();
        }

        private void FormAddPersonel_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            RefreshDatabase();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM restourant.dbo.personals WHERE username=@username", connection);
                command.Parameters.AddWithValue("@username", textBox2.Text);
                command.ExecuteNonQuery();
                connection.Close();
                RefreshDatabase();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowid = e.RowIndex;
            textBox2.Text = dataGridView1.Rows[rowid].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[rowid].Cells[1].Value.ToString();

            if (dataGridView1.Rows[rowid].Cells[2].Value.ToString().Equals("1")) comboBox1.SelectedIndex = 1;
            else comboBox1.SelectedIndex = 0;
            
        }
    }
}
