namespace EggsInteractiveGUI
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
            this.txt_entry1 = new System.Windows.Forms.TextBox();
            this.txt_entry3 = new System.Windows.Forms.TextBox();
            this.txt_entry4 = new System.Windows.Forms.TextBox();
            this.txt_entry5 = new System.Windows.Forms.TextBox();
            this.txt_entry2 = new System.Windows.Forms.TextBox();
            this.btn_eggs = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of eggs laid by 5 chickens";
            // 
            // txt_entry1
            // 
            this.txt_entry1.Location = new System.Drawing.Point(39, 71);
            this.txt_entry1.Name = "txt_entry1";
            this.txt_entry1.Size = new System.Drawing.Size(100, 20);
            this.txt_entry1.TabIndex = 1;
            // 
            // txt_entry3
            // 
            this.txt_entry3.Location = new System.Drawing.Point(39, 118);
            this.txt_entry3.Name = "txt_entry3";
            this.txt_entry3.Size = new System.Drawing.Size(100, 20);
            this.txt_entry3.TabIndex = 2;
            // 
            // txt_entry4
            // 
            this.txt_entry4.Location = new System.Drawing.Point(172, 118);
            this.txt_entry4.Name = "txt_entry4";
            this.txt_entry4.Size = new System.Drawing.Size(100, 20);
            this.txt_entry4.TabIndex = 3;
            // 
            // txt_entry5
            // 
            this.txt_entry5.Location = new System.Drawing.Point(106, 166);
            this.txt_entry5.Name = "txt_entry5";
            this.txt_entry5.Size = new System.Drawing.Size(100, 20);
            this.txt_entry5.TabIndex = 4;
            // 
            // txt_entry2
            // 
            this.txt_entry2.Location = new System.Drawing.Point(172, 71);
            this.txt_entry2.Name = "txt_entry2";
            this.txt_entry2.Size = new System.Drawing.Size(100, 20);
            this.txt_entry2.TabIndex = 5;
            // 
            // btn_eggs
            // 
            this.btn_eggs.Location = new System.Drawing.Point(106, 204);
            this.btn_eggs.Name = "btn_eggs";
            this.btn_eggs.Size = new System.Drawing.Size(100, 59);
            this.btn_eggs.TabIndex = 6;
            this.btn_eggs.Text = "Calculate";
            this.btn_eggs.UseVisualStyleBackColor = true;
            this.btn_eggs.Click += new System.EventHandler(this.btn_eggs_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(39, 285);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(233, 68);
            this.txt_result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 377);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_eggs);
            this.Controls.Add(this.txt_entry2);
            this.Controls.Add(this.txt_entry5);
            this.Controls.Add(this.txt_entry4);
            this.Controls.Add(this.txt_entry3);
            this.Controls.Add(this.txt_entry1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_entry1;
        private System.Windows.Forms.TextBox txt_entry3;
        private System.Windows.Forms.TextBox txt_entry4;
        private System.Windows.Forms.TextBox txt_entry5;
        private System.Windows.Forms.TextBox txt_entry2;
        private System.Windows.Forms.Button btn_eggs;
        private System.Windows.Forms.TextBox txt_result;
    }
}

