
namespace RestaurantSimulation_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonEgg = new System.Windows.Forms.RadioButton();
            this.radioButtonChicken = new System.Windows.Forms.RadioButton();
            this.buttonSubmitRequest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCopyRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPrepareFood = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonEgg);
            this.panel1.Controls.Add(this.radioButtonChicken);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 47);
            this.panel1.TabIndex = 0;
            // 
            // radioButtonEgg
            // 
            this.radioButtonEgg.AutoSize = true;
            this.radioButtonEgg.Location = new System.Drawing.Point(114, 14);
            this.radioButtonEgg.Name = "radioButtonEgg";
            this.radioButtonEgg.Size = new System.Drawing.Size(45, 19);
            this.radioButtonEgg.TabIndex = 1;
            this.radioButtonEgg.TabStop = true;
            this.radioButtonEgg.Text = "Egg";
            this.radioButtonEgg.UseVisualStyleBackColor = true;
            // 
            // radioButtonChicken
            // 
            this.radioButtonChicken.AutoSize = true;
            this.radioButtonChicken.Location = new System.Drawing.Point(13, 15);
            this.radioButtonChicken.Name = "radioButtonChicken";
            this.radioButtonChicken.Size = new System.Drawing.Size(68, 19);
            this.radioButtonChicken.TabIndex = 0;
            this.radioButtonChicken.TabStop = true;
            this.radioButtonChicken.Text = "Chicken";
            this.radioButtonChicken.UseVisualStyleBackColor = true;
            // 
            // buttonSubmitRequest
            // 
            this.buttonSubmitRequest.Location = new System.Drawing.Point(148, 78);
            this.buttonSubmitRequest.Name = "buttonSubmitRequest";
            this.buttonSubmitRequest.Size = new System.Drawing.Size(131, 23);
            this.buttonSubmitRequest.TabIndex = 0;
            this.buttonSubmitRequest.Text = "Submit new request";
            this.buttonSubmitRequest.UseVisualStyleBackColor = true;
            this.buttonSubmitRequest.Click += new System.EventHandler(this.buttonSubmitRequest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 23);
            this.textBox1.TabIndex = 2;
            // 
            // buttonCopyRequest
            // 
            this.buttonCopyRequest.Location = new System.Drawing.Point(13, 128);
            this.buttonCopyRequest.Name = "buttonCopyRequest";
            this.buttonCopyRequest.Size = new System.Drawing.Size(266, 23);
            this.buttonCopyRequest.TabIndex = 3;
            this.buttonCopyRequest.Text = "Copy the previous request";
            this.buttonCopyRequest.UseVisualStyleBackColor = true;
            this.buttonCopyRequest.Click += new System.EventHandler(this.buttonCopyRequest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Egg Quality:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 5;
            // 
            // buttonPrepareFood
            // 
            this.buttonPrepareFood.Location = new System.Drawing.Point(13, 216);
            this.buttonPrepareFood.Name = "buttonPrepareFood";
            this.buttonPrepareFood.Size = new System.Drawing.Size(266, 23);
            this.buttonPrepareFood.TabIndex = 6;
            this.buttonPrepareFood.Text = "Prepare Food";
            this.buttonPrepareFood.UseVisualStyleBackColor = true;
            this.buttonPrepareFood.Click += new System.EventHandler(this.buttonPrepareFood_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Results";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 288);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 105);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 420);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPrepareFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCopyRequest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmitRequest);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "RestaurantSimulation_1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonEgg;
        private System.Windows.Forms.RadioButton radioButtonChicken;
        private System.Windows.Forms.Button buttonSubmitRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCopyRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPrepareFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}

