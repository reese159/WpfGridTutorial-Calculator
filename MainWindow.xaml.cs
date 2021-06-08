using System.Windows;
using System.Windows.Input;

namespace WpfGridTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml, the calculator window
    /// </summary>
    public partial class MainWindow : Window
    {
        // Track if initial input value
        private bool initialInput = true;

        // First input value
        private string inputString1 = "";

        private long inputLong1 = 0;

        // Second input value
        private string inputString2 = "";

        private long inputLong2 = 0;

        // Holder of Current Math Operator
        private string mathOperator = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        // Map mouse locaiton in window
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Title = e.GetPosition(this).ToString();
        }

        // ========================== Generic Handler for Numeric Inputs ==========================
        private void Numeric_Button_Click(string numberClicked)
        {
            if (initialInput == true)
            {
                inputString1 += numberClicked;
                inputLong1 = long.Parse(inputString1);
                DisplayBox.Text = inputLong1.ToString();
            }
            else
            {
                inputString2 += numberClicked;
                inputLong2 = long.Parse(inputString2);
                DisplayBox.Text = inputLong2.ToString();
            }
        }

        //========================== Handlers for Specific Numeric Inputs ==========================
        private void Numeric_Button_Click_0(object sender, RoutedEventArgs e)
        {
            Numeric_Button_Click(NumButton0.Content.ToString());
        }

        private void Numeric_Button_Click_1(object sender, RoutedEventArgs e)
        {
            Numeric_Button_Click(NumButton1.Content.ToString());
        }

        private void Numeric_Button_Click_2(object sender, RoutedEventArgs e)
        {
            Numeric_Button_Click(NumButton2.Content.ToString());
        }

        private void Numeric_Button_Click_3(object sender, RoutedEventArgs e)
        {
            Numeric_Button_Click(NumButton3.Content.ToString());
        }

        private void Numeric_Button_Click_4(object sender, RoutedEventArgs e)
        {
            Numeric_Button_Click(NumButton4.Content.ToString());
        }

        private void Numeric_Button_Click_5(object sender, RoutedEventArgs e)
        {
            Numeric_Button_Click(NumButton5.Content.ToString());
        }

        private void Numeric_Button_Click_6(object sender, RoutedEventArgs e)
        {
            Numeric_Button_Click(NumButton6.Content.ToString());
        }

        private void Numeric_Button_Click_7(object sender, RoutedEventArgs e)
        {
            Numeric_Button_Click(NumButton7.Content.ToString());
        }

        private void Numeric_Button_Click_8(object sender, RoutedEventArgs e)
        {
            Numeric_Button_Click(NumButton8.Content.ToString());
        }

        private void Numeric_Button_Click_9(object sender, RoutedEventArgs e)
        {
            Numeric_Button_Click(NumButton9.Content.ToString());
        }

        //========================== Handlers for Mathematical Operator Inputs ==========================

        private void Oper_Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            // Begin inputting second value & save operator desired
            if (initialInput == true)
            {
                initialInput = false;
                DisplayBox.Text = inputLong2.ToString();
                mathOperator = "+";
            }
            // Save desired operator
            else
            {
                mathOperator = "+";
            }
        }

        private void Oper_Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            // Begin inputting second value & save operator desired
            if (initialInput == true)
            {
                initialInput = false;
                DisplayBox.Text = inputLong2.ToString();
                mathOperator = "-";
            }
            // Save desired operator
            else
            {
                mathOperator = "-";
            }
        }

        private void Oper_Button_Click_Mult(object sender, RoutedEventArgs e)
        {
            // Begin inputting second value & save operator desired
            if (initialInput == true)
            {
                initialInput = false;
                DisplayBox.Text = inputLong2.ToString();
                mathOperator = "*";
            }
            // Save desired operator
            else
            {
                mathOperator = "*";
            }
        }

        private void Oper_Button_Click_Div(object sender, RoutedEventArgs e)
        {
            // Begin inputting second value & save operator desired
            if (initialInput == true)
            {
                initialInput = false;
                DisplayBox.Text = inputLong2.ToString();
                mathOperator = "÷";
            }
            // Save desired operator
            else
            {
                mathOperator = "÷";
            }
        }

        //========================== Handlers for General Operator Inputs ==========================

        // Change signs of input
        private void Oper_Button_Click_Sign(object sender, RoutedEventArgs e)
        {
            if (initialInput == true)
            {
                inputLong1 = inputLong1 * -1;
                DisplayBox.Text = inputLong1.ToString();
            }
            else
            {
                inputLong2 = inputLong2 * -1;
                DisplayBox.Text = inputLong1.ToString();
            }
        }

        // Curr Unused
        private void Oper_Button_Click_Dec(object sender, RoutedEventArgs e)
        {
            //inputLong1 += (long)0.0;
            //inputLong2 += (long)0.0;
        }

        // Perform calculation if possible
        private void Oper_Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            // Some operator has been input
            if (mathOperator != "")
            {
                // Perform operation
                long outputLong;
                if (mathOperator == "+")
                {
                    outputLong = inputLong1 + inputLong2;
                }
                else if (mathOperator == "-")
                {
                    outputLong = inputLong1 - inputLong2;
                }
                else if (mathOperator == "*")
                {
                    outputLong = inputLong1 * inputLong2;
                }
                else
                {
                    outputLong = inputLong1 - inputLong2;
                }
                // Desplay result & reset
                MessageBox.Show($"The result is: {outputLong}");
                Oper_Button_Click_Clear(sender, e);
            }
        }

        // Reset variables & text
        private void Oper_Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            initialInput = true;
            mathOperator = "";
            inputString1 = "";
            inputString2 = "";
            inputLong1 = 0;
            inputLong2 = 0;
            DisplayBox.Text = "0";
        }

        // Handle keyboard inputs
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //========================== Handle Numeric Keyboard Inputs ==========================
            if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                Numeric_Button_Click(NumButton0.Content.ToString());
            }
            if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                Numeric_Button_Click(NumButton1.Content.ToString());
            }
            if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                Numeric_Button_Click(NumButton2.Content.ToString());
            }
            if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                Numeric_Button_Click(NumButton3.Content.ToString());
            }
            if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                Numeric_Button_Click(NumButton4.Content.ToString());
            }
            if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                Numeric_Button_Click(NumButton5.Content.ToString());
            }
            if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                Numeric_Button_Click(NumButton6.Content.ToString());
            }
            if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                Numeric_Button_Click(NumButton7.Content.ToString());
            }
            if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                Numeric_Button_Click(NumButton8.Content.ToString());
            }
            if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                Numeric_Button_Click(NumButton9.Content.ToString());
            }

            //========================== Handle Operator Keyboard Inputs ==========================
            if (e.Key == Key.Add)
            {
                Oper_Button_Click_Plus(sender, e);
            }
            if (e.Key == Key.Subtract)
            {
                Oper_Button_Click_Plus(sender, e);
            }
            if (e.Key == Key.Multiply)
            {
                Oper_Button_Click_Plus(sender, e);
            }
            if (e.Key == Key.Divide)
            {
                Oper_Button_Click_Div(sender, e);
            }
            if (e.Key == Key.Decimal)
            {
                Oper_Button_Click_Dec(sender, e);
            }
            if (e.Key == Key.C || e.Key == Key.Delete || e.Key == Key.Back)
            {
                Oper_Button_Click_Clear(sender, e);
            }
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                Oper_Button_Click_Equals(sender, e);
            }
        }
    }
}