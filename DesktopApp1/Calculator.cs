using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Calculator : Form
    {
        double Firstnumber = 0;
        double secondnumber = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtcalculator.Text = txtcalculator.Text + btn7.Text;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            
                txtcalculator.Text = txtcalculator.Text +btn1.Text;
        }
         private void Btnc_Click(object sender, EventArgs e)
        {
            txtcalculator.Clear();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtcalculator.Text = txtcalculator.Text + btn9.Text;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtcalculator.Text = txtcalculator.Text + btn2.Text;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtcalculator.Text = txtcalculator.Text + btn3.Text;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtcalculator.Text = txtcalculator.Text + btn4.Text;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtcalculator.Text = txtcalculator.Text + btn5.Text;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtcalculator.Text = txtcalculator.Text + btn6.Text;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtcalculator.Text = txtcalculator.Text + btn8.Text;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtcalculator.Text = txtcalculator.Text + btn0.Text;
        }

        private void Btnp_Click(object sender, EventArgs e)
        {
            txtcalculator.Text = txtcalculator.Text + btnp.Text;
        }

        private void Btna_Click(object sender, EventArgs e)
        {
            Firstnumber += double.Parse(txtcalculator.Text);
            txtcalculator.Clear();
            plusbuttonclicked = true;
            minusbuttonclicked = false;
            multiplybuttonclicked = false;
            dividebuttonclicked = false;

        }
             private void Btnresult_Click(object sender, EventArgs e)
        {
            if (plusbuttonclicked == true)
            {
                secondnumber = Firstnumber + double.Parse(txtcalculator.Text);
                txtcalculator.Text = secondnumber.ToString();
                Firstnumber = 0;
            }
            else if  (dividebuttonclicked==true)
            {
                secondnumber = Firstnumber / double.Parse(txtcalculator.Text);
                txtcalculator.Text = secondnumber.ToString();
                Firstnumber = 0;
            }
            else if (multiplybuttonclicked == true)
            {
                secondnumber = Firstnumber * double.Parse(txtcalculator.Text);
                txtcalculator.Text = secondnumber.ToString();
                Firstnumber = 0;
            }
            else if (minusbuttonclicked == true)
            {
                secondnumber = Firstnumber - double.Parse(txtcalculator.Text);
                txtcalculator.Text = secondnumber.ToString();
                Firstnumber = 0;
            }

        }
        bool plusbuttonclicked = false;
        bool minusbuttonclicked = false;
        bool multiplybuttonclicked = false;
        bool dividebuttonclicked = false;
    
       

        private void Btns_Click(object sender, EventArgs e)
        {
            Firstnumber += double.Parse(txtcalculator.Text);
            txtcalculator.Clear();

            plusbuttonclicked = false;
            minusbuttonclicked = true;
            multiplybuttonclicked = false;
            dividebuttonclicked = false;
        }

        private void Btnm_Click(object sender, EventArgs e)
        {
            Firstnumber += double.Parse(txtcalculator.Text);
            txtcalculator.Clear();

            plusbuttonclicked = false;
            minusbuttonclicked = false;
            multiplybuttonclicked = true;
            dividebuttonclicked = false;
        }

        private void Btnd_Click(object sender, EventArgs e)
        {
            Firstnumber += double.Parse(txtcalculator.Text);
            txtcalculator.Clear();

            plusbuttonclicked = false;
            minusbuttonclicked = false;
            multiplybuttonclicked = false;
            dividebuttonclicked = true;

        }
        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the application!", "Exit",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                //Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;

            }

        }
    }
}
