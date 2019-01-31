using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class GUI : Form
    {
        int value1;
        int value2;
        double result;
        string function = "";
        public GUI()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(txtValue1.Text);
            value2 = Convert.ToInt32(txtValue2.Text);

            if (function.Equals("+"))
            {
                result=value1 + value2;
            }else if (function.Equals("-"))
            {
                result = value1 - value2;
            }else if (function.Equals("*"))
            {
                result = value1 * value2;
            }else if (function.Equals("/"))
            {
                result = value1 / value2;
            }

            txtAnswer.Text = result.ToString();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            function = "+";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            function = "-";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            function = "/";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            function = "*";
        }
    }
}
