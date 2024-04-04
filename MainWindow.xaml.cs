using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Oussama_Moustarzik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number.Text = S2.Value.ToString("00");

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            number.Text = number5.Text;
            number2.Text = number6.Text;
            number3.Text = number7.Text;


        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(listBox.SelectedItem is ListBoxItem listBoxItem2)
            {
                number5.Text = listBoxItem2.Content.ToString();
                number6.Text = listBoxItem2.Content.ToString();
                number7.Text = listBoxItem2.Content.ToString();
            }
        }
    }
}