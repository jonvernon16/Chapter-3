namespace PayrollGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_entry1 = new System.Windows.Forms.TextBox();
            this.txt_entry2 = new System.Windows.Forms.TextBox();
            this.txt_entry3 = new System.Windows.Forms.TextBox();
            this.txt_entry4 = new System.Windows.Forms.TextBox();
            this.txt_gross = new System.Windows.Forms.TextBox();
            this.txt_netPay = new System.Windows.Forms.TextBox();
            this.txt_stateTax = new System.Windows.Forms.TextBox();
            this.txt_fedTax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(133, 213);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SSN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hourly Pay Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hours Worked";
            // 
            // txt_entry1
            // 
            this.txt_entry1.Location = new System.Drawing.Point(45, 79);
            this.txt_entry1.Name = "txt_entry1";
            this.txt_entry1.Size = new System.Drawing.Size(100, 20);
            this.txt_entry1.TabIndex = 5;
            // 
            // txt_entry2
            // 
            this.txt_entry2.Location = new System.Drawing.Point(196, 79);
            this.txt_entry2.Name = "txt_entry2";
            this.txt_entry2.Size = new System.Drawing.Size(100, 20);
            this.txt_entry2.TabIndex = 6;
            // 
            // txt_entry3
            // 
            this.txt_entry3.Location = new System.Drawing.Point(45, 158);
            this.txt_entry3.Name = "txt_entry3";
            this.txt_entry3.Size = new System.Drawing.Size(100, 20);
            this.txt_entry3.TabIndex = 7;
            // 
            // txt_entry4
            // 
            this.txt_entry4.Location = new System.Drawing.Point(196, 158);
            this.txt_entry4.Name = "txt_entry4";
            this.txt_entry4.Size = new System.Drawing.Size(100, 20);
            this.txt_entry4.TabIndex = 8;
            // 
            // txt_gross
            // 
            this.txt_gross.Location = new System.Drawing.Point(45, 271);
            this.txt_gross.Name = "txt_gross";
            this.txt_gross.Size = new System.Drawing.Size(110, 20);
            this.txt_gross.TabIndex = 9;
            // 
            // txt_netPay
            // 
            this.txt_netPay.Location = new System.Drawing.Point(196, 339);
            this.txt_netPay.Name = "txt_netPay";
            this.txt_netPay.Size = new System.Drawing.Size(108, 20);
            this.txt_netPay.TabIndex = 10;
            // 
            // txt_stateTax
            // 
            this.txt_stateTax.Location = new System.Drawing.Point(45, 339);
            this.txt_stateTax.Name = "txt_stateTax";
            this.txt_stateTax.Size = new System.Drawing.Size(110, 20);
            this.txt_stateTax.TabIndex = 11;
            // 
            // txt_fedTax
            // 
            this.txt_fedTax.Location = new System.Drawing.Point(196, 271);
            this.txt_fedTax.Name = "txt_fedTax";
            this.txt_fedTax.Size = new System.Drawing.Size(108, 20);
            this.txt_fedTax.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 391);
            this.Controls.Add(this.txt_fedTax);
            this.Controls.Add(this.txt_stateTax);
            this.Controls.Add(this.txt_netPay);
            this.Controls.Add(this.txt_gross);
            this.Controls.Add(this.txt_entry4);
            this.Controls.Add(this.txt_entry3);
            this.Controls.Add(this.txt_entry2);
            this.Controls.Add(this.txt_entry1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calculate);
            this.Name = "Form1";
            this.Text = "PayrollGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_entry1;
        private System.Windows.Forms.TextBox txt_entry2;
        private System.Windows.Forms.TextBox txt_entry3;
        private System.Windows.Forms.TextBox txt_entry4;
        private System.Windows.Forms.TextBox txt_gross;
        private System.Windows.Forms.TextBox txt_netPay;
        private System.Windows.Forms.TextBox txt_stateTax;
        private System.Windows.Forms.TextBox txt_fedTax;
    }
}

