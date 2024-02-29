//  C#II (Dor Ben Dor)  //
//     Rotem Feldman    //
//////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FormsHomework_RotemFeldman.Form1;

namespace FormsHomework_RotemFeldman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "Add";
            operation_label.Text = "+";
        }

        public delegate float Calculate(float x, float y);

        private float Add(float x, float y)
        {
            return x + y;
        }

        private float Subtract(float x, float y)
        {
            return x - y;
        }

        private float Multiply(float x, float y)
        {
            return x * y;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            Calculate calculate = Add;
          

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Add":
                    calculate = Add;
                    break;
                case "Subtract":
                    calculate = Subtract;
                    break;
                case "Multiply":
                    calculate = Multiply;
                    break;
            }

            ResultLabel.Text = calculate(num1,num2).ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string operation = "+";

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    operation = "+";
                    break;
                case 1:
                    operation = "-";
                    break;
                case 2:
                    operation= "*";
                    break;
            }

            operation_label.Text = operation;
        }
        
    }
}
