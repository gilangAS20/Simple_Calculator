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

namespace Simple_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public decimal input;
        public StringBuilder inputs = new StringBuilder();
        public MainWindow()
        {
            InitializeComponent();
        }


        // number input
        private void Button_Click_AddOne(object sender, RoutedEventArgs e)
        {
            inputs.Append("1");
            textInput.Text = inputs.ToString();
        }

        private void Button_Click_AddTwo(object sender, RoutedEventArgs e)
        {
            inputs.Append("2");
            textInput.Text = inputs.ToString();
        }

        private void Button_Click_AddThree(object sender, RoutedEventArgs e)
        {
            inputs.Append("3");
            textInput.Text = inputs.ToString();
        }

        private void Button_Click_AddFour(object sender, RoutedEventArgs e)
        {
            inputs.Append("4");
            textInput.Text = inputs.ToString();
        }

        private void Button_Click_AddFive(object sender, RoutedEventArgs e)
        {
            inputs.Append("5");
            textInput.Text = inputs.ToString();
        }

        private void Button_Click_AddSix(object sender, RoutedEventArgs e)
        {
            inputs.Append("6");
            textInput.Text = inputs.ToString();
        }

        private void Button_Click_AddSeven(object sender, RoutedEventArgs e)
        {
            inputs.Append("7");
            textInput.Text = inputs.ToString();
        }

        private void Button_Click_AddEight(object sender, RoutedEventArgs e)
        {
            inputs.Append("8");
            textInput.Text = inputs.ToString();
        }

        private void Button_Click_AddNine(object sender, RoutedEventArgs e)
        {
            inputs.Append("9");
            textInput.Text = inputs.ToString();
        }

        private void Button_Click_AddZero(object sender, RoutedEventArgs e)
        {
            inputs.Append("0");
            textInput.Text = inputs.ToString();
        }




        // operation input
        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            inputs.Append("+");
            textInput.Text = inputs.ToString();
        }

        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            inputs.Append("-");
            textInput.Text = inputs.ToString();
        }

        private void Button_Click_Multiple(object sender, RoutedEventArgs e)
        {
            inputs.Append("*");
            textInput.Text = inputs.ToString();
        }

        private void Button_Click_Divide(object sender, RoutedEventArgs e)
        {
            inputs.Append("/");
            textInput.Text = inputs.ToString();
        }


        // process the input
        private void Button_Click_Process(object sender, RoutedEventArgs e)
        {
            string resultString = inputs.ToString();

            if(resultString.StartsWith("+") || resultString.StartsWith("-") || resultString.StartsWith("*") || resultString.StartsWith("/"))
            {
                resultString = resultString.Substring(1);
            }
            if(resultString.EndsWith("+") || resultString.EndsWith("-") || resultString.EndsWith("*") || resultString.EndsWith("/"))
            {
                resultString = resultString.Substring(0, resultString.Length-1);
            }

            textInput.Text = resultString;
            CalculatorProcessor calculatorProcessor = new CalculatorProcessor();
            textResult.Text = calculatorProcessor.EvaluateExpression(resultString);
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            textInput.Text = "";
            textResult.Text = "";

            inputs.Clear();
        }
    }
}
