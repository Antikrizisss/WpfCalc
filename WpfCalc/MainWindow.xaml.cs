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

namespace WpfCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closed += MainWindow_Closed;
            this.Closing += MainWindow_Closing;
            
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string msg = "Вы действительно хотите выйти?";
            MessageBoxResult result = MessageBox.Show(msg, "Калькулятор", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
        private void MainWindow_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("Пока!", "Калькулятор");
        }
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Title = e.GetPosition(this).ToString();
        }
        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Действие выполнено", "Калькулятор");
        }
        private void TextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            //MessageBox.Show(textBox.Text);
        }
    }
}
