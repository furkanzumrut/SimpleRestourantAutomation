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
    public partial class FormPayment : Form
    {
        SqlConnection connection = new SqlConnection("server=localhost;user id=sa;password=1");
        public FormPayment()
        {
            InitializeComponent();
        }
        public string Value;
        public int Table;
        public void Set(string value)
        {
            Value = value;
        }
        public void SetTable(int table)
        {
            Table = table;
        }
        private void FormPayment_Load(object sender, EventArgs e)
        {
            label3.Text = Value+"$";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Received","Information");

            FormMain f = new FormMain();
            Console.WriteLine(Table);
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO restourant.dbo.report VALUES(@price,@date,@method)", connection);

            command.Parameters.AddWithValue("@price", Value);

            command.Parameters.AddWithValue("@date", DateTime.Now);

            command.Parameters.AddWithValue("@method", comboBox1.SelectedItem);

            command.ExecuteNonQuery();

            if (Table == 0) { 
                Console.WriteLine("It works!");
                f.changeButtonColor();
            
            }
            connection.Close();
            
            this.Close();
        }
    }
}
