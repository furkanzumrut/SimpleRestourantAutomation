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
    public partial class FormLogin : Form
    {
        SqlConnection connection = new SqlConnection("server=localhost;user id=sa;password=1");
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT username FROM restourant.dbo.personals", connection);
            //DataSet ds = new DataSet();

            //Console.WriteLine(adapter.Fill(ds));

            
            connection.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("SELECT * FROM restourant.dbo.personals WHERE username= @username and password=@password", connection);

            cmd.Parameters.Add("@username", textBox1.Text);
            cmd.Parameters.Add("@password", textBox2.Text);
            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlDataAdapter adaptor1 = new System.Data.SqlClient.SqlDataAdapter(cmd);
            adaptor1.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                FormMain f = new FormMain();
                int IsAdmin = Convert.ToInt16(dt.Rows[0].ItemArray.ElementAt(2));
                f.Set(IsAdmin);
                if (IsAdmin == 1)
                {
                    f.Text = "FormMain - System Administrator";
                }
                else {
                    f.Text = "FormMain - Personal Client";
                }
                f.Show();
                this.Hide();

               
            }else {
                MessageBox.Show("Wrong Password/Username. Try again!");
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
