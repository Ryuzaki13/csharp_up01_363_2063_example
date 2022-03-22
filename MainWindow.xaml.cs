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

namespace KFC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance { get; private set; }

        // DATABASE CONNECTION

        public static Database.Connection Connection { get; private set; }

        // PAGE VARIABLES

        public static AppPage.Authorization AppAuthorization { get; private set; }
        public static AppPage.Administrator AppAdministrator { get; private set; }
        public static AppPage.Client AppClient { get; private set; }
        public static AppPage.Cook AppCook { get; private set; }
        public static AppPage.Waiter AppWaiter { get; private set; }
        public static AppPage.Cashier AppCashier { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            Instance = this;
            Connection = new Database.Connection();

            AppAuthorization = new AppPage.Authorization();
            AppAdministrator = new AppPage.Administrator();
            AppClient = new AppPage.Client();
            AppCook = new AppPage.Cook();
            AppWaiter = new AppPage.Waiter();
            AppCashier = new AppPage.Cashier();

            AppFrame.Navigate(AppAuthorization);
        }

    }
}
