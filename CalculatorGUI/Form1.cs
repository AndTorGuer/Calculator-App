namespace CalculatorGUI
{
    public partial class Form1 : Form
    {

        int num1;
        int num2;
        int total;
        string operation;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        // Button connection
        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn0.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Assigns the addition btn to operation variable 
            operation = "+";
            // Gets the number that gets entered and parse it to int type
            num1 = int.Parse(txtDisplay.Text);
            // Clears the number
            txtDisplay.Clear();
        }

        private void btnSubs_Click(object sender, EventArgs e)
        {
            // Assigns the addition btn to operation variable 
            operation = "-";
            // Gets the number that gets entered and parse it to int type
            num1 = int.Parse(txtDisplay.Text);
            // Clears the number
            txtDisplay.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            // Assigns the addition btn to operation variable 
            operation = "x";
            // Gets the number that gets entered and parse it to int type
            num1 = int.Parse(txtDisplay.Text);
            // Clears the number
            txtDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            // Assigns the addition btn to operation variable 
            operation = "/";
            // Gets the number that gets entered and parse it to int type
            num1 = int.Parse(txtDisplay.Text);
            // Clears the number
            txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // Gets the number that gets entered and parse it to int type
            num2 = int.Parse(txtDisplay.Text);

            // Two different ways of doing it "if" and "switch"

            // Performs the operations
            //if (operation.equals("+"))
            //    total = num1 + num2;

            //if (operation.equals("-"))
            //    total = num1 - num2;

            //if (operation.equals("x"))
            //    total = num1 * num2;

            //if (operation.equals("/"))
            //    total = num1 / num2;

            switch (operation)
            {
                case "+":
                    total = num1 + num2;
                    break;

                case "-":
                    total = num1 - num2;
                    break;

                case "x":
                    total = num1 * num2;
                    break;

                case "/":
                    total = num1 / num2;
                    break;
            }
     
            txtDisplay.Text = total + "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            total = 0;
            num1 = 0;
            num2 = 0;
        }
    }
}