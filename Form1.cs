using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }



        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            double result = double.Parse((string)row["expression"]);

            textBox1.Text = result.ToString();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //clear textbox1
            textBox1.Text = "";
        }
        private bool isOpenParenthesis = true;
        private void button2_Click_1(object sender, EventArgs e)
        {
            string parentheses = isOpenParenthesis ? "(" : ")";

            textBox1.Text = textBox1.Text + parentheses;

            isOpenParenthesis = !isOpenParenthesis;


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "%";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //delete tail of textbox1
            if(textBox1.Text.Length > 0){

                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}
