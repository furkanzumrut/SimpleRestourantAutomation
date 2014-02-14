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
    public partial class FormReport : Form
    {
        SqlConnection connection = new SqlConnection("server=localhost;user id=sa;password=1");
        public FormReport()
        {
            InitializeComponent();
        }
        private void RefreshDatabase()
        {

            try
            {

               

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM restourant.dbo.report", connection);
                //adapter.InsertCommand.Parameters.Add("",);
                DataSet ds = new DataSet();
                

                adapter.Fill(ds);//Tables[0]

                dataGridView1.DataSource = ds.Tables[0];

            }

            catch (SqlException s)
            {

                Console.WriteLine(s);

            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            RefreshDatabase();
        }
    }
}
