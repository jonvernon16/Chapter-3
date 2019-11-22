namespace MadlibsGUI
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
            this.txt_color = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txt_wordEst = new System.Windows.Forms.TextBox();
            this.txt_bodyPartPlural = new System.Windows.Forms.TextBox();
            this.txt_animal = new System.Windows.Forms.TextBox();
            this.txt_noun = new System.Windows.Forms.TextBox();
            this.txt_pluralNoun = new System.Windows.Forms.TextBox();
            this.btn_madlib = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color";
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(127, 48);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(100, 20);
            this.txt_color.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Word ending in est";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Body part plural";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Animal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Noun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Plural Noun";
            // 
            // lbl_result
            // 
            this.lbl_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_result.Location = new System.Drawing.Point(108, 335);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(230, 82);
            this.lbl_result.TabIndex = 7;
            // 
            // txt_wordEst
            // 
            this.txt_wordEst.Location = new System.Drawing.Point(127, 98);
            this.txt_wordEst.Name = "txt_wordEst";
            this.txt_wordEst.Size = new System.Drawing.Size(100, 20);
            this.txt_wordEst.TabIndex = 8;
            // 
            // txt_bodyPartPlural
            // 
            this.txt_bodyPartPlural.Location = new System.Drawing.Point(127, 146);
            this.txt_bodyPartPlural.Name = "txt_bodyPartPlural";
            this.txt_bodyPartPlural.Size = new System.Drawing.Size(100, 20);
            this.txt_bodyPartPlural.TabIndex = 9;
            // 
            // txt_animal
            // 
            this.txt_animal.Location = new System.Drawing.Point(125, 199);
            this.txt_animal.Name = "txt_animal";
            this.txt_animal.Size = new System.Drawing.Size(100, 20);
            this.txt_animal.TabIndex = 10;
            // 
            // txt_noun
            // 
            this.txt_noun.Location = new System.Drawing.Point(127, 244);
            this.txt_noun.Name = "txt_noun";
            this.txt_noun.Size = new System.Drawing.Size(100, 20);
            this.txt_noun.TabIndex = 11;
            // 
            // txt_pluralNoun
            // 
            this.txt_pluralNoun.Location = new System.Drawing.Point(127, 298);
            this.txt_pluralNoun.Name = "txt_pluralNoun";
            this.txt_pluralNoun.Size = new System.Drawing.Size(100, 20);
            this.txt_pluralNoun.TabIndex = 12;
            // 
            // btn_madlib
            // 
            this.btn_madlib.Location = new System.Drawing.Point(33, 335);
            this.btn_madlib.Name = "btn_madlib";
            this.btn_madlib.Size = new System.Drawing.Size(69, 82);
            this.btn_madlib.TabIndex = 13;
            this.btn_madlib.Text = "Calculate";
            this.btn_madlib.UseVisualStyleBackColor = true;
            this.btn_madlib.Click += new System.EventHandler(this.btn_madlib_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Number 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Number 2 ";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(268, 117);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(50, 20);
            this.txt_b.TabIndex = 16;
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(265, 67);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(50, 20);
            this.txt_a.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 442);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_madlib);
            this.Controls.Add(this.txt_pluralNoun);
            this.Controls.Add(this.txt_noun);
            this.Controls.Add(this.txt_animal);
            this.Controls.Add(this.txt_bodyPartPlural);
            this.Controls.Add(this.txt_wordEst);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MadLibs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox txt_wordEst;
        private System.Windows.Forms.TextBox txt_bodyPartPlural;
        private System.Windows.Forms.TextBox txt_animal;
        private System.Windows.Forms.TextBox txt_noun;
        private System.Windows.Forms.TextBox txt_pluralNoun;
        private System.Windows.Forms.Button btn_madlib;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
    }
}

