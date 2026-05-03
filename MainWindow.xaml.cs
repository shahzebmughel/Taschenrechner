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

namespace Taschenrechner
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

        private void NumBtn(object sender, RoutedEventArgs e)
        {
            InputTxt.Text += ((Button)sender).Content;
        }

        private void NumBtnEquals_Click(object sender, RoutedEventArgs e)
        {
            string[] resultArray = InputTxt.Text.Split(new char[] { '+', '-', 'x', '/' }, StringSplitOptions.RemoveEmptyEntries);
            char operatorV;

            if(InputTxt.Text.Contains("+"))
            {
                operatorV = '+';
            }
            else if(InputTxt.Text.Contains("-"))
            {
                operatorV = '-';
            }
            else if(InputTxt.Text.Contains("x"))
            {
                operatorV = 'x';
            }
            else if(InputTxt.Text.Contains("/"))
            {
                operatorV = '/';
            }
            else
            {
                return;
            }

            if(resultArray.Length < 2)
            {
                return;
            }


            int num1 = int.Parse(resultArray[0]);
            int num2 = int.Parse(resultArray[1]);

            switch (operatorV)
            {
                case '+':
                    InputTxt.Text = (num1 + num2).ToString();
                    break;
                case '-':
                    InputTxt.Text = (num1 - num2).ToString();
                    break;
                case 'x':
                    InputTxt.Text = (num1 * num2).ToString();
                    break;
                case '/':
                    InputTxt.Text = (num1 / num2).ToString();
                    break;
                default:
                    break;
            }
        }

        private void NumBtnClear(object sender, RoutedEventArgs e)
        {
            if (InputTxt.Text.Length == 0) { return; }

            InputTxt.Text = InputTxt.Text.Substring(InputTxt.Text.Length);
        }

        private void NumBtnBackSpace(object sender, RoutedEventArgs e)
        {
            if(InputTxt.Text.Length == 0) { return; }

            InputTxt.Text = InputTxt.Text.Substring(0,InputTxt.Text.Length - 1);
        }
    }
}