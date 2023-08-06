using RestaurantSimulation_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranSimulation_2
{
    public partial class Form1 : Form
    {
        Server server;
        public Form1()
        {
            InitializeComponent();
            server = new Server();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
             int chickenQuantity = Convert.ToInt32(textBox1.Text);
             int eggQuantity = Convert.ToInt32(textBox2.Text);
             string drink = comboBox1.Text;
             Clear();
             server.ReceiveRequests(chickenQuantity, eggQuantity, drink);
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
                int? quality = server.SendAll();
                label3.Text = $"Egg quality:{quality}";
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
                textBox3.Text += server.Serve();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }
        private void Clear()
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            comboBox1.Text = "";
        }
    }
}
