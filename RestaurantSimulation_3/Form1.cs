using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSimulation_3.Employees;

namespace RestaurantSimulation_3
{
    public partial class Form1 : Form
    {
        Server server = new Server();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            int chickenCount = Convert.ToInt32(textBox1.Text);
            int eggCount = Convert.ToInt32(textBox2.Text);
            string drink = comboBox1.Text;
            server.AddNewRequest(chickenCount, eggCount, drink);
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
                server.SendAll();
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
                textBox3.Text = server.Serve().ToString();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
