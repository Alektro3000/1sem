using System.Data;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string currentNumInput = "";
        string currentNum = "0";

        double savedNum;
        string savedOperation = "";

        Button[] Buttons;
        public Calculator()
        {
            InitializeComponent();
            InitNums();
            BindOperators();
            Clear();
        }
        private void InitNums()
        {
            Buttons = new Button[10];
            for (int i = 0; i < 10; i++)
            {
                Buttons[i] = new Button();
                Buttons[i].Font = new Font("Segoe UI", 18F);
                Buttons[i].Location = new Point((i % 3) * 56, (i / 3) * 56);
                Buttons[i].Name = "Erase";
                Buttons[i].Size = new Size(52, 50);
                Buttons[i].TabIndex = 13;
                Buttons[i].Text = ((i + 1) % 10).ToString();
                Buttons[i].UseVisualStyleBackColor = true;
                Buttons[i].Click += Digit_Click;

                panel1.Controls.Add(Buttons[i]);
            }
        }
        private void BindOperators()
        {
            sum.Click += Operator_Click;
            sub.Click += Operator_Click;
            mul.Click += Operator_Click;
            div.Click += Operator_Click;
        }
        private void UpdateText()
        {
            currentNum = currentNumInput;

            Buttons[9].Enabled = true;
            NumOutput.Text = currentNum;
            OperatorPanel.Enabled = true;
        }
        private void Digit_Click(object sender, EventArgs e)
        {
            string Text = ((Button)sender).Text;

            currentNumInput += Text;
            UpdateText();
        }

        private void Comma_Click(object sender, EventArgs e)
        {
            if (currentNumInput.Length == 0)
                currentNumInput = "0,";
            else
                currentNumInput += ",";
            Comma.Enabled = false;
            UpdateText();
        }
        private void Clear(string currentDisplay = "0")
        {
            Buttons[9].Enabled = false;
            Comma.Enabled = true;
            currentNumInput = "";
            currentNum = currentDisplay;

            NumOutput.Text = currentDisplay;
        }
        private void Erase_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private bool SaveNum()
        {
            double ans;
            if (!double.TryParse(currentNum, out ans))
                return false;
            savedNum = ans;

            Clear(currentNum);
            return true;
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            if (!SaveNum())
                return;
            savedOperation = ((Button)sender).Text;

            OperatorOutput.Text = savedOperation;
            Equal.Enabled = true;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (savedOperation == "")
                return;
            double a = savedNum;
            if (!SaveNum())
                return;
            double b = savedNum;
            double res;
            bool error = false;
            switch (savedOperation)
            {
                case "+":
                    res = a + b;
                    break;
                case "-":
                    res = a - b;
                    break;
                case "*":
                    res = a * b;
                    break;
                case "/":
                    res = a / b;
                    if(b == 0)
                    {
                        MessageBox.Show("Нельзя делить на ноль");
                        error = true;
                    }
                    break;
                default:
                    throw new Exception("Incorrect Operator");
            }
            if (!error)
            {
                if (res == double.PositiveInfinity || double.NegativeInfinity == res)
                {
                    MessageBox.Show("Слишком большое число");
                    error = true;
                }
            }

            currentNumInput = "";
            if (error)
                currentNum = "0";
            else
                currentNum = res.ToString();
            NumOutput.Text = currentNum;


            savedOperation = "";
            OperatorOutput.Text = savedOperation;

            Equal.Enabled = false;
        }
    }
}
