namespace ProjectedRaisesGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_raise = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.txt_entry1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your salary below:";
            // 
            // btn_raise
            // 
            this.btn_raise.Location = new System.Drawing.Point(35, 63);
            this.btn_raise.Name = "btn_raise";
            this.btn_raise.Size = new System.Drawing.Size(102, 23);
            this.btn_raise.TabIndex = 1;
            this.btn_raise.Text = "Calculate";
            this.btn_raise.UseVisualStyleBackColor = true;
            this.btn_raise.Click += new System.EventHandler(this.btn_raise_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(43, 177);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 2;
            // 
            // txt_entry1
            // 
            this.txt_entry1.Location = new System.Drawing.Point(37, 25);
            this.txt_entry1.Name = "txt_entry1";
            this.txt_entry1.Size = new System.Drawing.Size(100, 20);
            this.txt_entry1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Here is your salary:";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(35, 125);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(175, 20);
            this.txt_result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 169);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_entry1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btn_raise);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Projected Raises";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_raise;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox txt_entry1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_result;
    }
}

