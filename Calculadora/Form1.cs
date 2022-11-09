using System.Globalization;

namespace Calculadora
{
    public partial class FrmCalculator : Form
    {
        decimal numberOne, numberTwo;
        string operation;

        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btntree_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            txtResult.Text += ",";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            lblTextResult.Text = "Nossa Calculadora";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "sub";
            lblTextResult.Text = txtResult.Text + " - ";


            txtResult.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "mult";
            lblTextResult.Text = txtResult.Text + " X ";


            txtResult.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "div";
            lblTextResult.Text = txtResult.Text + " / ";


            txtResult.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberTwo = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
                lblTextResult.Text += numberTwo + " = ";
                decimal result = 0;
                switch(operation)
                {
                    case "sum":
                        result = numberOne + numberTwo;
                        break;
                    case "sub":
                        result = numberOne - numberTwo;
                        break;
                    case "mult":
                        result = numberOne * numberTwo;
                        break;
                    case "div":
                        if(numberTwo == 0)
                        {
                            txtResult.Text = "Não é possível dividir por zero";
                            return;
                        }
                        result = numberOne / numberTwo;
                        break;
                    case "rest":
                        result = numberOne % numberTwo;
                        break;
                }

                txtResult.Text = result.ToString();
                lblTextResult.Text += result.ToString();
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rest_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "rest";
            lblTextResult.Text = txtResult.Text + " % ";


            txtResult.Clear();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if(txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "sum";
            lblTextResult.Text = txtResult.Text + " + ";


            txtResult.Clear();
        }
    }
}