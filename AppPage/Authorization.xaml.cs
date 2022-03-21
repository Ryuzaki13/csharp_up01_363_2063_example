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

namespace KFC.AppPage
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        private Dictionary<string, string> defaultPlaceholder = new Dictionary<string, string>();
        private Brush placeholderColor = Brushes.Gray;
        private Brush textColor = Brushes.Black;

        public Authorization()
        {
            InitializeComponent();

            defaultPlaceholder["login"] = "Логин";
            defaultPlaceholder["password"] = "Пароль";

            setTextBoxPlaceholder();
        }

        private void setTextBoxPlaceholder()
        {
            foreach (var element in AppPageGrid.Children)
            {
                if (element.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)element;
                    textBox.Foreground = placeholderColor;
                    textBox.Text = defaultPlaceholder[textBox.Uid];
                    textBox.GotFocus += textBoxFocus;
                    textBox.LostFocus += textBoxLostFocus;
                }
            }
        }

        private void textBoxLostFocus(object sender, RoutedEventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            if (textBox != null)
            {

                if (textBox.Text.Length == 0)
                {
                    textBox.Text = defaultPlaceholder[textBox.Uid];
                }

                if (textBox.Text == defaultPlaceholder[textBox.Uid])
                {
                    textBox.Foreground = placeholderColor;
                }

            }

        }

        private void textBoxFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox != null)
            {

                if (textBox.Text == defaultPlaceholder[textBox.Uid])
                {
                    textBox.Text = "";
                    textBox.Foreground = textColor;
                }
                
            }
            
        }

        private void onLogin(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(MainWindow.AppCashier);
        }
    }
}
