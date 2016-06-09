using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Calculator : Form
    {
        double firstNumber, secondNumber, total;
        string conmand; //if its multiplication, division, etc.

        public Calculator()
        #region botones
        {
            InitializeComponent();
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblDesplegar.Text += "0";
        }

        private void btn10_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void lblDesplegar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        
    }
}
