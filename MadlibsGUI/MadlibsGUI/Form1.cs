using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadlibsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_madlib_Click(object sender, EventArgs e)
        {
            string color;
            string wordEst;
            string bodyPartPlural;
            string animal;
            string noun;
            string pluralNoun;
            int a;
            int b;
            int c;

            color = txt_color.Text;
            wordEst = txt_wordEst.Text;
            bodyPartPlural = txt_bodyPartPlural.Text;
            animal = txt_animal.Text;
            noun = txt_noun.Text;
            pluralNoun = txt_pluralNoun.Text;
            a = Convert.ToInt32(txt_a.Text);
            b = Convert.ToInt32(txt_b.Text);

            c = a - b;

            lbl_result.Text = "The " + color + " Dragon is the " + wordEst + " Dragon of all." + 
                "It has " + c + " " + bodyPartPlural + " and a " + animal + " shaped like a " 
                + noun + " It loves to eat " + pluralNoun + ", although it will feast on nearly anything.";
        }
    }
}
