using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;
namespace Basic_Calculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            switch (cbOp.SelectedItem.ToString())
            {
                case "+":
                    float total = BasicComputation.Addition(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
                    txtResult.Text = $"Total:\r\n{total}";
                    break;
                case "-":
                    float total2 = BasicComputation.Subtraction(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
                    txtResult.Text = $"Total:\r\n{total2}";
                    break;
                case "*":
                    float total3 = BasicComputation.Multiplication(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
                    txtResult.Text = $"Total:\r\n{total3}";
                    break;
                case "/":
                    float total4 = BasicComputation.Division(float.Parse(txtNum1.Text), float.Parse(txtNum2.Text));
                    txtResult.Text = $"Total:\r\n{total4}";
                    break;
            }
        }
    }
}
