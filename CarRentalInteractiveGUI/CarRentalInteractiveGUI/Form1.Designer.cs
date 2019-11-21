namespace CarRentalInteractiveGUI
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
            this.txt_entry1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_carRental = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_entry2 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_entry1
            // 
            this.txt_entry1.Location = new System.Drawing.Point(59, 125);
            this.txt_entry1.Name = "txt_entry1";
            this.txt_entry1.Size = new System.Drawing.Size(100, 20);
            this.txt_entry1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter the number of miles and days you rented the vehicle";
            // 
            // btn_carRental
            // 
            this.btn_carRental.Location = new System.Drawing.Point(183, 183);
            this.btn_carRental.Name = "btn_carRental";
            this.btn_carRental.Size = new System.Drawing.Size(75, 64);
            this.btn_carRental.TabIndex = 2;
            this.btn_carRental.Text = "Calculate";
            this.btn_carRental.UseVisualStyleBackColor = true;
            this.btn_carRental.Click += new System.EventHandler(this.btn_carRental_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Days";
            // 
            // txt_entry2
            // 
            this.txt_entry2.Location = new System.Drawing.Point(277, 125);
            this.txt_entry2.Name = "txt_entry2";
            this.txt_entry2.Size = new System.Drawing.Size(100, 20);
            this.txt_entry2.TabIndex = 6;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(108, 311);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(235, 20);
            this.txt_result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 417);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_entry2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_carRental);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_entry1);
            this.Name = "Form1";
            this.Text = "CarRentalInteractiveGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_entry1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_carRental;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_entry2;
        private System.Windows.Forms.TextBox txt_result;
    }
}

