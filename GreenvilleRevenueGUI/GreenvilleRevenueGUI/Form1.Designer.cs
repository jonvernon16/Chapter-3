namespace GreenvilleRevenueGUI
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
            this.btn_revenue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_entry1 = new System.Windows.Forms.TextBox();
            this.txt_entry2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_bool = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_revenue
            // 
            this.btn_revenue.Location = new System.Drawing.Point(135, 130);
            this.btn_revenue.Name = "btn_revenue";
            this.btn_revenue.Size = new System.Drawing.Size(114, 61);
            this.btn_revenue.TabIndex = 0;
            this.btn_revenue.Text = "Calculate Revenue";
            this.btn_revenue.UseVisualStyleBackColor = true;
            this.btn_revenue.Click += new System.EventHandler(this.btn_revenue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter last years contestants";
            // 
            // txt_entry1
            // 
            this.txt_entry1.Location = new System.Drawing.Point(67, 89);
            this.txt_entry1.Name = "txt_entry1";
            this.txt_entry1.Size = new System.Drawing.Size(100, 20);
            this.txt_entry1.TabIndex = 2;
            // 
            // txt_entry2
            // 
            this.txt_entry2.Location = new System.Drawing.Point(221, 89);
            this.txt_entry2.Name = "txt_entry2";
            this.txt_entry2.Size = new System.Drawing.Size(100, 20);
            this.txt_entry2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter this years contestants";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(100, 215);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(186, 20);
            this.txt_total.TabIndex = 5;
            // 
            // txt_bool
            // 
            this.txt_bool.Location = new System.Drawing.Point(157, 265);
            this.txt_bool.Name = "txt_bool";
            this.txt_bool.Size = new System.Drawing.Size(69, 20);
            this.txt_bool.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Are there more contestents then last year?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_bool);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_entry2);
            this.Controls.Add(this.txt_entry1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_revenue);
            this.Name = "Form1";
            this.Text = "GreenvilleRevenueGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_revenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_entry1;
        private System.Windows.Forms.TextBox txt_entry2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_bool;
        private System.Windows.Forms.Label label3;
    }
}

