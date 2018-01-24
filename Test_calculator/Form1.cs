using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_presed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_presed))
                result.Clear();
            operation_presed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void operatar_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+": result.Text = (value + Double.Parse(result.Text)).ToString(); break;
                case "_": result.Text = (value - Double.Parse(result.Text)).ToString(); break;
                case "/": result.Text = (value / Double.Parse(result.Text)).ToString(); break;
                case "*": result.Text = (value * Double.Parse(result.Text)).ToString(); break;
                default:
                    break;
            }
                    Button b = (Button)sender;
                    operation = b.Text;
                    value = Double.Parse(result.Text);
                    operation_presed = true;
                    label1.Text = value + "" + operation;

            result.Clear();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (operation )
            {
                case "+": result.Text = (value + Double.Parse(result.Text)).ToString();break;
                case "_": result.Text = (value - Double.Parse(result.Text)).ToString(); break;
                case "/": result.Text = (value / Double.Parse(result.Text)).ToString(); break;
                case "*": result.Text = (value * Double.Parse(result.Text)).ToString(); break;
                default:
                    break;
            }
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            result.Clear();
            label1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int a = result.Text.Length;
            if (result.Text == "")
            {
                result.Text = "";
            }
            else
            {
                result.Text = result.Text.Remove (a - 1);
            }
           
        }
    }

    }




