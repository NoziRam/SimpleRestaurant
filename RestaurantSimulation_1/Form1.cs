using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSimulation_1
{
    public partial class Form1 : Form
    {

        string menuItem;
        object order;
        Employee employee;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            order = new object();
            employee = new Employee();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            menuItem = ((RadioButton)sender).Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                order = employee.NewRequest(quantity, menuItem);
                label5.Text = employee.Inspect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                order = employee.CopyRequest();
                label5.Text = employee.Inspect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text += employee.PrepareFood(order);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
