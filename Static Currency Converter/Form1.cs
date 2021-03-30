using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Static_Currency_Converter
{
    public partial class Form1 : Form
    {
        private double[] money_value = new double[]{ 1, 14456.6, 2194.9, 10726.07, 131.63 };
        private double conv_amount = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //From combo box
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //To combo box
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //convert button
        private void button1_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(amount_text.Text);
            int money_from = from_combo_box.SelectedIndex;
            int money_to = to_combo_box.SelectedIndex;
            conv_amount = amount * money_value[money_from] / money_value[money_to];
            
            Converted_amount_text.Text = "Converted Amount : " + conv_amount;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Amount text
        private void amount_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
