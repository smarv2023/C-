using System.Reflection.Emit;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaring a TextBox variable to track which of the two text boxes the user has selected to input a number
        private TextBox activeTextBox;

        // Create an instance of a class
        Calculate calculate = new Calculate();

        // Number buttons
        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonText = clickedButton.Text;

            // Default to operand1, also to handle error
            if (activeTextBox == null)
                activeTextBox = operand1;

            switch (buttonText)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    activeTextBox.Text += buttonText;
                    break;
            }
        }

        // Navigation buttons
        // .Focus() is added to (<- arrow ->) button to make the user aware which text box is selected
        private void btnNext_Click(object sender, EventArgs e)
        {
            activeTextBox = operand2;
            operand2.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            activeTextBox = operand1;
            operand1.Focus();
        }

        private void operand1_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = operand1;
        }

        private void operand2_TextChanged(object sender, EventArgs e)
        {
            activeTextBox = operand2;
        }

        // Delete and clear button
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null && activeTextBox.Text.Length > 0)
                activeTextBox.Text = activeTextBox.Text.Substring(0, activeTextBox.Text.Length - 1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            operand1.Text = "";
            operand2.Text = "";
            lblTotal.Text = "";
            lblOperator.Text = "o";
            calculate.Clear();
            activeTextBox = operand1;
            calculate.Result = 0;
        }

        // Operators buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblOperator.Text = btnAdd.Text;
            activeTextBox = operand2;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lblOperator.Text = btnSub.Text;
            activeTextBox = operand2;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            lblOperator.Text = btnMul.Text;
            activeTextBox = operand2;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblOperator.Text = btnDiv.Text;
            activeTextBox = operand2;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // Call the method and properties from Calculate class
            try
            {
                calculate.Operand1 = decimal.Parse(operand1.Text);
                calculate.Operand2 = decimal.Parse(operand2.Text);
                calculate.Equal(lblOperator.Text);
                lblTotal.Text = calculate.Result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a number");
            }
            catch (DivideByZeroException dE)
            {
                MessageBox.Show(dE.Message);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        // Decimal place
        private void btnDot_Click(object sender, EventArgs e)
        {
            // Allow only one decimal point
            if (activeTextBox != null && !activeTextBox.Text.Contains("."))
            {
                activeTextBox.Text += btnDot.Text;
            }
        }
        private void operand_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like Backspace) and digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Suppress the key press
            }

            // Allow only one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Suppress the key press
            }
        }
    }
}
