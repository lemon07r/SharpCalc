using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SharpCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private long _num1 = 0;
        private long _num2 = 0;
        private string _operation = "";
        private bool _newEquation = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumAppend(int btnNum)
        {
            if (_operation == "")
            {
                _num1 = (_num1 * 10) + btnNum;
                displayBox.Text = _num1.ToString();
            }
            else
            {
                if (_newEquation == false)
                {
                    _num2 = 0;
                    _newEquation = true;
                }
                _num2 = (_num2 * 10) + btnNum;
                displayBox.Text = _num2.ToString();
            }
        }
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            NumAppend(1);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            NumAppend(2);
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            NumAppend(3);
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            NumAppend(4);
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            NumAppend(5);
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            NumAppend(6);
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            NumAppend(7);
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            NumAppend(8);
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            NumAppend(9);
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            NumAppend(0);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            _operation = "+";
            displayBox.Text = "0";
        }

        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            _operation = "-";
            displayBox.Text = "0";
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            _operation = "*";
            displayBox.Text = "0";
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            _operation = "/";
            displayBox.Text = "0";
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            _newEquation = false;
            switch (_operation)
            {
                case "+":
                    _num1 += _num2;
                    displayBox.Text = _num1.ToString();
                    break;
                case "-":
                    _num1 -= _num2;
                    displayBox.Text = _num1.ToString();
                    break;
                case "*":
                    _num1 *= _num2;
                    displayBox.Text = _num1.ToString();
                    break;
                case "/":
                    _num1 /= _num2;
                    displayBox.Text = _num1.ToString();
                    break;
            }
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == "")
            {
                _num1 = 0;
            }
            else
            {
                _num2 = 0;
            }

            displayBox.Text = "0";
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            _num1 = 0;
            _num2 = 0;
            _operation = "";
            displayBox.Text = "0";
            _newEquation = true;
        }

        private void BtnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == "")
            {
                _num1 = (_num1 / 10);
                displayBox.Text = _num1.ToString();
            }
            else
            {
                _num2 = (_num2 / 10);
                displayBox.Text = _num2.ToString();
            }
        }

        private void BtnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == "")
            {
                _num1 *= -1;
                displayBox.Text = _num1.ToString();
            }
            else
            {
                _num2 *= -1;
                displayBox.Text = _num2.ToString();
            }
        }

        private void BtnHex_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == "" || _newEquation == false)
            {
                displayBox.Text = _num1.ToString("X");
            }
            else
            {
                displayBox.Text = _num2.ToString("X");
            }

            btnHex.Background = Brushes.DodgerBlue;
            btnDec.ClearValue(Button.BackgroundProperty);
            btnOct.ClearValue(Button.BackgroundProperty);
            btnBin.ClearValue(Button.BackgroundProperty);
        }

        private void BtnDec_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == "" || _newEquation == false)
            {
                displayBox.Text = _num1.ToString();
            }
            else
            {
                displayBox.Text = _num2.ToString();
            }

            btnDec.Background = Brushes.DodgerBlue;
            btnHex.ClearValue(Button.BackgroundProperty);
            btnOct.ClearValue(Button.BackgroundProperty);
            btnBin.ClearValue(Button.BackgroundProperty);
        }

        private void BtnOct_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == "" || _newEquation == false)
            {
                displayBox.Text = Convert.ToString(_num1, 8);
            }
            else
            {
                displayBox.Text = Convert.ToString(_num2, 8);
            }
            btnOct.Background = Brushes.DodgerBlue;
            btnDec.ClearValue(Button.BackgroundProperty);
            btnHex.ClearValue(Button.BackgroundProperty);
            btnBin.ClearValue(Button.BackgroundProperty);
        }

        private void BtnBin_Click(object sender, RoutedEventArgs e)
        {
            if (_operation == "" || _newEquation == false)
            {
                displayBox.Text = Convert.ToString(_num1, 2);
            }
            else
            {
                displayBox.Text = Convert.ToString(_num2, 2);
            }
            btnBin.Background = Brushes.DodgerBlue;
            btnDec.ClearValue(Button.BackgroundProperty);
            btnOct.ClearValue(Button.BackgroundProperty);
            btnHex.ClearValue(Button.BackgroundProperty);
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
