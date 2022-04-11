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
    /// Логика взаимодействия для AppClient.xaml
    /// </summary>
    public partial class Client : Page
    {
        public Client()
        {
            InitializeComponent();
        }

        public void Build()
        {
            var dishList = AppWindow.Connection.Dish.ToList();

            DishList.Children.Clear();

            foreach (var dish in dishList)
            {
                TextBlock tb = new TextBlock();
                tb.Text = dish.Name;
                DishList.Children.Add(tb);
            }
        }
    }
}
