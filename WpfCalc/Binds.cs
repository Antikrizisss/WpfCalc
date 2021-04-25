using System.Windows;

namespace WpfCalc
{
    public partial class MainWindow : Window
    {
        private void One_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "1";
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "2";
        }
        private void Three_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "3";
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "4";
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "5";
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "6";
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "7";
        }
        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "8";
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "9";
        }
        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "0";
        }
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "+";
        }
        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "*";
        }
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "-";
        }
        private void Division_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text += "/";
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text = "";
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text.Substring(0, CalcDisplay.Text.Length - 1);
        }
    }
}