namespace TestInteractiveGUI
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
            this.btn_test = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_entry2 = new System.Windows.Forms.TextBox();
            this.txt_entry3 = new System.Windows.Forms.TextBox();
            this.txt_entry4 = new System.Windows.Forms.TextBox();
            this.txt_entry5 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_entry1
            // 
            this.txt_entry1.Location = new System.Drawing.Point(55, 76);
            this.txt_entry1.Name = "txt_entry1";
            this.txt_entry1.Size = new System.Drawing.Size(100, 20);
            this.txt_entry1.TabIndex = 0;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(182, 163);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(100, 20);
            this.btn_test.TabIndex = 1;
            this.btn_test.Text = "Calculate";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the scores of 5 people ";
            // 
            // txt_entry2
            // 
            this.txt_entry2.Location = new System.Drawing.Point(182, 76);
            this.txt_entry2.Name = "txt_entry2";
            this.txt_entry2.Size = new System.Drawing.Size(100, 20);
            this.txt_entry2.TabIndex = 3;
            // 
            // txt_entry3
            // 
            this.txt_entry3.Location = new System.Drawing.Point(55, 120);
            this.txt_entry3.Name = "txt_entry3";
            this.txt_entry3.Size = new System.Drawing.Size(100, 20);
            this.txt_entry3.TabIndex = 4;
            // 
            // txt_entry4
            // 
            this.txt_entry4.Location = new System.Drawing.Point(182, 120);
            this.txt_entry4.Name = "txt_entry4";
            this.txt_entry4.Size = new System.Drawing.Size(100, 20);
            this.txt_entry4.TabIndex = 5;
            // 
            // txt_entry5
            // 
            this.txt_entry5.Location = new System.Drawing.Point(55, 163);
            this.txt_entry5.Name = "txt_entry5";
            this.txt_entry5.Size = new System.Drawing.Size(100, 20);
            this.txt_entry5.TabIndex = 6;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(55, 209);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(227, 20);
            this.txt_result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 248);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_entry5);
            this.Controls.Add(this.txt_entry4);
            this.Controls.Add(this.txt_entry3);
            this.Controls.Add(this.txt_entry2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.txt_entry1);
            this.Name = "Form1";
            this.Text = "TestInteractiveGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_entry1;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_entry2;
        private System.Windows.Forms.TextBox txt_entry3;
        private System.Windows.Forms.TextBox txt_entry4;
        private System.Windows.Forms.TextBox txt_entry5;
        private System.Windows.Forms.TextBox txt_result;
    }
}

