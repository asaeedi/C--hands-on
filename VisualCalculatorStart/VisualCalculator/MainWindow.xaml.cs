using System;
using System.Windows;
using System.Windows.Controls;

namespace VisualCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double currentValue = 0;
        enum Operation { Add, Subtract, Multiply, Divide, Equals, Start };
        
        public MainWindow()
        {
            InitializeComponent();
            txtOut.Text = ""; //currentValue.ToString();
        }

        private void BtnEntry_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string numEntry = btn.Content.ToString();

            switch (numEntry)
            {
                case "0":
                    txtOut.Text += "0";
                    break;
                case "1":
                    txtOut.Text += "1";
                    break;
                case "2":
                    txtOut.Text += "2";
                    break;
                case "3":
                    txtOut.Text += "3";
                    break;
                case "4":
                    txtOut.Text += "4";
                    break;
                case "5":
                    txtOut.Text += "5";
                    break;
                case "6":
                    txtOut.Text += "6";
                    break;
                case "7":
                    txtOut.Text += "7";
                    break;
                case "8":
                    txtOut.Text += "8";
                    break;
                case "9":
                    txtOut.Text += "9";
                    break;
                case ".":
                    txtOut.Text += ".";
                    break;
                default:
                    break;
            }

        }

        private void Calculate(Operation op)
        {

            switch (op)
            {
                case Operation.Add:
                    txtOut.Text += (CalcInputs.Num1 + CalcInputs.Num2).ToString();
                    break;
                case Operation.Subtract:
                    txtOut.Text += (CalcInputs.Num1 - CalcInputs.Num2).ToString();
                    break;
                case Operation.Multiply:
                    txtOut.Text += (CalcInputs.Num1 * CalcInputs.Num2).ToString();
                    break;
                case Operation.Divide:
                    if (CalcInputs.Num2 == 0.0)
                    {
                        txtOut.Text = "Division by zero!";
                    }
                    else
                    {
                        txtOut.Text += (CalcInputs.Num1 / CalcInputs.Num2).ToString();
                    }
                    break;

                default:
                    break;
            }

        }

        // 4 event handlers for operations:
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(Double.TryParse(txtOut.Text, out currentValue))
            {
                CalcInputs.Num1 = currentValue;
                CalcInputs.MainOp = Operation.Add;
                CalcInputs.MathOp = "+";
                txtOut.Text = currentValue.ToString() + "+";
            }
            else
            {
                txtOut.Text = "Incorrect format!";
            }
        }

        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            if (Double.TryParse(txtOut.Text, out currentValue))
            {
                CalcInputs.Num1 = currentValue;
                CalcInputs.MainOp = Operation.Subtract;
                CalcInputs.MathOp = "-";
                txtOut.Text = currentValue.ToString() + "-";
            }
            else
            {
                txtOut.Text = "Incorrect format!";
            }
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (Double.TryParse(txtOut.Text, out currentValue))
            {
                CalcInputs.Num1 = currentValue;
                CalcInputs.MainOp = Operation.Multiply;
                CalcInputs.MathOp = "*";
                txtOut.Text = currentValue.ToString() + "*";
            }
            else
            {
                txtOut.Text = "Incorrect format!";
            }
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (Double.TryParse(txtOut.Text, out currentValue))
            {
                CalcInputs.Num1 = currentValue;
                CalcInputs.MainOp = Operation.Divide;
                CalcInputs.MathOp = "/";
                txtOut.Text = currentValue.ToString() + "/";
            }
            else
            {
                txtOut.Text = "Incorrect format!";
            }
        }

        //Clear the current results
        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtOut.Text = "";
            CalcInputs.MainOp = Operation.Start;
        }

        //Handle the Equals button
        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {

            string num2 = ExtractNum2(txtOut.Text);

            if (Double.TryParse(num2, out currentValue))
            {
                CalcInputs.Num2 = currentValue;
                txtOut.Text += "=";
                Calculate(CalcInputs.MainOp);
            }
            else
            {
                txtOut.Text = "Incorrect format!";
            }
        }

        private string ExtractNum2(string text)
        {
            int index = text.IndexOf(CalcInputs.MathOp);
            string extractedNum = text.Substring(index+1, text.Length-index-1);
            return extractedNum;
        }

        class CalcInputs
        {
            public static double Num1 { set; get; }
            public static double Num2 { set; get; }
            public static Operation MainOp { set; get; }

            public static string MathOp { set; get; }
        }

    }


}
