using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Automation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public int Value;

        public void Set(int value)
        {
            Value = value;
        }
        public void changeButtonColor(){  
            button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            if (Value == 0) toolStripLabel3.Visible = false;

            
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            FormRezervation fr = new FormRezervation();
            fr.ShowDialog();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FormReport freport = new FormReport();
            freport.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            FormAddPersonel fpersonal = new FormAddPersonel();
            fpersonal.ShowDialog();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            FormChangePassword fc = new FormChangePassword();
            fc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this table?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormAddingFood faddingfood = new FormAddingFood();
                faddingfood.Set("1");
                faddingfood.ShowDialog();
                button1.BackColor = System.Drawing.Color.Firebrick;
                
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this table?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormAddingFood faddingfood = new FormAddingFood();
                faddingfood.Set("2");
                faddingfood.ShowDialog();
                button2.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this table?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormAddingFood faddingfood = new FormAddingFood();
                faddingfood.Set("3");
                faddingfood.ShowDialog();
                button3.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this table?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormAddingFood faddingfood = new FormAddingFood();
                faddingfood.Set("4");
                faddingfood.ShowDialog();
                button4.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this table?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormAddingFood faddingfood = new FormAddingFood();
                faddingfood.Set("5");
                faddingfood.ShowDialog();
                button8.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this table?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormAddingFood faddingfood = new FormAddingFood();
                faddingfood.Set("6");
                faddingfood.ShowDialog();
                button7.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this table?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormAddingFood faddingfood = new FormAddingFood();
                faddingfood.Set("7");
                faddingfood.ShowDialog();
                button6.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this table?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormAddingFood faddingfood = new FormAddingFood();
                faddingfood.Set("8");
                faddingfood.ShowDialog();
                button5.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this table?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormAddingFood faddingfood = new FormAddingFood();
                faddingfood.Set("9");
                faddingfood.ShowDialog();
                button12.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this table?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormAddingFood faddingfood = new FormAddingFood();
                faddingfood.Set("10");
                faddingfood.ShowDialog();
                button11.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this table?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormAddingFood faddingfood = new FormAddingFood();
                faddingfood.Set("11");
                faddingfood.ShowDialog();
                button10.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to open this table?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormAddingFood faddingfood = new FormAddingFood();
                faddingfood.Set("1");
                faddingfood.ShowDialog();
                button9.BackColor = System.Drawing.Color.Firebrick;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
