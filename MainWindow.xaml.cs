/*
* Name: Riley de Gans
* Date: May 27th, 2019
* Description: An app to help you study for math
*/
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

namespace _184863MathTutor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        double answer;
        int appState = 1;//1 to click for problem and 2 to click for answer
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {
            if (appState == 1)
            {
                double num1 = rand.Next(10) + 1;
                double num2 = rand.Next(10) + 1;
                int operation = rand.Next(4);
                string symbol;
                if (operation == 0)
                {
                    symbol = " + ";
                    answer = num1 + num2;
                }
                else if (operation == 1)
                {
                    symbol = " - ";
                    answer = num1 - num2;
                }
                else if (operation == 2)
                {
                    symbol = " / ";
                    answer = num1 / num2;
                }
                else
                {
                    symbol = " * ";
                    answer = num1 * num2;
                }
                lblOutput.Content = num1 + symbol + num2;
                btnCheck.Content = "Click me to check your answer";
                appState = 2;
            }
            else
            {
                if (answer.ToString() == txtInput.Text)
                {
                    lblOutput.Content = "Correct! The answer is " + answer;
                }
                else
                {
                    lblOutput.Content = "Wrong, the answer is " + answer;
                }
                txtInput.Text = "";
                btnCheck.Content = "Click me to get a problem";
                appState = 1;
            }
        }
    }
}
