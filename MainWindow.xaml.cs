namespace SimpleWindowsCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    public partial class MainWindow : Window
    {
        private decimal mValue = 0;
        private decimal firstMember = 0;
        private decimal secondMember = 0;

        private decimal result = 0;

        public decimal MValue
        {
            get { return this.mValue; }
            set { this.mValue = value; }
        }

        public MainWindow()
        {
            InitializeComponent();

            inputField.Text = "0";
        }

        void mcButtonClicked(object sender, EventArgs a)
        {
            MValue = 0;
        }

        void mrButtonClicked(object sender, EventArgs a)
        {
            inputField.Text = MValue.ToString();
        }

        void msButtonClicked(object sender, EventArgs a)
        {
            MValue = decimal.Parse(inputField.Text);
        }

        void mPlusButtonClicked(object sender, EventArgs a)
        {
            MValue += decimal.Parse(inputField.Text);
            inputField.Text = MValue.ToString();
        }

        void mMinusButtonClicked(object sender, EventArgs a)
        {
            MValue -= decimal.Parse(inputField.Text);
            inputField.Text = MValue.ToString();
        }

        void backspaceButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text.Length > 1)
            {
                inputField.Text = inputField.Text.Substring(0, inputField.Text.Length - 1);
            }
            else
            {
                inputField.Text = "0";
            }
        }

        void ceButtonClicked(object sender, EventArgs a)
        {
            inputField.Text = "0";
        }

        void cButtonClicked(object sender, EventArgs a)
        {
            inputField.Text = "0";
            tempField.Clear();
            MValue = 0;
        }

        void plusMinusButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text == string.Empty)
            {
                inputField.Text = '-' + inputField.Text;
            }
            else if (inputField.Text[0] != '-')
            {
                inputField.Text = '-' + inputField.Text;
            }
            else
            {
                var temp = inputField.Text;
                inputField.Clear();
                inputField.Text = temp.Substring(1, temp.Length - 1);
            }
        }

        void sqrtButtonClicked(object sender, EventArgs a)
        {
            var sqrtResult = Math.Sqrt(double.Parse(inputField.Text));
            inputField.Clear();
            inputField.Text = sqrtResult.ToString();
        }

        void sevenButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text == "0")
            {
                inputField.Clear();
            }

            inputField.AppendText(sevenButton.Content.ToString());
        }

        void eightButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text == "0")
            {
                inputField.Clear();
            }

            inputField.AppendText(eightButton.Content.ToString());
        }

        void nineButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text == "0")
            {
                inputField.Clear();
            }

            inputField.AppendText(nineButton.Content.ToString());
        }

        void divideButtonClicked(object sender, EventArgs a)
        {
            firstMember = decimal.Parse(inputField.Text);
            tempField.Text = inputField.Text + " / ";
            inputField.Clear();
        }

        void percentButtonClicked(object sender, EventArgs a)
        {

        }

        void fourButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text == "0")
            {
                inputField.Clear();
            }

            inputField.AppendText(fourButton.Content.ToString());
        }

        void fiveButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text == "0")
            {
                inputField.Clear();
            }

            inputField.AppendText(fiveButton.Content.ToString());
        }

        void sixButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text == "0")
            {
                inputField.Clear();
            }

            inputField.AppendText(sixButton.Content.ToString());
        }

        void multiplicationButtonClicked(object sender, EventArgs a)
        {
            firstMember = decimal.Parse(inputField.Text);
            tempField.Text = inputField.Text + " * ";
            inputField.Clear();
        }

        void oneOnXButtonClicked(object sender, EventArgs a)
        {
            firstMember = decimal.Parse(inputField.Text);
            inputField.Text = (1 / firstMember).ToString();
        }

        void oneButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text == "0")
            {
                inputField.Clear();
            }

            inputField.AppendText(oneButton.Content.ToString());
        }

        void twoButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text == "0")
            {
                inputField.Clear();
            }

            inputField.AppendText(twoButton.Content.ToString());
        }

        void threeButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text == "0")
            {
                inputField.Clear();
            }

            inputField.AppendText(threeButton.Content.ToString());
        }

        void minusButtonClicked(object sender, EventArgs a)
        {
            firstMember = decimal.Parse(inputField.Text);
            tempField.Text = inputField.Text + " - ";
            inputField.Clear();
        }

        void zeroButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text == "0")
            {
                inputField.Clear();
            }

            inputField.AppendText(zeroButton.Content.ToString());
        }

        void dotButtonClicked(object sender, EventArgs a)
        {
            if (inputField.Text.Contains('.'))
            {

            }
            else
            {
                inputField.AppendText(dotButton.Content.ToString());
            }
        }

        void plusButtonClicked(object sender, EventArgs a)
        {
            firstMember = decimal.Parse(inputField.Text);
            tempField.Text = inputField.Text + " + ";
            inputField.Clear();
        }

        void equalButtonClicked(object sender, EventArgs a)
        {
            secondMember = decimal.Parse(inputField.Text);

            if (tempField.Text == string.Empty)
            {
                result = secondMember;
            }
            else if (tempField.Text[tempField.Text.Length - 2] == '+')
            {
                result = firstMember + secondMember;

                tempField.Text += inputField.Text;
            }
            else if (tempField.Text[tempField.Text.Length - 2] == '-')
            {
                result = firstMember - secondMember;

                tempField.Text += inputField.Text;
            }
            else if (tempField.Text[tempField.Text.Length - 2] == '*')
            {
                result = firstMember * secondMember;

                tempField.Text += inputField.Text;
            }
            else if (tempField.Text[tempField.Text.Length - 2] == '/')
            {
                result = firstMember / secondMember;

                tempField.Text += inputField.Text;
            }

            inputField.Text = result.ToString();
        }
    }
}