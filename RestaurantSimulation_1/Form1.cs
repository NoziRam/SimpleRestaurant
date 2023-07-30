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
        
        Employee employee = new Employee();
        private object order;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void buttonSubmitRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(textBox1.Text);
                string menuItem;
                if (radioButtonChicken.Checked)
                {
                    menuItem = "Chicken";
                }
                else if (radioButtonEgg.Checked)
                    menuItem = "Egg";
                else throw new Exception("Xurokaro intihkob namoed!");
                            
                employee.NewRequest(quantity,menuItem);
                label3.Text = employee.Inspect();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonCopyRequest_Click(object sender, EventArgs e)
        {
            try
            {
                employee.CopyRequest();
                label3.Text = employee.Inspect();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void buttonPrepareFood_Click(object sender, EventArgs e)
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

        private void radioButtonChicken_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
