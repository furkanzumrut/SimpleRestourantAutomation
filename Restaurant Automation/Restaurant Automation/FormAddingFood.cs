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

    public partial class FormAddingFood : Form
    {
        public FormAddingFood()
        {
            InitializeComponent();
        }
        public int totalPrice = 0;
        public string Value;

        public void Set(string value) {
            Value = value;
        }

        class food
        {
            public string foodName;
            public int foodPrice;
            public food(string fn, int fp) {
                foodName = fn;
                foodPrice = fp;
            }
        }


        food f1 = new food("Turkish Kebap", 15);
        food f2 = new food("Soup", 5);
        food f3 = new food("Spaghetti", 12);
        food f4 = new food("Chicken",10);
        food f5 = new food("Beef", 15);
        food f6 = new food("Salad", 3);
        food f7 = new food("Desert", 8);
        food f8 = new food("Beverage", 4);
        food f9 = new food("Appetizer", 6);
     
        private void FormAddingFood_Load(object sender, EventArgs e)
        {
            if (Value == "1") label1.Text = "TABLE 1 FOOD LIST";
            if (Value == "2") label1.Text = "TABLE 2 FOOD LIST";
            if (Value == "3") label1.Text = "TABLE 3 FOOD LIST";
            if (Value == "4") label1.Text = "TABLE 4 FOOD LIST";
            if (Value == "5") label1.Text = "TABLE 5 FOOD LIST";
            if (Value == "6") label1.Text = "TABLE 6 FOOD LIST";
            if (Value == "7") label1.Text = "TABLE 7 FOOD LIST";
            if (Value == "8") label1.Text = "TABLE 8 FOOD LIST";
            if (Value == "9") label1.Text = "TABLE 9 FOOD LIST";
            if (Value == "10") label1.Text = "TABLE 10 FOOD LIST";
            if (Value == "11") label1.Text = "TABLE 11 FOOD LIST";
            
            listBox1.Items.Add(f1.foodName);
            listBox1.Items.Add(f2.foodName);
            listBox1.Items.Add(f3.foodName);
            listBox1.Items.Add(f4.foodName);
            listBox1.Items.Add(f5.foodName);
            listBox1.Items.Add(f6.foodName);
            listBox1.Items.Add(f7.foodName);
            listBox1.Items.Add(f8.foodName);
            listBox1.Items.Add(f9.foodName);

            FormPayment fp = new FormPayment();
            fp.SetTable(Convert.ToInt16(Value));

            


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPayment fpayment = new FormPayment();
            fpayment.Set(Convert.ToString(totalPrice));
            fpayment.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            if (listBox1.SelectedItem == f1.foodName) totalPrice = totalPrice + f1.foodPrice;
            if (listBox1.SelectedItem == f2.foodName) totalPrice = totalPrice + f2.foodPrice;
            if (listBox1.SelectedItem == f3.foodName) totalPrice = totalPrice + f3.foodPrice;
            if (listBox1.SelectedItem == f4.foodName) totalPrice = totalPrice + f4.foodPrice;
            if (listBox1.SelectedItem == f5.foodName) totalPrice = totalPrice + f5.foodPrice;
            if (listBox1.SelectedItem == f6.foodName) totalPrice = totalPrice + f6.foodPrice;
            if (listBox1.SelectedItem == f7.foodName) totalPrice = totalPrice + f7.foodPrice;
            if (listBox1.SelectedItem == f8.foodName) totalPrice = totalPrice + f8.foodPrice;
            if (listBox1.SelectedItem == f9.foodName) totalPrice = totalPrice + f9.foodPrice;
            label3.Text = totalPrice + "$";

            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
                listBox2.Items.Clear();

            label3.Text = "0$";
            totalPrice = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == f1.foodName) totalPrice = totalPrice - f1.foodPrice;
            if (listBox2.SelectedItem == f2.foodName) totalPrice = totalPrice - f2.foodPrice;
            if (listBox2.SelectedItem == f3.foodName) totalPrice = totalPrice - f3.foodPrice;
            if (listBox2.SelectedItem == f4.foodName) totalPrice = totalPrice - f4.foodPrice;
            if (listBox2.SelectedItem == f5.foodName) totalPrice = totalPrice - f5.foodPrice;
            if (listBox2.SelectedItem == f6.foodName) totalPrice = totalPrice - f6.foodPrice;
            if (listBox2.SelectedItem == f7.foodName) totalPrice = totalPrice - f7.foodPrice;
            if (listBox2.SelectedItem == f8.foodName) totalPrice = totalPrice - f8.foodPrice;
            if (listBox2.SelectedItem == f9.foodName) totalPrice = totalPrice - f9.foodPrice;
            label3.Text = totalPrice + "$";
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            if (listBox1.SelectedItem == f1.foodName) totalPrice = totalPrice + f1.foodPrice;
            if (listBox1.SelectedItem == f2.foodName) totalPrice = totalPrice + f2.foodPrice;
            if (listBox1.SelectedItem == f3.foodName) totalPrice = totalPrice + f3.foodPrice;
            if (listBox1.SelectedItem == f4.foodName) totalPrice = totalPrice + f4.foodPrice;
            if (listBox1.SelectedItem == f5.foodName) totalPrice = totalPrice + f5.foodPrice;
            if (listBox1.SelectedItem == f6.foodName) totalPrice = totalPrice + f6.foodPrice;
            if (listBox1.SelectedItem == f7.foodName) totalPrice = totalPrice + f7.foodPrice;
            if (listBox1.SelectedItem == f8.foodName) totalPrice = totalPrice + f8.foodPrice;
            if (listBox1.SelectedItem == f9.foodName) totalPrice = totalPrice + f9.foodPrice;
            label3.Text = totalPrice + "$";
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItem == f1.foodName) totalPrice = totalPrice - f1.foodPrice;
            if (listBox2.SelectedItem == f2.foodName) totalPrice = totalPrice - f2.foodPrice;
            if (listBox2.SelectedItem == f3.foodName) totalPrice = totalPrice - f3.foodPrice;
            if (listBox2.SelectedItem == f4.foodName) totalPrice = totalPrice - f4.foodPrice;
            if (listBox2.SelectedItem == f5.foodName) totalPrice = totalPrice - f5.foodPrice;
            if (listBox2.SelectedItem == f6.foodName) totalPrice = totalPrice - f6.foodPrice;
            if (listBox2.SelectedItem == f7.foodName) totalPrice = totalPrice - f7.foodPrice;
            if (listBox2.SelectedItem == f8.foodName) totalPrice = totalPrice - f8.foodPrice;
            if (listBox2.SelectedItem == f9.foodName) totalPrice = totalPrice - f9.foodPrice;
            label3.Text = totalPrice + "$";
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
