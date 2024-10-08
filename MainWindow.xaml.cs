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

namespace Homework6_Lab1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int op = list.SelectedIndex;
                decimal left = Convert.ToDecimal(leftbox.Text);
                decimal right = Convert.ToDecimal(rightbox.Text);
                decimal res = 0;
                switch (op)
                {
                    case 0:
                        res = left + right;
                        break;
                    case 1:
                        res = left - right;
                        break;
                    case 2:
                        res = left * right;
                        break;
                    case 3:
                        res = left / right;
                        break;
                    case 4:
                        res = left % right;
                        break;
                    default:
                        res = 0;
                        result.Content = "No Operations Selected!";
                        return;
                        break;
                }
                result.Content = res.ToString();
            }
            catch (DivideByZeroException)
            {
                result.Content = "Cannot divide by zero!";
            }
            catch (FormatException) {
                result.Content = "Cannot do operations on non-numbers!";
            }
        }
    }
}