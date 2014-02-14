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
    public partial class FormRezervation : Form
    {
        SqlConnection connection = new SqlConnection("server=localhost;user id=sa;password=1");
        public FormRezervation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO restourant.dbo.rezervation VALUES(@table,@rezervation)", connection);
            command.Parameters.AddWithValue("@table", comboBox1.SelectedIndex);

            command.Parameters.AddWithValue("@rezervation", 1);


            command.ExecuteNonQuery();
            connection.Close();

        }

        private void FormRezervation_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
